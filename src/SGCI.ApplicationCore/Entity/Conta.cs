using System;
using System.Collections.Generic;
using System.Text;

namespace SGCI.ApplicationCore.Entity
{
   public class Conta
    {

        public Conta()
        {



        }

        public int ContaId { get; set; }

        public string Nome { get; set; }

        public decimal Saldo { get; set; }

        public string TipoMoeda { get; set; }

        public DateTime DataInicial { get; set; }

        public ICollection<Carteira> Carteiras { get; set; }

        public ICollection<Lancamento> Lancamentos { get; set; }
    }
}
