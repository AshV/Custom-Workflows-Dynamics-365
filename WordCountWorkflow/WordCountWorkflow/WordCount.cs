using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;

namespace WordCountWorkflow
{
    public class WordCount : CodeActivity
    {
        [RequiredArgument]
        [Input("Input Text")]
        public InArgument<string> InputText { get; set; }

        [Output("Word Count")]
        public OutArgument<int> CountOfWords { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            this.CountOfWords.Set(
                context,
                this.InputText.Get<string>(context).Split(' ').Length);
        }
    }
}