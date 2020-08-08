using System;
using System.Collections.Generic;
using KanbanAPI.Models;
using KanbanAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KanbanAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardsController : ControllerBase
    {
        private ICardService _service;

        public CardsController(ICardService service)
        {
            _service = service;
        }

        [HttpGet("/cards")]
        public ActionResult<List<Card>> GetAllCards()
        {
            var cards = _service.GetAllCards();

            return cards;
        }

        [HttpGet("/boards/{boardId}/cards")]
        public ActionResult<List<Card>> GetCards([FromRoute] Guid boardId)
        {
            var cards = _service.GetCardsByBoardId(boardId);

            return cards;
        }

        [HttpPost("/boards/{boardId}/cards")]
        public ActionResult<Card> AddCard([FromRoute] Guid boardId, Card card)
        {
            
            _service.AddCard(boardId, card);

            return card;
        }

        [HttpPut("/boards/{boardId}/cards/{id}")]
        public ActionResult<Card> UpdateCard([FromRoute] Guid boardId, [FromRoute] Guid id, Card card)
        {
            _service.UpdateCard(id, boardId, card);

            return card;
        }

        [HttpDelete("/boards/{boardId}/cards/{id}")]
        public ActionResult<Guid> DeleteCard([FromRoute] Guid boardId, [FromRoute] Guid id)
        {
            _service.DeleteCard(id, boardId);

            return id;
        }
    }
}
