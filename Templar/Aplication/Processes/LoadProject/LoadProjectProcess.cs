using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Templar.Aplication.Base;
using Templar.Aplication.Commands.IncludeAllTemplates;
using Templar.Aplication.Commands.LoadTemplate;
using Templar.Aplication.Models;

namespace Templar.Aplication.Processes.LoadProject
{
    public class LoadProjectProcess : IProcess<string, ProjectModel>
    {
        public ProjectModel Execute(string param)
        {
            var jsonContent = System.IO.File.ReadAllText(param);
            var pf = JsonSerializer.Deserialize<ProjectFileModel>(jsonContent);
            if (pf == null)
            {
                throw new Exception("Unknown project format!");
            }

            var project = new ProjectModel();
            project.ProjectFile = pf;
            return project;
        }
    }
}
