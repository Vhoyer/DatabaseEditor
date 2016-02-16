namespace DatabaseEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColAdd = new System.Windows.Forms.Button();
            this.txtColAdd = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.btnAddtable = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slavarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.recenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carregandoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Enabled = false;
            this.dgv1.Location = new System.Drawing.Point(12, 86);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(411, 353);
            this.dgv1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColAdd);
            this.groupBox1.Controls.Add(this.txtColAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "add Column";
            // 
            // btnColAdd
            // 
            this.btnColAdd.Enabled = false;
            this.btnColAdd.Location = new System.Drawing.Point(126, 18);
            this.btnColAdd.Name = "btnColAdd";
            this.btnColAdd.Size = new System.Drawing.Size(75, 23);
            this.btnColAdd.TabIndex = 1;
            this.btnColAdd.Text = "Add Col";
            this.btnColAdd.UseVisualStyleBackColor = true;
            this.btnColAdd.Click += new System.EventHandler(this.btnColAdd_Click);
            // 
            // txtColAdd
            // 
            this.txtColAdd.Enabled = false;
            this.txtColAdd.Location = new System.Drawing.Point(7, 20);
            this.txtColAdd.Name = "txtColAdd";
            this.txtColAdd.Size = new System.Drawing.Size(113, 20);
            this.txtColAdd.TabIndex = 0;
            this.txtColAdd.Enter += new System.EventHandler(this.txtColAdd_Enter);
            // 
            // cb1
            // 
            this.cb1.Enabled = false;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(87, 20);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(105, 21);
            this.cb1.TabIndex = 9;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            this.cb1.Enter += new System.EventHandler(this.cb1_Enter);
            // 
            // btnAddtable
            // 
            this.btnAddtable.Enabled = false;
            this.btnAddtable.Location = new System.Drawing.Point(6, 18);
            this.btnAddtable.Name = "btnAddtable";
            this.btnAddtable.Size = new System.Drawing.Size(75, 23);
            this.btnAddtable.TabIndex = 10;
            this.btnAddtable.Text = "Add Table";
            this.btnAddtable.UseVisualStyleBackColor = true;
            this.btnAddtable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.slavarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.recenteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.criarToolStripMenuItem.Text = "New...";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.tsmiCriar_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.abrirToolStripMenuItem.Text = "Open...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.tsmiAbrir_Click);
            // 
            // slavarToolStripMenuItem
            // 
            this.slavarToolStripMenuItem.Name = "slavarToolStripMenuItem";
            this.slavarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.slavarToolStripMenuItem.Text = "Save";
            this.slavarToolStripMenuItem.Click += new System.EventHandler(this.tsmiSalvar_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.salvarComoToolStripMenuItem.Text = "Save as...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.tsmiSalvarComo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // recenteToolStripMenuItem
            // 
            this.recenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carregandoToolStripMenuItem});
            this.recenteToolStripMenuItem.Name = "recenteToolStripMenuItem";
            this.recenteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.recenteToolStripMenuItem.Text = "Recent";
            this.recenteToolStripMenuItem.MouseEnter += new System.EventHandler(this.tsmiRecente_MouseEnter);
            // 
            // carregandoToolStripMenuItem
            // 
            this.carregandoToolStripMenuItem.Name = "carregandoToolStripMenuItem";
            this.carregandoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.carregandoToolStripMenuItem.Text = "Loading...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sairToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newColumnToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // newColumnToolStripMenuItem
            // 
            this.newColumnToolStripMenuItem.Name = "newColumnToolStripMenuItem";
            this.newColumnToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newColumnToolStripMenuItem.Text = "New Column...";
            this.newColumnToolStripMenuItem.Click += new System.EventHandler(this.tsmiNewColumn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddtable);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Location = new System.Drawing.Point(225, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "add Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Database Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColAdd;
        private System.Windows.Forms.TextBox txtColAdd;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button btnAddtable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slavarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carregandoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

