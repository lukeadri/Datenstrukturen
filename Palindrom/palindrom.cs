using System;
using System.Collections;
using System.Security.Cryptography;


public class Palindrom
{

    public static void Main(string[] args)
    {
    }

    public static bool IsPalindrom(string input)
    {
        Stack stack = new Stack();

        int middle = input.Length / 2;

      
        for (int i = 0; i < middle; i++)
        {
            stack.Push(input[i]);
        }

        for (int i = middle; i < input.Length; i++)
        {
            if (input[i] != (char)stack.Pop())
            {
                return false;
            }
        }

        return true;
    }
}
