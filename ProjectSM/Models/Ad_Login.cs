using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSM.Models
{
    public class Ad_login
    {
        [Key]
        public string Admin_id { get; set; }
        public string Ad_Password { get; set; }
    }
}
