using System;
using System.Globalization;
using System.Windows.Forms;
using ApkUtil;

namespace ApkReader
{
    public partial class FrmMain : Form
    {
        private Reader _reader;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _reader = new Reader();
        }

        private void btnExplorer_Click(object sender, EventArgs e)
        {
            if (ofdApk.ShowDialog(this) != DialogResult.OK) return;
            try
            {
                ApkInfo info = _reader.GetApkInfo(ofdApk.FileName);
                ReadInfo(info);
                txtApk.Text = ofdApk.FileName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, exception.Message, @"失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadInfo(ApkInfo info)
        {
            dgvMain.Rows.Clear();
            AddRow("应用名称", info.ApplicationLabel);
            AddRow("主图标", info.ApplicationIcon);
            AddRow("图标总数", info.ApplicationIcons.Count.ToString(CultureInfo.InvariantCulture));
            AddRow("包名", info.PackageName);
            AddRow("内部版本号", info.VersionCode);
            AddRow("外部版本号", info.VersionName);
            AddRow("SDK版本", info.SdkVersion);
            AddRow("目标SDK版本", info.TargetSdkVersion);
            AddRow("所需权限数量", info.UsesPermissions.Count.ToString(CultureInfo.InvariantCulture));
            AddRow("启动界面", info.LaunchableActivity);
        }

        private void AddRow(String item, String value)
        {
            DataGridViewRow row = dgvMain.Rows[dgvMain.Rows.Add()];
            row.Cells[colItem.Index].Value = item;
            row.Cells[colValue.Index].Value = value;
        }


    }
}