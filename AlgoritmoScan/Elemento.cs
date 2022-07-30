using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoScan
{
    internal class Elemento
    {
        //Variable para almacenar la distancia entre el objeto_scan y la cabeza ingresada
        public int distancia = 0;
        //Variable que dará verdadero si ya se accedió al objeto_scan
        public Boolean acceso = false;
    }
}
