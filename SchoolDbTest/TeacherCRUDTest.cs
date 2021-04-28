using NUnit.Framework;
using RainbowSchoolModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDbTest
{
    class TeacherCRUDTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StudentAdd_Test()
        {
            TeacherDTO teach= new TeacherDTO();
            teach.TeacherId = "tbshfg676qe";
            teach.TeacherName = "Mr Robot";
            teach.TeacherBranch = "IT";
            bool flag = TeacherCRUD.AddTeacher(teach);
            Assert.AreEqual(true, flag);
        }
    }
}
