using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class BinarySearchTree
    {
        public class BSTNode
        {
            public BSTNode left, right;
            public int data;
            public BSTNode(int data)
            {
                this.data = data;
                left = right = null;
            }
        }


        public int GetHeight(BSTNode root)
        {
            //Write your code here        
            if (root == null)
                return -1;
            else
            {
                int leftHeight = GetHeight(root.left);
                int rightHeight = GetHeight(root.right);

                if (leftHeight > rightHeight)
                    return (leftHeight + 1);
                else
                    return (rightHeight + 1);
            }
        }


        public BSTNode Insert(BSTNode root, int data)
        {
            if (root == null)
            {
                return new BSTNode(data);
            }
            else
            {
                BSTNode cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
