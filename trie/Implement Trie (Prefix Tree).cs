public class Node
{
    public char Character;
    public Node[] Children;
    public bool IsEndOfWord;

    public Node(char c, bool end = false)
    {
        Character = c;
        Children = new Node[26];
        IsEndOfWord = end;
    }
}

public class Trie
{
    private Node[] start;

    public Trie()
    {
        start = new Node[26];
    }
    public void Insert(string word)
    {
        if (string.IsNullOrEmpty(word)) return;

        int index = word[0] - 'a';
        if (start[index] == null)
            start[index] = new Node(word[0]);

        Node curr = start[index];

        for (int i = 1; i < word.Length; ++i)
        {
            index = word[i] - 'a';
            if (curr.Children[index] == null)
                curr.Children[index] = new Node(word[i]);

            curr = curr.Children[index];
        }

        curr.IsEndOfWord = true;
    }
    public bool Search(string word)
    {
        if (string.IsNullOrEmpty(word)) return false;

        int index = word[0] - 'a';

        if (start[index] == null)
            return false;

        Node curr = start[index];

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

        if (start[index] == null)
            return false;

        Node curr = start[index];

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
