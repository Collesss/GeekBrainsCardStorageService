using AutoMapper;
using GeekBrainsCardStorageService.Models.Dto.Card.Request;
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
    public class CardController : ControllerBase
    {
        private readonly ILogger<CardController> _logger;
        private readonly IRepositoryCard _repositoryCard;
        private readonly IMapper _mapper;

        public CardController(/*ILogger<CardController> logger, */IRepositoryCard repositoryCard, IMapper mapper)
        {
            //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repositoryCard = repositoryCard ?? throw new ArgumentNullException(nameof(repositoryCard));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public async Task<IActionResult> GetAllCard()
        {
            try
            {
                return Ok(await _repositoryCard.GetAll());
            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.Message);
                return BadRequest(ModelState);
            }

            //return Ok(new DtoClientResponse[] { new DtoClientResponse() });
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public async Task<IActionResult> GetAllClientCards([FromRoute] int Id)
        {
            try
            {
                return Ok(await _repositoryCard.GetCardsClient(Id));
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
        public async Task<IActionResult> CreateCard([FromBody] DtoCardRequestCreate card)
        {
            try
            {
                return Ok(await _repositoryCard.Create(_mapper.Map<Card>(card)));
            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.Message);
                return BadRequest(ModelState);
            }

            //return Ok(new DtoClientResponse());
        }

        [HttpDelete("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public async Task<IActionResult> DeleteCard([FromBody] Guid Id)
        {
            try
            {
                return Ok(await _repositoryCard.Delete(Id));
            }
            catch (Exception e)
            {
                ModelState.AddModelError(String.Empty, e.Message);
                return BadRequest(ModelState);
            }

            //return Ok(new DtoClientResponse());
        }
    }
}
