using System;
using System.Collections;
using System.Collections.Generic;
// using System.Linq;
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
            dipendenti.Add("codfisc", new Persona());

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
    }

    internal class Fatture : object
    {
    }

    internal class Persona
    {

    }
}
