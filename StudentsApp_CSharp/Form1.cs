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
            //created the connection to a local database
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\S&B\Documents\Persoane.mdf; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();  
            string tabel_date = "select * from Persoana_Universitate";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tabel_date, connectionString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Persoana_Universitate");
            persoana_UniversitateDataGridView.DataSource = dataSet.Tables["Persoana_Universitate"].DefaultView;
            
            byte[] n_vector = new byte[5];

            try 
            {
                n_vector[0] = Convert.ToByte(cmb_Note1.Text);
                n_vector[1] = Convert.ToByte(cmb_Note2.Text);
                n_vector[2] = Convert.ToByte(cmb_Note3.Text);
                n_vector[3] = Convert.ToByte(cmb_Note4.Text);
                n_vector[4] = Convert.ToByte(cmb_Note5.Text);

                //created the object
                //updated the Student constructor
                Student object_s = new Student(Convert.ToByte(cmb_Year.Text), n_vector, txt_CNP.Text,
                    txt_Name.Text,Convert.ToByte(numericUpDown_Age.Value));

                //added the object_s to the generic list
                list_student.Add(object_s);

                //inserted the generic list into the local database for the Persoana_Universitate table
                string insertQuery_Person = "INSERT INTO Persoana_Universitate(CNP, Name, Age) VALUES(@txt_CNP, " +
                    "@txt_Name, @numericUpDown_Age)";
                
                //create an object of type SqlCommand to execute the SQL command on the Persoana_Universitate table
                SqlCommand cmd_Person = new SqlCommand(insertQuery_Person, conn);
                cmd_Person.Parameters.AddWithValue("@txt_CNP", object_s.CnpStudent);
                cmd_Person.Parameters.AddWithValue("@txt_Name", object_s.studentName);
                cmd_Person.Parameters.AddWithValue("@numericUpDown_Age", object_s.AgeStudent);

                //run the SQL command for the Persoana_Universitate table
                cmd_Person.ExecuteNonQuery();

                //inserted the generic list into the local database for the StudentUniversitate table
                string insertQuery_Student = "INSERT INTO StudentUniversitate(CNP, Year, Notes) " +
                    "VALUES(@txt_CNP, @cmb_Year, @cmb_AverageNotes)";

                //create an object of type SqlCommand to execute the SQL command on the StudentUniversitate table
                SqlCommand cmd_Student = new SqlCommand(insertQuery_Student, conn);
                cmd_Student.Parameters.AddWithValue("@txt_CNP", object_s.CnpStudent);
                cmd_Student.Parameters.AddWithValue("@cmb_Year", object_s.studyYear);
                cmd_Student.Parameters.AddWithValue("@cmb_AverageNotes", object_s.get_AverageNotes);

                //run the SQL command for the StudentUniversitate table
                cmd_Student.ExecuteNonQuery();
                
                listDisplay();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //close the database connection
            conn.Close();
        }

        //created the listDisplay function
        private void listDisplay()
        {
            lstStudents.Items.Clear();
            foreach (Student obj_s in list_student)
                lstStudents.Items.Add(obj_s.studentDisplay());
        }

        //created the event for the "Order by name" button
        private void btn_OrderByName_Click(object sender, EventArgs e)
        {
            //created the connection to the local database and see all the information ordered by name
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\S&B\Documents\Persoane.mdf; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            
            
            
            //created the object for name compatison
            CompareName compareName_obj = new CompareName();
            list_student.Sort(compareName_obj);
            listDisplay();
        }

        //created the event for the "Order by notes" button
        private void btn_OrderByNotes_Click(object sender, EventArgs e)
        {
            CompareAverage compareAverage_obj = new CompareAverage();
            list_student.Sort(compareAverage_obj);
            listDisplay();
        }

        //created the event for the "Display students of the year: " button
        private void btn_DisplayStudents_Click(object sender, EventArgs e)
        {
            try
            {
                int var_year = Convert.ToInt32(cmbYear.Text);
                lstStudents.Items.Clear();

                //search a student in the list
                foreach(Student s_obj in list_student)
                {
                    if (s_obj.studyYear == var_year)
                        lstStudents.Items.Add(s_obj.studentDisplay());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //created the event for the "Search name: " button
        private void btn_SearchName_Click(object sender, EventArgs e)
        {
            try
            {
                string var_name = txt_SearchName.Text;
                lstStudents.Items.Clear();

                //take a student from the list
                foreach (Student s_obj in list_student)
                {
                    //search for the name
                    if (s_obj.studentName == var_name)
                        lstStudents.Items.Add(s_obj.studentDisplay());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //created the event for the "Delete" button
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(lstStudents.SelectedIndex > -1)
            {
                list_student.RemoveAt(lstStudents.SelectedIndex);
                listDisplay();
            }
        }
        
    }
}
