using GeekBrainsCardStorageService.Models.Dto.Card.Request;
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
    public class CardController : ControllerBase
    {
        private readonly ILogger<CardController> _logger;
        private readonly IRepositoryCard _repositoryCard;

        public CardController(ILogger<CardController> logger, IRepositoryCard repositoryCard)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repositoryCard = repositoryCard ?? throw new ArgumentNullException(nameof(repositoryCard));
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public IActionResult GetAllCard()
        {
            try
            {

            }
            catch (Exception e)
            {

                return BadRequest(ModelState);
            }

            return Ok(new DtoClientResponse[] { new DtoClientResponse() });
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(DtoClientResponse), StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(ModelStateDictionary))]
        public IActionResult CreateCard(DtoCardRequestCreate card)
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
        public IActionResult DeleteCard(DtoCardRequestDelete card)
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
