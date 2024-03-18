using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin_Job_Administrator.CLASSES
{
    public enum State
    {
        Inscrito = 0,
        Rechazado = 1,
        Leido = 2
    }

    public class Oferta
    {
        public string CompanyName { get; set; }
        public string JobName { get; set; }
        public State JobState { get; set; }
        public string Date {  get; set; }
        public string LinkJob { get; set; }

        public Oferta() { }

        public Oferta(string xEmpresa, string xPuesto, State xState, string xDate, string xLink) 
        {
            CompanyName = xEmpresa;
            JobName = xPuesto;
            JobState = xState;
            Date = xDate;
            LinkJob = xLink;
        }
    }
}
