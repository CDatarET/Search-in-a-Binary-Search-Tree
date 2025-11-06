/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SearchBST(TreeNode root, int val) {
        TreeNode current = root;
        while(true){
            if(current == null){
                return(null);
            }

            if(val > current.val){
                current = current.right;
            }
            else if(val < current.val){
                current = current.left;
            }
            else{
                return(current);
            }
        }
    }
}
