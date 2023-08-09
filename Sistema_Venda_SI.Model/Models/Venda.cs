﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Sistema_Venda_SI.Model.Models
{
    public partial class Venda
    {
        public Venda()
        {
            Parcelas = new HashSet<Parcelas>();
            ItvCodigoProduto = new HashSet<Produto>();
        }

        public int VenCodigo { get; set; }
        public DateTime VenData { get; set; }
        public int VenCodigoCliente { get; set; }
        public string VenUsuario { get; set; }
        public int VenCodigoTipoPagamento { get; set; }
        public int? VenQtdParcelas { get; set; }

        public virtual Cliente VenCodigoClienteNavigation { get; set; }
        public virtual TipoPagamento VenCodigoTipoPagamentoNavigation { get; set; }
        public virtual ICollection<Parcelas> Parcelas { get; set; }

        public virtual ICollection<Produto> ItvCodigoProduto { get; set; }
    }
}