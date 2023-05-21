using ChatterApi.Dtos;
using ChatterApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatService _chatService;

        public ChatController(ChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser(UserDto model)
        {
            if (_chatService.AddUserToList(model.Name))
            {
                return NoContent();
            }

            return BadRequest("Ovo ime je zauzeto, molimo odaberite drugo");
        }
    }
}
