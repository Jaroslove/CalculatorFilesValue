using Calculator.Model.Counter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    class CounerTest
    {
        private IParser parser;
        private Element element;

        [TestCase]
        public void CalculateFolders()
        {
            element = new ElementFolder(@"C:\Users\1\Desktop\testCount", new Parser());

            int actual = element.Count();

            Assert.AreEqual(countFolder, actual);
        }

        [TestCase]
        public void CalculateFile()
        {
            element = new ElementFolder(@"C:\Users\1\Desktop\testCount\az\qa\r", new Parser());

            int actual = element.Count();

            Assert.AreEqual(countFile, actual);
        }

        [TestCase]
        public void Parse()
        {
            parser = new Parser();

            var actual = parser.Parse(@"C:\Users\1\Desktop\testCount\1.txt");

            CollectionAssert.AreEqual(testListInt, actual);
        }

        [TestCase]
        public void ParseFromString()
        {
            parser = new Parser();

            var actual = parser.ParseFromString(testArrayString);

            CollectionAssert.AreEqual(testListInt, actual);
        }

        #region testing data        
        private string[] testArrayString = { " 2424", "232 ", " 34 ", "", " ", "efaf", " f 434", "43 34" };
        #endregion

        #region expection        
        private int countFolder = 4056;
        private int countFile = 1016;
        private List<int> testListInt = new List<int> { 2424, 232, 34};
        #endregion
    }
}
