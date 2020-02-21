using System;
using System.Collections.Generic;

namespace Contoso.KeyPlayer.Common.Entities
{
    public partial class KpactivePlayer
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? TeamId { get; set; }
        public DateTime Birthdate { get; set; }
        public string Position { get; set; }
    }
}
