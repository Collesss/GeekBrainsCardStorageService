using AutoMapper;
using GeekBrainsCardStorageService.Models.Dto.Client.Request;
using GeekBrainsCardStorageService.Models.Dto.Client.Response;
using GeekBrainsCardStorageService.Repository.Data;
using GeekBrainsCardStorageService.Repository.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IRepositoryClient _repositoryClient;
        private readonly IMapper _mapper;

        public ClientController(/*ILogger<ClientController> logger, */IRepositoryClient repositoryClient, IMapper mapper)
        {
            //_logger = logger ?? throw new ArgumentNullException(nameof(logger)) ;
            _repositoryClient = repositoryClient ?? throw new ArgumentNullException(nameof(repositoryClient));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public async Task<IActionResult> GetAllClient()
        {
            try
            {
                return Ok(await _repositoryClient.GetAll());
            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.Message);
                return BadRequest(ModelState);
            }

            //return Ok(new DtoClientResponse[] { new DtoClientResponse() });
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public async Task<IActionResult> CreateClient([FromBody] DtoClientRequestCreate card)
        {
            try
            {
                return Ok(await _repositoryClient.Create(_mapper.Map<Client>(card)));
            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public async Task<IActionResult> DeleteClient([FromBody] int Id)
        {
            try
            {
                return Ok(await _repositoryClient.Delete(Id));
            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.Message);
                return BadRequest(ModelState);
            }
        }
    }
}
