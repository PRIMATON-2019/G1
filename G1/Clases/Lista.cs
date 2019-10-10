using System;

namespace G1.Clases
{
    public class Lista
    {
        private string[] lista = new string[1];

        public string[] GetLista()
        {
            //Devuelve una lista de strings
            return lista;
        }

        public string AgregarElemento(string elemento)
        {
            return "";
        }

        public void Tuplas()
        {
            string Cadena = "This is some text";
            int nro = 1;
            int[] arregloInt = { 5, 8, 5, 9, 6, 78, 6 };
            var projections = (Cadena,nro,arregloInt);
            foreach (var item in projections.Item3)
            {
                Console.WriteLine(projections.arregloInt[item]);
            }
            
        }
    }
}
