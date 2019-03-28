using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSetting
{
    public class Setting
    {
        public bool IsNewCode { get; set; }
        public bool AllColumnStauts { get; set; }
        public bool CodeStatus { get; set; }
        public string NewWorkSheetName { get; set; }
        public string TargetWorkSheetName { get; set; }
        public string OriginRange { get; set; }
        public string TargetColumn { get; set; }
        public string CodeOriginColumn { get; set; }
        public string CodeChangeColumn { get; set; }
    }
}
