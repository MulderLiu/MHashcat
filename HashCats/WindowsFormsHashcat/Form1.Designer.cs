namespace WindowsFormsHashcat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ConvertToHccapx = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnDele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(22, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(190, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // ConvertToHccapx
            // 
            this.ConvertToHccapx.Location = new System.Drawing.Point(299, 12);
            this.ConvertToHccapx.Name = "ConvertToHccapx";
            this.ConvertToHccapx.Size = new System.Drawing.Size(118, 23);
            this.ConvertToHccapx.TabIndex = 2;
            this.ConvertToHccapx.Text = "ConvertToHccapx";
            this.ConvertToHccapx.UseVisualStyleBackColor = true;
            this.ConvertToHccapx.Click += new System.EventHandler(this.ConvertToHccapx_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(22, 55);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(395, 300);
            this.txtResult.TabIndex = 3;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(449, 12);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDir.TabIndex = 4;
            this.btnOpenDir.Text = "打开";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(449, 55);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(308, 308);
            this.checkedListBox.Sorted = true;
            this.checkedListBox.TabIndex = 5;
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(763, 67);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(30, 23);
            this.btnDele.TabIndex = 6;
            this.btnDele.Text = "X";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 387);
            this.Controls.Add(this.btnDele);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.ConvertToHccapx);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button ConvertToHccapx;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnDele;
    }
}

