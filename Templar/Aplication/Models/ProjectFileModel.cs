namespace Templar.Aplication.Models
{
    public class ProjectFileModel
    {
        public string TemplatesFolder { get; set; } = String.Empty;
        public string DestinationFolder { get; set; } = String.Empty;
        public List<TemplateKeyword> Keywords { get; set; } = new List<TemplateKeyword>();
    }
}
