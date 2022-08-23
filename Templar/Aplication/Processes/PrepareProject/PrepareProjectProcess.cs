using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Base;
using Templar.Aplication.Commands.IncludeAllTemplates;
using Templar.Aplication.Commands.LoadTemplate;
using Templar.Aplication.Models;

namespace Templar.Aplication.Processes.PrepareProject
{
    public class PrepareProjectProcess : IProcess<ProjectModel>
    {
        public void Execute(ProjectModel parameters)
        {
            parameters.CodeTemplates.Clear();

            var tl = new GetAllTamplatesCommand().Execute(new Aplication.Commands.GetAllTemplates.GetAllTamplatesParameter()
            {
                TemplatesFolder = parameters.ProjectFile.TemplatesFolder
            });

            foreach (var item in tl)
            {
                LoadTemplateResult? template = null;
                if (item.TemplateType == Enums.TemplateTypes.File)
                {
                    template = new LoadTemplateCommand().Execute(item.TemplateFullPath);
                }

                var templateUri = new Uri(item.TemplateFullPath);

                parameters.CodeTemplates.Add(new CodeTemplateModel()
                {
                    TemplateType = item.TemplateType,
                    TemplatePath = item.TemplateFullPath,
                    Template = template?.Template,
                    TemplateRelativePath = Path.GetRelativePath(parameters.ProjectFile.TemplatesFolder, item.TemplateFullPath),
                    TemplateFileName = System.IO.Path.GetFileName(item.TemplateFullPath)
                });;
            }
        }
    }
}
