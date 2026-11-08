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
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
    }
}

public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new();
        if(root == null) return result;
        Queue<TreeNode> q = new ();
        q.Enqueue(root);
        while(q.Count>0){
            List<int> level = new();
            int levelNodesCnt = q.Count;
            for(int i=0; i< levelNodesCnt; i++){
                TreeNode cur = q.Dequeue();
                level.Add(cur.val);

                if(cur.left!=null) q.Enqueue(cur.left);
                if(cur.right != null) q.Enqueue(cur.right);
            }
            result.Add(level);
        }
        return result;
    }
}
