namespace exo_2_PPo
{
    class Compte 
    {
        private int numeroCompte;
        private string nomCompte;
        private string prenomCompte;
        private int soldeCompte;

        public Compte(int monNumero, string monNom, string monPrenom) 
        {
            numeroCompte = monNumero;
            nomCompte = monNom;
            prenomCompte = monPrenom;
            soldeCompte = 0;
        }
        public Compte(int monNumero, string monNom, string monPrenom, int monSolde) 
        {
            numeroCompte = monNumero;
            nomCompte = monNom;
            prenomCompte = monPrenom;
            soldeCompte = monSolde;
        }

        public void CrediterCompte(int montant_Ajoute)
        {
            soldeCompte = soldeCompte + montant_Ajoute;

        }
        public void DebiterCompte(int montant_Soustrait)
        {

            soldeCompte = soldeCompte - montant_Soustrait;

        }

        public int GetNumero()
        {
            return numeroCompte;
        }
        public string GetNom()
        {
            return nomCompte;
        }
        public string GetPrenom()
        {
            return prenomCompte;
        }
        public int GetSolde()
        {

            return soldeCompte;
        }
    }
}
