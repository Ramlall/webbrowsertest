using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserTest
    {
    public partial class Form1 : Form
        {
        string emailAddress = "";
        string testString = "www.craigslist.com";
        string valueID = "FromEMail";
        public Form1()
            {
            InitializeComponent();
            comboBox1.Items.Add("Manhattan");
            comboBox1.Items.Add("Brooklyn");
            comboBox1.Items.Add("Queens");
            comboBox1.Items.Add("Bing");
        }

        // webBrowser1.Document.GetElementById("textName").SetAttribute("value") = "ddddd" ;
        private void button1_Click(object sender, EventArgs e)
            {
            if (comboBox1.Text == null)
            { MessageBox.Show("Please choose an area from the list!"); }

            else
            {
                //button1.Enabled = false; // Disables our submit button.

                if (textBox1.Text != null)
                { emailAddress = textBox1.Text; }

                if (comboBox1.Text == "Manhattan")
                { testString = "https://post.craigslist.org/k/VNWeTNG-5RGtZs4V8D_J5w/5N4B2?s=edit"; }
                else if (comboBox1.Text == "Brooklyn")
                { testString = "https://post.craigslist.org/k/JgzPela-5RGpfZclEH4-Xw/vlYYg?s=edit"; }
                else if (comboBox1.Text == "Queens")
                { testString = "https://post.craigslist.org/k/BPABi1a-5RGP048wEBgXOQ/3WMc5?s=edit"; }
                else if (comboBox1.Text == "Bing")
                { testString = "http://www.bing.com"; valueID = "sb_form_q"; }

                System.Uri uri = new System.Uri(testString);
                webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(PrintDocument);
                //webBrowser1.Url = uri;
                webBrowser1.Navigate(uri);

                // From: http://stackoverflow.com/questions/1598780/c-sharp-pass-string-to-textbox-in-web-page-using-the-webbrowser-control
                //HtmlDocument doc = this.webBrowser1.Document;
                //doc.GetElementById("FromEMail").SetAttribute("value", emailAddress);


                //HtmlElement txt = webBrowser1.Document.GetElementById(valueID);
                //txt.SetAttribute("value", emailAddress);

                // From: http://www.dreamincode.net/forums/topic/128015-getting-text-in-textboxin-webbrowser-control/
                //if(webBrowser1.DocumentCompleted == true)
                //HtmlDocument objWbDoc = webBrowser1.Document;
                //HtmlElement hElTextBox = objWbDoc.GetElementById(valueID);
                //string txt = hElTextBox.GetAttribute(emailAddress);

            }
        }

            private void PrintDocument(object sender,
    WebBrowserDocumentCompletedEventArgs e)
            {
            //MessageBox.Show("Document completed!");
            //string valueID = "FromEMail";
            //string emailAddress = "the";

            HtmlElement txt = webBrowser1.Document.GetElementById(valueID);
            txt.SetAttribute("value", emailAddress);
            }


    }


    }
    
