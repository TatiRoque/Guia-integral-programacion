using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Model;

namespace Controller
{
    public class CitizenController
    {
        public Citizen AddNewCitizen() => CitizenView.AddCitizen();

        public void Greetting(Citizen citizen) => CitizenView.Greet(citizen);

        public void ShowLegalAge(Citizen citizen) => CitizenView.ShowLegalAgeStatus(citizen);

    }
}
