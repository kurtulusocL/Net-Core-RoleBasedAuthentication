using RoleBasedAuthentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthentication.Core.CrossCuttingConcern.Dtos.MenageDtos
{
    public class RemoveLoginDto : IDto
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
    }
}
