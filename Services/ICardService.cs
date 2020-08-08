using KanbanAPI.Models;
using System;
using System.Collections.Generic;

namespace KanbanAPI.Services
{
    public interface ICardService
    {
        public List<Card> GetAllCards();
        public List<Card> GetCardsByBoardId(Guid boardId);
        public Card AddCard(Guid boardId, Card card);
        public Card UpdateCard(Guid id, Guid boardId, Card card);
        public Guid DeleteCard(Guid id, Guid boardId);
    }
}
