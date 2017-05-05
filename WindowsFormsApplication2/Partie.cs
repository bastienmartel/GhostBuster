namespace WindowsFormsApplication2
{
    public class Partie
    {
        private int nbMinesRestantes;
        private int nbMinesInitial;
        private bool enCours; //Indique si la partie est en cours d'exécution

        public Partie(int nbMinesRestantes, int nbMinesInitial, bool enCours)
        {
            this.nbMinesRestantes = nbMinesRestantes;
            this.nbMinesInitial = nbMinesInitial;
            this.enCours = enCours;
        }

    }
}