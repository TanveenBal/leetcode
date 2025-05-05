public class TrieNode
{
    public TrieNode[] Children;
    public bool IsEndOfWord;

    public TrieNode() { Children = new TrieNode[26]; }
}

public class Trie
{
    public TrieNode start;

    public Trie() { start = new TrieNode(); }

    public void Insert(string word)
    {
        if (string.IsNullOrEmpty(word)) return;

        int index = word[0] - 'a';
        if (start.Children[index] == null)
            start.Children[index] = new TrieNode();

        TrieNode curr = start.Children[index];

        for (int i = 1; i < word.Length; ++i)
        {
            index = word[i] - 'a';
            if (curr.Children[index] == null)
                curr.Children[index] = new TrieNode();

            curr = curr.Children[index];
        }

        curr.IsEndOfWord = true;
    }

    public bool Search(string word)
    {
        if (string.IsNullOrEmpty(word)) return false;

        int index = word[0] - 'a';

        if (start.Children[index] == null)
            return false;

        TrieNode curr = start.Children[index];

        for (int i = 1; i < word.Length; ++i)
        {
            index = word[i] - 'a';
            if (curr.Children[index] == null)
                return false;

            curr = curr.Children[index];
        }

        return curr.IsEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        if (string.IsNullOrEmpty(prefix)) return false;

        int index = prefix[0] - 'a';

        if (start.Children[index] == null)
            return false;

        TrieNode curr = start.Children[index];

        for (int i = 1; i < prefix.Length; ++i)
        {
            index = prefix[i] - 'a';
            if (curr.Children[index] == null)
                return false;

            curr = curr.Children[index];
        }

        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
