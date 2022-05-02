using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;

namespace e_Agenda.ConsoleApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase
    {

        private string titulo;
        private int prioridade;
        private int percentualConcluido;
        private DateTime dataCriacao;
        private DateTime dataConclusao;
        private bool concluido;

        public Tarefa(string titulo, int prioridade, DateTime dataCriacao)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.concluido = false;
        }

        public Tarefa(string titulo, int prioridade, DateTime dataCriacao, DateTime dataConclusao)
        {
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            this.dataConclusao = dataConclusao;
            this.percentualConcluido = 0;
            this.concluido = false;
        }


        public string Titulo { get => titulo; set => titulo = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public DateTime DataConclusao { get => dataConclusao; set => dataConclusao = value; }
        public int PercentualConcluido { get => percentualConcluido; set => percentualConcluido = value; }
        public bool Concluido { get => concluido; set => concluido = value; }

        public override string ToString()
        {
            return "Id: " + numero + Environment.NewLine +
                "Nome: " + titulo + Environment.NewLine +
                "Prioridade: " + prioridade + Environment.NewLine +
                "Percentual Concluido: " + percentualConcluido + "% " + Environment.NewLine +
                "Data de criação: " + dataCriacao.ToShortDateString() + Environment.NewLine;

        }

        public void mostraTarefaNivel3()
        {
            if (prioridade == 3)
            {
                Console.WriteLine("Id:" + numero);
                Console.WriteLine("Nome: " + titulo);
                Console.WriteLine("Prioridadae: " + prioridade);
            }
        }

        public void mostraTarefaNivel2()
        {
            if (prioridade == 2)
            {
                Console.WriteLine("Id:" + numero);
                Console.WriteLine("Nome: " + titulo);
                Console.WriteLine("Prioridadae: " + prioridade);
            }
        }

        public void mostraTarefaNivel1()
        {
            if (prioridade == 1)
            {
                Console.WriteLine("Id:" + numero);
                Console.WriteLine("Nome: " + titulo);
                Console.WriteLine("Prioridadae: " + prioridade);
            }
        }
    }
}
