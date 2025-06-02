from collections import defaultdict
from typing import List

class Solution:
    def printVertically(self, s: str) -> List[str]:
        vertical = defaultdict(str)
        words = s.split(" ")
        max_len = max([len(word) for word in words])

        for i in range(len(words)):
            words[i] +=  " " * (max_len - len(words[i]))

        for word in words:
            for i in range(len(word)):
                vertical[i] += word[i]

        ans = []
        for _, val in vertical.items():
            ans.append(val.rstrip())

        return ans
