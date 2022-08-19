using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Templar.Aplication.Enums;

namespace Templar.Aplication.Commands.SaveCode
{
    public class SaveCodeParameter
    {
        public TemplateTypes TemplateType { get; set; } = TemplateTypes.Unknown;
        public string SourcePath { get; set; } = String.Empty;
        public string Source { get; set; } = String.Empty;
    }
}
