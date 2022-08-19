using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templar.Aplication.Models;
using Templar.Extensions;

namespace Templar.UI
{
    public partial class SolutionExplorer : UserControl
    {
        public SolutionExplorer()
        {
            InitializeComponent();
        }

        public ProjectModel Project { get; set; }

        public void BuildTree()
        {
            tvTemplates.BeginUpdate();
            tvTemplates.Nodes.Clear();

            foreach (var item in Project.CodeTemplates)
            {
                TreeNode? node = tvTemplates.Nodes.AddModeWithPath(item.TemplateRelativePath);
                if (node != null && item.TemplateType == Aplication.Enums.TemplateTypes.Folder)
                {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                }
                else if (node != null && item.TemplateType == Aplication.Enums.TemplateTypes.File)
                {
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                }

                node.Tag = item;
            }
            tvTemplates.EndUpdate();
        }

        private void tvTemplates_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var ct = (CodeTemplateModel)e.Node.Tag;
            if (ct == null)
            {
                return;
            }

            ApplicationService.ShowTemplate((CodeTemplateModel)e.Node.Tag);
        }
    }
}
