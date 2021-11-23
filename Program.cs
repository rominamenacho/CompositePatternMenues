using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent AllMenues = new Menu("All menues", ".", ".");

            MenuComponent item1 = new MenuItem("pollo al horno", "Pollo", "100");
            MenuComponent item2 = new MenuItem("verduras al horno", "VRD", "50");
            MenuComponent item3 = new MenuItem("pescado a la parrilla", "pescado", "200");
            MenuComponent item4 = new MenuItem("cafe", "cf", "10");
            MenuComponent item5 = new MenuItem("te", "te", "10");
            MenuComponent item6 = new MenuItem("tostado", "TJyQ", "80");

            MenuComponent desay = new Menu("Desayunos", "DSX", "");
            MenuComponent almuerzos = new Menu("Almuerzos", "ALM", "");

            MenuComponent cena = new Menu("Cenas", "CNA", "");

            AllMenues.AgregarHijo(desay);
            AllMenues.AgregarHijo(almuerzos);
            AllMenues.AgregarHijo(cena);

            desay.AgregarHijo(item4);
            desay.AgregarHijo(item5);
            desay.AgregarHijo(item6);

            almuerzos.AgregarHijo(item1);
            almuerzos.AgregarHijo(item2);
            cena.AgregarHijo(item3);

           
            foreach (var c in AllMenues.ObtenerMenu()) { 
                    Console.WriteLine(c.Nombre + " "+ c.Descripcion);
                c.Imprimir();
            }
          // AllMenues.Imprimir();


            Console.ReadKey();
        }
    }
}
