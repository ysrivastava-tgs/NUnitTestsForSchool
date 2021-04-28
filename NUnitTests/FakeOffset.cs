using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    class FakeOffset : Offset
    {
        public override int Get()
        {
            return 100;
        }
        public override string Concatinating()
        {
            return "World";
        }
    }
}
