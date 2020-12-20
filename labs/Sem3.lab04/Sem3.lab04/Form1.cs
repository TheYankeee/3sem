using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Sem3.lab05;


namespace Sem3.lab04
{
    public partial class main_form : System.Windows.Forms.Form
    {
        private List<string> words = new List<string>();
        private Stopwatch watch = new Stopwatch();
        public main_form()
        {
            InitializeComponent();

            labelLoadTime.Visible = false;
            labelSearchTime.Visible = false;
            textBoxSearch.Visible = false;
            listBoxSearch.Visible = false;
            buttonSearch.Visible = false;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var word = textBoxSearch.Text;

            watch.Reset();
            watch.Start();

            listBoxSearch.BeginUpdate();
            listBoxSearch.Items.Clear();

            foreach (var text_word in words)
            {
                if (text_word.Contains(word))
                {
                    listBoxSearch.Items.Add(text_word);
                }
            }

            listBoxSearch.EndUpdate();

            watch.Stop();

            labelSearchTime.Text = "Время поиска: " + watch.Elapsed + "ms";
            labelSearchTime.Visible = true;
            listBoxSearch.Visible = true;
        }
        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            watch.Reset();
            watch.Start();
            
            var text = File.ReadAllText(openFileDialog.FileName);
            foreach (var word in text.Split(' ', '.', ',', '\n', '\t', '/', '\\', '[', ']', '{', '}', '<', '>', '@', '#', '$', '%',
                '^', '&', '*', '(', ')', ';', '\'', '\"', '|', '?', '!'))
            {
                if (word != "" && !words.Contains(word))
                {
                    words.Add(word);
                }

                watch.Stop();
                labelLoadTime.Text = "Время загрузки:" + watch.Elapsed + "ms";

                buttonSearch.Visible = true;
                labelLoadTime.Visible = true;
                textBoxSearch.Visible = true;
            }
        }
    }
}
