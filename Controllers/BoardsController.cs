using System;
using System.Collections.Generic;
using KanbanAPI.Models;
using KanbanAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KanbanAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardsController : ControllerBase
    {
        private IBoardService _service;

        public BoardsController(IBoardService service)
        {
            _service = service;
        }

        [HttpGet("/boards")]
        public ActionResult<List<Board>> GetAllBoards()
        {
            return _service.GetAllBoards();
        }

        [HttpPost("/boards")]
        public ActionResult<Board> AddBoard(Board board)
        {
            _service.AddBoard(board);
            return board;
        }

        [HttpPut("/boards/{boardId}")]
        public ActionResult<Board> UpdateBoard(Guid boardId, Board board)
        {
            _service.UpdateBoard(boardId, board);
            return board;
        }

        [HttpDelete("/boards/{boardId}")]
        public ActionResult<Guid> DeleteBoard(Guid boardId)
        {
            _service.DeleteBoard(boardId);
            return boardId;
        }
    }
}
