namespace Integrador
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelResultado = new Label();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.BackColor = SystemColors.Control;
            btnOperar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOperar.Location = new Point(20, 199);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(133, 50);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "OPERAR";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.Control;
            btnLimpiar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(183, 199);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(133, 50);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Control;
            btnCerrar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Location = new Point(346, 199);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(133, 50);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 7;
            textBox1.TabIndexChanged += FormCalculadora_Load_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(183, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 128);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 4;
            label1.Text = "Primer Operando:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(206, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 5;
            label2.Text = "Operando:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(339, 128);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 6;
            label3.Text = "Segundo Operando:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultado.Location = new Point(12, 29);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(120, 27);
            labelResultado.TabIndex = 0;
            labelResultado.Text = "Resultado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 80);
            label5.Name = "label5";
            label5.Size = new Size(208, 21);
            label5.TabIndex = 1;
            label5.Text = "Representar Resultado en:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(11, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "DECIMAL";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(109, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 19);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "BINARIO";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(230, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 40);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 269);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Alumno: Tobias Suarez";
            FormClosing += FormCalculadora_FormClosing;
            Load += FormCalculadora_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelResultado;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
    }
}