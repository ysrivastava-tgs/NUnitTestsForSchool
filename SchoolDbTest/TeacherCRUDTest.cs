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
        [Test]
        [TestCase("tbshfg676qe", ExpectedResult = true)]
        public bool SubjectDel_Test(string id)
        {

            bool flag = TeacherCRUD.DeleteTeacher(id);
            return flag;
        }
        [Test]
        public void GetAllTeacher_Test()
        {
            int count = TeacherCRUD.GetAllTeacher();
            Assert.AreEqual(1, count);
        }
        [Test]
        public void GetTeacherById_Test()
        {
            TeacherDTO obj = TeacherCRUD.GetTeacherById("tbshfg676qe");
            Assert.IsNotNull(obj);
        }
    }
}
