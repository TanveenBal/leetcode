public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        int[] freq1 = new int[26];
        int[] freq2 = new int[26];

        foreach (char c in s1)
            ++freq1[c - 'a'];

        int l = 0, r = s1.Length;

        for (int i = 0; i < s1.Length; ++i)
            ++freq2[s2[i] - 'a'];

        for (; r < s2.Length; ++r, ++l)
        {
            if (freq1.SequenceEqual(freq2))
                return true;

            ++freq2[s2[r] - 'a'];
            --freq2[s2[l] - 'a'];
        }

        return freq1.SequenceEqual(freq2);
    }

    /*public bool CheckInclusion(string s1, string s2)*/
    /*{*/
    /*    if (string.IsNullOrEmpty(s1)) return true;*/
    /*    if (s1.Length > s2.Length) return false;*/
    /**/
    /*    Dictionary<char, int> freq1 = new Dictionary<char, int>();*/
    /*    foreach (char c in s1)*/
    /*    {*/
    /*        if (!freq1.ContainsKey(c))*/
    /*            freq1[c] = 0;*/
    /*        ++freq1[c];*/
    /*    }*/
    /**/
    /*    Dictionary<char, int> freq2 = new Dictionary<char, int>();*/
    /*    int l = 0;*/
    /**/
    /*    for (int r = 0; r < s2.Length; ++r)*/
    /*    {*/
    /*        char c = s2[r];*/
    /**/
    /*        if (freq1.ContainsKey(c))*/
    /*        {*/
    /*            if (!freq2.ContainsKey(c))*/
    /*                freq2[c] = 0;*/
    /*            ++freq2[c];*/
    /**/
    /*            while (freq2[c] > freq1[c])*/
    /*            {*/
    /*                char leftChar = s2[l];*/
    /*                freq2[leftChar]--;*/
    /*                if (freq2[leftChar] == 0)*/
    /*                    freq2.Remove(leftChar);*/
    /*                l++;*/
    /*            }*/
    /**/
    /*            if (r - l + 1 == s1.Length)*/
    /*                return true;*/
    /*        }*/
    /*        else*/
    /*        {*/
    /*            freq2.Clear();*/
    /*            l = r + 1;*/
    /*        }*/
    /*    }*/
    /**/
    /*    return false;*/
    /*}*/
}
