using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp_CSharp
{
    public partial class Form1 : Form
    {
        //created a generic list of objects
        private List<Student> list_student = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        //created the event for the Add button
        private void btn_Add_Click(object sender, EventArgs e)
        {
            byte[] n_vector = new byte[5];

            try 
            {
                n_vector[0] = Convert.ToByte(cmb_Note1.Text);
                n_vector[1] = Convert.ToByte(cmb_Note2.Text);
                n_vector[2] = Convert.ToByte(cmb_Note3.Text);
                n_vector[3] = Convert.ToByte(cmb_Note4.Text);
                n_vector[4] = Convert.ToByte(cmb_Note5.Text);

                //created the object
                Student object_s = new Student(Convert.ToByte(cmb_Year.Text), n_vector, 
                    txt_Name.Text,Convert.ToByte(numericUpDown_Age.Value));

                //added the object_s to the generic list
                list_student.Add(object_s);

                listDisplay();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listDisplay()
        {
            lstStudents.Items.Clear();
            foreach (Student obj_s in list_student)
                lstStudents.Items.Add(obj_s.studentDisplay());
        }
    }
}
