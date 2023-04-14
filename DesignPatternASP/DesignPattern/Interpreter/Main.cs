using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace DesignPatternASP.DesignPattern.Interpreter
{
    public class Main
    {
        public void ExecuteJSON(List<IFormFile> files)
        {
            foreach (var file in files)
            {
                ContentDispositionHeaderValue header = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                string fileName = file.FileName;
                fileName = fileName.Trim('"');
                fileName = Path.GetFileName(fileName);
                string filePath = Path.Combine("BatchFiles\\", fileName);
                file.SaveAs(filePath);

                List<ApiCall> apiCalls = JsonConvert.DeserializeObject<List<ApiCall>>(System.IO.File.ReadAllText(filePath));
                InterpreterContext context = new InterpreterContext();
                context.AssemblyStore = Path.Combine("BatchFiles\\", "AssemblyStore");
                context.BasePath = "env.WebRootPath";
                foreach (ApiCall call in apiCalls)
                {
                    call.Interpret(context);
                }
            }
        }
    }
}
