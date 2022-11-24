using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingTextFile
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string setFileName = txtStudentNo.Text;
            String studentNo = txtStudentNo.Text;
            String lname = txtLname.Text;
            String fname = txtFname.Text;
            string age = txtAge.Text;
            String mi = txtMI.Text;
            String contact = txtContactNo.Text;
            string program = cbProgram.Text;
            string gender = cbGender.Text;
            string dateBday = dtBday.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, setFileName)))
            {
                outputFile.WriteLine("Student No.:" + studentNo);
                outputFile.WriteLine("Full Name:" + lname + "," + fname + "," + mi + ".");
                outputFile.WriteLine("Program:" + program);
                outputFile.WriteLine("Gender:" + gender);
                outputFile.WriteLine("Age:"+age);
                outputFile.WriteLine("Birthday:" + dateBday);
                outputFile.WriteLine("Contact No."+contact);
                // Console.WriteLine(getInput);
            }

        }
    }
}
