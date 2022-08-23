using System.Windows.Forms;
using Templar.Aplication.Models;
using Templar.UI.Controls;

namespace Templar.UI
{
    public partial class MainForm : Form, IRefreshableContent
    {
        public MainForm()
        {
            InitializeComponent();

            MainPages.TabPages.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
            projectProperties1.RefreshContent();

            foreach (TabPage tabPage in MainPages.TabPages)
            {
                if (tabPage.Controls[0] is IRefreshableContent)
                {
                    ((IRefreshableContent)tabPage.Controls[0]).RefreshContent();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() !=  DialogResult.OK)
            {
                return;
            }

            ApplicationService.LoadProject(openFileDialog1.FileName);
            RefreshContent();
            solutionExplorer1.BuildTree();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            ApplicationService.SaveProject(saveFileDialog1.FileName);
        }
    }
}
