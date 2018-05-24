using Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestset
{
    [TestClass]
    public class BaseTestset
    {
        protected static readonly string inMask = @"(input)(\d+)(.txt)";
        protected static readonly string outMask = @"(output)(\d+)(.txt)";
        protected virtual IPlatformLogger Logger { get; set; }
    }
}
