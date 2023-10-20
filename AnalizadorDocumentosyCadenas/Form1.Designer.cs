namespace AnalizadorDocumentosyCadenas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtExpresion = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            textRuta = new TextBox();
            txtContenido = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 64);
            label1.Name = "label1";
            label1.Size = new Size(236, 26);
            label1.TabIndex = 0;
            label1.Text = "Escribe una expresion";
            // 
            // txtExpresion
            // 
            txtExpresion.BorderStyle = BorderStyle.FixedSingle;
            txtExpresion.Location = new Point(327, 50);
            txtExpresion.Multiline = true;
            txtExpresion.Name = "txtExpresion";
            txtExpresion.Size = new Size(502, 53);
            txtExpresion.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(70, 135);
            button1.Name = "button1";
            button1.Size = new Size(105, 50);
            button1.TabIndex = 2;
            button1.Text = "Analizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(221, 136);
            button2.Name = "button2";
            button2.Size = new Size(107, 49);
            button2.TabIndex = 3;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(371, 135);
            button3.Name = "button3";
            button3.Size = new Size(107, 49);
            button3.TabIndex = 4;
            button3.Text = "Examinar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(408, 259);
            dataGridView1.TabIndex = 5;
            // 
            // textRuta
            // 
            textRuta.BorderStyle = BorderStyle.FixedSingle;
            textRuta.Location = new Point(503, 135);
            textRuta.Multiline = true;
            textRuta.Name = "textRuta";
            textRuta.Size = new Size(326, 49);
            textRuta.TabIndex = 6;
            textRuta.TextChanged += textBox2_TextChanged;
            // 
            // txtContenido
            // 
            txtContenido.BackColor = Color.FromArgb(255, 128, 128);
            txtContenido.BorderStyle = BorderStyle.FixedSingle;
            txtContenido.Location = new Point(503, 214);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(326, 259);
            txtContenido.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(897, 516);
            Controls.Add(txtContenido);
            Controls.Add(textRuta);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtExpresion);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ANALIZADOR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtExpresion;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textRuta;
        private TextBox txtContenido;
        private OpenFileDialog openFileDialog1;
    }
}