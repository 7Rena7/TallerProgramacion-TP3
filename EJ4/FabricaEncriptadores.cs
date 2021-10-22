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
        private static FabricaEncriptadores cInstancia;
        private static Dictionary<string, Encriptador> iEncriptadores = new Dictionary<string, Encriptador>();
        // Constructor privado para evitar la instanciación directa
        private FabricaEncriptadores()
        {
            iEncriptadores.Add("Cesar", new EncriptadorCesar(4));
            iEncriptadores.Add("AES", new EncriptadorAES());
            iEncriptadores.Add("Base64", new EncriptadorBase64());
            iEncriptadores.Add("Simple", new EncriptadorSimple());
            iEncriptadores.Add("Null", new EncriptadorNulo());
        }

        // Metodo para acceder a la instancia
        public static FabricaEncriptadores GetInstance()
        {
            if (cInstancia == null)
            {
                cInstancia = new FabricaEncriptadores();
            }
            return cInstancia;
        }

        // Devuelve la instancia de IEncriptador cuyo nombre coincide con el parámetro proporcionado.
        public IEncriptador getEncriptador(string pNombre)
        {
            if (!iEncriptadores.ContainsKey(pNombre)) return iEncriptadores.GetValueOrDefault("Null");

            else return iEncriptadores.GetValueOrDefault(pNombre);
        }
    }
}
