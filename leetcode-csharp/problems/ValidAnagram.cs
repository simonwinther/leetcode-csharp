using System;
namespace leetcode_csharp.problems
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> sDict = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (sDict.ContainsKey(c))
                    sDict[c] += 1;
                else
                    sDict.Add(c, 1);
            }

            foreach (char c in t)
            {
                if (sDict.ContainsKey(c))
                {
                    sDict[c] -= 1;
                    if (sDict[c] == 0)
                        sDict.Remove(c);
                }
                else
                    return false;
            }

            if (sDict.Count == 0)
                return true;
            
            return false;
        }

        public bool IsAnagramArr(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] arr = new char[26];

            for(int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
                arr[t[i] - 'a']--;
            }

            return arr.All(c => c == 0);
        }
    }
}

