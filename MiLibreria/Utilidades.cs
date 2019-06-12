using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {

        //Control de usuario: para que no pueda ingresar cualquier cosa en los txtbox
        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider errorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls) //esto me permite comprobar que no haya campos vacios en los txtbox
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;
                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            errorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    if (Obj.SoloNumeros == true)//esto me permite comprobar que no haya letras en los txtbox, que permita solo numeros
                    {
                        int cont = 0, LetrasEncontradas = 0;

                        foreach (char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), cont))
                            {
                                LetrasEncontradas++;
                            }
                            cont++;
                        }
                        if (LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            errorProvider.SetError(Obj, "Solo numeros");
                        }
                    }
                }
            }
            return HayErrores;
        }
    }
}
