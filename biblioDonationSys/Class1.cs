using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace biblioDonationSys
{
    internal class tabSansHeader : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }

    public abstract class Personne
    {
        protected string _nom;
        protected string _prenom;

        public string getNom()
        {
            return this._nom;
        }

        public string getPrenom()
        {
            return this._prenom;
        }

        abstract public int getId();
    }

    public class Commanditaire : Personne
    {
        static private int _id_creator = 155;
        protected int _id;

        public Commanditaire(string nom, string prenom)
        {
            this._prenom = prenom;
            this._nom = nom;
            this._id = idCreator();
        }

        private int idCreator()
        {
            _id_creator++;
            return _id_creator;
        }

        override public int getId()
        {
            return this._id;
        }
    }

    public class Donateur : Personne
    {
        static private int _id_creator = 10001;
        protected int _id;
        protected string _email;
        protected string _telephone;
        protected char _type_carte;
        protected string _numero_carte;
        protected string _carte_exp;

        public Donateur(string nom, string prenom, string email, string telephone, char type_carte, string num_carte, string carte_exp)
        {
            this._email = email;
            this._carte_exp = carte_exp;
            this._nom = nom;
            this._prenom = prenom;
            this._type_carte = type_carte;
            this._numero_carte = num_carte;
            this._telephone = telephone;
            this._id = idCreator();
        }

        public Donateur(string nom, string prenom, string telephone, char type_carte, string num_carte, string carte_exp)
        {
            this._carte_exp = carte_exp;
            this._nom = nom;
            this._prenom = prenom;
            this._type_carte = type_carte;
            this._numero_carte = num_carte;
            this._telephone = telephone;
            this._id = idCreator();
        }
        public string getType()
        {
            if (this._type_carte == 'A') return "Amex";
            else if (this._type_carte == 'V') return "Visa";
            else return "MasterCard";
        }
        private int idCreator()
        {
            _id_creator++;
            return _id_creator;
        }

        public override int getId()
        {
            return this._id;
        }
    }

    public class Prix
    {
        static private int _id_creator = 3000000;
        protected int _id;
        protected string _description;
        protected double _valeurs;

        protected int _qte_original;
        protected int _qte_disponible;
        protected Commanditaire _commanditaire;

        public Prix(string description, double valeurs, int qte_original, Commanditaire sponsor)
        {
            this._description = description;
            this._valeurs = valeurs;
            this._qte_original = qte_original;
            this._qte_disponible = qte_original;
            this._commanditaire = sponsor;
            this._id = idCreator();
        }
        public int getQte()
        {
            return this._qte_original;
        }
        public Commanditaire getSponsed()
        {
            return this._commanditaire;
        }

        public double getValeur()
        {
            return this._valeurs;
        }
        public string getDesc()
        {
            return this._description;
        }
        private int idCreator()
        {
            _id_creator++;
            return _id_creator;
        }
    }

    public class Don
    {
        static private int _id_creator = 0;
        protected int _id;
        protected string _date;
        protected Donateur _donateur;
        protected double _montant;

        public Don(string date, Donateur donateur, double montant)
        {
            this._id = idCreator();
            this._date = date;
            this._donateur = donateur;
            this._montant = montant;
        }
        //public int getId()
        //{
        //    return this._id;
        //}
        public string getDate()
        {
            return this._date;
        }
       public Donateur getDonateur()
        {
            return this._donateur;
        }
        public double getMontant()
        {
            return this._montant;
        }
        public int getId()
        {
            return this._id;
        }

        private int idCreator()
        {
            _id_creator++;
            return _id_creator;
        }
    }

    public class GestionnaireSTE
    {
        protected List<Commanditaire> tab_sponsor = new List<Commanditaire>();
        protected List<Donateur> tab_donateurs = new List<Donateur>();
        protected List<Don> tab_don = new List<Don>();
        protected List<Prix> tab_prix = new List<Prix>();

        public List<Commanditaire> getSponsor()
        {
            return this.tab_sponsor;
        }
        public List<Donateur> getDonateur()
        {
            return this.tab_donateurs;
        }
        public List<Don> getDon()
        {
            return this.tab_don;
        }
        public List<Prix> getPrix()
        {
            return this.tab_prix;
        }
        public void ajouterSponsor(Commanditaire sponsor)
        {
            this.tab_sponsor.Add(sponsor);
        }

        public void ajouterDonateur(Donateur donateur)
        {
            this.tab_donateurs.Add(donateur);
        }

        public void ajouterPrix(Prix prix)
        {
            this.tab_prix.Add(prix);
        }

        public void ajouterDon(Don don)
        {
            this.tab_don.Add(don);
        }
    }
}