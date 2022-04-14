using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;

namespace e_Agenda.ConsoleApp.ModuloContato
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Empresa { get; set; }

        public string Cargo { get; set; }

        public override string ToString()
        {
            return
            "Nome: " + Nome + Environment.NewLine +
            "Email: " + Email + Environment.NewLine +
            "Telefone: " + Telefone + Environment.NewLine +
            "Empresa: " + Empresa + "%" + Environment.NewLine +
            "Cargo: " + Cargo;
        }

    }
}
