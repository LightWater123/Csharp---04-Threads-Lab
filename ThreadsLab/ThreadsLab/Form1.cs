using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace ThreadsLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("- Before starting thread -");
        }

        public class MyThreadClass
        {
            // static method thread1
            public static void Thread1()
            {
                // loop that terminates the thread in the 5th attempt

                for (int loopCount = 0; loopCount <= 5; loopCount++)
                {
                    Thread thread = Thread.CurrentThread;
                    Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                    Thread.Sleep(1500);
                }
            }
        }
        
 

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ThreadA
            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A Process";

            // ThreadB
            Thread threadB = new Thread(MyThreadClass.Thread1);
            threadB.Name = "Thread B Process";

            // start
            threadA.Start();
            threadB.Start();


            // join
            threadA.Join();
            threadB.Join();

            Console.WriteLine("- End of Thread -");
            label1.Text = "- End of Thread -";
        }
    }
}
