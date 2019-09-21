using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filas {
    class Program {
        static void Main(string[] args) {
            Clientes cli;
            Fila filaLanchonete;

            filaLanchonete = new Fila();
            cli = new Clientes("Maria", new DateTime(2018, 4, 14, 10, 41, 10));
            filaLanchonete.enfileirar(cli);
            cli = new Clientes("João", new DateTime(2018, 4, 14, 10, 43, 25));
            filaLanchonete.enfileirar(cli);
            cli = new Clientes("Ana", new DateTime(2018, 4, 14, 10, 44, 17));
            filaLanchonete.enfileirar(cli);
            cli = new Clientes("Bruno   ", new DateTime(2018, 4, 14, 10, 44, 17));
            filaLanchonete.enfileirar(cli);

            filaLanchonete.dividir();
          
            Console.ReadKey();
        }
    }
}
