namespace WinForms.Client
{
    partial class UpdateHolding
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
            btnExit = new Button();
            btnUpdate = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBoxPurPrice = new TextBox();
            label4 = new Label();
            textBoxShares = new TextBox();
            label3 = new Label();
            comboBoxSymbol = new ComboBox();
            label2 = new Label();
            comboBoxAcctNbr = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(8, 206);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(590, 29);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(8, 171);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(590, 29);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(338, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 93);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 20;
            label5.Text = "PurDate";
            // 
            // textBoxPurPrice
            // 
            textBoxPurPrice.Location = new Point(172, 116);
            textBoxPurPrice.Name = "textBoxPurPrice";
            textBoxPurPrice.Size = new Size(125, 27);
            textBoxPurPrice.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 93);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 18;
            label4.Text = "PurPrice";
            // 
            // textBoxShares
            // 
            textBoxShares.Location = new Point(8, 116);
            textBoxShares.Name = "textBoxShares";
            textBoxShares.Size = new Size(125, 27);
            textBoxShares.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 93);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 16;
            label3.Text = "Shares";
            // 
            // comboBoxSymbol
            // 
            comboBoxSymbol.FormattingEnabled = true;
            comboBoxSymbol.Location = new Point(200, 36);
            comboBoxSymbol.Name = "comboBoxSymbol";
            comboBoxSymbol.Size = new Size(151, 28);
            comboBoxSymbol.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 13);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 14;
            label2.Text = "Symbol";
            // 
            // comboBoxAcctNbr
            // 
            comboBoxAcctNbr.FormattingEnabled = true;
            comboBoxAcctNbr.Location = new Point(8, 36);
            comboBoxAcctNbr.Name = "comboBoxAcctNbr";
            comboBoxAcctNbr.Size = new Size(151, 28);
            comboBoxAcctNbr.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "AcctNbr";
            // 
            // UpdateHolding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 245);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
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
            Name = "UpdateHolding";
            Text = "UpdateHolding";
            Load += UpdateHolding_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnUpdate;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBoxPurPrice;
        private Label label4;
        private TextBox textBoxShares;
        private Label label3;
        private ComboBox comboBoxSymbol;
        private Label label2;
        private ComboBox comboBoxAcctNbr;
        private Label label1;
    }
}