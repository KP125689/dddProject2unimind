﻿using OpenAI_API.Completions;
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

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var openAI = new OpenAIAPI("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");
            CompletionRequest completionRequest = new CompletionRequest();
            completionRequest.Prompt = richTextBox1.Text;
            completionRequest.Model = OpenAI_API.Models.Model.DavinciText;
            completionRequest.MaxTokens = 2000;
            var completions = await openAI.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Completions)
            {
                richTextBox2.Text = completion.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var logmoodPage = new ExtrasPage();
            logmoodPage.Show();
            this.Hide();

        }
    }
}
