using Contoso.KeyPlayer.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.KeyPlayer.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<ICollection<KpactivePlayer>> GetActivePlayerAsync();

        Task<KpactivePlayer> GetActivePlayerByIdAsync(int id);
    }
}
