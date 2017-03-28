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
            this.manualInputCheck.Location = new System.Drawing.Point(384, 37);
            this.manualInputCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manualInputCheck.Name = "manualInputCheck";
            this.manualInputCheck.Size = new System.Drawing.Size(107, 21);
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
            this.phoneOsLabel.Location = new System.Drawing.Point(12, 11);
            this.phoneOsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneOsLabel.Name = "phoneOsLabel";
            this.phoneOsLabel.Size = new System.Drawing.Size(185, 20);
            this.phoneOsLabel.TabIndex = 4;
            this.phoneOsLabel.Text = "Select your phone\'s OS";
            // 
            // manualInputLabel
            // 
            this.manualInputLabel.AutoSize = true;
            this.manualInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualInputLabel.Location = new System.Drawing.Point(335, 11);
            this.manualInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manualInputLabel.Name = "manualInputLabel";
            this.manualInputLabel.Size = new System.Drawing.Size(156, 20);
            this.manualInputLabel.TabIndex = 5;
            this.manualInputLabel.Text = "Or enter it manually";
            // 
            // ttlBox
            // 
            this.ttlBox.Location = new System.Drawing.Point(76, 68);
            this.ttlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ttlBox.MaxLength = 3;
            this.ttlBox.Name = "ttlBox";
            this.ttlBox.ReadOnly = true;
            this.ttlBox.Size = new System.Drawing.Size(132, 22);
            this.ttlBox.TabIndex = 6;
            this.ttlBox.Text = "64";
            this.ttlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttlBox_KeyPress);
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLabel.Location = new System.Drawing.Point(16, 69);
            this.ttlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(39, 20);
            this.ttlLabel.TabIndex = 7;
            this.ttlLabel.Text = "TTL";
            // 
            // patchButton
            // 
            this.patchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.patchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patchButton.Location = new System.Drawing.Point(0, 136);
            this.patchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(512, 62);
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
            "IOS"});
            this.selectOS.Location = new System.Drawing.Point(16, 34);
            this.selectOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectOS.Name = "selectOS";
            this.selectOS.Size = new System.Drawing.Size(192, 24);
            this.selectOS.TabIndex = 9;
            this.selectOS.SelectedIndexChanged += new System.EventHandler(this.selectOS_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 198);
            this.Controls.Add(this.selectOS);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.ttlLabel);
            this.Controls.Add(this.ttlBox);
            this.Controls.Add(this.manualInputLabel);
            this.Controls.Add(this.phoneOsLabel);
            this.Controls.Add(this.manualInputCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

