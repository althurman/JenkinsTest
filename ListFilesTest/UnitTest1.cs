using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace ListFilesTest
{
    [TestClass]
    public class UnitTest1
    {

        [Fact]
        public void Successfultest()
        {
            int x = 1;
            Assert.False(3 == x);
        }
    }
}
