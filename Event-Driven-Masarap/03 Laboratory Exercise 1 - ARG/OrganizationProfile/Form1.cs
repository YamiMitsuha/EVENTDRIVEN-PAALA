using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

// Paala, James P.
// BSIT - 501

namespace OrganizationProfile
{
    public partial class Form1 : Form
    {
        private string _FullName;
        private int _Age;
        long _ContactNo, _StudentNo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
             "BS Information Technology",
             "BS Computer Science",
             "BS Information Systems",
             "BS in Accountancy",
             "BS in Hospitality Management",
             "BS in Tourism Management"
             };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

        }

        // Paala, James P.
        // BSIT - 501

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text,
                txtFirstName.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = (int) ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyyMM-dd");
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch(OverflowException oe)
            {
                MessageBox.Show(oe.Message);
            }
            catch(IndexOutOfRangeException iore)
            {
                MessageBox.Show(iore.Message);
            }
            finally
            {
                MessageBox.Show("Yehey");
            }
        }

        // Paala, James P.
        // BSIT - 501

        /////return methods 
        public long StudentNumber(string studNum)
        {
            try
            {
                _StudentNo = long.Parse(studNum);
            }
            catch (FormatException e)
            {
                MessageBox.Show("May irror");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            try
            {
                if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
                {
                    _ContactNo = long.Parse(Contact);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch(FormatException e)
            {
                MessageBox.Show("May irror");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        // Paala, James P.
        // BSIT - 501
        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }
    }
}
