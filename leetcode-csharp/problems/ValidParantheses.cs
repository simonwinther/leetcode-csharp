using System;
namespace leetcode_csharp.problems
{
    public class ValidParantheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if(c == '(') { stack.Push(')'); continue; }
                if (c == '[') { stack.Push(']'); continue; }
                if (c == '{') { stack.Push('}'); continue; }
                if (stack.Count == 0 || c != stack.Pop()) return false;
            }

            return stack.Count == 0;
        }
    }
}

