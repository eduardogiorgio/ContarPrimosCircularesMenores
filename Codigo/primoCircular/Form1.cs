using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace primoCircular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // This is the delegate that runs on the UI thread to update the bar.
        
        delegate void RefreshProgressDelegate(decimal percent);
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            string valor = limitNumber.GetItemText(limitNumber.SelectedItem);
            int limiteSearch=0;
            bool canConvert = int.TryParse(valor, out limiteSearch);

            // hasta el millon
            if (canConvert && limiteSearch<1000001)
            {
            int text;


            // mientras este calculando
            totalPrimosCirculares.Text = ".....calculando ....";
            buscar.Text = "Cancelar";
           
            // Create the thread object. This does not start the thread.
            classPrimoCircular workerObject = new classPrimoCircular();
            workerObject.setLimitSearch(limiteSearch);
            Thread workerThread = new Thread(workerObject.comenzar);

            // Start the worker thread.
            workerThread.Start();
            Console.WriteLine("main thread: Starting worker thread...");

            // Loop until worker thread activates.
            while (!workerThread.IsAlive) ;
                
            // Put the main thread to sleep for 1 millisecond to
            // allow the worker thread to do some work:
            Thread.Sleep(1);

            
           
            // Request that the worker thread stop itself:
          //  workerObject.RequestStop();

            // Use the Join method to block the current thread 
            // until the object's thread terminates.

          

            workerThread.Join();
            
            // verificacion porque funciona muy rapido
            //System.Threading.Thread.Sleep(5000);
            
            text = workerObject.getShow();
            Console.WriteLine("main thread: Worker thread has terminated." + text);
            totalPrimosCirculares.Text = text.ToString();

            // mientras este calculando
            
            buscar.Text = "Buscar";
            }
            else
            {
                totalPrimosCirculares.Text = "..dato no valido..";
            }
            
        }

        private void totalPrimosCirculares_Click(object sender, EventArgs e)
        {

        }

        public void setTotalPrimosCirculares(int total)
        {
            string texto =  total.ToString();
            totalPrimosCirculares.Text = texto;
            totalPrimosCirculares.Text = "aaa";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

  
    }
}
