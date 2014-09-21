namespace ApkReader
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApk = new System.Windows.Forms.Label();
            this.txtApk = new System.Windows.Forms.TextBox();
            this.btnExplorer = new System.Windows.Forms.Button();
            this.ofdApk = new System.Windows.Forms.OpenFileDialog();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApk
            // 
            this.lblApk.AutoSize = true;
            this.lblApk.Location = new System.Drawing.Point(9, 18);
            this.lblApk.Name = "lblApk";
            this.lblApk.Size = new System.Drawing.Size(34, 17);
            this.lblApk.TabIndex = 0;
            this.lblApk.Text = "APK:";
            // 
            // txtApk
            // 
            this.txtApk.Location = new System.Drawing.Point(50, 14);
            this.txtApk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApk.Name = "txtApk";
            this.txtApk.ReadOnly = true;
            this.txtApk.Size = new System.Drawing.Size(426, 23);
            this.txtApk.TabIndex = 1;
            // 
            // btnExplorer
            // 
            this.btnExplorer.Location = new System.Drawing.Point(484, 14);
            this.btnExplorer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(87, 23);
            this.btnExplorer.TabIndex = 2;
            this.btnExplorer.Text = "浏览";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // ofdApk
            // 
            this.ofdApk.DefaultExt = "apk";
            this.ofdApk.Filter = "APK 文件|*.apk";
            this.ofdApk.Title = "选择APK文件";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colValue});
            this.dgvMain.Location = new System.Drawing.Point(9, 52);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(560, 258);
            this.dgvMain.TabIndex = 3;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "项目";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.HeaderText = "值";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 321);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnExplorer);
            this.Controls.Add(this.txtApk);
            this.Controls.Add(this.lblApk);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APK详细信息查询 Powered By 小笨猫-LiveFace";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApk;
        private System.Windows.Forms.TextBox txtApk;
        private System.Windows.Forms.Button btnExplorer;
        private System.Windows.Forms.OpenFileDialog ofdApk;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;

    }
}

