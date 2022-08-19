using Templar.Aplication.Base;
using Templar.Aplication.Commands.SaveCode;
using Templar.Aplication.Models;

namespace Templar.Aplication.Processes.GenerateCode
{
    public class GenerateCodeProcess : IProcess<ProjectModel>
    {
        public void Execute(ProjectModel parameters)
        {
            foreach (var item in parameters.CodeTemplates)
            {
                new SaveCodeCommand().Execute(new SaveCodeParameter()
                {
                    TemplateType = item.TemplateType,
                    SourcePath = item.SourcePath,
                    Source = item.Source,
                });
            }
        }
    }
}
