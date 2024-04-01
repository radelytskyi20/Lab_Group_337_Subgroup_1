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
            toolTip1 = new ToolTip(components);
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1664, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, contextToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(116, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // contextToolStripMenuItem
            // 
            contextToolStripMenuItem.Name = "contextToolStripMenuItem";
            contextToolStripMenuItem.Size = new Size(116, 22);
            contextToolStripMenuItem.Text = "Context";
            // 
            // clientsGridView
            // 
            clientsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsGridView.Location = new Point(10, 50);
            clientsGridView.Margin = new Padding(3, 2, 3, 2);
            clientsGridView.Name = "clientsGridView";
            clientsGridView.RowHeadersWidth = 51;
            clientsGridView.RowTemplate.Height = 29;
            clientsGridView.Size = new Size(1643, 172);
            clientsGridView.TabIndex = 1;
            toolTip1.SetToolTip(clientsGridView, "Цей компонент відображає інформацію про клієнтів біржі з бази даних. Використовуйте цю таблицю для перегляду даних про клієнтів, їхні угоди та інші важливі деталі.");
            // 
            // AddClientButton
            // 
            AddClientButton.Location = new Point(10, 233);
            AddClientButton.Margin = new Padding(3, 2, 3, 2);
            AddClientButton.Name = "AddClientButton";
            AddClientButton.Size = new Size(82, 22);
            AddClientButton.TabIndex = 2;
            AddClientButton.Text = "Add";
            toolTip1.SetToolTip(AddClientButton, "Додати клієнта");
            AddClientButton.UseVisualStyleBackColor = true;
            AddClientButton.Click += AddClientButton_Click;
            // 
            // btnClientsFirst
            // 
            btnClientsFirst.Location = new Point(453, 233);
            btnClientsFirst.Margin = new Padding(3, 2, 3, 2);
            btnClientsFirst.Name = "btnClientsFirst";
            btnClientsFirst.Size = new Size(82, 22);
            btnClientsFirst.TabIndex = 3;
            btnClientsFirst.Text = "First";
            toolTip1.SetToolTip(btnClientsFirst, "Перший запис");
            btnClientsFirst.UseVisualStyleBackColor = true;
            btnClientsFirst.Click += btnClientsFirst_Click;
            // 
            // btnClientsPrevious
            // 
            btnClientsPrevious.Location = new Point(541, 233);
            btnClientsPrevious.Margin = new Padding(3, 2, 3, 2);
            btnClientsPrevious.Name = "btnClientsPrevious";
            btnClientsPrevious.Size = new Size(82, 22);
            btnClientsPrevious.TabIndex = 4;
            btnClientsPrevious.Text = "Previous";
            toolTip1.SetToolTip(btnClientsPrevious, "Попередній запис");
            btnClientsPrevious.UseVisualStyleBackColor = true;
            btnClientsPrevious.Click += btnClientsPrevious_Click;
            // 
            // btnClientsNext
            // 
            btnClientsNext.Location = new Point(628, 233);
            btnClientsNext.Margin = new Padding(3, 2, 3, 2);
            btnClientsNext.Name = "btnClientsNext";
            btnClientsNext.Size = new Size(82, 22);
            btnClientsNext.TabIndex = 5;
            btnClientsNext.Text = "Next";
            toolTip1.SetToolTip(btnClientsNext, "Наступний запис");
            btnClientsNext.UseVisualStyleBackColor = true;
            btnClientsNext.Click += btnClientsNext_Click;
            // 
            // btnClientsLast
            // 
            btnClientsLast.Location = new Point(716, 233);
            btnClientsLast.Margin = new Padding(3, 2, 3, 2);
            btnClientsLast.Name = "btnClientsLast";
            btnClientsLast.Size = new Size(82, 22);
            btnClientsLast.TabIndex = 6;
            btnClientsLast.Text = "Last";
            toolTip1.SetToolTip(btnClientsLast, "Останній запис");
            btnClientsLast.UseVisualStyleBackColor = true;
            btnClientsLast.Click += btnClientsLast_Click;
            // 
            // btnClientsUpdate
            // 
            btnClientsUpdate.Location = new Point(97, 233);
            btnClientsUpdate.Margin = new Padding(3, 2, 3, 2);
            btnClientsUpdate.Name = "btnClientsUpdate";
            btnClientsUpdate.Size = new Size(82, 22);
            btnClientsUpdate.TabIndex = 7;
            btnClientsUpdate.Text = "Update";
            toolTip1.SetToolTip(btnClientsUpdate, "Оновити клієнта");
            btnClientsUpdate.UseVisualStyleBackColor = true;
            btnClientsUpdate.Click += btnClientsUpdate_Click;
            // 
            // btnClinetsDelete
            // 
            btnClinetsDelete.Location = new Point(185, 233);
            btnClinetsDelete.Margin = new Padding(3, 2, 3, 2);
            btnClinetsDelete.Name = "btnClinetsDelete";
            btnClinetsDelete.Size = new Size(82, 22);
            btnClinetsDelete.TabIndex = 8;
            btnClinetsDelete.Text = "Delete";
            toolTip1.SetToolTip(btnClinetsDelete, "Видалити клієнта");
            btnClinetsDelete.UseVisualStyleBackColor = true;
            btnClinetsDelete.Click += btnClinetsDelete_Click;
            // 
            // holdingsGridView
            // 
            holdingsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            holdingsGridView.Location = new Point(10, 286);
            holdingsGridView.Margin = new Padding(3, 2, 3, 2);
            holdingsGridView.Name = "holdingsGridView";
            holdingsGridView.RowHeadersWidth = 51;
            holdingsGridView.RowTemplate.Height = 29;
            holdingsGridView.Size = new Size(1643, 172);
            holdingsGridView.TabIndex = 9;
            toolTip1.SetToolTip(holdingsGridView, "Цей компонент показує акції, які утримує клієнт. Він відображає інформацію про назву акції, кількість одиниць та інші важливі деталі.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 10;
            label1.Text = "Clients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 269);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 11;
            label2.Text = "Holdings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 498);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Masters";
            // 
            // mastersGridView
            // 
            mastersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mastersGridView.Location = new Point(10, 515);
            mastersGridView.Margin = new Padding(3, 2, 3, 2);
            mastersGridView.Name = "mastersGridView";
            mastersGridView.RowHeadersWidth = 51;
            mastersGridView.RowTemplate.Height = 29;
            mastersGridView.Size = new Size(1643, 172);
            mastersGridView.TabIndex = 13;
            toolTip1.SetToolTip(mastersGridView, "Цей компонент показує загальний перелік акцій, які доступні на біржі. Ви можете переглядати інформацію про різні компанії, їхні ціни, зміни та інші важливі деталі.");
            // 
            // btnAddHolding
            // 
            btnAddHolding.Location = new Point(10, 463);
            btnAddHolding.Margin = new Padding(3, 2, 3, 2);
            btnAddHolding.Name = "btnAddHolding";
            btnAddHolding.Size = new Size(82, 22);
            btnAddHolding.TabIndex = 14;
            btnAddHolding.Text = "Add";
            toolTip1.SetToolTip(btnAddHolding, "Додати вклад");
            btnAddHolding.UseVisualStyleBackColor = true;
            btnAddHolding.Click += btnAddHolding_Click;
            // 
            // btnUpdateHolding
            // 
            btnUpdateHolding.Location = new Point(98, 463);
            btnUpdateHolding.Margin = new Padding(3, 2, 3, 2);
            btnUpdateHolding.Name = "btnUpdateHolding";
            btnUpdateHolding.Size = new Size(82, 22);
            btnUpdateHolding.TabIndex = 15;
            btnUpdateHolding.Text = "Update";
            toolTip1.SetToolTip(btnUpdateHolding, "Оновити інформацію про вклад");
            btnUpdateHolding.UseVisualStyleBackColor = true;
            btnUpdateHolding.Click += btnUpdateHolding_Click;
            // 
            // btnDeleteHolding
            // 
            btnDeleteHolding.Location = new Point(185, 463);
            btnDeleteHolding.Margin = new Padding(3, 2, 3, 2);
            btnDeleteHolding.Name = "btnDeleteHolding";
            btnDeleteHolding.Size = new Size(82, 22);
            btnDeleteHolding.TabIndex = 16;
            btnDeleteHolding.Text = "Delete";
            toolTip1.SetToolTip(btnDeleteHolding, "Видалити вклад");
            btnDeleteHolding.UseVisualStyleBackColor = true;
            btnDeleteHolding.Click += btnDeleteHolding_Click;
            // 
            // btnHoldingsLast
            // 
            btnHoldingsLast.Location = new Point(716, 463);
            btnHoldingsLast.Margin = new Padding(3, 2, 3, 2);
            btnHoldingsLast.Name = "btnHoldingsLast";
            btnHoldingsLast.Size = new Size(82, 22);
            btnHoldingsLast.TabIndex = 20;
            btnHoldingsLast.Text = "Last";
            toolTip1.SetToolTip(btnHoldingsLast, "Останній запис");
            btnHoldingsLast.UseVisualStyleBackColor = true;
            btnHoldingsLast.Click += btnHoldingsLast_Click;
            // 
            // btnHoldingsNext
            // 
            btnHoldingsNext.Location = new Point(628, 463);
            btnHoldingsNext.Margin = new Padding(3, 2, 3, 2);
            btnHoldingsNext.Name = "btnHoldingsNext";
            btnHoldingsNext.Size = new Size(82, 22);
            btnHoldingsNext.TabIndex = 19;
            btnHoldingsNext.Text = "Next";
            toolTip1.SetToolTip(btnHoldingsNext, "Наступний запис");
            btnHoldingsNext.UseVisualStyleBackColor = true;
            btnHoldingsNext.Click += btnHoldingsNext_Click;
            // 
            // btnHoldingsPrevious
            // 
            btnHoldingsPrevious.Location = new Point(541, 463);
            btnHoldingsPrevious.Margin = new Padding(3, 2, 3, 2);
            btnHoldingsPrevious.Name = "btnHoldingsPrevious";
            btnHoldingsPrevious.Size = new Size(82, 22);
            btnHoldingsPrevious.TabIndex = 18;
            btnHoldingsPrevious.Text = "Previous";
            toolTip1.SetToolTip(btnHoldingsPrevious, "Попередній запис");
            btnHoldingsPrevious.UseVisualStyleBackColor = true;
            btnHoldingsPrevious.Click += btnHoldingsPrevious_Click;
            // 
            // btnHoldingsFirst
            // 
            btnHoldingsFirst.Location = new Point(453, 463);
            btnHoldingsFirst.Margin = new Padding(3, 2, 3, 2);
            btnHoldingsFirst.Name = "btnHoldingsFirst";
            btnHoldingsFirst.Size = new Size(82, 22);
            btnHoldingsFirst.TabIndex = 17;
            btnHoldingsFirst.Text = "First";
            toolTip1.SetToolTip(btnHoldingsFirst, "Перший запис");
            btnHoldingsFirst.UseVisualStyleBackColor = true;
            btnHoldingsFirst.Click += btnHoldingsFirst_Click;
            // 
            // btnMastersLast
            // 
            btnMastersLast.Location = new Point(715, 692);
            btnMastersLast.Margin = new Padding(3, 2, 3, 2);
            btnMastersLast.Name = "btnMastersLast";
            btnMastersLast.Size = new Size(82, 22);
            btnMastersLast.TabIndex = 27;
            btnMastersLast.Text = "Last";
            toolTip1.SetToolTip(btnMastersLast, "Останній запис");
            btnMastersLast.UseVisualStyleBackColor = true;
            btnMastersLast.Click += btnMastersLast_Click;
            // 
            // btnMastersNext
            // 
            btnMastersNext.Location = new Point(627, 692);
            btnMastersNext.Margin = new Padding(3, 2, 3, 2);
            btnMastersNext.Name = "btnMastersNext";
            btnMastersNext.Size = new Size(82, 22);
            btnMastersNext.TabIndex = 26;
            btnMastersNext.Text = "Next";
            toolTip1.SetToolTip(btnMastersNext, "Наступний запис");
            btnMastersNext.UseVisualStyleBackColor = true;
            btnMastersNext.Click += btnMastersNext_Click;
            // 
            // btnMastersPrevious
            // 
            btnMastersPrevious.Location = new Point(540, 692);
            btnMastersPrevious.Margin = new Padding(3, 2, 3, 2);
            btnMastersPrevious.Name = "btnMastersPrevious";
            btnMastersPrevious.Size = new Size(82, 22);
            btnMastersPrevious.TabIndex = 25;
            btnMastersPrevious.Text = "Previous";
            toolTip1.SetToolTip(btnMastersPrevious, "Попередній запис");
            btnMastersPrevious.UseVisualStyleBackColor = true;
            btnMastersPrevious.Click += btnMastersPrevious_Click;
            // 
            // btnMastersFirst
            // 
            btnMastersFirst.Location = new Point(452, 692);
            btnMastersFirst.Margin = new Padding(3, 2, 3, 2);
            btnMastersFirst.Name = "btnMastersFirst";
            btnMastersFirst.Size = new Size(82, 22);
            btnMastersFirst.TabIndex = 24;
            btnMastersFirst.Text = "First";
            toolTip1.SetToolTip(btnMastersFirst, "Перший запис");
            btnMastersFirst.UseVisualStyleBackColor = true;
            btnMastersFirst.Click += btnMastersFirst_Click;
            // 
            // btnDeleteMaster
            // 
            btnDeleteMaster.Location = new Point(184, 692);
            btnDeleteMaster.Margin = new Padding(3, 2, 3, 2);
            btnDeleteMaster.Name = "btnDeleteMaster";
            btnDeleteMaster.Size = new Size(82, 22);
            btnDeleteMaster.TabIndex = 23;
            btnDeleteMaster.Text = "Delete";
            toolTip1.SetToolTip(btnDeleteMaster, "Видалити акцію");
            btnDeleteMaster.UseVisualStyleBackColor = true;
            btnDeleteMaster.Click += btnDeleteMaster_Click;
            // 
            // btnUpdateMaster
            // 
            btnUpdateMaster.Location = new Point(97, 692);
            btnUpdateMaster.Margin = new Padding(3, 2, 3, 2);
            btnUpdateMaster.Name = "btnUpdateMaster";
            btnUpdateMaster.Size = new Size(82, 22);
            btnUpdateMaster.TabIndex = 22;
            btnUpdateMaster.Text = "Update";
            toolTip1.SetToolTip(btnUpdateMaster, "Оновити акцію");
            btnUpdateMaster.UseVisualStyleBackColor = true;
            btnUpdateMaster.Click += btnUpdateMaster_Click;
            // 
            // btnAddMaster
            // 
            btnAddMaster.Location = new Point(10, 692);
            btnAddMaster.Margin = new Padding(3, 2, 3, 2);
            btnAddMaster.Name = "btnAddMaster";
            btnAddMaster.Size = new Size(82, 22);
            btnAddMaster.TabIndex = 21;
            btnAddMaster.Text = "Add";
            toolTip1.SetToolTip(btnAddMaster, "Додати акцію");
            btnAddMaster.UseVisualStyleBackColor = true;
            btnAddMaster.Click += btnAddMaster_Click;
            // 
            // btnAllMasters
            // 
            btnAllMasters.Location = new Point(271, 692);
            btnAllMasters.Margin = new Padding(3, 2, 3, 2);
            btnAllMasters.Name = "btnAllMasters";
            btnAllMasters.Size = new Size(82, 22);
            btnAllMasters.TabIndex = 28;
            btnAllMasters.Text = "All";
            toolTip1.SetToolTip(btnAllMasters, "Усі акції");
            btnAllMasters.UseVisualStyleBackColor = true;
            btnAllMasters.Click += btnAllMasters_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ShowAlways = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 782);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolTip toolTip1;
    }
}
