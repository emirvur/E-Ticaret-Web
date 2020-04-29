using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.MvcWebUI.Models
{
    public class Login
    {
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Şifre")]
        
        public string Password { get; set; }
       
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}