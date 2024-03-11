public class Solution {
  public  bool IsAnagram(string s, string t)
{
    string ss = SortString(s);
    string st = SortString(t);

    if (ss.Length == st.Length)
    {
        for(int i = 0; i < ss.Length; i++)
        {
            if (ss[i] != st[i])
            {
                return false;
            }
        }
        return true;
    }

    return false;
}

public string SortString(string s)
{
    char[] arr = s.ToCharArray();
    Array.Sort(arr);
    return new string(arr);
}
}