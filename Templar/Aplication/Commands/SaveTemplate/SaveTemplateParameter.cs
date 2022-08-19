using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Enums;

namespace Templar.Aplication.Commands.SaveTemplate
{
    public class SaveTemplateParameter
    {
        public TemplateTypes TemplateType { get; set; } = TemplateTypes.Unknown;
        public string TemplatePath { get; set; } = String.Empty;
        public string Template { get; set; } = String.Empty;
    }
}
