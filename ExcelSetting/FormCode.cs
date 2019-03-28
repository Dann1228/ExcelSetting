using ExcelSetting.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelSetting
{
    public partial class FormCode : Form
    {
        public FormCode()
        {
            InitializeComponent();
        }
        private Dictionary<string, int> codeSetting = new Dictionary<string, int>();
        private void FormCode_Load(object sender, EventArgs e)
        {
            codeSetting = JsonConvert.DeserializeObject<Dictionary<string,int>>(Settings.Default.CodeCompare);
           
            if (codeSetting != null && codeSetting.Count > 0)
            {
                var dataSource = from c in codeSetting
                                 select new Code { OriginCode = c.Key,ChangeCode=c.Value};
                this.dataGridCode.DataSource = dataSource.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var datas = this.dataGridCode.DataSource;
            Dictionary<string, int> code = new Dictionary<string, int>();

            foreach ( var data in (datas as List<Code>))
            {
                code.Add(data.OriginCode,data.ChangeCode);
            }
            Settings.Default.CodeCompare =JsonConvert.SerializeObject(code);
            Settings.Default.Save();
            this.Close();
        }
    }
}
