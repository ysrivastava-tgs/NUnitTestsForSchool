using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RainbowSchoolModels
{
    public class SubjectCRUD
    {
        static SqlConnection con = DatabaseConnection.GetConnection();
        public static bool AddSubject(SubjectDTO obj)
        {
            
            try
            {
                SqlCommand insert = new SqlCommand($"insert into [Subject] values(@subjId,@subjName)", con);
                insert.Parameters.AddWithValue("@subjId", obj.SubjId);
                insert.Parameters.AddWithValue("@subjName", obj.SubjName);
               
                con.Open();
                int res = insert.ExecuteNonQuery();
                if (res == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DeleteSubject(string id)
        {
            try
            {
                SqlCommand delete = new SqlCommand("delete from [Subject] where subjId = @subjId", con);
                delete.Parameters.AddWithValue("@subjId", id);
                con.Open();
                int res = delete.ExecuteNonQuery();
                if (res > 0)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Console.WriteLine(ex.StackTrace);
                con.Close();
                return false;
            }
        }
    }
}
