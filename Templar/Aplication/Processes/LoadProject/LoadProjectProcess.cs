using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var project = new ProjectModel();
            project.ProjectFile.TemplatesFolder = @"D:\Development\NewtonsoftJSON\JSON\JSON";
            project.ProjectFile.DestinationFolder = @"D:\Tmp";

            return project;
        }
    }
}
