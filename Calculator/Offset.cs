using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    public class Offset
    {
        public virtual int Get()
        {
            // call db
            // call api
            throw new Exception("this is for test");
            // return 100;
        }
        public virtual string Concatinating()
        {
            return "World";
        }
    }
}
