using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templar.Aplication.Commands.GetAllTemplates;
using Templar.Aplication.Commands.IncludeAllTemplates;
using Templar.Aplication.Models;
using Templar.Aplication.Processes.LoadProject;
using Templar.Aplication.Processes.PrepareProject;
using Templar.Extensions;

namespace Templar.UI
{
    public partial class MainForm : Form, IRefreshableContent
    {
        public MainForm()
        {
            InitializeComponent();

            MainPages.TabPages.Clear();
        }

        public ProjectModel Project { get; set; } = ApplicationService.Project;

        private void MainForm_Load(object sender, EventArgs e)
        {
            solutionExplorer1.Project = Project;
            solutionExplorer1.BuildTree();
        }

        public void ShowTemplate(CodeTemplateModel codeTemplate)
        {
            TabPage? tabPage = FindMainPage(codeTemplate.TemplatePath);

            if (tabPage != null)
            {
                MainPages.SelectedTab = tabPage;
                return;
            }

            if (codeTemplate.TemplateType == Aplication.Enums.TemplateTypes.File)
            {
                var codeEditor = new CodeEditor();
                codeEditor.Code = codeTemplate;
                tabPage = AddMainPage(codeEditor, codeTemplate.TemplateFileName, codeTemplate.TemplatePath);
            }

            if (tabPage != null)
            {
                MainPages.SelectedTab = tabPage;
            }

        }

        private TabPage? FindMainPage(string key)
        {
            foreach (TabPage item in MainPages.TabPages)
            {
                if ((item.Tag ?? "") == key)
                {
                    return item;
                }
            }

            return null;
        }

        private TabPage AddMainPage(Control control, string text, string key)
        {
            TabPage newPage = new TabPage();
            
            control.Dock = DockStyle.Fill;
            newPage.Controls.Add(control);
            newPage.Text = text;
            newPage.Tag = key;

            MainPages.TabPages.Add(newPage);

            return newPage;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ApplicationService.BuildProject();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ApplicationService.GenerateCode();
        }

        public void RefreshContent()
        {
            foreach (TabPage tabPage in MainPages.TabPages)
            {
                if (tabPage.Controls[0] is IRefreshableContent)
                {
                    ((IRefreshableContent)tabPage.Controls[0]).RefreshContent();
                }
            }
        }
    }
}
