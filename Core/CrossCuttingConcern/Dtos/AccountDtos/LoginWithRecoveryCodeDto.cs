using RoleBasedAuthentication.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthentication.Core.CrossCuttingConcern.Dtos.AccountDtos
{
    public class LoginWithRecoveryCodeDto : IDto
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Recovery Code")]
        public string RecoveryCode { get; set; }
    }
}
