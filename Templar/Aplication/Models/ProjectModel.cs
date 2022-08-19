namespace Templar.Aplication.Models
{
    public class ProjectModel
    {
        public ProjectFileModel ProjectFile { get; set; } = new ProjectFileModel();

        public List<CodeTemplateModel> CodeTemplates { get; set; } = new List<CodeTemplateModel>();
    }
}
