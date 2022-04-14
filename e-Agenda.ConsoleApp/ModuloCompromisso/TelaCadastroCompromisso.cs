using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;
using e_Agenda.ConsoleApp.ModuloContato;

namespace e_Agenda.ConsoleApp.ModuloCompromisso
{
    public class TelaCadastroCompromisso : TelaBase, ITelaCadastravel
    {
        private readonly RepositorioCompromisso repositorioCompromisso;
        private readonly Notificador notificador;

        RepositorioContato repositorioContato;
        TelaCadastroContato telaCadastroContato;

        public TelaCadastroCompromisso(RepositorioCompromisso repositorioCompromisso, Notificador notificador, RepositorioContato repositorioContato)
          : base("Cadastro de Compromisso")
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.notificador = notificador;
            this.repositorioContato = repositorioContato;
            this.telaCadastroContato = telaCadastroContato;
        }


        public void Inserir()
        {        
           
        }
        public void Editar()
        {

        }
    }
}
