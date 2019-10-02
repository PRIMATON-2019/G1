using System.Data;

namespace G1.Clases
{
    public class Tablas
    {
        private readonly string nombreArchivo;
        public DataTable Tabla;

        public Tablas()
        {
            Tabla = new DataTable();
        }

        public Tablas(int cantColumnas, string[] columnas, string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            Tabla = new DataTable(nombreArchivo);
            ArmarTabla(cantColumnas, columnas);
        }


        private void ArmarTabla(int cantColumnas, string[] columnas)
        {
            for (int i = 0; i < cantColumnas; i++)
            {
                Tabla.Columns.Add(columnas[i]);
            }
        }

        public void CargaDatos(string[] datos, int cantColumnas, string[] columnas)
        {
            Tabla.Rows.Add();
            for (int i = 0; i < cantColumnas; i++)
            {
                Tabla.Rows[Tabla.Rows.Count - 1][columnas[i]] = datos[i];
            }
        }

        public DataSet ListarRegistros(string nombreArchivo)
        {
            Persistencia pd = new Persistencia();
            DataSet ds = pd.LeerArchivo(nombreArchivo);
            return ds;
            //Tabla.TableName = ds.Tables[0].TableName;
            
            //Tabla.ReadXml(nombreArchivo + ".xml");

        }

        /// <summary>
        /// Borra una linea del registro en tabla
        /// </summary>
        public void BorrarRegistro()
        {

        }

        /// <summary>
        /// Buscar un registro por su clave de identificacion.
        /// </summary>
        /// <returns></returns>
        public string BuscarRegistro()
        {
            return "";

        }











    }
}
