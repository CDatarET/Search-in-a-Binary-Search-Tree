# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def searchBST(self, root, val):
        current = root
        while True:
            if current is None:
                return None
            
            if val > current.val:
                current = current.right
            elif val < current.val:
                current = current.left
            else:
                return current
