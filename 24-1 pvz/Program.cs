using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _24_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\darius.vainilavicius\Documents\Visual Studio 2015\Projects\CS_kursai\24-1 pvz\Database1.mdf; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlComand = new SqlCommand();
            sqlComand.Connection = sqlConnection;

            /*     for (int i = 0; i < 5; i++)
                 {




                     using (SqlCommand sqlComand = new SqlCommand("INSERT INTO students(Name, Surname) VALUES(@Name, @Surname)", sqlConnection))

                     {

                         sqlConnection.Open();
                         Console.WriteLine("Iveskite varda");
                         sqlComand.Parameters.AddWithValue("@Name", Console.ReadLine());
                         Console.WriteLine("Iveskite pavarde");
                         sqlComand.Parameters.AddWithValue("Surname", Console.ReadLine());


                         sqlComand.ExecuteNonQuery();
                         sqlConnection.Close();

                     }
                 }*/
            /*  //1.4
                        SqlCommand sqlComand = new SqlCommand("INSERT INTO student_address(student_id, street) VALUES('1', 'Kupiskis')", sqlConnection);
                        sqlComand.ExecuteNonQuery();

                        sqlComand.CommandText =  "INSERT INTO student_address(student_id, street) VALUES('2', 'Joniskis')";

                        sqlComand.ExecuteNonQuery();

                        sqlComand.CommandText = "INSERT INTO student_address(student_id, street) VALUES('2', 'Jonava')";
            */

            Random rng = new Random();

            /* //1.5

                        for (int i = 0; i < 6; i++)
                        {

                            sqlComand.CommandText = "INSERT INTO student_marks(student_id, title, mark) VALUES(@student_id,@title,@mark)";
                            sqlComand.Parameters.AddWithValue("student_id", i);
                            sqlComand.Parameters.AddWithValue("title", "Chemija");
                            sqlComand.Parameters.AddWithValue("mark", rng.Next(1, 11));
                            sqlComand.ExecuteNonQuery();
                            sqlComand.Parameters.Clear();

                        }
            */
          //  sqlComand.CommandText = "SELECT * FROM students ORDER BY Name";

            SqlDataReader reader = null;

            // reader = sqlComand.ExecuteReader();  1.6

            //  while (reader.Read())
            //  {
            //      Console.WriteLine(reader["Id"].ToString());
            //      Console.WriteLine(reader["Name"]);
            //     Console.WriteLine(reader["Surname"]);
            // }

            // reader.Close();


            /*1.7*/
            /*
                        sqlComand.CommandText = "SELECT * FROM students WHERE Name LIKE '%as' AND Surname LIKE '%as' ORDER BY Surname";
                        reader = sqlComand.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Id"].ToString());
                            Console.WriteLine(reader["Name"]);
                            Console.WriteLine(reader["Surname"]);
                        }
            */

            /*1.8*/
            /*
                        sqlComand.CommandText = "SELECT * FROM student_address WHERE City = 'Kaunas'";
                        reader = sqlComand.ExecuteReader();

                        while (reader.Read())
                        {                
                            Console.WriteLine(reader["student_id"]);
                            Console.WriteLine(reader["City"]);
                        }

                */

            /*1.14*/

            sqlComand.CommandText = "SELECT * FROM student_address INNER JOIN students on student_address.Id = students.Id WHERE City != 'NULL'";
            reader = sqlComand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["student_id"]);
                Console.WriteLine(reader["Name"]);
                Console.WriteLine(reader["City"]);
            }




            sqlConnection.Close();
        }
    }
}
