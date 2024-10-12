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

            thread_label.Text = "    END OF THE THREAD";
            System.Diagnostics.Debug.WriteLine("-Before starting thread-");

            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread1));

            threadA.Name = "ThreadA";
            threadB.Name = "ThreadB";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            System.Diagnostics.Debug.WriteLine("END OF THE THREAD");
            thread_label.Text = "-End of thread-";
        }
    }
    }
