using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;

namespace Tarefa_POO_Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //nome do usuario e os dados
            Conta Juridica conta = new Conta Juridica(8010, “Lara Croft”, 100.0, 500.0);
            Console.WriteLine(conta.Saldo);
        }
    }
}
