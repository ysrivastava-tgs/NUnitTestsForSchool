using NUnit.Framework;
using RainbowSchoolModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDbTest
{
    class SubjectCRUDTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StudentAdd_Test()
        {
            SubjectDTO subj = new SubjectDTO();
            subj.SubjId = "OOPS_001";
            subj.SubjName = "OOPS";
            bool flag = SubjectCRUD.AddSubject(subj);
            Assert.AreEqual(true, flag);
        }
    }
}
