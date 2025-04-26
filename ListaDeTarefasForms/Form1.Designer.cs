namespace ListaDeTarefasForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            concluir = new Button();
            checkBox1 = new CheckBox();
            label5 = new Label();
            procurar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(30, 108);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "criar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(30, 43);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "criar tarefa";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(24, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(344, 43);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "procurar tarefa";
            label2.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(561, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 27);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Desktop;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(561, 43);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = " tarefa";
            label3.Click += label1_Click;
            // 
            // concluir
            // 
            concluir.BackColor = SystemColors.Desktop;
            concluir.ForeColor = SystemColors.ButtonHighlight;
            concluir.Location = new Point(561, 108);
            concluir.Name = "concluir";
            concluir.Size = new Size(94, 29);
            concluir.TabIndex = 0;
            concluir.Text = "concluir";
            concluir.UseVisualStyleBackColor = false;
            concluir.Click += concluir_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(537, 75);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 3;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(276, 78);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 2;
            label5.Text = "0";
            label5.Click += label1_Click;
            // 
            // procurar
            // 
            procurar.BackColor = SystemColors.Desktop;
            procurar.ForeColor = SystemColors.ButtonHighlight;
            procurar.Location = new Point(374, 69);
            procurar.Name = "procurar";
            procurar.Size = new Size(94, 29);
            procurar.TabIndex = 0;
            procurar.Text = "procurar";
            procurar.UseVisualStyleBackColor = false;
            procurar.Click += procurar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(800, 149);
            Controls.Add(procurar);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(concluir);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button concluir;
        private CheckBox checkBox1;
        private Label label5;
        private Button procurar;
    }
}
