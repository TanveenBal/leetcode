class Solution:

    def encode(self, strs: list[str]) -> str:
        encoded = ""

        for s in strs:
            for c in s:
                encoded += chr(ord(c) + 1)
            encoded += "#"

        return encoded

    def decode(self, s: str) -> list[str]:
        if s == "":
            return []
        s = s[:-1]
        splitted = s.split("#")
        decoded = []

        for s in splitted:
            dec = ""
            for c in s:
                dec += chr(ord(c) - 1)
            decoded.append(dec)

        return decoded
