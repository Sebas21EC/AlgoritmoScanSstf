using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_SCAN.Enabled = false;
            btn_sstf.Enabled = false;
            chrt.Series[0].Points.Clear();
            chrt.Series[1].Points.Clear();
            chrt.Series[2].Points.Clear();
            chrt.Series[3].Points.Clear();
            chrt.Series[4].Points.Clear();
            chrt.Series[5].Points.Clear();
            chrt.Series[6].Points.Clear();
            chrt.Series[7].Points.Clear();
        }
        Algoritmo_Scan objeto_scan;
        SSTF objeto_sstf;


      private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(); 
            btn_SCAN.Enabled=true;
            btn_sstf.Enabled=true;  
            txt_recorrido_SCAN.Text = "";
            txt_recorrido_SSTF.Text = "";
            chrt.Series[4].Points.Clear();
            chrt.Series[5].Points.Clear();
            chrt.Series[6].Points.Clear();
            chrt.Series[7].Points.Clear();


            int tamanio = 20;
            //int tamanio = 8;
            //int[] numeros = {37,14,65,122,124,183,98,67 };

            int[] numeros = new int[tamanio];
            String cadena_arreglo = "[ ";
           for (int i = 0; i < numeros.Length; i++) { 
                numeros[i] = random.Next(1,99);
                cadena_arreglo += numeros[i] + "  ";
            }
            cadena_arreglo += "]";


            txt_arreglo.Text = cadena_arreglo;
            //chrt_scan.Series[0].Points.Clear();
            chrt.Series[0].Points.DataBindY(numeros);
            chrt.Series[1].Points.DataBindY(numeros);
            objeto_scan = new Algoritmo_Scan(numeros);
            objeto_sstf = new SSTF(numeros);
            int[] arreglo_ordenado = objeto_scan.Arreglo_numeros;
            String cadena_arreglo_ordenado = "[ ";
            for (int i = 0; i < arreglo_ordenado.Length; i++)
            {
                cadena_arreglo_ordenado+=arreglo_ordenado[i]+ "  ";
            }

            cadena_arreglo_ordenado += "]";
            txt_arreglo_ordenado.Text = cadena_arreglo_ordenado;

            //chrt.Series[2].Points.DataBindY(arreglo_ordenado);
           // chrt.Series[3].Points.DataBindY(arreglo_ordenado);
           
           



        }

        private void button2_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(txt_numero_base.Text);
            bool existe = false;
            for (int i = 0; i < objeto_scan.Arreglo_numeros.Length; i++)
            {
                if (num == objeto_scan.Arreglo_numeros[i])
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
               List<int> lista_sstf = objeto_scan.SCAN(objeto_scan.Arreglo_numeros, num,"izquierda");
                chrt.Series[4].Points.DataBindY(lista_sstf);
                chrt.Series[5].Points.DataBindY(lista_sstf);
                txt_operaciones_scan.Text = ""+ objeto_scan.Numero_operaciones;
                string cadena_recorrido_scan = txt_numero_base.Text +" ";
                for (int i = 0; i < lista_sstf.Count; i++)
                {
                    cadena_recorrido_scan += lista_sstf[i]+"  ";
                }
                txt_recorrido_SCAN.Text = cadena_recorrido_scan;
            }
            else
            {
                MessageBox.Show("El número " + num + " ya está en el arreglo");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(txt_numero_base.Text);
            bool existe = false;
            for (int i = 0; i < objeto_sstf.Arreglo.Length; i++)
            {
                if (num == objeto_sstf.Arreglo[i])
                {
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                int[] lista_sstf = objeto_sstf.AlSSTF(objeto_sstf.Arreglo, num);
                chrt.Series[6].Points.DataBindY(lista_sstf);
                chrt.Series[7].Points.DataBindY(lista_sstf);
                txt_operaciones_sstf.Text = "" + objeto_sstf.ContadorBusqueda;
                string cadena_recorrido_sstf = "";
                for (int i = 0; i < lista_sstf.Length; i++)
                {
                    cadena_recorrido_sstf += lista_sstf[i] + "  ";
                }
                txt_recorrido_SSTF.Text = cadena_recorrido_sstf;
            }
            else
            {
                MessageBox.Show("El número " + num + " ya está en el arreglo");
            }


        }
    }
}
