using Contoso.KeyPlayer.Common.Entities;
using Contoso.KeyPlayer.Common.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.KeyPlayer.DB.Repository
{
    class PlayerRepository : BaseRepository<KpactivePlayer>, IPlayerRepository
    {
        private readonly ILogger<PlayerRepository> _logger;
        private readonly KeyPlayerContext _context;

        public PlayerRepository(ILogger<PlayerRepository> logger, KeyPlayerContext context) : base(context)
        {
            _logger = logger;
            _context = context;
        }

    }
}
