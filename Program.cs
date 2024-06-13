using System;

namespace Interface_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mono miMono = new Mono("Willy");
            Gato miGato = new Gato("Misus");

            miMono.NombreMono();
            miMono.Trepar();
            miMono.Comer();
            //Utilizando el método heredado de la interface
            Console.WriteLine("Tengo " + miMono.NumeroDePatas() + " patas");
            
            Console.WriteLine();

            miGato.NombreGato();
            miGato.Vista();
            miGato.Comer();
            //utilizando el método heredado de la interface
            Console.WriteLine($"Tengo {miGato.NumeroDePatas()} patas");

        }
    }    

    interface IMamiferosTerrestres
    {
        int NumeroDePatas();
    }

    class Mamifero
    {
        private string nombre;
        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }
        public virtual void Comer()
        {
            Console.WriteLine("Tengo que comer para sobrevivir");
        }
        protected string GetNombre()
        {
            return nombre;
        }
    }
    class Mono: Mamifero, IMamiferosTerrestres
    {
        public Mono(string nombre) : base(nombre) { }
        
        public void NombreMono()
        {
            Console.WriteLine($"Mi nombre es {GetNombre()}" );
        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        //modificación del metodo comer
        public override void Comer()
        {
            Console.WriteLine("Me gusta comer banana");
        }

        //Método heredado de la interface 'IMamiferosTerrestres'
        public int NumeroDePatas()
        {
            return 2;
        }

        
    }
    class Gato: Mamifero, IMamiferosTerrestres
    {
        public Gato(string nombre) : base(nombre) { }

        public void NombreGato()
        {
            Console.WriteLine($"Mi nombre es {GetNombre()}");
        }
        public void Vista()
        {
            Console.WriteLine("Soy capaz de ver en la oscuridad");
        }
        //Modificación del método virtual Comer

        public override void Comer()
        {
            //base.Comer();
            Console.WriteLine("Me gusta comer comida para gatos");
        }

        //Metodo heredado de la interface 'IMamiferosTerrestres
        public int NumeroDePatas()
        {
            return 4;
        }
    }
}
