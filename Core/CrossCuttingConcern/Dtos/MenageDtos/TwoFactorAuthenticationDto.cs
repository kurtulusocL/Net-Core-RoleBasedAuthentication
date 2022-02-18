using RoleBasedAuthentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthentication.Core.CrossCuttingConcern.Dtos.MenageDtos
{
    public class TwoFactorAuthenticationDto : IDto
    {
        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        public bool Is2faEnabled { get; set; }
    }
}
