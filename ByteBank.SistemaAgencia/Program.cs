using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);
            
          

            Console.WriteLine(conta.Numero);

            DateTime dataFimPagamento = new DateTime(2018, 10, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan difenreca = TimeSpan.FromMinutes(40); //dataFimPagamento - dataCorrente;

            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);


            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(difenreca);
            Console.WriteLine(mensagem);
            
            Console.ReadLine();
        }


        
        }
    }

