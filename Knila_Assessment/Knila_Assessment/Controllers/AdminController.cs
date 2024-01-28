using Knila_Assessment.Data;
using Knila_Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Knila_Assessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly DataDbContext dataDbContext;

        public AdminController(DataDbContext dataDbContext)
        {
            this.dataDbContext = dataDbContext;
        }



        //listbooks sorted by publisher

        [HttpGet("SortedByPublisher")]

        public async Task<IActionResult> GetOrderByPulisher()
        {
            var localvar = await dataDbContext.Books
                .OrderBy(book => book.Publisher)
                .ThenBy(book => book.AuthorLastName)
                .ThenBy(book => book.AuthorFirstName)
                .ThenBy(book => book.Title)
                .ToListAsync();

            return Ok(localvar);
        }




        //listbooks sorted by author

        [HttpGet("SortedByAuthor")]

        public async Task<IActionResult> GetOrderByAuthor()
        {
            var localvar = await dataDbContext.Books
                .OrderBy(book => book.AuthorLastName)
                .ThenBy(book => book.AuthorFirstName)
                .ThenBy(book => book.Title)
                .ToListAsync();

            return Ok (localvar);
        }




        //Storeprocdure for OrderByAuthor

        [HttpGet("SortedByAuthorSP")]
        public async Task<IActionResult> GetOrderByAuthorSP()
        {
           
            var localvar = await dataDbContext.Books.FromSqlRaw("EXEC Orderbyauthor").ToListAsync();

            return Ok(localvar);
        }




        //Storeprocdure for OrderByPublisher

        [HttpGet("SortedByPublisherSP")]
        public async Task<IActionResult> GetOrderByPublisherSP()
        {

            var localvar = await dataDbContext.Books.FromSqlRaw("EXEC Orderbypublisher").ToListAsync();

            return Ok(localvar);
        }





        //Return the total price of the book
        [HttpGet("TotalPrice")]
        public IActionResult GetTotalPrice()
        {
            decimal localvar = dataDbContext.Books.Sum(book => book.Price);
            return Ok(new {TotalPrice = localvar});
        }










    }
}
