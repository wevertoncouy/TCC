using SGCI.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGCI.Infrastructure.Data
{
    public static class DbInitializer
    {

        public static void Initialize(GestaoCarteiraContext context)
        {
            if (context.Carteiras.Any())
            {
                return;
            }


            var carteiras = new Carteira[]
            {
               new Carteira
               {
                DataCadastro = DateTime.Parse("2018-01-01"),
                Descricao = "Forex",
                Tipo = "Dolar",
                Valor = 11000

               }
            };
            context.AddRange(carteiras);

            var contas = new Conta[]
            {
                new Conta
                {
                    DataInicial = DateTime.Parse("2018-01-01"),
                    Nome = "Weverton Matheus",
                    Saldo = 10000,
                    TipoMoeda = "GBP"
                }
            };
            context.AddRange(contas);

           // context.SaveChanges();



        }



    }
}
