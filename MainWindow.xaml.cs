using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP2_Dev_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {

            InitializeComponent();

            ElementAjoute classe = new ElementAjoute("/images/Class_16x.png", "Classe (WPF)", "Élément Visual C#", "Définition classe vide", "Classe1.cs");
            ElementAjoute fenetre = new ElementAjoute("/images/WindowsForm_16x.png", "Fenêtre (WPF)", "Élément Visual C#", "Fenêtre Windows Presentation Foundation", "Window1.xaml");
            ElementAjoute page = new ElementAjoute("/images/PageContent_16x.png", "Page (WPF)", "Élément Visual C#", "Page Windows Presentation Foundation", "Page1.cs");
            ElementAjoute interfa = new ElementAjoute("/images/Interface_16x.png", "Interface (WPF)", "Élément Visual C#", "Définition interface vide", "Interface1.cs");

            ObservableCollection<ElementAjoute> listeInstalle = new ObservableCollection<ElementAjoute>();
            listeInstalle.Add(classe);
            listeInstalle.Add(fenetre);
            listeInstalle.Add(page);
            listeInstalle.Add(interfa);

            ObservableCollection<ElementAjoute> listeEnLigne = new ObservableCollection<ElementAjoute>();
            listeEnLigne.Add(classe);
            listeEnLigne.Add(fenetre);
            listeEnLigne.Add(page);
            listeEnLigne.Add(interfa);

            ObservableCollection<ElementAjoute> listeGeneral = new ObservableCollection<ElementAjoute>();
            listeGeneral.Add(classe);
            listeGeneral.Add(fenetre);

            ObservableCollection<ElementAjoute> listeWpf = new ObservableCollection<ElementAjoute>();
            listeWpf.Add(classe);
            listeWpf.Add(fenetre);
            listeWpf.Add(page);

            ObservableCollection<ElementAjoute> listeElementVisualC = new ObservableCollection<ElementAjoute>();
            listeElementVisualC.Add(interfa);

            Categorie installe = new Categorie() { Nom = "Installé", ElementAjoute = listeInstalle };
            installe.Noeuds.Add( new Categorie() { Nom = "Général", ElementAjoute = listeGeneral });
            installe.Noeuds.Add(new Categorie() { Nom = "WPF", ElementAjoute = listeWpf });
                Categorie visualC = new Categorie() { Nom = "Élément Visual C#", ElementAjoute = listeElementVisualC };
                installe.Noeuds.Add(visualC);
                visualC.Noeuds.Add(new Categorie() { Nom = "Général", ElementAjoute = listeGeneral });
                visualC.Noeuds.Add(new Categorie() { Nom = "WPF", ElementAjoute = listeWpf });
                    Categorie enLigne = new Categorie() { Nom = "En Ligne", ElementAjoute = listeEnLigne };
                    enLigne.Noeuds.Add(new Categorie() { Nom = "Général", ElementAjoute = listeGeneral });
                    enLigne.Noeuds.Add(new Categorie() { Nom = "WPF", ElementAjoute = listeWpf });

            TrvCategorie.Items.Add(installe);
            TrvCategorie.Items.Add(enLigne);
        }

        private void LstElement_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataContext = lstElement.SelectedItem;
        }
    }
}
