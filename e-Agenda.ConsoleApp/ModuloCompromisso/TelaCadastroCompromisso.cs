using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;

namespace e_Agenda.ConsoleApp.ModuloCompromisso
{
    public class TelaCadastroCompromisso : TelaBase, ITelaCadastravel
    {
        private readonly RepositorioCompromisso repositorioCompromisso;
        private readonly Notificador notificador;

        public TelaCadastroCompromisso(RepositorioCompromisso repositorioCompromisso, Notificador notificador)
          : base("Cadastro de Compromisso")
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.notificador = notificador;
        }

        public void Inserir()
        {

        }
        public void Editar()
        {

        }
    }
}
