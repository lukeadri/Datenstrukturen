using System;
using Xunit;

public class PalindromeTests
{
    [Fact]
    public void TestEmptyStringIsPalindrome()
    {
        string input = "";
        Assert.True(PalindromeChecker.IsPalindrome(input));
    }

    [Fact]
    public void TestSingleCharacterIsPalindrome()
    {
        string input = "a";
        Assert.True(PalindromeChecker.IsPalindrome(input));
    }

    [Fact]
    public void TestPalindrome()
    {
        string input = "ANNA";
        Assert.True(PalindromeChecker.IsPalindrome(input));
    }

    [Fact]
    public void TestNonPalindrome()
    {
        string input = "HELLO";
        Assert.False(PalindromeChecker.IsPalindrome(input));
    }

    [Fact]
    public void TestLongPalindrome()
    {
        string input = "LAGERREGAL";
        Assert.True(PalindromeChecker.IsPalindrome(input));
    }
}
