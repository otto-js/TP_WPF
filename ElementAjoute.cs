using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Media;

namespace TP2_Dev_UI
{
    class ElementAjoute
    {
        public string PathIcone { get; set; }
        public string NomElement { get; set; }
        public string TypeElement { get; set; }
        public string DescriptionElement { get; set; }
        public string NomFichier { get; set; }

        public ElementAjoute(string pathIcone, string nomElement, string typeElement, string descriptionElement, string nomFichier)
       {
            this.PathIcone = pathIcone;
            this.NomElement = nomElement;
            this.TypeElement = typeElement;
            this.DescriptionElement = descriptionElement;
            this.NomFichier = nomFichier;
       }
    }
}
