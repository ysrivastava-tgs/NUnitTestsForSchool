using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    class AddTestData
    {
        public static List<TestCaseData> Get()
        {
            var list = new List<TestCaseData>();
            list.Add(new TestCaseData(10, 20).Returns(30));
            list.Add(new TestCaseData(100, 200).Returns(300));
            list.Add(new TestCaseData(1000, 2000).Returns(3000));
            list.Add(new TestCaseData(50, 10).Returns(60));
            return list;
        }
    }
}
