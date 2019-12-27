using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] expression1 = { '(', '{', '}', ')' };
            char[] expression2 = { '(', '{', '}', ')', ']' };

            Console.WriteLine("Is Expression1 Balanced? " + IsParanthesesBalanced(expression1));
            Console.WriteLine("Is Expression2 Balanced? " + IsParanthesesBalanced(expression2));
            Console.ReadLine();
        }

        private static bool IsParanthesesBalanced(char[] expression)
        {
            HashSet<char> openingParentheses = new HashSet<char>() { '(', '{', '[' };
            HashSet<char> closingParentheses = new HashSet<char>() { ')', '}', ']' };
            Dictionary<char, char> matchingPairs = GetMatchingPairsDict();

            Stack bracketStack = new Stack();

            foreach (char i in expression)
            {
                if (openingParentheses.Contains(i))
                {
                    bracketStack.Push(i);
                    continue;
                }
                if (closingParentheses.Contains(i))
                {
                    if (bracketStack.IsEmpty())
                        return false;

                    char openingParenthesis = bracketStack.Pop();
                    if (matchingPairs[openingParenthesis] != i)
                        return false;
                }
            }

            if (bracketStack.IsEmpty())
                return true;
            return false;
        }

        private static Dictionary<char, char> GetMatchingPairsDict()
        {
            Dictionary<char, char> matchingPairs = new Dictionary<char, char>();
            matchingPairs.Add('(', ')');
            matchingPairs.Add('{', '}');
            matchingPairs.Add('[', ']');
            return matchingPairs;
        }
    }
}