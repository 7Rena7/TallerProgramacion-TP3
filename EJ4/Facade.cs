using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    static class Facade
    {
        public static string EncriptarFrase(string pNombreEncriptador, string pFraseAEncriptar)
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.GetInstance();
            IEncriptador encriptadorActual = instancia.getEncriptador(pNombreEncriptador);
            string fraseEncriptada = encriptadorActual.Encriptar(pFraseAEncriptar);
            return fraseEncriptada;
        }

        public static string DesencriptarFrase(string pNombreEncriptador, string pFraseADesencriptar)
        {
            FabricaEncriptadores instancia = FabricaEncriptadores.GetInstance();
            IEncriptador encriptadorActual = instancia.getEncriptador(pNombreEncriptador);
            string fraseDesencriptada = encriptadorActual.Desencriptar(pFraseADesencriptar);
            return fraseDesencriptada;
        }
    }
}
