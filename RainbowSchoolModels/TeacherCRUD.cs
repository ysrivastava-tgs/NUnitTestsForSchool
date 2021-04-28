﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RainbowSchoolModels
{
    public class TeacherCRUD
    {
        static SqlConnection con = DatabaseConnection.GetConnection();
        public static bool AddTeacher(TeacherDTO obj)
        {
            
            try
            {
                SqlCommand insert = new SqlCommand($"insert into [Teacher] values(@teacherId,@teacherName,@teacherBranch)", con);
                insert.Parameters.AddWithValue("@teacherId", obj.TeacherId);
                insert.Parameters.AddWithValue("@teacherName", obj.TeacherName);
                insert.Parameters.AddWithValue("@teacherBranch", obj.TeacherBranch);
                
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
