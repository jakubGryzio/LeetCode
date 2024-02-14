using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Models
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.Value = val;
            this.Left = left;
            this.Right = right;
        }

        public static void GetNode(TreeNode node)
        {
            if (node.Left != null)
            {
                GetNode(node.Left);
            }
            if (node.Right != null)
            {
                GetNode(node.Right);
            }
        }
    }
}
