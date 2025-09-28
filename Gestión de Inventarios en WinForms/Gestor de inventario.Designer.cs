namespace Gestión_de_Inventarios_en_WinForms
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            this.btnMovimientos = new Button();
            btnProductos = new Button();
            btnCategorías = new Button();
            bindingSource1 = new BindingSource(components);
            panel7 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(this.btnMovimientos);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnCategorías);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 97);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Walmart_spark__2025__svg;
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Location = new Point(12, 270);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new Size(101, 49);
            this.btnMovimientos.TabIndex = 2;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(12, 194);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(101, 45);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnCategorías
            // 
            btnCategorías.Location = new Point(12, 125);
            btnCategorías.Name = "btnCategorías";
            btnCategorías.Size = new Size(101, 45);
            btnCategorías.TabIndex = 0;
            btnCategorías.Text = "Categorías";
            btnCategorías.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLight;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel3);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(137, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(677, 450);
            panel7.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Location = new Point(56, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 154);
            panel3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button btnProductos;
        private Button btnCategorías;
        private Panel panel2;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private Panel panel7;
        private Panel panel3;
    }
}
