using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoScan
{
    internal class Algoritmo_Scan
    {

        private int tamanio;
        private int tamanio_disco;
        private int numero_operaciones;
        int[] arreglo_numeros;

        public Algoritmo_Scan(int[] arreglo_numero) {
            this.Arreglo_numeros = arreglo_numero;
            Tamanio = arreglo_numero.Length;
            Numero_operaciones = 0;
            this.Ordenar_arreglo(0,arreglo_numero.Length-1);
            Tamanio_disco = arreglo_numero[arreglo_numero.Length-1]+1;
        }
       
        public int Tamanio { get => tamanio; set => tamanio = value; }
        public int Tamanio_disco { get => tamanio_disco; set => tamanio_disco = value; }
        public int Numero_operaciones { get => numero_operaciones; set => numero_operaciones = value; }
        public int[] Arreglo_numeros { get => arreglo_numeros; set => arreglo_numeros = value; }

        public void Ordenar_arreglo(int i, int j) {

            int inicio = i;
            int fin = j;
            int pivote = this.Arreglo_numeros[i];

            do
            {

                while (Arreglo_numeros[i] < pivote)
                {
                    i++;
                }

                while (Arreglo_numeros[j] > pivote)
                {
                    j--;
                }

                if (i <= j)
                {
                    int aux = Arreglo_numeros[i];
                    Arreglo_numeros[i] = Arreglo_numeros[j];
                    Arreglo_numeros[j] = aux;
                    i++;
                    j--;
                }

            } while (i <= j);
            if (inicio < j)
            {
                Ordenar_arreglo(inicio, j);
            }
            if (i < fin)
            {
                Ordenar_arreglo(i, fin);
            }


        }

        public List<int> SCAN(int[] arreglo, int @base, String direccion)
        {
            int contador_busqueda = 0;
            int distancia, pista_carrera;
            List<int> izquierda = new List<int>(),
                            derecha = new List<int>();
            List<int> secuencia_busqueda = new List<int>();

            if (direccion == "izquierda")
                izquierda.Add(0);
            else if (direccion == "derecha")
                derecha.Add(Tamanio_disco - 1);

            for (int i = 0; i < Tamanio; i++)
            {
                if (arreglo[i] < @base)
                    izquierda.Add(arreglo[i]);
                if (arreglo[i] > @base)
                    derecha.Add(arreglo[i]);
            }
            izquierda.Sort();
            derecha.Sort();

            int recorrido = 2;
            while (recorrido-- > 0)
            {
                if (direccion == "izquierda")
                {
                    for (int i = izquierda.Count - 1; i >= 0; i--)
                    {
                        pista_carrera = izquierda[i];

                        secuencia_busqueda.Add(pista_carrera);

                        distancia = Math.Abs(pista_carrera - @base);

                        contador_busqueda += distancia;
                        @base = pista_carrera;
                    }
                    direccion = "derecha";
                }
                else if (direccion == "derecha")
                {
                    for (int i = 0; i < derecha.Count; i++)
                    {
                        pista_carrera = derecha[i];

                        secuencia_busqueda.Add(pista_carrera);

                        distancia = Math.Abs(pista_carrera - @base);

                        contador_busqueda += distancia;

                        @base = pista_carrera;
                    }
                    direccion = "izquierda";
                }
            }

            Numero_operaciones = secuencia_busqueda.Count;
            return secuencia_busqueda;
        }


    }
}
