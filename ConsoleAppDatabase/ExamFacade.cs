using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace ConsoleAppDatabase
{
    public class ExamFacade
    {
        private static string conn =
            "Server=tcp:lasses3sem.database.windows.net,1433;Initial Catalog=student;Persist Security Info=False;User ID=L4SS3__;Password=Qwerty123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static Exam GetOneStudents(int examid)
        {
            string sql = "SELECT Exam.ExamId, Exam.ExamNavn, Exam.Karakter, Exam.StudentId " +
                         "FROM Exam WHERE Exam.ExamId = @examid";
            var result = new Exam();
            using (SqlConnection dbConn = new SqlConnection(conn))
            {
                dbConn.Open();
                using (SqlCommand selectCommand = new SqlCommand(sql, dbConn))
                {
                    selectCommand.Parameters.AddWithValue("@examid", examid);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int examId = reader.GetInt32(0);
                            string examname = reader.GetString(1);
                            int karakter = reader.GetInt32(2);
                            int studentid = reader.GetInt32(3);

                            var Exam = new Exam()
                            {
                                ExamId = examId,
                                ExamNavn = examname,
                                Karakter = karakter,
                                StudentId = studentid
                            };
                            return Exam;
                        }
                    }
                }

                return result;
            }
        }
        public static Exam DeleteOneExam(int examid)
        {
            string sql = "DELETE FROM Exam WHERE Exam.ExamId = @examid";


            var result = new Exam();
            using (SqlConnection dbConn = new SqlConnection(conn))
            {
                dbConn.Open();
                using (SqlCommand selectCommand = new SqlCommand(sql, dbConn))
                {
                    selectCommand.Parameters.AddWithValue("@examid", examid);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int examId = reader.GetInt32(0);
                            string examname = reader.GetString(1);
                            int karakter = reader.GetInt32(2);
                            int studentid = reader.GetInt32(3);

                            var Exam = new Exam()
                            {
                                ExamId = examId,
                                ExamNavn = examname,
                                Karakter = karakter,
                                StudentId = studentid
                            };
                            return Exam;
                        }
                    }
                }

                return result;
            }
        }
    }
}