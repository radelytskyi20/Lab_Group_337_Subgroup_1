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
            btnAddHolding = new Button();
            btnUpdateHolding = new Button();
            btnDeleteHolding = new Button();
            btnHoldingsLast = new Button();
            btnHoldingsNext = new Button();
            btnHoldingsPrevious = new Button();
            btnHoldingsFirst = new Button();
            holdingsBindingSource = new BindingSource(components);
            btnMastersLast = new Button();
            btnMastersNext = new Button();
            btnMastersPrevious = new Button();
            btnMastersFirst = new Button();
            btnDeleteMaster = new Button();
            btnUpdateMaster = new Button();
            btnAddMaster = new Button();
            btnAllMasters = new Button();
            mastersBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)holdingsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mastersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)holdingsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mastersBindingSource).BeginInit();
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
            label3.Location = new Point(11, 664);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 12;
            label3.Text = "Masters";
            // 
            // mastersGridView
            // 
            mastersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mastersGridView.Location = new Point(11, 687);
            mastersGridView.Name = "mastersGridView";
            mastersGridView.RowHeadersWidth = 51;
            mastersGridView.RowTemplate.Height = 29;
            mastersGridView.Size = new Size(1878, 229);
            mastersGridView.TabIndex = 13;
            // 
            // btnAddHolding
            // 
            btnAddHolding.Location = new Point(12, 617);
            btnAddHolding.Name = "btnAddHolding";
            btnAddHolding.Size = new Size(94, 29);
            btnAddHolding.TabIndex = 14;
            btnAddHolding.Text = "Add";
            btnAddHolding.UseVisualStyleBackColor = true;
            btnAddHolding.Click += btnAddHolding_Click;
            // 
            // btnUpdateHolding
            // 
            btnUpdateHolding.Location = new Point(112, 617);
            btnUpdateHolding.Name = "btnUpdateHolding";
            btnUpdateHolding.Size = new Size(94, 29);
            btnUpdateHolding.TabIndex = 15;
            btnUpdateHolding.Text = "Update";
            btnUpdateHolding.UseVisualStyleBackColor = true;
            btnUpdateHolding.Click += btnUpdateHolding_Click;
            // 
            // btnDeleteHolding
            // 
            btnDeleteHolding.Location = new Point(211, 617);
            btnDeleteHolding.Name = "btnDeleteHolding";
            btnDeleteHolding.Size = new Size(94, 29);
            btnDeleteHolding.TabIndex = 16;
            btnDeleteHolding.Text = "Delete";
            btnDeleteHolding.UseVisualStyleBackColor = true;
            btnDeleteHolding.Click += btnDeleteHolding_Click;
            // 
            // btnHoldingsLast
            // 
            btnHoldingsLast.Location = new Point(818, 617);
            btnHoldingsLast.Name = "btnHoldingsLast";
            btnHoldingsLast.Size = new Size(94, 29);
            btnHoldingsLast.TabIndex = 20;
            btnHoldingsLast.Text = "Last";
            btnHoldingsLast.UseVisualStyleBackColor = true;
            btnHoldingsLast.Click += btnHoldingsLast_Click;
            // 
            // btnHoldingsNext
            // 
            btnHoldingsNext.Location = new Point(718, 617);
            btnHoldingsNext.Name = "btnHoldingsNext";
            btnHoldingsNext.Size = new Size(94, 29);
            btnHoldingsNext.TabIndex = 19;
            btnHoldingsNext.Text = "Next";
            btnHoldingsNext.UseVisualStyleBackColor = true;
            btnHoldingsNext.Click += btnHoldingsNext_Click;
            // 
            // btnHoldingsPrevious
            // 
            btnHoldingsPrevious.Location = new Point(618, 617);
            btnHoldingsPrevious.Name = "btnHoldingsPrevious";
            btnHoldingsPrevious.Size = new Size(94, 29);
            btnHoldingsPrevious.TabIndex = 18;
            btnHoldingsPrevious.Text = "Previous";
            btnHoldingsPrevious.UseVisualStyleBackColor = true;
            btnHoldingsPrevious.Click += btnHoldingsPrevious_Click;
            // 
            // btnHoldingsFirst
            // 
            btnHoldingsFirst.Location = new Point(518, 617);
            btnHoldingsFirst.Name = "btnHoldingsFirst";
            btnHoldingsFirst.Size = new Size(94, 29);
            btnHoldingsFirst.TabIndex = 17;
            btnHoldingsFirst.Text = "First";
            btnHoldingsFirst.UseVisualStyleBackColor = true;
            btnHoldingsFirst.Click += btnHoldingsFirst_Click;
            // 
            // btnMastersLast
            // 
            btnMastersLast.Location = new Point(817, 922);
            btnMastersLast.Name = "btnMastersLast";
            btnMastersLast.Size = new Size(94, 29);
            btnMastersLast.TabIndex = 27;
            btnMastersLast.Text = "Last";
            btnMastersLast.UseVisualStyleBackColor = true;
            btnMastersLast.Click += btnMastersLast_Click;
            // 
            // btnMastersNext
            // 
            btnMastersNext.Location = new Point(717, 922);
            btnMastersNext.Name = "btnMastersNext";
            btnMastersNext.Size = new Size(94, 29);
            btnMastersNext.TabIndex = 26;
            btnMastersNext.Text = "Next";
            btnMastersNext.UseVisualStyleBackColor = true;
            btnMastersNext.Click += btnMastersNext_Click;
            // 
            // btnMastersPrevious
            // 
            btnMastersPrevious.Location = new Point(617, 922);
            btnMastersPrevious.Name = "btnMastersPrevious";
            btnMastersPrevious.Size = new Size(94, 29);
            btnMastersPrevious.TabIndex = 25;
            btnMastersPrevious.Text = "Previous";
            btnMastersPrevious.UseVisualStyleBackColor = true;
            btnMastersPrevious.Click += btnMastersPrevious_Click;
            // 
            // btnMastersFirst
            // 
            btnMastersFirst.Location = new Point(517, 922);
            btnMastersFirst.Name = "btnMastersFirst";
            btnMastersFirst.Size = new Size(94, 29);
            btnMastersFirst.TabIndex = 24;
            btnMastersFirst.Text = "First";
            btnMastersFirst.UseVisualStyleBackColor = true;
            btnMastersFirst.Click += btnMastersFirst_Click;
            // 
            // btnDeleteMaster
            // 
            btnDeleteMaster.Location = new Point(210, 922);
            btnDeleteMaster.Name = "btnDeleteMaster";
            btnDeleteMaster.Size = new Size(94, 29);
            btnDeleteMaster.TabIndex = 23;
            btnDeleteMaster.Text = "Delete";
            btnDeleteMaster.UseVisualStyleBackColor = true;
            btnDeleteMaster.Click += btnDeleteMaster_Click;
            // 
            // btnUpdateMaster
            // 
            btnUpdateMaster.Location = new Point(111, 922);
            btnUpdateMaster.Name = "btnUpdateMaster";
            btnUpdateMaster.Size = new Size(94, 29);
            btnUpdateMaster.TabIndex = 22;
            btnUpdateMaster.Text = "Update";
            btnUpdateMaster.UseVisualStyleBackColor = true;
            btnUpdateMaster.Click += btnUpdateMaster_Click;
            // 
            // btnAddMaster
            // 
            btnAddMaster.Location = new Point(11, 922);
            btnAddMaster.Name = "btnAddMaster";
            btnAddMaster.Size = new Size(94, 29);
            btnAddMaster.TabIndex = 21;
            btnAddMaster.Text = "Add";
            btnAddMaster.UseVisualStyleBackColor = true;
            btnAddMaster.Click += btnAddMaster_Click;
            // 
            // btnAllMasters
            // 
            btnAllMasters.Location = new Point(310, 922);
            btnAllMasters.Name = "btnAllMasters";
            btnAllMasters.Size = new Size(94, 29);
            btnAllMasters.TabIndex = 28;
            btnAllMasters.Text = "All";
            btnAllMasters.UseVisualStyleBackColor = true;
            btnAllMasters.Click += btnAllMasters_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1042);
            Controls.Add(btnAllMasters);
            Controls.Add(btnMastersLast);
            Controls.Add(btnMastersNext);
            Controls.Add(btnMastersPrevious);
            Controls.Add(btnMastersFirst);
            Controls.Add(btnDeleteMaster);
            Controls.Add(btnUpdateMaster);
            Controls.Add(btnAddMaster);
            Controls.Add(btnHoldingsLast);
            Controls.Add(btnHoldingsNext);
            Controls.Add(btnHoldingsPrevious);
            Controls.Add(btnHoldingsFirst);
            Controls.Add(btnDeleteHolding);
            Controls.Add(btnUpdateHolding);
            Controls.Add(btnAddHolding);
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
            ((System.ComponentModel.ISupportInitialize)holdingsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)mastersBindingSource).EndInit();
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
        private Button btnAddHolding;
        private Button btnUpdateHolding;
        private Button btnDeleteHolding;
        private Button btnHoldingsLast;
        private Button btnHoldingsNext;
        private Button btnHoldingsPrevious;
        private Button btnHoldingsFirst;
        private BindingSource holdingsBindingSource;
        private Button btnMastersLast;
        private Button btnMastersNext;
        private Button btnMastersPrevious;
        private Button btnMastersFirst;
        private Button btnDeleteMaster;
        private Button btnUpdateMaster;
        private Button btnAddMaster;
        private Button btnAllMasters;
        private BindingSource mastersBindingSource;
    }
}
