using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templar.Extensions
{
    public static class TreeViewExtensions
    {
        public static TreeNode? FindNode(this TreeNodeCollection nodes, string path)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.FullPath == path)
                {
                    return node;
                }

                if (node.Nodes.Count > 0)
                {
                    var n = FindNode(node.Nodes, path);
                    if (n != null)
                    {
                        return n;
                    }

                }
            }

            return null;
        }

        public static TreeNode? AddModeWithPath(this TreeNodeCollection nodes, string path)
        {
            TreeNode newNode;

            string templateName = System.IO.Path.GetFileName(path);
            string ? parentPath = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty( parentPath))
            {
                newNode = nodes.Add(templateName);
            }
            else
            {
                TreeNode? parentNode = nodes.FindNode(parentPath);
                if (parentNode == null)
                {
                    string parentName = System.IO.Path.GetFileName(parentPath);
                    parentNode = nodes.Add(parentName);
                }
                newNode = parentNode.Nodes.Add(templateName);
            }

            return newNode;
        }
    }
}
