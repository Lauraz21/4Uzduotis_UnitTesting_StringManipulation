
using _4Uzduotis_UnitTesting_StringManipulation;

namespace Test4Uzduotis_StringManipulation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string userText = "Laura graziai dainuoja";

            string expected = "Luouruo gruozeuoe duoenuojuo";

            string actual = Program.ReplacingText(userText);

            Assert.AreEqual(expected, actual);
        }
    }
}