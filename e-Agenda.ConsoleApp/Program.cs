using System;
using e_Agenda.ConsoleApp.Compartilhado;
using e_Agenda.ConsoleApp.ModuloCompromisso;
using e_Agenda.ConsoleApp.ModuloContato;
using e_Agenda.ConsoleApp.ModuloTarefa;

namespace e_Agenda.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificador notificador = new Notificador();
            TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal(notificador);

            while (true)
            {
                TelaBase telaSelecionada = menuPrincipal.ObterTela();

                if (telaSelecionada is null)
                    return;

                string opcaoSelecionada = telaSelecionada.MostrarOpcoes();

                if (telaSelecionada is TelaCadastroTarefa)
                    GerenciarCadastroTarefa(telaSelecionada, opcaoSelecionada);

                else if (telaSelecionada is TelaCadastroContato)
                    GerenciarCadastroContato(telaSelecionada, opcaoSelecionada);

                else if (telaSelecionada is TelaCadastroCompromisso)
                    GerenciarCadastroCompromisso(telaSelecionada, opcaoSelecionada);

            }
        }

        private static void GerenciarCadastroCompromisso(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            TelaCadastroCompromisso telaCadastroCompromisso = telaSelecionada as telaCadastroCompromisso;

            if (telaCadastroCompromisso is null)
                return;

            if (opcaoSelecionada == "1")
                TelaCadastroCompromisso.Inserir();

            else if (opcaoSelecionada == "2")
                TelaCadastroCompromisso.Editar();

            else if (opcaoSelecionada == "3")
                TelaCadastroCompromisso.Excluir();

            else if (opcaoSelecionada == "4")
                TelaCadastroCompromisso.Visualizar("tela");
        
    }

        private static void GerenciarCadastroContato(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            TelaCadastroContato telaCadastroContato = telaSelecionada as TelaCadastroContato;

            if (telaCadastroContato is null)
                return;

            if (opcaoSelecionada == "1")
               TelaCadastroContato.Inserir();

            else if (opcaoSelecionada == "2")
               TelaCadastroContato.Editar();

            else if (opcaoSelecionada == "3")
               TelaCadastroContato.Excluir();

            else if (opcaoSelecionada == "4")
                TelaCadastroContato.Visualizar("tela");
        }

        private static void GerenciarCadastroTarefa(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            TelaCadastroTarefa telaCadastroTarefa = telaSelecionada as TelaCadastroTarefa;

            if (telaCadastroTarefa is null)
                return;

            if (opcaoSelecionada == "1")
                TelaCadastroTarefa.Inserir();

            else if (opcaoSelecionada == "2")
                TelaCadastroTarefa.Editar();

            else if (opcaoSelecionada == "3")
                TelaCadastroTarefa.Excluir();

            else if (opcaoSelecionada == "4")
                TelaCadastroTarefa.Visualizar("tela");
        }
    }

}