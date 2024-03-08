namespace WinForms.Client
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            contextToolStripMenuItem = new ToolStripMenuItem();
            clientsGridView = new DataGridView();
            AddClientButton = new Button();
            clientsBindingSource = new BindingSource(components);
            btnClientsFirst = new Button();
            btnClientsPrevious = new Button();
            btnClientsNext = new Button();
            btnClientsLast = new Button();
            btnClientsUpdate = new Button();
            btnClinetsDelete = new Button();
            holdingsGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mastersGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)holdingsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mastersGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, contextToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(143, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // contextToolStripMenuItem
            // 
            contextToolStripMenuItem.Name = "contextToolStripMenuItem";
            contextToolStripMenuItem.Size = new Size(143, 26);
            contextToolStripMenuItem.Text = "Context";
            // 
            // clientsGridView
            // 
            clientsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsGridView.Location = new Point(12, 66);
            clientsGridView.Name = "clientsGridView";
            clientsGridView.RowHeadersWidth = 51;
            clientsGridView.RowTemplate.Height = 29;
            clientsGridView.Size = new Size(1878, 229);
            clientsGridView.TabIndex = 1;
            // 
            // AddClientButton
            // 
            AddClientButton.Location = new Point(11, 311);
            AddClientButton.Name = "AddClientButton";
            AddClientButton.Size = new Size(94, 29);
            AddClientButton.TabIndex = 2;
            AddClientButton.Text = "Add";
            AddClientButton.UseVisualStyleBackColor = true;
            AddClientButton.Click += AddClientButton_Click;
            // 
            // btnClientsFirst
            // 
            btnClientsFirst.Location = new Point(518, 311);
            btnClientsFirst.Name = "btnClientsFirst";
            btnClientsFirst.Size = new Size(94, 29);
            btnClientsFirst.TabIndex = 3;
            btnClientsFirst.Text = "First";
            btnClientsFirst.UseVisualStyleBackColor = true;
            btnClientsFirst.Click += btnClientsFirst_Click;
            // 
            // btnClientsPrevious
            // 
            btnClientsPrevious.Location = new Point(618, 311);
            btnClientsPrevious.Name = "btnClientsPrevious";
            btnClientsPrevious.Size = new Size(94, 29);
            btnClientsPrevious.TabIndex = 4;
            btnClientsPrevious.Text = "Previous";
            btnClientsPrevious.UseVisualStyleBackColor = true;
            btnClientsPrevious.Click += btnClientsPrevious_Click;
            // 
            // btnClientsNext
            // 
            btnClientsNext.Location = new Point(718, 311);
            btnClientsNext.Name = "btnClientsNext";
            btnClientsNext.Size = new Size(94, 29);
            btnClientsNext.TabIndex = 5;
            btnClientsNext.Text = "Next";
            btnClientsNext.UseVisualStyleBackColor = true;
            btnClientsNext.Click += btnClientsNext_Click;
            // 
            // btnClientsLast
            // 
            btnClientsLast.Location = new Point(818, 311);
            btnClientsLast.Name = "btnClientsLast";
            btnClientsLast.Size = new Size(94, 29);
            btnClientsLast.TabIndex = 6;
            btnClientsLast.Text = "Last";
            btnClientsLast.UseVisualStyleBackColor = true;
            btnClientsLast.Click += btnClientsLast_Click;
            // 
            // btnClientsUpdate
            // 
            btnClientsUpdate.Location = new Point(111, 311);
            btnClientsUpdate.Name = "btnClientsUpdate";
            btnClientsUpdate.Size = new Size(94, 29);
            btnClientsUpdate.TabIndex = 7;
            btnClientsUpdate.Text = "Update";
            btnClientsUpdate.UseVisualStyleBackColor = true;
            btnClientsUpdate.Click += btnClientsUpdate_Click;
            // 
            // btnClinetsDelete
            // 
            btnClinetsDelete.Location = new Point(211, 311);
            btnClinetsDelete.Name = "btnClinetsDelete";
            btnClinetsDelete.Size = new Size(94, 29);
            btnClinetsDelete.TabIndex = 8;
            btnClinetsDelete.Text = "Delete";
            btnClinetsDelete.UseVisualStyleBackColor = true;
            btnClinetsDelete.Click += btnClinetsDelete_Click;
            // 
            // holdingsGridView
            // 
            holdingsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            holdingsGridView.Location = new Point(11, 382);
            holdingsGridView.Name = "holdingsGridView";
            holdingsGridView.RowHeadersWidth = 51;
            holdingsGridView.RowTemplate.Height = 29;
            holdingsGridView.Size = new Size(1878, 229);
            holdingsGridView.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 10;
            label1.Text = "Clients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 359);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 11;
            label2.Text = "Holdings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 724);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 12;
            label3.Text = "Masters";
            // 
            // mastersGridView
            // 
            mastersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mastersGridView.Location = new Point(11, 747);
            mastersGridView.Name = "mastersGridView";
            mastersGridView.RowHeadersWidth = 51;
            mastersGridView.RowTemplate.Height = 29;
            mastersGridView.Size = new Size(1878, 229);
            mastersGridView.TabIndex = 13;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1042);
            Controls.Add(mastersGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(holdingsGridView);
            Controls.Add(btnClinetsDelete);
            Controls.Add(btnClientsUpdate);
            Controls.Add(btnClientsLast);
            Controls.Add(btnClientsNext);
            Controls.Add(btnClientsPrevious);
            Controls.Add(btnClientsFirst);
            Controls.Add(AddClientButton);
            Controls.Add(clientsGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)holdingsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)mastersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem contextToolStripMenuItem;
        private DataGridView clientsGridView;
        private Button AddClientButton;
        private BindingSource clientsBindingSource;
        private Button btnClientsFirst;
        private Button btnClientsPrevious;
        private Button btnClientsNext;
        private Button btnClientsLast;
        private Button btnClientsUpdate;
        private Button btnClinetsDelete;
        private DataGridView holdingsGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView mastersGridView;
    }
}
