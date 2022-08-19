using Templar.Aplication.Base;
using Templar.Aplication.Commands.GetAllTemplates;

namespace Templar.Aplication.Commands.IncludeAllTemplates
{
    public class GetAllTamplatesCommand : ICommand<GetAllTamplatesParameter, List<GetAllTemplatesResult>>
    {
        public List<GetAllTemplatesResult> Execute(GetAllTamplatesParameter param)
        {
            var result = new List<GetAllTemplatesResult>();

            var folders = System.IO.Directory
                .GetDirectories(param.TemplatesFolder, "*", SearchOption.AllDirectories)
                .Select(x => new GetAllTemplatesResult()
                {
                    TemplateType = Enums.TemplateTypes.Folder,
                    TemplateFullPath = x
                });
            result.AddRange(folders);

            var files = System.IO.Directory
                    .GetFiles(param.TemplatesFolder, "*", SearchOption.AllDirectories)
                    .Select(x => new GetAllTemplatesResult()
                    {
                        TemplateType = Enums.TemplateTypes.File,
                        TemplateFullPath = x
                    });
            result.AddRange(files);




            return result;
        }
    }
}
