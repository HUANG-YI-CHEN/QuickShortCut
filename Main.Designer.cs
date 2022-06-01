
namespace QuickShortCut
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TB_SRC = new System.Windows.Forms.TextBox();
            this.LB_OS_TYPE = new System.Windows.Forms.Label();
            this.TB_OS_TYPE = new System.Windows.Forms.TextBox();
            this.TB_OS_BIT = new System.Windows.Forms.TextBox();
            this.LB_OS_BIT = new System.Windows.Forms.Label();
            this.BTN_SRC = new System.Windows.Forms.Button();
            this.BTN_CREATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.RDB_Single = new System.Windows.Forms.RadioButton();
            this.RDB_Multiple = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TB_SRC
            // 
            this.TB_SRC.AllowDrop = true;
            this.TB_SRC.Location = new System.Drawing.Point(90, 64);
            this.TB_SRC.Margin = new System.Windows.Forms.Padding(4);
            this.TB_SRC.Multiline = true;
            this.TB_SRC.Name = "TB_SRC";
            this.TB_SRC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_SRC.Size = new System.Drawing.Size(269, 41);
            this.TB_SRC.TabIndex = 1;
            // 
            // LB_OS_TYPE
            // 
            this.LB_OS_TYPE.AllowDrop = true;
            this.LB_OS_TYPE.AutoSize = true;
            this.LB_OS_TYPE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LB_OS_TYPE.Cursor = System.Windows.Forms.Cursors.No;
            this.LB_OS_TYPE.Enabled = false;
            this.LB_OS_TYPE.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OS_TYPE.Location = new System.Drawing.Point(11, 14);
            this.LB_OS_TYPE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_OS_TYPE.Name = "LB_OS_TYPE";
            this.LB_OS_TYPE.Size = new System.Drawing.Size(65, 16);
            this.LB_OS_TYPE.TabIndex = 3;
            this.LB_OS_TYPE.Text = "OS_TYPE :";
            this.LB_OS_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_OS_TYPE
            // 
            this.TB_OS_TYPE.AllowDrop = true;
            this.TB_OS_TYPE.BackColor = System.Drawing.SystemColors.Window;
            this.TB_OS_TYPE.Enabled = false;
            this.TB_OS_TYPE.Location = new System.Drawing.Point(90, 11);
            this.TB_OS_TYPE.Margin = new System.Windows.Forms.Padding(4);
            this.TB_OS_TYPE.Name = "TB_OS_TYPE";
            this.TB_OS_TYPE.Size = new System.Drawing.Size(136, 22);
            this.TB_OS_TYPE.TabIndex = 4;
            this.TB_OS_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_OS_BIT
            // 
            this.TB_OS_BIT.AllowDrop = true;
            this.TB_OS_BIT.BackColor = System.Drawing.SystemColors.Window;
            this.TB_OS_BIT.Enabled = false;
            this.TB_OS_BIT.Location = new System.Drawing.Point(294, 11);
            this.TB_OS_BIT.Margin = new System.Windows.Forms.Padding(4);
            this.TB_OS_BIT.Name = "TB_OS_BIT";
            this.TB_OS_BIT.Size = new System.Drawing.Size(63, 22);
            this.TB_OS_BIT.TabIndex = 5;
            this.TB_OS_BIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_OS_BIT
            // 
            this.LB_OS_BIT.AutoSize = true;
            this.LB_OS_BIT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LB_OS_BIT.Enabled = false;
            this.LB_OS_BIT.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OS_BIT.Location = new System.Drawing.Point(234, 14);
            this.LB_OS_BIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_OS_BIT.Name = "LB_OS_BIT";
            this.LB_OS_BIT.Size = new System.Drawing.Size(52, 16);
            this.LB_OS_BIT.TabIndex = 6;
            this.LB_OS_BIT.Text = "OS_Bit :";
            this.LB_OS_BIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_SRC
            // 
            this.BTN_SRC.BackColor = System.Drawing.Color.PowderBlue;
            this.BTN_SRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SRC.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_SRC.Location = new System.Drawing.Point(8, 64);
            this.BTN_SRC.Name = "BTN_SRC";
            this.BTN_SRC.Size = new System.Drawing.Size(75, 41);
            this.BTN_SRC.TabIndex = 7;
            this.BTN_SRC.Text = "OPEN";
            this.BTN_SRC.UseVisualStyleBackColor = false;
            this.BTN_SRC.Click += new System.EventHandler(this.BTN_SRC_Click);
            // 
            // BTN_CREATE
            // 
            this.BTN_CREATE.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_CREATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CREATE.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_CREATE.Location = new System.Drawing.Point(8, 111);
            this.BTN_CREATE.Name = "BTN_CREATE";
            this.BTN_CREATE.Size = new System.Drawing.Size(162, 22);
            this.BTN_CREATE.TabIndex = 8;
            this.BTN_CREATE.Text = "CREATE";
            this.BTN_CREATE.UseVisualStyleBackColor = false;
            this.BTN_CREATE.Click += new System.EventHandler(this.BTN_CREATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.Red;
            this.BTN_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DELETE.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_DELETE.Location = new System.Drawing.Point(190, 111);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(169, 22);
            this.BTN_DELETE.TabIndex = 9;
            this.BTN_DELETE.Text = "DELETE";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // RDB_Single
            // 
            this.RDB_Single.AutoSize = true;
            this.RDB_Single.Location = new System.Drawing.Point(14, 42);
            this.RDB_Single.Name = "RDB_Single";
            this.RDB_Single.Size = new System.Drawing.Size(52, 16);
            this.RDB_Single.TabIndex = 10;
            this.RDB_Single.TabStop = true;
            this.RDB_Single.Text = "Single";
            this.RDB_Single.UseVisualStyleBackColor = true;
            this.RDB_Single.CheckedChanged += new System.EventHandler(this.RDB_Single_CheckedChanged);
            // 
            // RDB_Multiple
            // 
            this.RDB_Multiple.AutoSize = true;
            this.RDB_Multiple.Location = new System.Drawing.Point(72, 42);
            this.RDB_Multiple.Name = "RDB_Multiple";
            this.RDB_Multiple.Size = new System.Drawing.Size(62, 16);
            this.RDB_Multiple.TabIndex = 11;
            this.RDB_Multiple.TabStop = true;
            this.RDB_Multiple.Text = "Multiple";
            this.RDB_Multiple.UseVisualStyleBackColor = true;
            this.RDB_Multiple.CheckedChanged += new System.EventHandler(this.RDB_Multiple_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 145);
            this.Controls.Add(this.RDB_Multiple);
            this.Controls.Add(this.RDB_Single);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.BTN_CREATE);
            this.Controls.Add(this.BTN_SRC);
            this.Controls.Add(this.LB_OS_BIT);
            this.Controls.Add(this.TB_OS_BIT);
            this.Controls.Add(this.TB_OS_TYPE);
            this.Controls.Add(this.LB_OS_TYPE);
            this.Controls.Add(this.TB_SRC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.Text = "QuickShortCut";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox TB_SRC;
        private System.Windows.Forms.Label LB_OS_TYPE;
        private System.Windows.Forms.TextBox TB_OS_TYPE;
        private System.Windows.Forms.TextBox TB_OS_BIT;
        private System.Windows.Forms.Label LB_OS_BIT;
        private System.Windows.Forms.Button BTN_SRC;
        private System.Windows.Forms.Button BTN_CREATE;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.RadioButton RDB_Single;
        private System.Windows.Forms.RadioButton RDB_Multiple;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

