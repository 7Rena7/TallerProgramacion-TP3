using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class FabricaEncriptadores
    {
        // Clase que implementa el patron Singleton
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        private static readonly Lazy<FabricaEncriptadores> cInstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());

        // Constructor privado para evitar la instanciación directa
        private FabricaEncriptadores()
        {
        }

        // Propiedad para acceder a la instancia
        public static FabricaEncriptadores Instancia
        {
            get
            {
                return cInstancia.Value;
            }
            private set { }
        }

        // Devuelve la instancia de IEncriptador cuyo nombre coincide con el parámetro proporcionado.
        /*public static IEncriptador getEncriptador(string pNombre)
        {
            
        }*/
    }
}
