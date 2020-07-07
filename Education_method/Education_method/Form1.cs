using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_method
{
    public partial class Form1 : Form
    {
        private string connectionString;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            SqlCommand command = new SqlCommand();
            command.CommandText = "(SELECT *from Subject  WHERE Name_Subject LIKE + '" + textBox12.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView5.DataSource = ds.Tables[0];

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department  where ID_Teacher=2 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department  where ID_Teacher=7 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department  where ID_Teacher=4 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department  where ID_Teacher=5 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department  where ID_Teacher=6 ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department  where ID_Teacher=3";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            SqlCommand command = new SqlCommand();
            command.CommandText = "(SELECT Training_load.Number_Group, Teachers_of_the_Department.Surname,Teachers_of_the_Department.FirstName, Subject.Name_Subject,Training_load.Beginning_of_the_course,Training_load.End_of_course FROM Training_load JOIN Teachers_of_the_Department ON Teachers_of_the_Department.ID_Teacher = Training_load.ID_Teacher JOIN Subject ON Subject.ID_Subject = Training_load.ID_Subject WHERE Number_Group LIKE + '" + textBox13.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView4.DataSource = ds.Tables[0];

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            SqlCommand command = new SqlCommand();
            command.CommandText = "(SELECT Archive.Year_now,Archive.Half,Training_load.Number_Group, Teachers_of_the_Department.Surname,Teachers_of_the_Department.FirstName, Subject.Name_Subject FROM Training_load JOIN Teachers_of_the_Department ON Teachers_of_the_Department.ID_Teacher = Training_load.ID_Teacher JOIN Subject ON Subject.ID_Subject = Training_load.ID_Subject JOIN Archive ON Archive.ID = Training_load.ID WHERE Year_now LIKE + '" + textBox14.Text + "')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string Surname = textBox1.Text;
            string FirstName = textBox2.Text;
            string Gender = textBox3.Text;

            int Age = Convert.ToInt32(textBox4.Text);
            string Scientific_degree = textBox5.Text;
            string Post = textBox6.Text;
            int Work_experience = Convert.ToInt32(textBox7.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandText = "insert into Teachers_of_the_Department (Surname, FirstName, Gender,Age,Scientific_degree,Post,Work_experience) values (@Surname,@FirstName,@Gender,@Age,@Scientific_degree,@Post,@Work_experience)";
                

                command.Parameters.Add("@Surname", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@Gender", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@Age", SqlDbType.Int);
                command.Parameters.Add("@Scientific_degree", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@Post", SqlDbType.NVarChar, 20);
                command.Parameters.Add("@Work_experience", SqlDbType.Int);
                // передаем данные в команду через параметры
                

                command.Parameters["@Surname"].Value = Surname;
                command.Parameters["@FirstName"].Value = FirstName;
                command.Parameters["@Gender"].Value = Gender;
                command.Parameters["@Age"].Value = Age;
                command.Parameters["@Scientific_degree"].Value = Scientific_degree;
                command.Parameters["@Post"].Value = Post;
                command.Parameters["@Work_experience"].Value = Work_experience;
                command.ExecuteNonQuery();
                MessageBox.Show("Данні додано!");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string Name_Subject = textBox8.Text;
            int Number_of_hours = Convert.ToInt32(textBox9.Text);
            int Laboratory = Convert.ToInt32(textBox10.Text);
            int Lecture = Convert.ToInt32(textBox11.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandText = "insert into Subject (Name_Subject,Number_of_hours,Laboratory,Lecture) values (@Name_Subject,@Number_of_hours,@Laboratory,@Lecture)";


                command.Parameters.Add("@Name_Subject", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@Number_of_hours", SqlDbType.Int);
                command.Parameters.Add("@Laboratory", SqlDbType.Int);
                command.Parameters.Add("@Lecture", SqlDbType.Int);

                // передаем данные в команду через параметры


                command.Parameters["@Name_Subject"].Value = Name_Subject;
                command.Parameters["@Number_of_hours"].Value = Number_of_hours;
                command.Parameters["@Laboratory"].Value = Laboratory;
                command.Parameters["@Lecture"].Value = Lecture;
                command.ExecuteNonQuery();
                MessageBox.Show("Данні додано!");

                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Subject";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Education;Integrated Security=True";
            string sql = "SELECT* FROM Teachers_of_the_Department";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
    }

