using System.CodeDom;

namespace WindowsFormsApplication2
{
    public class Plateau
    {
        private int _largeur;
        private int _longueur;
        private Case [] _casesPlateau;

        public Plateau(int largeur, int longueur, Case[] casesPlateau)
        {
            this._largeur = largeur;
            this._longueur = longueur;
            this._casesPlateau = casesPlateau;
        }

    }
}