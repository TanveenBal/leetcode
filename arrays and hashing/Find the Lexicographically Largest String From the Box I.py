class Solution:
    def answerString(self, word: str, numFriends: int) -> str:
        wordLen = len(word)
        wordAscii = [ord(c) for c in word]

        windowSize = wordLen - (numFriends - 1)
        curr = sum(wordAscii[:windowSize])

        currMax = curr
        start = 0
        for i in range(1, wordLen - windowSize + 1):
            curr -= wordAscii[i - 1]
            curr += wordAscii[i + windowSize - 1]
            if curr > currMax:
                currMax = curr
                start = i

        return word[start: start + windowSize]

s = Solution()
print(s.answerString("gggg", 4))
print(s.answerString("dbca", 2))
print(s.answerString("bif", 2))
print(s.answerString("aann", 2))
