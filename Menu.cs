using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
   public class Menu : MenuComponent
    {

        private List<MenuComponent> hijos;


        public Menu(string descripcion, string nombre, string precio) : base(descripcion, nombre, precio)
        {

            Hijos = new List<MenuComponent>();
        }
        public List<MenuComponent> Hijos { get => hijos; set => hijos = value; }

        public override void AgregarHijo(MenuComponent m)
        {
            Hijos.Add(m);
        }

        public override void EliminarHijo(MenuComponent m)
        {
            Hijos.Remove(m);
        }

        public override void Imprimir()
        {
            foreach(var c in Hijos)
            {
               c.Imprimir() ;
                
            }
        }

        public override List<MenuComponent> ObtenerMenu()
        {
            return hijos;
        }
    }
}
