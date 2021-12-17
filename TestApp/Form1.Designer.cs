namespace TestApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxAccountType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxTransactionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banking App";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter Transaction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(356, 319);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(17, 23);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "?";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account:";
            // 
            // boxAccountType
            // 
            this.boxAccountType.FormattingEnabled = true;
            this.boxAccountType.Items.AddRange(new object[] {
            "Everyday",
            "Investment",
            "Omni"});
            this.boxAccountType.Location = new System.Drawing.Point(427, 121);
            this.boxAccountType.Name = "boxAccountType";
            this.boxAccountType.Size = new System.Drawing.Size(121, 21);
            this.boxAccountType.TabIndex = 5;
            this.boxAccountType.SelectedIndexChanged += new System.EventHandler(this.boxAccountType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transaction:";
            // 
            // boxTransactionType
            // 
            this.boxTransactionType.FormattingEnabled = true;
            this.boxTransactionType.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal"});
            this.boxTransactionType.Location = new System.Drawing.Point(427, 188);
            this.boxTransactionType.Name = "boxTransactionType";
            this.boxTransactionType.Size = new System.Drawing.Size(121, 21);
            this.boxTransactionType.TabIndex = 7;
            this.boxTransactionType.SelectedIndexChanged += new System.EventHandler(this.boxTransactionType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Value:";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(427, 247);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(121, 20);
            this.valueInput.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(647, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Staff Account";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 517);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxTransactionType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxAccountType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxAccountType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxTransactionType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

