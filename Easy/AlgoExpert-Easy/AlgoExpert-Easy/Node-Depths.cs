namespace AlgoExpert_Easy;

using System;

public class Program
{
    public static int NodeDepths(BinaryTree root) {
        // Write your code here.
        
        return new Program().DepthCount(-1,root);
    }

    public int DepthCount(int parentDepth,BinaryTree root)
    {
        if(root==null)
            return 0;
        int currentDepth = parentDepth + 1;
        int left = DepthCount(currentDepth,root.left);
        int right = DepthCount(currentDepth,root.right);
        return left + currentDepth + right;
    }  

    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
            left = null;
            right = null;
        }
    }
}
