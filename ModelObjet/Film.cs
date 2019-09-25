using System;
using System.Collections.Generic;
using System.Text;

namespace ModelObjet
{
    public class Film
    {
        public string PhotoFilm { get; set; }
        public string TitreFilm { get; set; }
        public Realisateur LeRealisateur { get; set; }
        public List<Acteur> LesActeurs { get; set; }
        public int NbEntrees { get; set; }

        // permet d'ajouter un acteur à la liste d'acteurs
        public void AjouterActeur(Acteur unActeur)
        {
            LesActeurs.Add(unActeur);
        }
    }
}
