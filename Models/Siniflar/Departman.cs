﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace mvc_net_Crm.Models.Siniflar
{
	public class Departman
	{
        public Departman() //DEFAULT BILGILER VERILIYOR
        {
            Durum = true;
        }

        [Key]
        public int Departmanid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string DepartmanAd { get; set; }

        public bool Durum { get; set; }

        public ICollection<Personel> Personels { get; set; }
    }
}

