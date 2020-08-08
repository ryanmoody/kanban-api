using KanbanAPI.Models;
using System;
using System.Collections.Generic;

namespace KanbanAPI.Services
{
    public class BoardService : IBoardService
    {
        private List<Board> _boards;

        public BoardService()
        {
            _boards = new List<Board>();
        }

        public List<Board> GetAllBoards()
        {
            return _boards;
        }

        public Board AddBoard(Board board)
        {
            board.Id = Guid.NewGuid();
            _boards.Add(board);

            return board;
        }

        public Board UpdateBoard(Guid boardId, Board board)
        {
            for (var index = _boards.Count - 1; index >= 0; index--)
            {
                if (_boards[index].Id == boardId)
                {
                    _boards[index] = board;
                }
            }

            return board;
        }

        public Guid DeleteBoard(Guid boardId)
        {
            for (var index = _boards.Count - 1; index >= 0; index--)
            {
                if (_boards[index].Id == boardId)
                {
                    _boards.RemoveAt(index);
                }
            }

            return boardId;
        }
    }
}
