using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorPrescription
{
    class Prescript
    {
        public string Appointment { get; private set; }
        public DateTime Term { get; private set; }
        public Prescript(string appointment, DateTime term)
        {
            Appointment = appointment;
            Term = term;
        }

        public Prescript Clone(DateTime term)
        {
            return new Prescript(this.Appointment, term);
        }
    }
}
