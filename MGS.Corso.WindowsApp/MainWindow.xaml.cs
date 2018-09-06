using MGS.Corso.DomainModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MGS.Corso.WindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int qualcosa = 99;


        public MainWindow()
        {
            InitializeComponent();

            int x = 34;
            ArrayList listaDinamica = new ArrayList();
            listaDinamica.Add(2);
            listaDinamica.Add(true);
            listaDinamica.Add(78.34);
            listaDinamica.Add("Corso a Modena");
            x++;
            // double peso = (double)listaDinamica[3];

            // Generics
            List<string> nomi = new List<string>();
            nomi.Add("Gabriele");
            nomi.Add("Laura");
            nomi.Add("Igor");
            // nomi.Add(45);
            string partecipante1 = nomi[0];

            Dictionary<string, Persona> dipendenti = new Dictionary<string, Persona>();
            dipendenti.Add("codfisc", new Persona());
            Persona p = dipendenti["codfisc"];

            Dictionary<int, List<Fatture>> archivio = new Dictionary<int, List<Fatture>>();

            string nome = "Igor Damiani";
            // Fluent API
            var docente = "Igor Damiani";



            var peso1 = 5.5 * Math.PI;
            var totale = somma(8, 5);





        }

        private int somma(int a, int b)
        {
            var result = a + b + qualcosa;
            return result;
        }

        private void btnCreaFattura_Click(object sender, RoutedEventArgs e)
        {
            // Collection Initializer(s)
            List<int> numeri = new List<int>() { 18, 19, 20 };
            List<int> anni = new List<int>() {
                DateTime.Now.Year - 1,
                DateTime.Now.Year,
                DateTime.Now.Year + 1
            };

            // Mix
            List<Fattura> elencoFatture = new List<Fattura>()
            {
                new Fattura() { Numero = this.somma(1, 1).ToString() },
                new Fattura() { Numero = "1" },
                new Fattura() { Numero = "1" },
                new Fattura() { Numero = "1" },
                new Fattura() { Numero = "1" },
            };

            // Object Initializer(s)
            var f = new Fattura()
            {
                Pagata = false,
                Numero = "1/2018",
                Data = DateTime.Now
            };

            //f = new Fattura();
            //f.Pagata = false;
            //f.Data = DateTime.Now;
            //f.Numero = "1/2018";

            DateTime oggi = DateTime.Now;
            // var dt = Utility.PrimoGiornoDelMese(oggi);
            var dt = oggi.PrimoGiornoDelMese();
            // oggi.PrimoGiornoDelMese();

            DateTime complIgor = new DateTime(1976, 2, 28);
            bool maggIt = complIgor.IsMaggiorenne();
            bool maggUs = complIgor.IsMaggiorenne("US");
        }
    }

    internal class Fatture : object
    {
    }

    internal class Persona
    {

    }
}
