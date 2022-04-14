using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda.ConsoleApp.Compartilhado;
using e_Agenda.ConsoleApp.ModuloContato;

namespace e_Agenda.ConsoleApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public string assunto;
        public string local;
        public DateTime data;
        public TimeSpan horaInicio;
        public TimeSpan horaTermino;
        public Contato contato;

        public Compromisso(string assunto, string local, DateTime data, TimeSpan horaInicio, TimeSpan horaTermino, Contato contato)
        {
            this.assunto = assunto;
            this.local = local;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaTermino = horaTermino;
            this.contato = contato;
        }

    }
}
