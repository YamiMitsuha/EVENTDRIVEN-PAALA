using FraBasicThread;

namespace FrmBasicThread
{
    // Paala, James P.
    // BSIT - 501
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread_label.Text = "        END OF TRHREAD";
            System.Diagnostics.Debug.WriteLine("-Before starting thread-");

            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread1));

            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread2));
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));


            threadA.Name = "ThreadA";
            threadB.Name = "ThreadB";
            threadC.Name = "ThreadC";
            threadD.Name = "ThreadD";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            // Paala, James P.
            // BSIT - 501

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();


            System.Diagnostics.Debug.WriteLine("-End of thread-");
            thread_label.Text = "-End of thread-";
        }
    }
    }
