using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filas {
    class Fila {
        private Clientes frente; // referência ao cliente que está na frente da fila. Esse cliente é utilizado apenas para controle.
        private Clientes tras;   // referência ao cliente que está na última posição da fila.
        public int counter;

        // Construtor que cria uma fila vazia inicializando o cliente da frente da fila e os atributos de controle da fila (frente e tras).
        public Fila() {
            Clientes cli;
            DateTime horaChegada;
            counter = 0;
            horaChegada = new DateTime(2018, 4, 14, 10, 40, 0);
            cli = new Clientes(" ", horaChegada);
            frente = cli;
            tras = cli;
        }

        // Verifica se a fila está vazia. Em caso afirmativo, retorna true e em caso negativo retorna false.
        public Boolean filaVazia() {
            // se a fila apresentar apenas o elemento de controle, ela está vazia.
            if (frente == tras) {
                return true;
            } else {
                return false;
            }
        }

        // Insere o cliente cli, passado como parâmetro para esse método, no final da fila.
        public void enfileirar(Clientes cli) {
            // inserção do novo cliente no final da fila.
            tras.proximo = cli;

            // atualização do atributo de controle tras.
            tras = cli;
            counter++;
        }

        // Retira o cliente que ocupa a primeira posição da fila. Se a fila estiver vazia, esse método deve retornar null; caso contrário, esse método deve retornar o cliente retirado da fila.
        public Clientes desenfileirar() {
            // cli aponta para o cliente da fila que será retornado/desenfileirado, ou seja, o primeiro cliente da fila.
            Clientes cli = frente.proximo;

            if (!(filaVazia())) {
                // atualização do primeiro cliente da fila.
                frente.proximo = cli.proximo;

                cli.proximo = null;
                counter--;
            }
            return (cli);
        }

        public Clientes obterPrimeiro() {
            Clientes cli = frente.proximo;
            if ((filaVazia())) {
                return null;
            }
            return cli;
        }

        public void imprimir() {
            while (counter > 0) {
                Clientes cliente = obterPrimeiro();
                Console.WriteLine("{0}", cliente.nome);
                desenfileirar();
            }
        }

        public Fila dividir() {
            Fila par = new Fila();
            Fila impar = new Fila();
            while (counter > 0) {
                if (counter % 2 == 0) {
                    par.enfileirar(obterPrimeiro());
                    desenfileirar();
                } else {
                    impar.enfileirar(obterPrimeiro());
                    desenfileirar();
                }
            }
            Console.WriteLine("fila atual: ");
            impar.imprimir();
            Console.WriteLine("\nfila par: ");
            par.imprimir();
           
            return par;
        }

        public int obterNumeroClientes() {
            return counter;
        }
    }
}
