using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebReqPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUrlResponse getUrlResponse = new GetUrlResponse();
            WebRequest webRequest = getUrlResponse.MyGetWebRequest(new Uri(textBox1.Text));
            WebResponse response = webRequest.GetResponse();
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            textBox2.Text = responseFromServer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "https://www.w3schools.com/";
        }
    }
}
