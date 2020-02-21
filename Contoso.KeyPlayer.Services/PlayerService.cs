using Contoso.KeyPlayer.Common.Entities;
using Contoso.KeyPlayer.Common.Interfaces;
using Contoso.KeyPlayer.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.KeyPlayer.Services
{
    class PlayerService : IPlayerService
    {
        private readonly ILogger<PlayerService> _logger;
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(ILogger<PlayerService> logger, IPlayerRepository repository)
        {
            _logger = logger;
            _playerRepository = repository;
        }
        public async Task<ICollection<KpactivePlayer>> GetActivePlayerAsync()
        {
            return await _playerRepository.GetAsync();
        }

        public async Task<KpactivePlayer> GetActivePlayerByIdAsync(int id)
        {
            return await _playerRepository.GetByIdAsync(id);
        }
    }
}
