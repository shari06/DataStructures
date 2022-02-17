using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearDataStructure
{
    public class BinarySearchTree
    {
        /*
        Binary Search Tree
        Searching Time Complexity: O(logN) 
        */
        public bool Search(int[] sortedArray, int pSearchKey)
        {
            var nodeModel = Creation(sortedArray, 0, sortedArray.Length);
            return SearchKey(nodeModel, pSearchKey);
        }

        private bool SearchKey(TreeNode nodeModel, int pSearchKey)
        {
            bool result = false;
            if (nodeModel.val == pSearchKey)
            {
                result = true;
            }
            // 1 > 2 => It will be left side of the node
            else if (nodeModel.val > pSearchKey)
            {
                result = nodeModel.left is null ? false : SearchKey(nodeModel.left, pSearchKey);
            }
            // 1 < 3 => It will be Right side of the node
            else if (nodeModel.val < pSearchKey)
            {
                result = nodeModel.right is null ? false : SearchKey(nodeModel.right, pSearchKey);
            }

            return result;
        }

        /// <summary>
        /// Binary Search Tree Creation through sorted array
        /// </summary>
        /// <param name="sortedArray">Soreted Array</param>
        public TreeNode Creation(int[] sortedArray, int sindex, int lindex)
        {

            if (sindex > lindex)
            {
                return null;
            }

            int median = (sindex + lindex) / 2;
            TreeNode root = new TreeNode(sortedArray[median]);


            root.left = Creation(sortedArray, sindex, median - 1);

            root.right = Creation(sortedArray, median + 1, lindex);

            return root;
        }

        public TreeNode SearchBST(TreeNode nodeModel, int pSearchKey)
        {
            TreeNode result = null;
            if (nodeModel.val == pSearchKey)
            {
                result = nodeModel;
            }
            // 1 > 2 => It will be left side of the node
            else if (nodeModel.val > pSearchKey)
            {
                result = nodeModel.left is null ? null : SearchBST(nodeModel.left, pSearchKey);
            }
            // 1 < 3 => It will be Right side of the node
            else if (nodeModel.val < pSearchKey)
            {
                result = nodeModel.right is null ? null : SearchBST(nodeModel.right, pSearchKey);
            }

            return result;

        }
    }

}
