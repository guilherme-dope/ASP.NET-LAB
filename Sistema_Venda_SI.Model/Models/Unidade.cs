﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Sistema_Venda_SI.Model.Models
{
    public partial class Unidade
    {
        public Unidade()
        {
            Produto = new HashSet<Produto>();
        }

        public int UnCodigo { get; set; }
        public string UnDescricao { get; set; }
        public bool UnDesativado { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}