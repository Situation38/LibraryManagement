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

        /// <summary>
        ///     Controller for create library
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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


        /// <summary>
        ///     Controller for get all libraries services
        /// </summary>
        /// <returns></returns>
        [HttpGet("Library/")]
        public async Task<ActionResult> Get()
        {

            var result = await _libraryService.GetAllLibraryAsync();

            if (result.Message.Contains(MsgUtils.INTERNAL_SERVER_ERROR))
            {
                return StatusCode(500, result.Message);
            }

            return Ok(result);
        }

        /// <summary>
        ///  controller  for get a specific Library service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Library/{id}")]
        public async Task<ActionResult> GetLibraryByIdAsync(int id)
        {
            var result = await _libraryService.GetLibraryByIdAsync(id);

            if (id <= 0)
            {
                return BadRequest();
            }

            if (result.Message.Contains(MsgUtils.NOT_FOUND))
            {
                return NotFound();
            }

            if (result.Message.Contains(MsgUtils.INTERNAL_SERVER_ERROR))
            {
                return StatusCode(500, result.Message);
            }

            return Ok(result);
        }
    }
}
