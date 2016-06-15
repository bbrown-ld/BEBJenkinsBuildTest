using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JenkinsBuildTestLib;
using NUnit.Framework;
namespace JenkinsBuildTestLib.Tests
{
    [TestFixture()]
    public class StringExtTests
    {
        [Test()]
        public void IsValidEmailAddressTest_ValidEmailAddressSupplied_IsValidEmail()
        {

            var s = "bbrown@livingdirect.com";

            var actual = s.IsValidEmailAddress();

            Assert.IsTrue(actual);
        }


        [Test()]
        public void IsValidEmailAddressTest_InValidEmailAddressSupplied_IsNotValidEmail()
        {

            var s = "bbrown127";

            var actual = s.IsValidEmailAddress();

            Assert.IsFalse(actual);
        }


    }
}
