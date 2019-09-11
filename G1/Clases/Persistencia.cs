using System;
using System.Data;

namespace G1.Clases
{
    class Persistencia
    {
        #region Propiedades
        private const string NombreArchivo = @"registros.xml";
        public DataTable Tabla = new DataTable("Registros");

        public Persistencia()
        {
            ConfiguracionInicial();

        }
        private void ConfiguracionInicial()
        {
            // diseño de la Tabla
            Tabla.Columns.Add("Id");
            //Tabla.Columns.Add("Fecha");
            //Tabla.Columns.Add("Usuario");
            //Tabla.Columns.Add("Tipo Residuo");
            //Tabla.Columns.Add("Cantidad");
            //Tabla.Columns.Add("Contenedor");
            //Tabla.Columns.Add("Ticket");
            //Tabla.Columns.Add("Tipo Registro");

            // busca si el archivo ya existe para precargar sus datos
            if (System.IO.File.Exists(NombreArchivo))
            {
                Tabla.ReadXml(NombreArchivo);
            }
        }

        public void GrabarArchivo()
        {
            Tabla.WriteXml(NombreArchivo);
        }

        // Llena con string vacio los texbox


        /// <summary>
        /// Rellena las columnas del último registro agregado con los valores del textbox correspondiente
        /// </summary>
        public void LlenaRegistroTabla(Object registro)// pasamos un objeto " registro "
        {
            //TablaPersona.Rows.Add();
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Id"] = registro.Id; //despues lo utilizamos aca
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Fecha"] = registro.Fecha; //despues lo utilizamos aca
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Usuario"] = registro.Usuario; //despues lo utilizamos aca
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Tipo Residuo"] = registro.Tipo; //despues lo utilizamos aca
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Cantidad"] = registro.Cantidad; //despues lo utilizamos aca
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Contenedor"] = registro.Contenedor;
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Ticket"] = registro.Ticket;
            //TablaPersona.Rows[TablaPersona.Rows.Count - 1]["Tipo Registro"] = registro.TipodeRegistro;
        }
        #endregion
    }
}
