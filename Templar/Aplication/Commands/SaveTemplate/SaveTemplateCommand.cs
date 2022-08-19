using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Base;

namespace Templar.Aplication.Commands.SaveTemplate
{
    public class SaveTemplateCommand : ICommand<SaveTemplateParameter>
    {
        public void Execute(SaveTemplateParameter param)
        {
            if (param.TemplateType == Enums.TemplateTypes.Folder)
            {
                Directory.CreateDirectory(param.TemplatePath);
            }
            else if (param.TemplateType == Enums.TemplateTypes.File)
            {
                var dirPath = System.IO.Path.GetDirectoryName(param.TemplatePath);
                if (dirPath != null)
                {
                    Directory.CreateDirectory(dirPath);
                }
                System.IO.File.WriteAllText(param.TemplatePath, param.Template);
            }
        }
    }
}
