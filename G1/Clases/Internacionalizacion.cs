using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1.Clases
{
    public class Internacionalizacion
    {
            public string Eng_mail { get; set; } 
        public string SetLanguage()
        {
            this.Eng_mail = "email";
            return Eng_mail;

            //Etiquetas para mostrar el formulario Login en Ingles



            //string Eng_password = "password";
            //string Eng_recovery = "Recover my password";
            //string Eng_acceptButton = "Accept";
            //string Eng_cancelButton = "Cancel";
            //string Eng_I8NButton = "English";

        }





    }
}
