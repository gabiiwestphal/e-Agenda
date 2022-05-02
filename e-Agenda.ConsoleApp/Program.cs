using System;
using e_Agenda.ConsoleApp.Compartilhado;
using e_Agenda.ConsoleApp.ModuloCompromisso;
using e_Agenda.ConsoleApp.ModuloContato;
using e_Agenda.ConsoleApp.ModuloTarefa;

namespace e_Agenda.ConsoleApp
{
    internal class Program
    {
        static Notificador notificador = new Notificador();
        static TelaMenuPrincipal menuPrincipal = new TelaMenuPrincipal(notificador);
        static void Main(string[] args)
        {


            while (true)
            {
                TelaBase telaSelecionada = menuPrincipal.obterTela();

                string opcaoSelecionada = telaSelecionada.MostrarOpcoes();


                if (telaSelecionada is ITelaCadastravel)
                    GerenciarCadastro(telaSelecionada, opcaoSelecionada);

            }


        }

        public static void GerenciarCadastro(TelaBase telaSelecionada, string opcaoSelecionada)
        {
            ITelaCadastravel telaCadastro = (ITelaCadastravel)telaSelecionada;

            if (opcaoSelecionada == "1")
                telaCadastro.InserirRegistro();

            else if (opcaoSelecionada == "2")
                telaCadastro.EditarRegistro();

            else if (opcaoSelecionada == "3")
                telaCadastro.ExcluirRegistro();

            else if (opcaoSelecionada == "4")
            {
                bool temRegistros = telaCadastro.VisualizarRegistros("Tela");

                if (!temRegistros)
                    notificador.apresentarMensagem("Nenhum registro disponível!", TipoMensagem.Atencao);
            }

        }

    }

}