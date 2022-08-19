using Templar.Aplication.Enums;

namespace Templar.Aplication.Commands.GetAllTemplates
{
    public class GetAllTemplatesResult
    {
        public TemplateTypes TemplateType { get; set; } = TemplateTypes.Unknown;
        public string TemplateFullPath { get; set; } = "";
    }
}
