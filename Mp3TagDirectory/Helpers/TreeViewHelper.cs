using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3TagDirectory.Helpers
{
    class TreeViewHelper
    {

        public  static void  ExpandFirstNode(TreeView treeView)
        {
            ExpandNodes(treeView.Nodes);
        }

        public static void ExpandSecondNode(TreeView treeView)
        {
            foreach (TreeNode firstlevel in treeView.Nodes)
            {
                firstlevel.Expand();

               

                foreach (TreeNode secondlevel in firstlevel.Nodes)
                {
                    treeView.SelectedNode = secondlevel;
                    secondlevel.Expand();
                }
            }
           
        }

        public static void ExpandNodes(TreeNodeCollection nodes )
        {
            foreach (TreeNode tn in nodes)
            {
                tn.Expand();
            }
        }

    }
}
