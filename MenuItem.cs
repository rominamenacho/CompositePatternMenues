using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class MenuItem : MenuComponent//leaf
    {
        

        public MenuItem(string descripcion, string nombre, string precio) : base(descripcion, nombre, precio)
        {
        }

        

        public override void AgregarHijo(MenuComponent m)
        {
            throw new NotImplementedException();
        }

      
        public override void EliminarHijo(MenuComponent m)
        {
            throw new NotImplementedException();
        }

        public override void Imprimir()
        {
            Console.WriteLine( $@"item: {Nombre} ,descripcion: {Descripcion}, precio: {Precio}");
        }

        public override List<MenuComponent> ObtenerMenu()
        {
            return null;
        }
    }
}
