using Templar.Aplication.Base;

namespace Templar.Aplication.Commands.LoadTemplate
{
    public class LoadTemplateCommand : ICommand<string, LoadTemplateResult>
    {
        public LoadTemplateResult Execute(string param)
        {
            var result = new LoadTemplateResult();

            result.Template = System.IO.File.ReadAllText(param);

            return result;
        }
    }
}
