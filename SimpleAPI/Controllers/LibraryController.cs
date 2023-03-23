using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SimpleAPI.BusinessLogic.IServices;
using SimpleAPI.Dtos.VBM;
using SimpleAPI.Helpers;

namespace SimpleAPI.Controllers
{

    /// <summary>
    ///     Controller Use to Set Services Endpoints
    /// </summary>
    [Route("api/")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        /// <summary>
        ///     Calling for use library Services
        /// </summary>
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        
        [HttpPost("Library/")]
        public async Task<ActionResult> Post([FromBody] LibraryBM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _libraryService.CreateLibraryAsync(model);

            if (result.Message.Contains(MsgUtils.NOT_FOUND))
            {
                return NotFound(result);
            }

            if (result.Message.Contains(MsgUtils.INTERNAL_SERVER_ERROR))
            {
                return StatusCode(500, result.Message);
            }

            return Ok(result);
        }
    }
}
