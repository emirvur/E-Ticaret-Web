﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class ShippingDetails
    {
   
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen adres tanımımnı giriniz")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen adresgiriniz")]

        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen şehir giriniz")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen semt giriniz")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen mahalle giriniz")]
        public string Mahalle { get; set; }

        [Required(ErrorMessage = "Lütfen postakodu giriniz")]
        public string PostaKodu { get; set; }
    }
}