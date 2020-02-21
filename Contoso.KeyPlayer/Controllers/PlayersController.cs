using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso.KeyPlayer.Common.Entities;
using Contoso.KeyPlayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Contoso.KeyPlayer.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly ILogger<PlayersController> _logger;
        private readonly IPlayerService _playerService;

        public PlayersController(ILogger<PlayersController> logger, IPlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<KpactivePlayer>>> Get()
        {
            return Ok(await _playerService.GetActivePlayerAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<KpactivePlayer>> Get(int id)
        {
            var player = await _playerService.GetActivePlayerByIdAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
    }
}
