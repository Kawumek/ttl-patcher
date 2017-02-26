namespace TTL_Patcher
{
    partial class mainForm
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.manualInputCheck = new System.Windows.Forms.CheckBox();
            this.phoneOsLabel = new System.Windows.Forms.Label();
            this.manualInputLabel = new System.Windows.Forms.Label();
            this.ttlBox = new System.Windows.Forms.TextBox();
            this.ttlLabel = new System.Windows.Forms.Label();
            this.patchButton = new System.Windows.Forms.Button();
            this.selectOS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // manualInputCheck
            // 
            this.manualInputCheck.AutoSize = true;
            this.manualInputCheck.Location = new System.Drawing.Point(288, 30);
            this.manualInputCheck.Name = "manualInputCheck";
            this.manualInputCheck.Size = new System.Drawing.Size(84, 17);
            this.manualInputCheck.TabIndex = 2;
            this.manualInputCheck.Text = "Custom TTL";
            this.manualInputCheck.UseVisualStyleBackColor = true;
            this.manualInputCheck.CheckedChanged += new System.EventHandler(this.manualInputCheck_CheckedChanged);
            // 
            // phoneOsLabel
            // 
            this.phoneOsLabel.AutoSize = true;
            this.phoneOsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneOsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneOsLabel.Location = new System.Drawing.Point(9, 9);
            this.phoneOsLabel.Name = "phoneOsLabel";
            this.phoneOsLabel.Size = new System.Drawing.Size(148, 16);
            this.phoneOsLabel.TabIndex = 4;
            this.phoneOsLabel.Text = "Select your phone\'s OS";
            // 
            // manualInputLabel
            // 
            this.manualInputLabel.AutoSize = true;
            this.manualInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualInputLabel.Location = new System.Drawing.Point(251, 9);
            this.manualInputLabel.Name = "manualInputLabel";
            this.manualInputLabel.Size = new System.Drawing.Size(121, 16);
            this.manualInputLabel.TabIndex = 5;
            this.manualInputLabel.Text = "Or enter it manually";
            // 
            // ttlBox
            // 
            this.ttlBox.Location = new System.Drawing.Point(57, 55);
            this.ttlBox.MaxLength = 3;
            this.ttlBox.Name = "ttlBox";
            this.ttlBox.ReadOnly = true;
            this.ttlBox.Size = new System.Drawing.Size(100, 20);
            this.ttlBox.TabIndex = 6;
            this.ttlBox.Text = "64";
            this.ttlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttlBox_KeyPress);
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLabel.Location = new System.Drawing.Point(12, 56);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(33, 16);
            this.ttlLabel.TabIndex = 7;
            this.ttlLabel.Text = "TTL";
            // 
            // patchButton
            // 
            this.patchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchButton.Location = new System.Drawing.Point(0, 111);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(384, 50);
            this.patchButton.TabIndex = 8;
            this.patchButton.Text = "PATCH";
            this.patchButton.UseVisualStyleBackColor = true;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            // 
            // selectOS
            // 
            this.selectOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectOS.FormattingEnabled = true;
            this.selectOS.Items.AddRange(new object[] {
            "Android",
            "IOS",
            "WIndows Phone"});
            this.selectOS.Location = new System.Drawing.Point(12, 28);
            this.selectOS.Name = "selectOS";
            this.selectOS.Size = new System.Drawing.Size(145, 21);
            this.selectOS.TabIndex = 9;
            this.selectOS.SelectedIndexChanged += new System.EventHandler(this.selectOS_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.selectOS);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.ttlLabel);
            this.Controls.Add(this.ttlBox);
            this.Controls.Add(this.manualInputLabel);
            this.Controls.Add(this.phoneOsLabel);
            this.Controls.Add(this.manualInputCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "TTL Patcher by kawumek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.CheckBox manualInputCheck;
        private System.Windows.Forms.Label phoneOsLabel;
        private System.Windows.Forms.Label manualInputLabel;
        private System.Windows.Forms.TextBox ttlBox;
        private System.Windows.Forms.Label ttlLabel;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.ComboBox selectOS;
    }
}

