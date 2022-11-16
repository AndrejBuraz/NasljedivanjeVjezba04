using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje04
{
    class GeometrijskiLik
    {
        int brojStranica;
        public int BrojStranica
        {
            get => this.brojStranica; set => this.brojStranica = value;
        }
        double[] stranice = new double[10];

        public void UcitajStranice()
        {
            for(int i = 0; i < this.brojStranica; i++)
            {
                Console.WriteLine("Unesi duzinu " + (i+1) +". stranice: ");
                this.stranice[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double rez = 0;
            for (int i = 0; i < this.brojStranica; i++)
            {
                rez += this.stranice[i];
            }
            return rez;
        }

        public GeometrijskiLik(int brojStranica)
        {
            this.brojStranica = brojStranica;
        }
    }
    class Trokut : GeometrijskiLik
    {
        public Trokut() : base(3)
        {

        }
    }
    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut() : base(4)
        {

        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Trokut x = new Trokut();
            Console.WriteLine("TROKUT");
            x.UcitajStranice();
            Console.WriteLine("Opseg trokuta: " + x.Opseg());
            Cetverokut y = new Cetverokut();
            Console.WriteLine("CETVEROKUT");
            y.UcitajStranice();
            Console.WriteLine("Opseg cetverokuta: " + y.Opseg());
            Console.ReadKey();
        }
    }
}
