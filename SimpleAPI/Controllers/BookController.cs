using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    /// <summary>
    ///     Controller Use to Set Services Endpoints
    /// </summary>
    [Route("api/")]
    [ApiController]
    public class BookController : ControllerBase
    {
        /// <summary>
        ///     Calling for use book Services
        /// </summary>
        //private readonly IBookService _bookService;

        public BookController()
        {
            //_bookService = bookservice;
        }

        [HttpGet("Book")]
        public async Task<ActionResult> Books()
        {
            return Ok();
        }

    }
}
