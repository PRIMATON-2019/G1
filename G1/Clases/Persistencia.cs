using System.Data;

namespace G1.Clases
{
    public class Persistencia
    {
        #region Propiedades
        public DataTable Tabla;
        public string NombreArchivo;
        #endregion

        /// <summary>
        /// Clase encargada de persistir datos.
        /// </summary>
        /// <param name="cantColumnas">Numero de columnas en la tabla</param>
        /// <param name="columnas">Encabezados de la tabla. Debe coincidir con la cantidad en cantColumnas</param>
        /// <param name="nombreArchivo">Nombre del archivo a guardar, sin extension.</param>
        public Persistencia()
        {
            Tabla = new DataTable();
        }
        public Persistencia(int cantColumnas, string[] columnas, string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
            Tabla = new DataTable(NombreArchivo);
            ConfiguracionInicial(cantColumnas, columnas);
        }
        private void ConfiguracionInicial(int cantColumnas, string[] columnas)
        {
            // Diseñamos la Tabla 
            for (int i = 0; i < cantColumnas; i++)
            {
                Tabla.Columns.Add(columnas[i]);
            }

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo + ".xml"))
            {
                Tabla.ReadXml(NombreArchivo + ".xml");
            }
        }
        /// <summary>
        /// Graba el archivo XML a disco.
        /// </summary>
        /// <param name="NombreArchivo">Nombre de Archivo, sin extension</param>
        public void GrabarArchivo()
        {
            Tabla.WriteXml(NombreArchivo + ".xml");
        }
        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        public void CargaDatos(string[] datos, int cantColumnas, string[] columnas)// pasamos un objeto " registro "
        {
            Tabla.Rows.Add();
            for (int i = 0; i < cantColumnas; i++)
            {
                Tabla.Rows[Tabla.Rows.Count - 1][columnas[i]] = datos[i]; //despues lo utilizamos aca
            }
            GrabarArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists(NombreArchivo + ".xml"))
            {
                Tabla.ReadXml(NombreArchivo + ".xml");
            }
        }

        public string[,] BuscarDatos(string[] datos, string nombreArchivo)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(nombreArchivo + ".xml");


            string[,] conjunto = new string[ds.Tables[0].Rows.Count, ds.Tables[0].Columns.Count];

            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    conjunto[j,i] = ds.Tables[0].Rows[j][i].ToString();
                }

            }
            return conjunto;
        }
    }
}
