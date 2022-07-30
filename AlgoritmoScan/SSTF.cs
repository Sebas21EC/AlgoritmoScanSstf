using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoScan
{
    internal class SSTF
    {
        int contadorBusqueda;
        int[] arreglo;

        public SSTF( int[] arreglo)
        {
            this.contadorBusqueda = 0;
            this.Arreglo = arreglo;
        }

        public int ContadorBusqueda { get => contadorBusqueda; set => contadorBusqueda = value; }
        public int[] Arreglo { get => arreglo; set => arreglo = value; }

        public void CalcularDist(int[] arreglo, int cabeza, Elemento[] diferencia)
        {
            for (int i = 0; i < diferencia.Length; i++)
                diferencia[i].distancia = Math.Abs(arreglo[i] - cabeza);
        }

        //buscar pista a la que no se accede que está a una distancia mínima de la cabeza
        public int encontrar_minimo(Elemento[] diferencia)
        {
            int index = -1;
            int minimo = int.MaxValue;

            for (int i = 0; i < diferencia.Length; i++)
            {
                if (!diferencia[i].acceso && minimo > diferencia[i].distancia)
                {
                    minimo = diferencia[i].distancia;
                    index = i;
                }
            }
            return index;
        }

        public int [] AlSSTF(int[] pedido,int cabeza)
        {
            
            if (pedido.Length == 0)
                return null;

            // Crea un array de elementos
            Elemento[] diferencia = new Elemento[pedido.Length];

            for (int i = 0; i < diferencia.Length; i++)

                diferencia[i] = new Elemento();

            // Numero de busqueda
            ContadorBusqueda = 0;

            // Almacena la secuencia en la que se realiza el acceso al disco
            int[] seceunciadeBusqueda = new int[pedido.Length + 1];

            for (int i = 0; i < pedido.Length; i++)
            {

                seceunciadeBusqueda[i] = cabeza;
                CalcularDist(pedido, cabeza, diferencia);

                int index = encontrar_minimo(diferencia);

                diferencia[index].acceso = true;

                //Aumenta el contador de busqueda
                ContadorBusqueda += diferencia[index].distancia;

                // La pista a la que se accede ahora es la nueva cabeza
                cabeza = pedido[index];
            }

            seceunciadeBusqueda[seceunciadeBusqueda.Length - 1] = cabeza;

            return seceunciadeBusqueda;
        }

        public void MetodoBurbuja(int[] arreglo)
        {
            int t;
            for (int a = 1; a < arreglo.Length; a++)
                for (int b = arreglo.Length - 1; b >= a; b--)
                {
                    if (arreglo[b - 1] > arreglo[b])
                    {
                        t = arreglo[b - 1];
                        arreglo[b - 1] = arreglo[b];
                        arreglo[b] = t;
                    }
                }
        }
    }
}
