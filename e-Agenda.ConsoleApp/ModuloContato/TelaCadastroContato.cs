using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;


namespace e_Agenda.ConsoleApp.ModuloContato
{
    public class TelaCadastroContato : TelaBase, ITelaCadastravel
    {
        private readonly IRepositorio<Contato> _repositorioContato;
        private readonly Notificador _notificador;

        public TelaCadastroContato(IRepositorio<Contato> repositorioContato, Notificador notificador)
          : base("Cadastro de Contatos")
        {
            _repositorioContato = repositorioContato;
            _notificador = notificador;
        }

        public void Inserir()
        {

        }
        public void Editar()
        {

        }
        public void Excluir()
        {

        }
        public void Visualizar()
        {

        }
    }
}
