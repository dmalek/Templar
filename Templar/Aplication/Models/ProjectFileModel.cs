namespace Templar.Aplication.Models
{
    public class ProjectFileModel
    {
        public string TemplatesFolder { get; set; } = String.Empty;
        public string DestinationFolder { get; set; } = String.Empty;
        public Dictionary<string, string> Keywords { get; set; } = new Dictionary<string, string>();
    }
}
