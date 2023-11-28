namespace palindrom_test
{
    public class UnitTest1
    {
        [Test]
        public void TestEmptyStringIsPalindrome()
        {
            string input = "";
            Assert.True(PalindromeChecker.IsPalindrome(input));
        }
    }
}