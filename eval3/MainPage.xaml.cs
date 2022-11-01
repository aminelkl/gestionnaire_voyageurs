using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace eval3
{

    public sealed partial class MainPage : Page
    {

        List<Voyageur> voyageur_list = new List<Voyageur>();
        int position = 0;


        public MainPage()
        {
            this.InitializeComponent();

            voyageur_list.Add(new Voyageur("Amine", "Lakhal", "Masculin", "12-12-1998", "123456789", "12-12-2030"));
            voyageur_list.Add(new Voyageur("Rafa", "Ducros", "Masculin", "01-12-1998", "987654321", "03-03-2011"));
            voyageur_list.Add(new Voyageur("Hamoud", "Boualem", "Masculin", "01-01-2045", "192837465", "12-11-2036"));

            DataContext = voyageur_list[0];
           
        }

        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            Voyageur voyageur = new Voyageur(prenom.Text, nom.Text, sexe.Text, date_naissance.Text, numero_passeport.Text, echeance_passeport.Text);
            voyageur_list.Add(voyageur);

            prenom.Text = " ";
            nom.Text = " ";
            sexe.Text = " ";
            date_naissance.Text = " ";
            numero_passeport.Text = " ";
            echeance_passeport.Text = " ";

            label.Text = "Voyageur ajouté avec succès !";
        }

        private void nouveau_Click(object sender, RoutedEventArgs e)
        {
            prenom.Text = " ";
            nom.Text = " ";
            sexe.Text = " ";
            date_naissance.Text = " ";
            numero_passeport.Text = " ";
            echeance_passeport.Text = " ";
        }

        private void supprimer_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < voyageur_list.Count; i++)
            {
                if (voyageur_list[i].prenom == prenom.Text && voyageur_list[i].nom == nom.Text)
                {
                    label.Text = "Le voyageur " + voyageur_list[i].prenom + " " + voyageur_list[i].prenom + " est supprimé de la liste !";
                    voyageur_list.Remove(voyageur_list[i]);
                }
            }
        }

        private void premier_Click(object sender, RoutedEventArgs e)
        {
            prenom.Text = voyageur_list[0].prenom;
            nom.Text = voyageur_list[0].nom;
            sexe.Text = voyageur_list[0].sexe;
            date_naissance.Text = voyageur_list[0].date_naissance;
            numero_passeport.Text = voyageur_list[0].numero_passeport;
            echeance_passeport.Text = voyageur_list[0].date_echeance;
        }

        private void precedent_Click(object sender, RoutedEventArgs e)
        {
            if (position == 0)
            {
                position = voyageur_list.Count - 1;
                prenom.Text = voyageur_list[position].prenom;
                nom.Text = voyageur_list[position].nom;
                sexe.Text = voyageur_list[position].sexe;
                date_naissance.Text = voyageur_list[position].date_naissance;
                numero_passeport.Text = voyageur_list[position].numero_passeport;
                echeance_passeport.Text = voyageur_list[position].date_echeance;
            }
            else
            {
                position--;
                prenom.Text = voyageur_list[position].prenom;
                nom.Text = voyageur_list[position].nom;
                sexe.Text = voyageur_list[position].sexe;
                date_naissance.Text = voyageur_list[position].date_naissance;
                numero_passeport.Text = voyageur_list[position].numero_passeport;
                echeance_passeport.Text = voyageur_list[position].date_echeance;
            }
        }

        private void suivant_Click(object sender, RoutedEventArgs e)
        {
            if (position == 0)
            {
                DataContext = voyageur_list[position];
                position++;
            }
            else if (position <= voyageur_list.Count - 1)
            {
                DataContext = voyageur_list[position];
                position++;
            }
            else
            {
                position = 0;
                DataContext = voyageur_list[position];
                position++;
            }
        }

        private void dernier_Click(object sender, RoutedEventArgs e)
        {
            position = voyageur_list.Count - 1;
            prenom.Text = voyageur_list[position].prenom;
            nom.Text = voyageur_list[position].nom;
            sexe.Text = voyageur_list[position].sexe;
            date_naissance.Text = voyageur_list[position].date_naissance;
            numero_passeport.Text = voyageur_list[position].numero_passeport;
            echeance_passeport.Text = voyageur_list[position].date_echeance;
        }

    }
}
