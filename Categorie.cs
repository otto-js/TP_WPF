using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TP2_Dev_UI
{
    class Categorie 
    {
        public string Nom { get; set; }
        public ObservableCollection<Categorie> Noeuds { get; set; }
        public ObservableCollection<ElementAjoute> ElementAjoute { get; set; }

        public Categorie() {
            this.Noeuds = new ObservableCollection<Categorie>();
        }
        public Categorie(string nom, ObservableCollection<ElementAjoute> elementAjoute) { 
            Nom = nom; 
            ElementAjoute = elementAjoute; 
        }
    }
}
