public class DictNode
{
    public DictNode[] Children;
    public bool IsEndOfWord;

    public DictNode() { Children = new DictNode[26]; }
}

public class WordDictionary
{
    public DictNode start;

    public WordDictionary() { start = new DictNode(); }

    public void AddWord(string word)
    {
        if (string.IsNullOrEmpty(word)) return;

        int index = word[0] - 'a';
        if (start.Children[index] == null)
            start.Children[index] = new DictNode();

        DictNode curr = start.Children[index];

        for (int i = 1; i < word.Length; ++i)
        {
            index = word[i] - 'a';
            if (curr.Children[index] == null)
                curr.Children[index] = new DictNode();

            curr = curr.Children[index];
        }

        curr.IsEndOfWord = true;
    }
    public bool Search(string word)
    {
        return SearchHelper(word, 0, start);
    }

    private bool SearchHelper(string word, int pos, DictNode node)
    {
        if (node == null) return false;
        if (pos == word.Length) return node.IsEndOfWord;

        char c = word[pos];

        if (c == '.')
        {
            for (int i = 0; i < 26; ++i)
            {
                if (node.Children[i] != null && SearchHelper(word, pos + 1, node.Children[i]))
                    return true;
            }
            return false;
        }
        else
        {
            int index = c - 'a';
            return SearchHelper(word, pos + 1, node.Children[index]);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
