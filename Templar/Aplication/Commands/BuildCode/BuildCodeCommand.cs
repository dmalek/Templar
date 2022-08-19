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
                sourcePath = sourcePath.Replace(keyword.Key, keyword.Value);
                sourceFileName = sourceFileName.Replace(keyword.Key, keyword.Value);
                sourceCode = sourceCode.Replace(keyword.Key, keyword.Value);
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
