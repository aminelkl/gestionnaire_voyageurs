using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eval3
{
    public class Voyageur : INotifyPropertyChanged
    {
        public string prenom { get; set ; }
        public string nom { get; set; }
        public string sexe { get; set; }
        public string date_naissance { get; set; }
        public string numero_passeport { get; set; }
        public string date_echeance{ get; set; }

    public Voyageur(string un_prenom, string un_nom, string un_sexe, string un_date_naissance, string un_numero_passeport, string un_date_echeance)
        {
            prenom = un_prenom;
            nom = un_nom;
            sexe = un_sexe;
            date_naissance = un_date_naissance;
            numero_passeport = un_numero_passeport;
            date_echeance = un_date_echeance;   
        }

        public void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
