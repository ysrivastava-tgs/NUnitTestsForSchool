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
    }
}
