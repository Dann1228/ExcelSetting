using ExcelSetting.Properties;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSetting
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Init();
        }
        private Dictionary<string, int> codeSetting = new Dictionary<string, int>();
        private bool allColumnStatus;
        private bool codeStatus;
        public void DefaultSetting()
        {
            Setting setting = new Setting()
            {
                IsNewCode = true,
                AllColumnStauts = true,
                CodeStatus = true,
                NewWorkSheetName = string.Empty,
                TargetWorkSheetName = string.Empty,
                OriginRange = string.Empty,
                TargetColumn = string.Empty,
                CodeOriginColumn = string.Empty,
                CodeChangeColumn = string.Empty,
            };
            Settings.Default.Setting = JsonConvert.SerializeObject(setting);
            Settings.Default.Save();
        }
        public void Init()
        {
            Setting setting = JsonConvert.DeserializeObject<Setting>(Settings.Default.Setting);
            if (setting == null)
            {
                DefaultSetting();
            }
            InitSetting(setting);
            StatusBtnText();
        }
        private void btnExcelTargetPath_Click(object sender, EventArgs e)
        {
            if (openFileExcelTarget.ShowDialog() == DialogResult.OK)
            {
                this.tbTargetExcelPath.Text = openFileExcelTarget.FileName;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int targetColumn = 0;
            int codeOrigin = 0;
            int codeChange = 0;
            if (!int.TryParse(this.tbTargetColumn.Text,out targetColumn) || !int.TryParse(this.tbOriginCode.Text,out codeOrigin) ||
                !int.TryParse(this.tbChangeCode.Text,out codeChange))
            {
                MessageBox.Show("Column輸入格式錯誤");
            }
            else if (tbWorkSheet.Text != string.Empty && tbTargetExcelPath.Text != string.Empty)
            {
                if (ExecuteExportExcel(targetColumn,codeOrigin,codeChange))
                {
                    MessageBox.Show("匯出成功");
                }
                else
                {
                    MessageBox.Show("匯出失敗");
                }
            }
            else
            {
                MessageBox.Show("請選擇Excel檔案及新增活頁簿名稱");
            }
        }
        public string SetRow(string address)
        {
            int index = 0;
            for (int i=0;i<address.Count() ;i++)
            {
                if (!int.TryParse(address[i].ToString(),out index))
                {
                    address=address.Remove(i,1);
                }
            }
            return address;
        }
        public void SetCode(string companyName)
        {
            if (!codeSetting.ContainsKey(companyName))
            {
                codeSetting.Add(companyName,codeSetting.Count+1 );
            }
        }
        public bool ExecuteExportExcel(int targetColumn ,int codeOrigin,int codeChange)
        {
            bool result = false;
            try
            {           
                var file =new FileInfo(this.tbTargetExcelPath.Text);
                if (file != null)
                {
                    using (ExcelPackage package = new ExcelPackage(file))
                    {                      
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[this.tbWorkSheetName.Text];
                        if (worksheet != null)
                        {                    
                            ExcelWorksheet worksheetTarget = package.Workbook.Worksheets.Copy(tbWorkSheetName.Text, this.tbWorkSheet.Text);
                            if (!this.chbIsNewCode.Checked)
                            {
                                codeSetting = JsonConvert.DeserializeObject<Dictionary< string,int>> (Settings.Default.CodeCompare);
                            }
                            if (allColumnStatus)
                            {
                                foreach (var cell in worksheetTarget.Cells[this.tbRange.Text])
                                {
                                    SetCode(cell.Text);
                                    if (tbTargetColumn.Text != string.Empty)
                                    {
                                        var address = cell.Address;
                                        worksheetTarget.Cells[int.Parse(SetRow(address)),targetColumn].Value = codeSetting[cell.Text];
                                    }
                                }
                            }                          
                            if (codeStatus)
                            {
                                int codeRow = 2;
                                foreach (var code in codeSetting)
                                {
                                    worksheetTarget.Cells[codeRow, codeOrigin].Value = code.Key;
                                    worksheetTarget.Cells[codeRow, codeChange].Value = code.Value;
                                    codeRow++;
                                }
                            }
                            package.Save();
                            result = true;
                        }
                    }
                }              
            }   
            catch (Exception ex)
            {
                MessageBox.Show("錯誤訊息:\n"+ex);
            }
            if (result)
            {
                Settings.Default.CodeCompare = JsonConvert.SerializeObject(codeSetting);
            }
            return result;
        }
        public void ChangeStatus(ref bool status)
        {
            status = !status;
            StatusBtnText();
        }
        public void StatusBtnText()
        {
            this.btnAllColumn.Text = allColumnStatus ?ConstValue.STATUSTEXT_ENABLE:ConstValue.STATUSTEXT_UNENABLE;
            this.btnCode.Text = codeStatus ?ConstValue.STATUSTEXT_ENABLE:ConstValue.STATUSTEXT_UNENABLE;
        }
        public void InitSetting(Setting setting)
        {
            this.chbIsNewCode.Checked = setting.IsNewCode;
            allColumnStatus = setting.AllColumnStauts;
            codeStatus = setting.CodeStatus;
            this.tbWorkSheet.Text = setting.NewWorkSheetName;
            this.tbWorkSheetName.Text = setting.TargetWorkSheetName;
            tbRange.Text = setting.OriginRange;
            tbTargetColumn.Text = setting.TargetColumn;
            this.tbOriginCode.Text = setting.CodeOriginColumn;
            this.tbChangeCode.Text = setting.CodeChangeColumn;
        }
        public void SaveSetting()
        {
            Setting setting = new Setting()
            {
                IsNewCode = this.chbIsNewCode.Checked,
                AllColumnStauts = allColumnStatus,
                CodeStatus = codeStatus,
                NewWorkSheetName = this.tbWorkSheet.Text ,
                TargetWorkSheetName = this.tbWorkSheetName.Text,
                OriginRange = this.tbRange.Text,
                TargetColumn = this.tbTargetColumn.Text,
                CodeOriginColumn = this.tbOriginCode.Text,
                CodeChangeColumn = this.tbChangeCode.Text,
            };
            Settings.Default.Setting = JsonConvert.SerializeObject(setting);
            Settings.Default.Save();
        }
        private void btnFormCode_Click(object sender, EventArgs e)
        {
            FormCode form = new FormCode();
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSetting();
            MessageBox.Show("儲存成功");
        }

        private void btnAllColumn_Click(object sender, EventArgs e)
        {
            ChangeStatus(ref allColumnStatus);
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            ChangeStatus(ref codeStatus);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            DefaultSetting();
            Setting setting = JsonConvert.DeserializeObject<Setting>(Settings.Default.Setting);
            InitSetting(setting);
            StatusBtnText();
        }
    }
}
