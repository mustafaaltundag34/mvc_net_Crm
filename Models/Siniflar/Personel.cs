﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvc_net_Crm.Models.Siniflar
{
	public class Personel
	{

        public Personel() //DEFAULT BILGILER VERILIYOR
        {
            Durum = true;
        }

        [Key]
        public int Personelid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string PersonelAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string PersonelSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonelGorsel { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }

        public int Departmanid { get; set; }
        public virtual Departman Departman { get; set; }

    }
}

