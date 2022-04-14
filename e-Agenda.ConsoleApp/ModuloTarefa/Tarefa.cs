using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;

namespace e_Agenda.ConsoleApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase, IComparable<Tarefa> //INCOMPLETO
    {
        public Prioridade prioridade;
        string titulo;
        DateTime dataCriacao;
        DateTime dataConclusao;
        double percConclusao;

        public Tarefa(Prioridade prioridade, string titulo, DateTime dataCriacao, DateTime dataConclusao)
        {
            this.prioridade = prioridade;
            this.titulo = titulo;
            this.dataCriacao = dataCriacao;
            this.dataConclusao = dataConclusao;

        }

        public double PercConclusão { get => percConclusao; set => percConclusao = value; }
        public DateTime DataConclusao { get => dataConclusao; set => dataConclusao = value; }

        public override string ToString()
        {
            return $"Id  {id}\n" +
                $"prioridade  {prioridade}\n" +
                $"titulo  {titulo}\n" +
                $"Data de criação {dataCriacao}\n" +
                $"data de conclusão {DataConclusao}\n" +
                $"Percentual de conclusão {percConclusao * 100}%";
        }

        public int CompareTo(Tarefa other)
        {
            return other.prioridade.CompareTo(prioridade);
        }
    }
}
