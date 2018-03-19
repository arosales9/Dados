using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionDados
{
    class Dado
    {
        Random r = new Random();

        int[] _Dado = new int[100];
        //int[] _Dado1 = new int[100];
        int[] _ReptDado = new int[100];

        public string Lanzar()
        {
            string cad = "";
            for (int i = 0; i < 100; i++)//hasta el 99==100
            {
                _Dado[i]= r.Next(1, 7);
                //_Dado1[i] = _Dado[i];
            }

            for (int i = 0; i<100; i++)
            {
                for (int j = 0; j<100; j++)
                {
                    if (_Dado[i]==_Dado[j])
                    {
                        _ReptDado[i]+= 1;
                    }
                }
            }

            for (int i = 0; i < 100; i++)
            {
                cad += (i+1)+" ---> El "+_Dado[i] + " se repite " + _ReptDado[i] + " veces."+Environment.NewLine;
            }
            return cad;
        }
    }
}
