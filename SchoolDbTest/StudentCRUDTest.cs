using NUnit.Framework;
using RainbowSchoolModels;

namespace SchoolDbTest
{
    public class StudentCRUDTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StudentAdd_Test()
        {
            StudentDTO stud = new StudentDTO();
            stud.StudId = 101;
            stud.StudName = "Yash";
            stud.StudBranch = "CSE";
            stud.StudClass = "VIII-Sem-A";
            bool flag = StudentCRUD.AddStudent(stud);
            Assert.AreEqual(true, flag);
        }
        [Test]
        [TestCase(101, ExpectedResult = true)]
        public bool StudentDel_Test(int id)
        {
            
            bool flag = StudentCRUD.DeleteStudent(id);
            return flag;
        }
    }
}