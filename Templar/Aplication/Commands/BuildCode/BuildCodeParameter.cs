namespace Templar.Aplication.Commands.BuildCode
{
    public class BuildCodeParameter
    {
        public string TemplatePath { get; set; } = String.Empty;
        public string TemplateFileName { get; set; } = String.Empty;
        public string Template { get; set; } = String.Empty;
        public Dictionary<string, string> Keywords { get; set; } = new Dictionary<string, string>();
    }
}
