﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RainbowSchoolModels
{
    public class StudentCRUD
    {
        static SqlConnection con = DatabaseConnection.GetConnection();

        public static int GetAllStudent()
        {
            try
            {
                SqlCommand get = new SqlCommand("select * from [Student]",con);
                con.Open();
                SqlDataReader sdr = get.ExecuteReader();
                int count = 0;
                while(sdr.Read())
                {
                    count++;
                }
                return count;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }
        public static bool AddStudent(StudentDTO obj)
        {
            
            if(con!=null)
            {
                Console.WriteLine(con);
            }
            try
            {
                SqlCommand insert = new SqlCommand("insert into [Student] (studId,studName,studBranch,studClass)values(@studId,@studName,@studBranch,@studClass)", con);
                insert.Parameters.AddWithValue("@studId",obj.StudId);
                insert.Parameters.AddWithValue("@studName", obj.StudName);
                insert.Parameters.AddWithValue("@studBranch", obj.StudBranch);
                insert.Parameters.AddWithValue("@studClass", obj.StudClass);
                con.Open();
                int res = insert.ExecuteNonQuery();
                if(res>0)
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
               // Console.WriteLine(ex.StackTrace);
                con.Close();
                return false;
            }
        }
        public static bool DeleteStudent(int id)
        {
            try
            {
                SqlCommand delete = new SqlCommand("delete from [Student] where studId = @studId", con);
                delete.Parameters.AddWithValue("@studId", id);
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
