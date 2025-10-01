namespace Gestión_de_categorías_de_productos
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            PRODUCTOS = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, NOMBRE, PRODUCTOS, ESTADO });
            dataGridView1.Location = new Point(44, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 395);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "Nombre de la categoría";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            // 
            // PRODUCTOS
            // 
            PRODUCTOS.HeaderText = "Productos asociados";
            PRODUCTOS.Name = "PRODUCTOS";
            PRODUCTOS.ReadOnly = true;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "Estado";
            ESTADO.Name = "ESTADO";
            ESTADO.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(522, 59);
            button1.Name = "button1";
            button1.Size = new Size(236, 96);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(522, 166);
            button2.Name = "button2";
            button2.Size = new Size(236, 82);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PRODUCTOS;
        private DataGridViewTextBoxColumn ESTADO;
        private Button button1;
        private Button button2;
    }
}
