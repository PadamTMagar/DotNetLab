using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        public MySqlConnection conn;

        public void ConnectDatabase()
        {
            try
            { 
                conn = new MySqlConnection("SERVER=localhost;DATABASE=megadotnet;UID=root;PASSWORD=;");
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter student name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student roll?");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student course?");
                string course = Console.ReadLine();
                Console.WriteLine("Enter student phone?");
                int phone = int.Parse(Console.ReadLine());

                MySqlCommand cmd = new MySqlCommand("Insert into students (name, roll, course,phone) values(@name, @roll, @course,@phone)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@phone", phone);
                int num = cmd.ExecuteNonQuery();
                if (num == 1)
                {
                    Console.WriteLine("Student Added Successfully");
                }
                else
                {
                    Console.WriteLine("Student Addtion Failed");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConnectDatabase();
            p.AddStudent();
        }
    }
}

using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        public MySqlConnection conn;

        public void ConnectDatabase()
        {
            try
            {
                conn = new MySqlConnection("SERVER=localhost;DATABASE=megadotnet;UID=root;PASSWORD=;");
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter student name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student roll?");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student course?");
                string course = Console.ReadLine();
                Console.WriteLine("Enter student phone?");
                int phone = int.Parse(Console.ReadLine());

                MySqlCommand cmd = new MySqlCommand("Insert into students (name, roll, course,phone) values(@name, @roll, @course,@phone)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@phone", phone);
                int num = cmd.ExecuteNonQuery();
                if (num == 1)
                {
                    Console.WriteLine("Student Added Successfully");
                }
                else
                {
                    Console.WriteLine("Student Addtion Failed");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConnectDatabase();
            p.AddStudent();
        }
    }
}

using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        public MySqlConnection conn;

        public void ConnectDatabase()
        {
            try
            {
                conn = new MySqlConnection("SERVER=localhost;DATABASE=megadotnet;UID=root;PASSWORD=;");
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter student name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student roll?");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student course?");
                string course = Console.ReadLine();
                Console.WriteLine("Enter student phone?");
                int phone = int.Parse(Console.ReadLine());

                MySqlCommand cmd = new MySqlCommand("Insert into students (name, roll, course,phone) values(@name, @roll, @course,@phone)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@phone", phone);
                int num = cmd.ExecuteNonQuery();
                if (num == 1)
                {
                    Console.WriteLine("Student Added Successfully");
                }
                else
                {
                    Console.WriteLine("Student Addtion Failed");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConnectDatabase();
            p.AddStudent();
        }
    }
}

using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        public MySqlConnection conn;

        public void ConnectDatabase()
        {
            try
            {
                conn = new MySqlConnection("SERVER=localhost;DATABASE=megadotnet;UID=root;PASSWORD=;");
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddStudent()
        {
            try
            {
                Console.WriteLine("Enter student name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student roll?");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student course?");
                string course = Console.ReadLine();
                Console.WriteLine("Enter student phone?");
                int phone = int.Parse(Console.ReadLine());

                MySqlCommand cmd = new MySqlCommand("Insert into students (name, roll, course,phone) values(@name, @roll, @course,@phone)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@phone", phone);
                int num = cmd.ExecuteNonQuery();
                if (num == 1)
                {
                    Console.WriteLine("Student Added Successfully");
                }
                else
                {
                    Console.WriteLine("Student Addtion Failed");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConnectDatabase();
            p.AddStudent();
        }
    }
}
