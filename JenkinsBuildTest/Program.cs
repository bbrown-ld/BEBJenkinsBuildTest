using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JenkinsBuildTestLib;

namespace JenkinsBuildTest
{
    class Program
    {
        /// <summary>Main entry-point for this application.</summary>
        ///
        /// <remarks>BBrown, 6/15/2016.</remarks>
        ///
        /// <param name="args">Array of command-line argument strings.</param>

        static void Main(string[] args)
        {

            var s1 = "bbrown127@gmail.com";
            var s2 = "bbrown123";
            
            Console.WriteLine("{0} is a valid email: {1}", s1, s1.IsValidEmailAddress());
            Console.WriteLine("{0} is a valid email: {1}", s2, s2.IsValidEmailAddress());

            //Add Comment 1
        }
    }
}
