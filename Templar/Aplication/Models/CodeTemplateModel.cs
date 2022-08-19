using Templar.Aplication.Enums;

namespace Templar.Aplication.Models
{
    public class CodeTemplateModel
    {
        /// <summary>
        /// Template object type
        /// </summary>
        public TemplateTypes TemplateType { get; set; } = TemplateTypes.Unknown;

        /// <summary>
        /// Absolute path to template
        /// </summary>
        public string TemplatePath { get; set; } = String.Empty;

        /// <summary>
        /// Relative path to template file
        /// </summary>
        public string TemplateRelativePath { get; set; } = String.Empty;
        
        /// <summary>
        /// Template file name
        /// </summary>
        public string TemplateFileName { get; set; } = String.Empty;
        
        /// <summary>
        /// Template content
        /// </summary>
        public string? Template { get; set; } = String.Empty;
        
        /// <summary>
        /// Absolute path to source file
        /// </summary>
        public string? SourcePath { get; set; } = String.Empty;
        
        /// <summary>
        /// Source file name
        /// </summary>
        public string? SourceFileName { get; set; } = String.Empty;
        
        /// <summary>
        /// Source content
        /// </summary>
        public string? Source { get; set; } = String.Empty;
    }
}
