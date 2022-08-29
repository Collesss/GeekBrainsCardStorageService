using GeekBrainsCardStorageService.Models.Dto.Client.Request;
using GeekBrainsCardStorageService.Models.Dto.Client.Response;
using GeekBrainsCardStorageService.Repository.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;

namespace GeekBrainsCardStorageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IRepositoryClient _repositoryClient;

        public ClientController(ILogger<ClientController> logger, IRepositoryClient repositoryClient)
        {
            _logger = logger;
            _repositoryClient = repositoryClient;
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public IActionResult GetAllCard()
        {
            try
            {
                return Ok(_repositoryClient.GetAll());
            }
            catch (Exception e)
            {
                return BadRequest(ModelState);
            }

            //return Ok(new DtoClientResponse[] { new DtoClientResponse() });
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public IActionResult CreateCard(DtoClientRequestCreate card)
        {
            try
            {

            }
            catch (Exception e)
            {
                return BadRequest(ModelState);
            }

            return Ok(new DtoClientResponse());
        }

        [HttpDelete("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public IActionResult DeleteCard(DtoClientRequestDelete card)
        {
            try
            {

            }
            catch (Exception e)
            {
                return BadRequest(ModelState);
            }

            return Ok(new DtoClientResponse());
        }
    }
}
