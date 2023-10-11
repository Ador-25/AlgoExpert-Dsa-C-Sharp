namespace AlgoExpert_Easy;

public class Validate_BST
{
    public static bool ValidateBst(BST tree) {
        // Write your code here.
        return Validate(int.MinValue,int.MaxValue,tree);
    }
    public static bool Validate(int min,int max,BST tree)
    {
        if(tree==null)
            return true;
        if(tree.value>=min && tree.value<max)
        {
            return Validate(min,tree.value,tree.left) && Validate(tree.value,max,tree.right);
        }
        else return false;
    }

    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }
}