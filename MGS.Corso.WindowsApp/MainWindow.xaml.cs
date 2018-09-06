using MGS.Corso.DomainModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

        private void btnTipiAnonimi_Click(object sender, RoutedEventArgs e)
        {
            var t1 = new
            {
                MioNome = "Liborio Igor",
                Eta = this.somma(3, 4),
                Peso = 78.9
            };

            // short, byte, uint
            bool? sposato;
            DateTime? data = null;
            double? lunghezza = null;
            //  int? annoNascita = null;
            Nullable<int> annoNascita = null;
            annoNascita = 2000;
            annoNascita++;

            if (annoNascita > 1990)
            {
                annoNascita = null;
            }

            //if (!annoNascita.HasValue)
            //{
            //    int a = annoNascita.Value;
            //}

            char? carattere = null;
            ushort? x = null;
            int valore = annoNascita.GetValueOrDefault();
            int? somma = annoNascita + 90;

            Fattura f = new Fattura();
            f = null;
        }

        private void btnLinq_Click(object sender, RoutedEventArgs e)
        {
            // 2867 file
            DirectoryInfo di = new DirectoryInfo(@"C:\Windows\System32");
            FileInfo[] files = di.GetFiles("*.*", SearchOption.TopDirectoryOnly);

            //List<FileInfo> soloIni = new List<FileInfo>();
            //foreach (var f in files)
            //{
            //    if (f.Extension == ".dll")
            //    {
            //        soloIni.Add(f);
            //    }
            //}

            // && fi.Length < 20 * 1024
            IEnumerable<FileInfo> soloFileDiTipoDll = files
                .Where(fi => fi.Extension == ".dll")
                .Where(fi => fi.Length < 20 * 1024)
                .Where(fi => fi.Exists)
                .ToList();

            var ordinati = files
                .OrderBy(fi => fi.Name[0])
                .ThenByDescending(fi => fi.Length)
                .ToList();

            var ilPrimo1 = files.Where(f => f.LastWriteTime.Month == 8
                && f.LastWriteTime.Year == 1800)
                .OrderByDescending(f => f.Length)
                .FirstOrDefault();

            if (ilPrimo1 != null)
            {
                // Fai qualcosa...
            }

            var ilPrimo2 = files.LastOrDefault
                (fi => fi.Name.EndsWith(".txt"));

            // Single
            // Non trovo nulla --> eccezione
            // Trovo più elementi --> eccezione
            // Ne trovo 1 --> OK

            // SingleOrDefault
            // Non trovo nulla --> null
            // Trovo più elementi --> eccezione
            // Ne trovo 1 --> OK

            var cpx = files
                .SingleOrDefault(f => f.Extension == ".zzz");

            bool solaLettura = files
                .Where(f => f.Extension == ".dll")
                .Where(f => f.Name.StartsWith("a"))
                .All(f => f.IsReadOnly);

            if (files != null
                && files.Any(f => f.LastAccessTime.DayOfWeek == DayOfWeek.Sunday))
            {

            }

            int c = files.Count(f => f.Length >= 30000);

            // FileInfo fi2 = files[200000];
            var fi2 = files.ElementAtOrDefault(200000);

            double media = files.Average(f => f.Length);
            double somma = files.Sum(f => f.Length);
            double piuGrande = files.Max(f => f.Length);
            FileInfo filePiuGrande = files.OrderByDescending(f => f.Length).First();

            // 2000
            var sullaUI = files
                .Where(f => f.Length > 50000)
                .Select(f => new SmallFileInfo
                {
                    NOMEFILE = f.Name,
                    DIMENSIONE_IN_KBYTES = (f.Length / 2014).ToString() + "K"
                })
                .ToList();

            //var sullaUI = files
            //    .Where(f => f.Length > 50000)
            //    .Select(f => new Button() { Content = f.Name })
            //    .ToList();

            var props = Process.GetProcesses()
                .Where(p => p.PagedMemorySize64 > 500000)
                .FirstOrDefault();

            var dtUs = DateTime.Now.ToItaly();

            var fusiOrari = TimeZoneInfo.GetSystemTimeZones()
                .FirstOrDefault(fo => fo.DisplayName.Contains("Rom"));

            Debug.WriteLine(sullaUI[0]);
            this.lstFiles.ItemsSource = sullaUI;

            string città = "Modena";
            IEnumerable<char> caratteri = città.Take(5);
            città = string.Join(string.Empty, caratteri);
        }

        private void todo()
        {

        }

        //private bool filtraSoloIni(FileInfo fi)
        //{
        //    return fi.Extension == ".ini";
        //}
    }

    internal class Fatture : object
    {
    }

    internal class Persona
    {

    }
}
