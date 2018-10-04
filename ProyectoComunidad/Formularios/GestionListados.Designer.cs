namespace ProyectoComunidad.Formularios
{
    partial class GestionListados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Fincas");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Propietarios");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sistema", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mayor Finca Entre Fecha", 0, 0);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ingresos Propietarios Entre Fechas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Situacion");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gestion", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionListados));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFechaFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFechaInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClienteFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClienteInicial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(481, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "A Fecha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxFechaFinal
            // 
            this.textBoxFechaFinal.Enabled = false;
            this.textBoxFechaFinal.Location = new System.Drawing.Point(475, 296);
            this.textBoxFechaFinal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxFechaFinal.Name = "textBoxFechaFinal";
            this.textBoxFechaFinal.Size = new System.Drawing.Size(85, 23);
            this.textBoxFechaFinal.TabIndex = 64;
            this.textBoxFechaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFechaFinal.TextChanged += new System.EventHandler(this.textBoxFechaFinal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(361, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "De Fecha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxFechaInicial
            // 
            this.textBoxFechaInicial.Enabled = false;
            this.textBoxFechaInicial.Location = new System.Drawing.Point(364, 296);
            this.textBoxFechaInicial.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxFechaInicial.Name = "textBoxFechaInicial";
            this.textBoxFechaInicial.Size = new System.Drawing.Size(85, 23);
            this.textBoxFechaInicial.TabIndex = 62;
            this.textBoxFechaInicial.Text = "12/12/2018";
            this.textBoxFechaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxFechaInicial.TextChanged += new System.EventHandler(this.textBoxFechaInicial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(361, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "A Finca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxClienteFinal
            // 
            this.textBoxClienteFinal.Enabled = false;
            this.textBoxClienteFinal.Location = new System.Drawing.Point(360, 214);
            this.textBoxClienteFinal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxClienteFinal.Name = "textBoxClienteFinal";
            this.textBoxClienteFinal.Size = new System.Drawing.Size(200, 23);
            this.textBoxClienteFinal.TabIndex = 60;
            this.textBoxClienteFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxClienteFinal.TextChanged += new System.EventHandler(this.textBoxClienteFinal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(357, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "De Finca";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxClienteInicial
            // 
            this.textBoxClienteInicial.Enabled = false;
            this.textBoxClienteInicial.Location = new System.Drawing.Point(360, 162);
            this.textBoxClienteInicial.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxClienteInicial.Name = "textBoxClienteInicial";
            this.textBoxClienteInicial.Size = new System.Drawing.Size(200, 23);
            this.textBoxClienteInicial.TabIndex = 58;
            this.textBoxClienteInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxClienteInicial.TextChanged += new System.EventHandler(this.textBoxClienteInicial_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(216, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 42);
            this.label9.TabIndex = 57;
            this.label9.Text = "Listados";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(37, 117);
            this.treeView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Fincas";
            treeNode1.Text = "Fincas";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Propietarios";
            treeNode2.Text = "Propietarios";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "Sistema";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Sistema";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Mayor";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Mayor Finca Entre Fecha";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Ingresos";
            treeNode5.Text = "Ingresos Propietarios Entre Fechas";
            treeNode6.Name = "Situacion";
            treeNode6.Text = "Situacion";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "Gestion";
            treeNode7.SelectedImageIndex = 1;
            treeNode7.Text = "Gestion";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(286, 231);
            this.treeView1.TabIndex = 56;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(83, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 60);
            this.button1.TabIndex = 69;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Location = new System.Drawing.Point(316, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 60);
            this.button2.TabIndex = 68;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(612, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFechaFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFechaInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClienteFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClienteInicial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionListados";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionListados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFechaFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFechaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClienteFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClienteInicial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}