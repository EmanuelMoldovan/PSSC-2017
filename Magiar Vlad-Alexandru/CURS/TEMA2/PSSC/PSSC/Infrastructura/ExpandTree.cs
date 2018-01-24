using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSSC
{
    public class ExpandTree
    {
        private TreeView treeView1;

        public ExpandTree(TreeView treeView1)
        {
            this.TreeView1 = treeView1;
        }

        public TreeView TreeView1 { get => treeView1; set => treeView1 = value; }

        internal void expand()
        {
            TreeView1.ExpandAll();
        }
    }
}
