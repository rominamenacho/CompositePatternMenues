using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
   public abstract class MenuComponent
    {
        private string descripcion;
        private string nombre;
        private string precio;
       
        protected MenuComponent(string descripcion, string nombre, string precio)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
            this.Precio = precio;

        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Precio { get => precio; set => precio = value; }
       
        public abstract void AgregarHijo(MenuComponent m);
        public abstract void EliminarHijo(MenuComponent m);
        public abstract List<MenuComponent> ObtenerMenu();
        public abstract void Imprimir();
    }
}
