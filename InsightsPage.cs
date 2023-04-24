using OpenAI_API.Completions;
using OpenAI_API;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dddProject2
{
    public partial class InsightsPage : Form
    {

         
        public InsightsPage()
        {
            InitializeComponent();
        }

        private async void Querybutton_Click(object sender, EventArgs e)
        {
            var openAI = new OpenAIAPI("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");
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt = richTextBox1.Text; //the request is taken from this textbox that the user writes in.
            completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
            completionRequest.MaxTokens = 2000;

            var completions = await openAI.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Completions)
            {
                richTextBox2.Text = completion.Text;
            }

        }
    }
}

