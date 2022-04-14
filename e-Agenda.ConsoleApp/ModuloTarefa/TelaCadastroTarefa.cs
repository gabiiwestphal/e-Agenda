using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;
using e_Agenda.ConsoleApp.ModuloCompromisso;
using e_Agenda.ConsoleApp.ModuloContato;

namespace e_Agenda.ConsoleApp.ModuloTarefa
{
    public class TelaCadastroTarefa : TelaBase, ITelaCadastravel
    {
        private readonly RepositorioTarefa repositorioTarefa;
        private readonly Notificador notificador;

        public TelaCadastroTarefa(RepositorioTarefa repositorioTarefa, Notificador notificador)
          : base("Cadastro de Tarefa")
        {
            this.repositorioTarefa = repositorioTarefa;
            this.notificador = notificador;
        }           
    }
   
    //public void CadastrarNovaTarefa()
    //{

    //}
    //public void AtualizarTarefa()
    //{

    //}
    //public void ExcluirTarefa()
    //{

    //}
    //public void VisualizarTodasAsTarefas()
    //{

    //}


}
