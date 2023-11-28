namespace palindrom_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPalindrom()
        {
            string input = "ANNA";
            Assert.IsTrue(Palindrom.IsPalindrom(input));
        }

        [Test]
        public void TestNonPalindrom()
        {
            string input = "SCHOOL";
            Assert.IsTrue(Palindrom.IsPalindrom(input));
        }
    }
}