using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPractice1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Int64 result = 680131659347;

            String text = "leepadg";

            Assert.AreEqual(result, Program.Hash(text));



            /*
             * 
            function Hash( s : string) : int64
            begin
            h : int64;
            letters : string;
            i : int;
            index : int;
            inc : int; 

            h = 7;
                letters = “acdegilmnoprstuw”;

            for ( i from 0 to length(s) )
            begin
            inc = h * 37;
            index = indexOf s[i] in letters;
            h = inc + index;
            end

            return h;
            end
                         */

        }
    }
}
