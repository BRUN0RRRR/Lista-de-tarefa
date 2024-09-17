namespace Lista_de_tarefa
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
            ent_tarefa = new TextBox();
            btnadicionar = new Button();
            lista = new ListBox();
            bntexcluir = new Button();
            btnlimpar = new Button();
            label1 = new Label();
            btneditar = new Button();
            SuspendLayout();
            // 
            // ent_tarefa
            // 
            ent_tarefa.Location = new Point(125, 10);
            ent_tarefa.Name = "ent_tarefa";
            ent_tarefa.Size = new Size(439, 23);
            ent_tarefa.TabIndex = 0;
            // 
            // btnadicionar
            // 
            btnadicionar.Location = new Point(125, 50);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(75, 23);
            btnadicionar.TabIndex = 1;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += button1_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 79);
            lista.Name = "lista";
            lista.Size = new Size(552, 199);
            lista.TabIndex = 2;
            // 
            // bntexcluir
            // 
            bntexcluir.Location = new Point(206, 50);
            bntexcluir.Name = "bntexcluir";
            bntexcluir.Size = new Size(75, 23);
            bntexcluir.TabIndex = 3;
            bntexcluir.Text = "Excluir";
            bntexcluir.UseVisualStyleBackColor = true;
            bntexcluir.Click += button2_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(287, 50);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(75, 23);
            btnlimpar.TabIndex = 4;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 5;
            label1.Text = "Entre com a Tarefa";
            // 
            // btneditar
            // 
            btneditar.Location = new Point(368, 50);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 6;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 292);
            Controls.Add(btneditar);
            Controls.Add(label1);
            Controls.Add(btnlimpar);
            Controls.Add(bntexcluir);
            Controls.Add(lista);
            Controls.Add(btnadicionar);
            Controls.Add(ent_tarefa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ent_tarefa;
        private Button btnadicionar;
        private ListBox lista;
        private Button bntexcluir;
        private Button btnlimpar;
        private Label label1;
        private Button btneditar;
    }
}
