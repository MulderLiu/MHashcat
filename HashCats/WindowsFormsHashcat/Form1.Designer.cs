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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChoseCap = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ConvertToHccapx = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.btnDele = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOneFile = new System.Windows.Forms.Button();
            this.txtSaveDir = new System.Windows.Forms.TextBox();
            this.groupBoxHccapx = new System.Windows.Forms.GroupBox();
            this.groupBoxCap = new System.Windows.Forms.GroupBox();
            this.ToolStip = new System.Windows.Forms.ToolStrip();
            this.tpCap = new System.Windows.Forms.ToolStripButton();
            this.tpHccapx = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtHc = new System.Windows.Forms.TextBox();
            this.groupBoxHccapx.SuspendLayout();
            this.groupBoxCap.SuspendLayout();
            this.ToolStip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoseCap
            // 
            this.btnChoseCap.Location = new System.Drawing.Point(15, 20);
            this.btnChoseCap.Name = "btnChoseCap";
            this.btnChoseCap.Size = new System.Drawing.Size(88, 23);
            this.btnChoseCap.TabIndex = 0;
            this.btnChoseCap.Text = "打开cap文件";
            this.btnChoseCap.UseVisualStyleBackColor = true;
            this.btnChoseCap.Click += new System.EventHandler(this.btnChoseCap_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(15, 49);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(383, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // ConvertToHccapx
            // 
            this.ConvertToHccapx.Location = new System.Drawing.Point(113, 20);
            this.ConvertToHccapx.Name = "ConvertToHccapx";
            this.ConvertToHccapx.Size = new System.Drawing.Size(118, 23);
            this.ConvertToHccapx.TabIndex = 2;
            this.ConvertToHccapx.Text = "ConvertToHccapx";
            this.ConvertToHccapx.UseVisualStyleBackColor = true;
            this.ConvertToHccapx.Click += new System.EventHandler(this.ConvertToHccapx_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 76);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(387, 404);
            this.txtResult.TabIndex = 3;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(15, 20);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(156, 23);
            this.btnOpenDir.TabIndex = 4;
            this.btnOpenDir.Text = "设置hccapx文件保存位置";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(15, 76);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(333, 196);
            this.checkedListBox.Sorted = true;
            this.checkedListBox.TabIndex = 5;
            // 
            // btnDele
            // 
            this.btnDele.Location = new System.Drawing.Point(354, 124);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(46, 23);
            this.btnDele.TabIndex = 6;
            this.btnDele.Text = "删除";
            this.btnDele.UseVisualStyleBackColor = true;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(354, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOneFile
            // 
            this.btnOneFile.Location = new System.Drawing.Point(235, 20);
            this.btnOneFile.Name = "btnOneFile";
            this.btnOneFile.Size = new System.Drawing.Size(101, 23);
            this.btnOneFile.TabIndex = 8;
            this.btnOneFile.Text = "合并成一个文件";
            this.btnOneFile.UseVisualStyleBackColor = true;
            this.btnOneFile.Click += new System.EventHandler(this.btnOneFile_Click);
            // 
            // txtSaveDir
            // 
            this.txtSaveDir.Location = new System.Drawing.Point(15, 49);
            this.txtSaveDir.Name = "txtSaveDir";
            this.txtSaveDir.Size = new System.Drawing.Size(333, 21);
            this.txtSaveDir.TabIndex = 9;
            // 
            // groupBoxHccapx
            // 
            this.groupBoxHccapx.Controls.Add(this.txtHc);
            this.groupBoxHccapx.Controls.Add(this.checkedListBox);
            this.groupBoxHccapx.Controls.Add(this.btnOpenDir);
            this.groupBoxHccapx.Controls.Add(this.btnOneFile);
            this.groupBoxHccapx.Controls.Add(this.btnAdd);
            this.groupBoxHccapx.Controls.Add(this.txtSaveDir);
            this.groupBoxHccapx.Controls.Add(this.btnDele);
            this.groupBoxHccapx.Location = new System.Drawing.Point(6, 13);
            this.groupBoxHccapx.Name = "groupBoxHccapx";
            this.groupBoxHccapx.Size = new System.Drawing.Size(413, 486);
            this.groupBoxHccapx.TabIndex = 10;
            this.groupBoxHccapx.TabStop = false;
            this.groupBoxHccapx.Text = "合并hccapx";
            // 
            // groupBoxCap
            // 
            this.groupBoxCap.Controls.Add(this.txtResult);
            this.groupBoxCap.Controls.Add(this.btnChoseCap);
            this.groupBoxCap.Controls.Add(this.txtFilePath);
            this.groupBoxCap.Controls.Add(this.ConvertToHccapx);
            this.groupBoxCap.Location = new System.Drawing.Point(6, 13);
            this.groupBoxCap.Name = "groupBoxCap";
            this.groupBoxCap.Size = new System.Drawing.Size(408, 486);
            this.groupBoxCap.TabIndex = 6;
            this.groupBoxCap.TabStop = false;
            this.groupBoxCap.Text = "cap转换为hccapx";
            // 
            // ToolStip
            // 
            this.ToolStip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tpCap,
            this.tpHccapx});
            this.ToolStip.Location = new System.Drawing.Point(0, 0);
            this.ToolStip.Name = "ToolStip";
            this.ToolStip.Size = new System.Drawing.Size(913, 25);
            this.ToolStip.TabIndex = 11;
            this.ToolStip.Text = "toolStrip1";
            this.ToolStip.Visible = false;
            // 
            // tpCap
            // 
            this.tpCap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tpCap.Image = ((System.Drawing.Image)(resources.GetObject("tpCap.Image")));
            this.tpCap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpCap.Name = "tpCap";
            this.tpCap.Size = new System.Drawing.Size(97, 22);
            this.tpCap.Text = "cap转换hccapx";
            this.tpCap.Click += new System.EventHandler(this.tpCap_Click);
            // 
            // tpHccapx
            // 
            this.tpHccapx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tpHccapx.Image = ((System.Drawing.Image)(resources.GetObject("tpHccapx.Image")));
            this.tpHccapx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tpHccapx.Name = "tpHccapx";
            this.tpHccapx.Size = new System.Drawing.Size(100, 22);
            this.tpHccapx.Text = "多个hccapx合并";
            this.tpHccapx.Click += new System.EventHandler(this.tpHccapx_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 531);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxCap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "cap转换为hccapx";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxHccapx);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "合并hccapx";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtHc
            // 
            this.txtHc.Location = new System.Drawing.Point(13, 281);
            this.txtHc.Multiline = true;
            this.txtHc.Name = "txtHc";
            this.txtHc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHc.Size = new System.Drawing.Size(387, 199);
            this.txtHc.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ToolStip);
            this.Name = "Form1";
            this.Text = "MHashcat";
            this.groupBoxHccapx.ResumeLayout(false);
            this.groupBoxHccapx.PerformLayout();
            this.groupBoxCap.ResumeLayout(false);
            this.groupBoxCap.PerformLayout();
            this.ToolStip.ResumeLayout(false);
            this.ToolStip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoseCap;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button ConvertToHccapx;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOneFile;
        private System.Windows.Forms.TextBox txtSaveDir;
        private System.Windows.Forms.GroupBox groupBoxHccapx;
        private System.Windows.Forms.GroupBox groupBoxCap;
        private System.Windows.Forms.ToolStrip ToolStip;
        private System.Windows.Forms.ToolStripButton tpCap;
        private System.Windows.Forms.ToolStripButton tpHccapx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtHc;
    }
}

