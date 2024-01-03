namespace cadastro
{
    public partial class Form1 : Form
    {
        private bool mousedown;

        public Form1()
        {



            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mousedown = true;

            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);

            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Lê todos os dados do arquivo
            string filePath = "logins.txt";
            string[] logins = System.IO.File.ReadAllLines(filePath);

            bool loggedIn = false;

            // Verifica se o nome de usuário e senha correspondem aos dados lidos
            foreach (string loginData in logins)
            {
                string[] parts = loginData.Split(':');

                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    loggedIn = true;
                    break;
                }
            }

            if (loggedIn)
            {
                MessageBox.Show("Login bem-sucedido!");
                // Faça aqui o redirecionamento para o próximo formulário, ocultando este

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos.");
            }
        
    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Verifica se os campos não estão vazios
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Salva os dados em um arquivo de texto (append)
                string filePath = "logins.txt";
                string loginData = $"{username}:{password}";

                System.IO.File.AppendAllText(filePath, loginData + Environment.NewLine);

                MessageBox.Show("Registro concluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }
    }
}


