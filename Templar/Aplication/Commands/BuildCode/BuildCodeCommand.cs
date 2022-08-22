using Templar.Aplication.Base;

namespace Templar.Aplication.Commands.BuildCode
{
    public class BuildCodeCommand : ICommand<BuildCodeParameter, BuildCodeResult>
    {
        public BuildCodeResult Execute(BuildCodeParameter param)
        {
            var sourcePath = param.TemplatePath;
            var sourceFileName = param.TemplateFileName;
            var sourceCode = param.Template;

            foreach (var keyword in param.Keywords)
            {
                sourcePath = sourcePath.Replace(keyword.Name, keyword.Value);
                sourceFileName = sourceFileName.Replace(keyword.Name, keyword.Value);
                sourceCode = sourceCode.Replace(keyword.Name, keyword.Value);
            }

            return new BuildCodeResult()
            {
                SourcePath = sourcePath,
                SourceFileName = sourceFileName,
                Source = sourceCode
            };
        }
    }
}
