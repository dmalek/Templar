using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Base;
using Templar.Aplication.Commands.BuildCode;
using Templar.Aplication.Models;

namespace Templar.Aplication.Processes.BuildProject
{
    public class BuildProjectProcess : IProcess<ProjectModel>
    {
        public void Execute(ProjectModel parameters)
        {
            foreach (var item in parameters.CodeTemplates)
            {
                var r = new BuildCodeCommand().Execute(new BuildCodeParameter()
                {
                    Keywords = parameters.ProjectFile.Keywords,
                    TemplatePath = item.TemplatePath,
                    TemplateFileName = item.TemplateFileName,
                    Template = item.Template ?? ""
                }) ;

                item.SourcePath = r.SourcePath;
                item.SourceFileName = r.SourceFileName;
                item.Source = r.Source;
                
            }
        }
    }
}
