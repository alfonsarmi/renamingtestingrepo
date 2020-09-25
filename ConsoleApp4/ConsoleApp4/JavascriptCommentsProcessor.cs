using System.Collections.Generic;
using System.Linq;
using Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.FileScanner.Interfaces;
using Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.Models.Info;
using Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.Models.JSSyntaxTree;
using Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.Models.JSSyntaxTree.BasicToken;

namespace Workflow.Providers.CodeLanguageParsers.CodeScanners.Languages.Javascript.FileScanner
{
    public class JavascriptCommentsProcessor : IJavascriptCommentsProcessor
    {
        public void ProccessJavascriptComments(JavascriptFileInfo file, JavascriptSyntaxComments jsCommentsTree)
        {
            var javascriptComments = jsCommentsTree.Comments;

            file.Metrics.LinesOfComments = javascriptComments.Count;

            foreach (var codeBlock in file.CodeBlocksInfo)
            {
                ProcessChildCodeBlocksComments(codeBlock, javascriptComments);
            }
        }

        private int ProcessChildCodeBlocksComments(JavascriptCodeBlockInfo codeBlock, List<JavascriptSyntaxBasicToken> javascriptComments)
        {
            if (codeBlock.CodeBlocksInfo != null)
            {
                foreach (var cBlock in codeBlock.CodeBlocksInfo)
                {
                    codeBlock.Metrics.LinesOfComments = ProcessChildCodeBlocksComments(cBlock, javascriptComments);
                }
            }

            var comments = javascriptComments.Where(c => c.Loc.Start.Line >= codeBlock.Location.Start && c.Loc.End.Line <= codeBlock.Location.End).ToList();
            codeBlock.Metrics.LinesOfComments += comments.Count();

            return codeBlock.Metrics.LinesOfComments;
        }
    }
}
