using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Models;
using Templar.Aplication.Processes.BuildProject;
using Templar.Aplication.Processes.GenerateCode;
using Templar.Aplication.Processes.PrepareProject;
using Templar.UI;

namespace Templar
{
    public static class ApplicationService
    {
        public static MainForm MainForm;

        public static ProjectModel Project { get; set; } = new ProjectModel();

        public static void ShowTemplate(CodeTemplateModel codeTemplate)
        {
            MainForm.ShowTemplate(codeTemplate);
        }

        public static void BuildProject()
        {
            new BuildProjectProcess().Execute(Project);
            MainForm.RefreshContent();
        }

        public static void PrepareProject()
        {
            new PrepareProjectProcess().Execute(Project);
        }

        public static void GenerateCode()
        {
            new GenerateCodeProcess().Execute(Project);
        }
    }
}
