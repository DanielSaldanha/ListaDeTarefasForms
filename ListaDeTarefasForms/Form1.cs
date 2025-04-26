using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace ListaDeTarefasForms
{
    public partial class Form1 : Form
    {
        string[] list = new string[10];
        int index = 0;
        int indexArmazenador = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"([a-zA-Z0-9]{3})";
            if (Regex.IsMatch(textBox1.Text, pattern))//impede o codigo caso tenha menos de 3 caracteres
            {

                if (index > 9 || index == 10)
                {
                    label1.Text = "lista cheia";
                }
                else
                {
                    list[index] = textBox1.Text;
                    index++;
                    if (label5.Text == "9") { label5.Text = "9"; }
                    else label5.Text = index.ToString();
                }
            }
            else { MessageBox.Show("isto nao é uma atarefa"); }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void procurar_Click(object sender, EventArgs e)
        {
           
            if(textBox2.Text != null)
            {
                              
                int var = int.Parse(textBox2.Text);
                if (var >= 0 && var <= 9)// impede o codigo caso seja maior que 9 e menor que 0
                {
                    indexArmazenador = var;
                    textBox3.Text = list[var];
                }
                else
                {
                    MessageBox.Show("nao foi possivel encontrar");
                }
                checkBox1_CheckedChanged(checkBox1, EventArgs.Empty);// atualiza o estado da tarefa

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string pattern = @"\b(concluido)\b";
            if (Regex.IsMatch(textBox3.Text, pattern))
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
        private void concluir_Click(object sender, EventArgs e)
        {                  
            string pattern = @"\b(concluido)\b";
            if (Regex.IsMatch(textBox3.Text, pattern))//verifica se a atrefa ja foi concluida
            {
                MessageBox.Show("a tarefa ja foi concluida");
            }
            else
            {
                list[indexArmazenador] += " (concluido)";//adiciona um concluido
                textBox3.Text = list[indexArmazenador];// atualiza o texto da txtBox3               
            }
            checkBox1_CheckedChanged(checkBox1, EventArgs.Empty); // Atualiza o estado da tarefa
        }
    }
}
