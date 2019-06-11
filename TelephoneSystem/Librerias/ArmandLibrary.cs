using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneSystem.Librerias
{
    public class ArmandLibrary
    {
        public string SumarTime(string cadena1, string cadena2)
        {            
            int[] arr1;
            int[] arr2;
            int[] arr3 = new int[2];
            int temp;
            int aux = 0;
            arr1 = Tranformar(cadena1);
            arr2 = Tranformar(cadena2);
            temp = arr1[1] + arr2[1];
            if (temp >= 60)
            {
                temp -= 60;
                arr3[1] = temp;
                aux = 1;
            }
            else
            {
                arr3[1] = temp;
            }

            temp = arr1[0] + arr2[0] + aux;
            if (temp >= 12)
            {
                temp -= 12;
                arr3[0] = temp;
            }
            else
            {
                arr3[0] = temp;
            }

            return formato(arr3[0]) + ":" + formato(arr3[1]);
        }

        public string RestarTime(string cadena1, string cadena2)
        {
            int[] arr1;
            int[] arr2;
            int[] arr3 = new int[2];
            int temp;
            arr1 = Tranformar(cadena1);
            arr2 = Tranformar(cadena2);
            temp = arr1[1] - arr2[1];
            if (temp <= 0)
            {
                arr3[1] = temp;
                temp = arr1[0] - arr2[0];
                if (temp <= 0)
                {
                    arr3[0] = 0;
                    arr3[1] = 0;
                }
                else
                {
                    arr3[0] = temp - 1;
                    arr3[1] = 60 + arr3[1];
                }
            }
            else
            {
                arr3[1] = temp;
                temp = arr1[0] - arr2[0];
                if (temp <= 0)
                {
                    arr3[0] = 0;
                }
                else
                {
                    arr3[0] = temp;
                }
            }

            return formato(arr3[0]) + ":" + formato(arr3[1]);
        }

        private int[] Tranformar(string cadena)
        {
            string[] time = new string[2];
            int[] temp = new int[2];
            time = cadena.Split(':');
            temp[0] = Convert.ToInt32(time[0]); //Horas
            temp[1] = Convert.ToInt32(time[1]); //Minutos

            return temp;
        }

        private string formato(int ok)
        {
            string temp;
            if (ok <= 9)
            {
                temp = "0" + ok;
            }
            else
            {
                temp = "" + ok;
            }

            return temp;
        }

        public string JustNumInFec(string cadena)
        {
            string temp = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                temp += cadena[i];
            }
            return temp;
        }
    }
}
