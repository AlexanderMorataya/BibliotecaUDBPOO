using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Log_In
{
    public class Usuario_Controlador
    {
        //ATRIBUTOS
        public static string UserCode { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string Mail { get; set; }
        public static string Phone { get; set; }
        public static string Dui { get; set; }
        public static string Estatus { get; set; }

        //VALIDACIONES
        //Validacion del campo nombre
        public List<string> ValidarNombre(string texto)
        {
            List<string> errors = new List<string>();

            if (!Regex.IsMatch(texto, "^[a-zA-ZáéíóúÁÉÍÓÚ ]+$"))
            {
                errors.Add("Error: Este campo solo acepta letras");
            }
            return errors;
        }
        //Validacion del campo correo
        public List<string> ValidarMail(string email)
        {
            List<string> errors = new List<string>();

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                errors.Add("Error: El formato del correo electrónico no es válido.");
            }
            return errors;
        }
        //Validacion del campo telefono
        public List<string> ValidarTelefono(string numero)
        {
            List<string> errors = new List<string>();
            if(numero.Length != 9)
            {
                errors.Add("Error: El campo telefono debe tener 8 digitos.");
            }
            for (int i = 0; i < numero.Length; i++)
            {
                if (i != 4)
                {
                    if (!char.IsDigit(numero[i]))
                    {
                        errors.Add("Error: El campo telefono solo puede llevar numeros (A excepcion del - del formato).");
                    }
                }
                else
                {
                    if (numero[i] != '-')
                    {
                        errors.Add("Error: El campo telefono debe llevar un - como tras los primeros 4 digitos");
                    }
                }
            }
            return errors;
        }
        //Validacion del campo DUI
        public List<string> ValidarDUI(string dui)
        {
            List<string> errors = new List<string>();
            if(dui.Length != 10)
            {
                errors.Add("Error: En el campo DUI debe contener 9 digitos");
            }

            for (int i = 0; i < dui.Length; i++)
            {
                if (i != 8)
                {
                    if (!char.IsDigit(dui[i]))
                    {
                        errors.Add("Error: En el campo DUI solo debe digitar numeros");
                    }
                }
                else
                {
                    if (dui[i] != '-')
                    {
                        errors.Add("Error: El campo DUI debe llevar un - como tras los primeros 9 digitos");
                    }
                }
            }
            return errors;
        }

    }
}
