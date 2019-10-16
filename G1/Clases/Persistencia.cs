using G1.Clases.Modelos;
using System;
using System.Data;

namespace G1.Clases
{
    public class Persistencia
    {
        #region Propiedades
        public DataTable Tabla;
        public string nombreArchivo;
        

       


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

        public Persistencia(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            Tabla = new DataTable();

        }
        public Persistencia(int cantColumnas, string[] columnas, string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            Tabla = new DataTable(nombreArchivo);
            ConfiguracionInicial(cantColumnas, columnas, nombreArchivo);
        }
        private void ConfiguracionInicial(int cantColumnas, string[] columnas, string nombreArchivo)
        {
            if (System.IO.File.Exists(nombreArchivo + ".xml"))
            {
                Tabla.TableName = nombreArchivo;
                Tabla.ReadXmlSchema(nombreArchivo + ".xml");
                Tabla.ReadXml(nombreArchivo + ".xml");
                
            }
            else
            {
                for (int i = 0; i < cantColumnas; i++)
                {
                    Tabla.Columns.Add(columnas[i]);
                }
                GrabarArchivo();
            }
        }
        public void LeerArchivo()
        {
            if (System.IO.File.Exists(nombreArchivo + ".xml"))
            {
                Tabla.ReadXml(nombreArchivo + ".xml");
            }
        }
        /// <summary>
        /// Graba el archivo XML a disco.
        /// </summary>
        /// <param name="NombreArchivo">Nombre de Archivo, sin extension</param>
        public void GrabarArchivo()
        {
            Tabla.WriteXml(nombreArchivo + ".xml");
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

        public DataTable BuscarDatos(string nombreArchivo)
        {
            //DataSet ds = new DataSet();
            if (System.IO.File.Exists(nombreArchivo + ".xml"))
            {
                Tabla.TableName = nombreArchivo;
                Tabla.ReadXmlSchema(nombreArchivo + ".xml");
                Tabla.ReadXml(nombreArchivo + ".xml");
            }
            else
            {
                Tabla = null;
            }
            return Tabla;
        }
    }
}
