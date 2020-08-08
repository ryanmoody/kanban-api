using KanbanAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KanbanAPI.Services
{
    public class CardService : ICardService
    {
        private List<Card> _cards;

        public CardService()
        {
            _cards = new List<Card>();
        }

        public List<Card> GetAllCards()
        {
            return _cards;
        }

        public List<Card> GetCardsByBoardId(Guid boardId)
        {
            List<Card> cards = _cards.Where(card => card.BoardId == boardId).ToList();

            return cards;
        }

        public Card AddCard(Guid boardId, Card card)
        {
            card.Id = Guid.NewGuid();
            card.BoardId = boardId;
            _cards.Add(card);

            return card;
        }

        public Card UpdateCard(Guid id, Guid boardId, Card card)
        {
            for (var index = _cards.Count - 1; index >= 0; index--)
            {
                if (_cards[index].Id == id && _cards[index].BoardId == boardId)
                {
                    _cards[index] = card;
                }
            }

            return card;
        }

        public Guid DeleteCard(Guid id, Guid boardId)
        {
            for (var index = _cards.Count - 1; index >= 0; index--)
            {
                if (_cards[index].Id == id && _cards[index].BoardId == boardId)
                {
                    _cards.RemoveAt(index);
                }
            }

            return id;
        }
    }
}
