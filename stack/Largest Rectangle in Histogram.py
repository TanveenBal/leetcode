def largestRectangleArea(heights: list[int]) -> int:
    stack = []
    max_area = 0
    for i, h in enumerate(heights):
        while stack and heights[stack[-1]] > h:
            height = heights[stack.pop()]
            width = i if not stack else i - stack[-1] - 1
            max_area = max(max_area, height * width)
        stack.append(i)
    while stack:
        height = heights[stack.pop()]
        width = len(heights) if not stack else len(heights) - stack[-1] - 1
        max_area = max(max_area, height * width)
    return max_area

print(largestRectangleArea([2,1,5,6,2,3]))
print(largestRectangleArea([2,4]))
print(largestRectangleArea([1,2,3,4,5]))
print(largestRectangleArea([0,1,0,2,1,0,1,3,2,1,2,1]))
print(largestRectangleArea([1,3,2,1,2,1]))
