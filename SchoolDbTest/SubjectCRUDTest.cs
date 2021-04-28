﻿using NUnit.Framework;
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
        public void SubjectAdd_Test()
        {
            SubjectDTO subj = new SubjectDTO();
            subj.SubjId = "OOPS_001";
            subj.SubjName = "OOPS";
            bool flag = SubjectCRUD.AddSubject(subj);
            Assert.AreEqual(true, flag);
        }
        [Test]
        [TestCase("OOPS_001", ExpectedResult = true)]
        public bool SubjectDel_Test(string id)
        {

            bool flag = SubjectCRUD.DeleteSubject(id);
            return flag;
        }
    }
}
