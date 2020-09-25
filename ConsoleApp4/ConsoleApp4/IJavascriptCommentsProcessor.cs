using Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.Models.Info;
using Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.Models.JSSyntaxTree;

namespace Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.FileScanner.Interfaces
{
    public interface IJavascriptCommentsProcessor
    {
        void ProccessJavascriptComments(JavascriptFileInfo file, JavascriptSyntaxComments jsCommentsTree);
    }
}