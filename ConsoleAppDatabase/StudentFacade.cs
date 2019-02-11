using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ConsoleAppDatabase
{
    public class StudentFacade
    {
        private static string conn =
            "Server=tcp:lasses3sem.database.windows.net,1433;Initial Catalog=student;Persist Security Info=False;User ID=L4SS3__;Password=Qwerty123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public static List<Student> GetAllStudents()
        {
        string sql = "SELECT * FROM Student";
        var result = new List<Student>();
            using (SqlConnection dbConn = new SqlConnection(conn))
            {
                dbConn.Open();
                using (SqlCommand selectCommand = new SqlCommand(sql, dbConn))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string hold = reader.GetString(2);
                            int mobilnr = reader.GetInt32(3);

                            var Student = new Student()
                            {
                                StudentId = id,
                                Navn = name,
                                MobilNr = mobilnr,
                                Hold = hold
                            };

                            result.Add(Student);
                        }
                    }
                }

                return result;
            }
        }



    }

}