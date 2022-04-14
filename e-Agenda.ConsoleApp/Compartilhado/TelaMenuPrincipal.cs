using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.ModuloTarefa;
using e_Agenda.ConsoleApp.ModuloContato;
using e_Agenda.ConsoleApp.ModuloCompromisso;

namespace e_Agenda.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private string opcaoSelecionada;

        private RepositorioTarefa repositorioTarefa;
        private TelaCadastroTarefa telaCadastroTarefa;

        private RepositorioContato repositorioContato;
        private TelaCadastroContato telaCadastroContato;

        private RepositorioCompromisso repositorioCompromisso;
        private TelaCadastroCompromisso telaCadastroCompromisso;

        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioTarefa = new RepositorioTarefa();
            telaCadastroTarefa = new TelaCadastroTarefa(repositorioTarefa, notificador);

            repositorioContato = new RepositorioContato();
            telaCadastroContato = new TelaCadastroContato(repositorioContato, notificador);

            repositorioCompromisso = new RepositorioCompromisso();
            telaCadastroCompromisso = new TelaCadastroCompromisso(repositorioCompromisso, notificador);
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("eAgenda");

            Console.WriteLine("Digite 1 para Gerenciar Tarefas");

            Console.WriteLine("Digite 2 para Gerenciar Contatos");

            Console.WriteLine("Digite 3 para Gerenciar Compromissos");

            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroTarefa;

            if (opcao == "2")
                tela = telaCadastroContato;

            if (opcao == "3")
                tela = telaCadastroCompromisso;

            return tela;
        }
    }
}

