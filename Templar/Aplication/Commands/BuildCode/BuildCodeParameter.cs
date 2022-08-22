using Templar.Aplication.Models;

namespace Templar.Aplication.Commands.BuildCode
{
    public class BuildCodeParameter
    {
        public string TemplatePath { get; set; } = String.Empty;
        public string TemplateFileName { get; set; } = String.Empty;
        public string Template { get; set; } = String.Empty;
        public List<TemplateKeyword> Keywords { get; set; } = new List<TemplateKeyword>();
    }
}
