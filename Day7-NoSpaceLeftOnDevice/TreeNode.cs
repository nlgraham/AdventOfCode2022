/* TreeNode.cs
 * Author: Natasha Graham
 * Created 2023-09-24
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_NoSpaceLeftOnDevice
{
    internal class TreeNode
    {
        public TreeNode(String name)
        {
            Name = name;
            IsDir = true;
            Size = 0;
        }

        public TreeNode(String name, int size, TreeNode parent)
        {
            Name = name;
            Size = size;
            Parent = parent;
            IsDir = false;
        }

        public TreeNode(String name, TreeNode parent)
        {
            Name = name;
            Parent = parent;
            IsDir = true;
            Size = 0;
        }

        public String Name { get; set; }
        public int Size { get; set; }
        public TreeNode? Parent { get; set; }
        public bool IsDir { get; set; }
        public List<TreeNode> Children { get; set;} = new List<TreeNode>();

        public void AddChild(TreeNode child)
        {
            if (IsDir)
            {
                Children.Add(child);
            }
        }

        public void UpdateSize(int s)
        {
            Size += s;
        }

        public int FindSmallDir(int maxSize, List<int> finalNodes)
        {
            foreach(TreeNode child in Children)
            {
                if(child.IsDir)
                { Size += child.FindSmallDir(maxSize, finalNodes); }
                else
                {
                    Size += child.Size;
                }
            }

            if(Size <= maxSize)
            {
                finalNodes.Add(Size);
            }

            return Size;
        }

        public int FindDirSize(List<int> finalNodes)
        {
            foreach (TreeNode child in Children)
            {
                if (child.IsDir)
                { Size += child.FindDirSize(finalNodes); }
                else
                {
                    Size += child.Size;
                }
            }

            finalNodes.Add(Size);

            return Size;
        }
    }
}
