using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Base;

namespace Templar.Aplication.Commands.SaveCode
{
    public class SaveCodeCommand : ICommand<SaveCodeParameter>
    {
        public void Execute(SaveCodeParameter param)
        {
            if (param.TemplateType == Enums.TemplateTypes.Folder)
            {
                Directory.CreateDirectory(param.SourcePath);
            }
            else if (param.TemplateType == Enums.TemplateTypes.File)
            {
                var dirPath = System.IO.Path.GetDirectoryName(param.SourcePath);
                if (dirPath != null)
                {
                    Directory.CreateDirectory(dirPath);
                }                
                System.IO.File.WriteAllText(param.SourcePath, param.Source);
            }
        }
    }
}
