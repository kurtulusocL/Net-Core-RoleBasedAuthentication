using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using RoleBasedAuthentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthentication.Core.CrossCuttingConcern.Dtos.MenageDtos
{
    public class ExternalLoginsDto : IDto
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationScheme> OtherLogins { get; set; }

        public bool ShowRemoveButton { get; set; }

        public string StatusMessage { get; set; }
    }
}
