namespace WinForms.Client
{
    partial class AddHolding
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
            label1 = new Label();
            comboBoxAcctNbr = new ComboBox();
            label2 = new Label();
            comboBoxSymbol = new ComboBox();
            label3 = new Label();
            textBoxShares = new TextBox();
            label4 = new Label();
            textBoxPurPrice = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "AcctNbr";
            // 
            // comboBoxAcctNbr
            // 
            comboBoxAcctNbr.FormattingEnabled = true;
            comboBoxAcctNbr.Location = new Point(10, 24);
            comboBoxAcctNbr.Margin = new Padding(3, 2, 3, 2);
            comboBoxAcctNbr.Name = "comboBoxAcctNbr";
            comboBoxAcctNbr.Size = new Size(133, 23);
            comboBoxAcctNbr.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 7);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Symbol";
            // 
            // comboBoxSymbol
            // 
            comboBoxSymbol.FormattingEnabled = true;
            comboBoxSymbol.Location = new Point(178, 24);
            comboBoxSymbol.Margin = new Padding(3, 2, 3, 2);
            comboBoxSymbol.Name = "comboBoxSymbol";
            comboBoxSymbol.Size = new Size(133, 23);
            comboBoxSymbol.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 67);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Shares";
            // 
            // textBoxShares
            // 
            textBoxShares.Location = new Point(10, 84);
            textBoxShares.Margin = new Padding(3, 2, 3, 2);
            textBoxShares.Name = "textBoxShares";
            textBoxShares.Size = new Size(110, 23);
            textBoxShares.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 67);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "PurPrice";
            // 
            // textBoxPurPrice
            // 
            textBoxPurPrice.Location = new Point(154, 84);
            textBoxPurPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxPurPrice.Name = "textBoxPurPrice";
            textBoxPurPrice.Size = new Size(110, 23);
            textBoxPurPrice.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 67);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 8;
            label5.Text = "PurDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(299, 84);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 125);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(516, 22);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(10, 152);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(516, 22);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AddHolding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 182);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBoxPurPrice);
            Controls.Add(label4);
            Controls.Add(textBoxShares);
            Controls.Add(label3);
            Controls.Add(comboBoxSymbol);
            Controls.Add(label2);
            Controls.Add(comboBoxAcctNbr);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddHolding";
            Text = "AddHolding";
            Load += AddHolding_Load;
            HelpRequested += AddHolding_HelpRequested;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxAcctNbr;
        private Label label2;
        private ComboBox comboBoxSymbol;
        private Label label3;
        private TextBox textBoxShares;
        private Label label4;
        private TextBox textBoxPurPrice;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button btnAdd;
        private Button btnExit;
    }
}