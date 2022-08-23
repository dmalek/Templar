using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Templar.Aplication.Models;
using Templar.Aplication.Processes.BuildProject;
using Templar.Aplication.Processes.GenerateCode;
using Templar.Aplication.Processes.LoadProject;
using Templar.Aplication.Processes.PrepareProject;
using Templar.UI;
using static System.Net.WebRequestMethods;

namespace Templar
{
    public static class ApplicationService
    {
        public static MainForm MainForm;

        public static ProjectModel Project { get; set; } = new ProjectModel();

        public static void LoadProject(string fileName)
        {
            Project = new LoadProjectProcess().Execute(fileName);
            new PrepareProjectProcess().Execute(ApplicationService.Project);
            MainForm.RefreshContent();
        }

        public static void SaveProject(string fileName)
        {
            var jsonContent = JsonSerializer.Serialize(Project.ProjectFile);
            System.IO.File.WriteAllText(fileName, jsonContent);
        }

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
