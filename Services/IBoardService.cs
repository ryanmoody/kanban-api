using KanbanAPI.Models;
using System;
using System.Collections.Generic;

namespace KanbanAPI.Services
{
    public interface IBoardService
    {
        public List<Board> GetAllBoards();
        public Board AddBoard(Board board);
        public Board UpdateBoard(Guid boardId, Board board);
        public Guid DeleteBoard(Guid boardId);
    }
}
