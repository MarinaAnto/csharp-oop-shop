using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop
{
    internal class Prodotto
    {
        //Attributi
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        //Costruttore
        public Prodotto(int codice,string nome,string descrizione,double prezzo,double iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        //Metodi
        public string GetNome()
        {
            return nome;
        }
        public string GetDescrizione()
        {
            return descrizione;
        }
        public double GetPrezzo()
        {
            return prezzo;
        }
        public double GetIVA() 
        { 
            return iva;
        }

        public int CodeRandom()
        {
            Random random = new Random();
            int i = 0;
            while (i < 6)
            {
                codice = random.Next();
                i++;
            }
            Console.WriteLine(codice);
        } 
        public string NomeEsteso()
        {
            Console.WriteLine(codice + nome);
        }
        public double PrezzoBase()
        {
            Console.WriteLine(prezzo);
        }
        public double PrezzoIva()
        {
            iva = prezzo * iva;
            Console.WriteLine(prezzo + iva);
        }
        
        public void StampaTutto()
        {
            Console.WriteLine("Codice identificativo e nome: "+ NomeEsteso() +"\nDescrizione: "+ descrizione +"\nPrezzo Base: "+ PrezzoBase() +"\nPrezzo iva inclusa: "+ PrezzoIva());
        }




    }
}
