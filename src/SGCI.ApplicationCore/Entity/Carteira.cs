using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGCI.ApplicationCore.Entity
{
    public class Carteira { 
    
        public Carteira()
        {

        }

        public int CarteiraId { get; set; }

        public DateTime DataCadastro { get; set; }

        //public string Descriao { get; set; }

        public string Tipo { get; set; }

        public decimal Valor { get; set; }

        public string Descricao { get; set; }

        [ForeignKey("Conta")]
        public int ContaId { get; set; }

        public  Conta Conta { get; set; }  // propriedade de navegaçao
        
    } 
}
