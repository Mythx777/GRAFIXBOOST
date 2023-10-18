using System;
using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace GRAFIXBOOST
{
    public partial class Form1 : Form
    {
        public object Private { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialização do seu aplicativo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Função para abrir um aplicativo no Windows
            string appName = "C:\\Users\\STRIX\\AppData\\Local\\Programs\\Opera GX"; // O caminho para o executável do Opera GX
           Process.Start("opera-gx.exe");

            
            
         
        }
            };
            
    }

