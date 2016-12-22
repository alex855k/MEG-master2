using MEG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAltSolution
{
    public class DBConnectionLayer
    {
        string connectionString = "Data Source=ealdb1.eal.Local;" + "Initial Catalog=EJL81_DB;" + "User id=ejl81_usr;" + "Password=Baz1nga81;";
        //string connectionString = "server=ealdb1.eal.Local;user=ejl_81_usr;database=EAL81_DB,password=Baz1nga81;database=EJL81_DB";

        string fetchTeachersQuery = "SELECT * FROM Teacher";

        string fetchStudentsQuery = "SELECT * FROM Students";

        SqlDataAdapter adapter;

        public DBConnectionLayer() {
                
        }

        public void SaveStudent(Student s) {
            
        }

        public void SaveTeacher(Teacher t)
        {

        }

        public void SaveStudentClassRoomAssociation() {

        }



        public List<Teacher> FetchTeachers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(fetchTeachersQuery, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataTable table in ds.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            Console.WriteLine("___TEACHER ROW" + dr.ItemArray.GetValue(1).ToString() + "___");
                            Console.WriteLine(dr.ItemArray.GetValue(1).ToString());
                            Console.WriteLine(dr.ItemArray.GetValue(2).ToString());
                            Console.WriteLine(dr.ItemArray.GetValue(3).ToString());
                            Console.WriteLine(dr.ItemArray.GetValue(4).ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public List<Student> FetchStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(fetchTeachersQuery, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    foreach (DataTable table in ds.Tables)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            Console.WriteLine("___TEACHER ROW" + dr.ItemArray.GetValue(1).ToString() + "___");
                            Console.WriteLine(dr.ItemArray.GetValue(1).ToString());
                            Console.WriteLine(dr.ItemArray.GetValue(2).ToString());
                            Console.WriteLine(dr.ItemArray.GetValue(3).ToString());
                            Console.WriteLine(dr.ItemArray.GetValue(4).ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }



    }
}
