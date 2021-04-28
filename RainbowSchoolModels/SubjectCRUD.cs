using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RainbowSchoolModels
{
    public class SubjectCRUD
    {
        static SqlConnection con = DatabaseConnection.GetConnection();
        public static int GetAllSubject()
        {
            try
            {
                SqlCommand get = new SqlCommand("select * from [Subject]", con);
                con.Open();
                SqlDataReader sdr = get.ExecuteReader();
                int count = 0;
                while (sdr.Read())
                {
                    count++;
                }
                return count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static SubjectDTO GetSubjectById(string id)
        {
            try
            {
                SqlCommand get = new SqlCommand("select * from [Subject] where subjId = @subjId", con);
                get.Parameters.AddWithValue("@subjId", id);
                con.Open();
                SqlDataReader r = get.ExecuteReader();
                SubjectDTO obj = null;
                while (r.Read())
                {
                    obj = new SubjectDTO();
                    obj.SubjId = r["subjId"].ToString();
                    obj.SubjName = r["subjName"].ToString();
                   
                }
                return obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static bool AddSubject(SubjectDTO obj)
        {
            
            try
            {
                SqlCommand insert = new SqlCommand("insert into [Subject] values(@subjId,@subjName)", con);
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
