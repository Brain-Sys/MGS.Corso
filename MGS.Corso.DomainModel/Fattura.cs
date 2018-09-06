using System;

namespace MGS.Corso.DomainModel
{
    public class Fattura
    {
        public DateTime Data { get; set; }
        public string Numero { get; set; }
        public bool Pagata { get; set; }

        public Fattura()
        {

        }

        public Fattura(string numero)
        {
            this.Numero = numero;
        }
    }
}