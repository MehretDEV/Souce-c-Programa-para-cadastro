using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // URL do convite do servidor do Discord
            string conviteDiscord = "https://discord.gg/sCx6xJCK"; // Substitua "seuCodigoDeConvite" pelo código real

            // Abre a URL no navegador padrão
            Process.Start(conviteDiscord);
        }
    }
    }

