using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreKURS.ViewModels
{
    public class CreateRoleViewmodel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
