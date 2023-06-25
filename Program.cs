using System;
using System.Collections.Generic;
namespace MSTestProlems
{
    public class GroupEligibilityChecker
{
    public bool IsGroupEligible(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        int[] counts = new int[26];

        foreach (char c in word1)
        {
            counts[c - 'a']++;
        }

        foreach (char c in word2)
        {
            counts[c - 'a']--;
        }

        foreach (int count in counts)
        {
            if (count != 0)
            {
                return false;
            }
        }

        return true;
    }
}


}
