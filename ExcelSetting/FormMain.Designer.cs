namespace ExcelSetting
{
    partial class FormMain
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
            this.btnExcelTargetPath = new System.Windows.Forms.Button();
            this.tbTargetExcelPath = new System.Windows.Forms.TextBox();
            this.lbExcelPath = new System.Windows.Forms.Label();
            this.openFileExcelTarget = new System.Windows.Forms.OpenFileDialog();
            this.lbOriginCell1 = new System.Windows.Forms.Label();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTargetColumn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.chbIsNewCode = new System.Windows.Forms.CheckBox();
            this.btnFormCode = new System.Windows.Forms.Button();
            this.tbChangeCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOriginCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.tbWorkSheet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbWorkSheetName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllColumn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcelTargetPath
            // 
            this.btnExcelTargetPath.Location = new System.Drawing.Point(284, 32);
            this.btnExcelTargetPath.Name = "btnExcelTargetPath";
            this.btnExcelTargetPath.Size = new System.Drawing.Size(75, 23);
            this.btnExcelTargetPath.TabIndex = 0;
            this.btnExcelTargetPath.Text = "選擇位置";
            this.btnExcelTargetPath.UseVisualStyleBackColor = true;
            this.btnExcelTargetPath.Click += new System.EventHandler(this.btnExcelTargetPath_Click);
            // 
            // tbTargetExcelPath
            // 
            this.tbTargetExcelPath.Location = new System.Drawing.Point(40, 34);
            this.tbTargetExcelPath.Name = "tbTargetExcelPath";
            this.tbTargetExcelPath.Size = new System.Drawing.Size(238, 22);
            this.tbTargetExcelPath.TabIndex = 1;
            // 
            // lbExcelPath
            // 
            this.lbExcelPath.AutoSize = true;
            this.lbExcelPath.ForeColor = System.Drawing.Color.Firebrick;
            this.lbExcelPath.Location = new System.Drawing.Point(38, 19);
            this.lbExcelPath.Name = "lbExcelPath";
            this.lbExcelPath.Size = new System.Drawing.Size(79, 12);
            this.lbExcelPath.TabIndex = 2;
            this.lbExcelPath.Text = "Excel檔案位置";
            // 
            // openFileExcelTarget
            // 
            this.openFileExcelTarget.FileName = "openFileDialog1";
            this.openFileExcelTarget.Filter = "Excel|*.xlsx";
            // 
            // lbOriginCell1
            // 
            this.lbOriginCell1.AutoSize = true;
            this.lbOriginCell1.Location = new System.Drawing.Point(29, 58);
            this.lbOriginCell1.Name = "lbOriginCell1";
            this.lbOriginCell1.Size = new System.Drawing.Size(59, 12);
            this.lbOriginCell1.TabIndex = 6;
            this.lbOriginCell1.Text = "原本Range";
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(100, 55);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(76, 22);
            this.tbRange.TabIndex = 7;
            this.tbRange.Text = "A2:A263064";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "參照Excel位置寫法。ex : A1:B99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "目標Column";
            // 
            // tbTargetColumn
            // 
            this.tbTargetColumn.Location = new System.Drawing.Point(102, 83);
            this.tbTargetColumn.Name = "tbTargetColumn";
            this.tbTargetColumn.Size = new System.Drawing.Size(74, 22);
            this.tbTargetColumn.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCode);
            this.groupBox1.Controls.Add(this.chbIsNewCode);
            this.groupBox1.Controls.Add(this.btnFormCode);
            this.groupBox1.Controls.Add(this.tbChangeCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbOriginCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(53, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "對照代碼設定";
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(257, 106);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(75, 23);
            this.btnCode.TabIndex = 20;
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // chbIsNewCode
            // 
            this.chbIsNewCode.AutoSize = true;
            this.chbIsNewCode.Location = new System.Drawing.Point(25, 85);
            this.chbIsNewCode.Name = "chbIsNewCode";
            this.chbIsNewCode.Size = new System.Drawing.Size(156, 16);
            this.chbIsNewCode.TabIndex = 19;
            this.chbIsNewCode.Text = "以現在代碼做為新的對照";
            this.chbIsNewCode.UseVisualStyleBackColor = true;
            // 
            // btnFormCode
            // 
            this.btnFormCode.Location = new System.Drawing.Point(21, 107);
            this.btnFormCode.Name = "btnFormCode";
            this.btnFormCode.Size = new System.Drawing.Size(75, 22);
            this.btnFormCode.TabIndex = 17;
            this.btnFormCode.Text = "代碼設定";
            this.btnFormCode.UseVisualStyleBackColor = true;
            this.btnFormCode.Click += new System.EventHandler(this.btnFormCode_Click);
            // 
            // tbChangeCode
            // 
            this.tbChangeCode.Location = new System.Drawing.Point(152, 49);
            this.tbChangeCode.Name = "tbChangeCode";
            this.tbChangeCode.Size = new System.Drawing.Size(77, 22);
            this.tbChangeCode.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "目標Column(轉換代碼)";
            // 
            // tbOriginCode
            // 
            this.tbOriginCode.Location = new System.Drawing.Point(152, 21);
            this.tbOriginCode.Name = "tbOriginCode";
            this.tbOriginCode.Size = new System.Drawing.Size(77, 22);
            this.tbOriginCode.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "目標Column(原本代碼)";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(335, 421);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "執行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // tbWorkSheet
            // 
            this.tbWorkSheet.Location = new System.Drawing.Point(40, 83);
            this.tbWorkSheet.Name = "tbWorkSheet";
            this.tbWorkSheet.Size = new System.Drawing.Size(119, 22);
            this.tbWorkSheet.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(29, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "活頁簿名稱";
            // 
            // tbWorkSheetName
            // 
            this.tbWorkSheetName.Location = new System.Drawing.Point(100, 27);
            this.tbWorkSheetName.Name = "tbWorkSheetName";
            this.tbWorkSheetName.Size = new System.Drawing.Size(76, 22);
            this.tbWorkSheetName.TabIndex = 18;
            this.tbWorkSheetName.Text = "工作表1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(40, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "新活頁簿名稱";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "注意 : 所有Column請輸入英文對應的數字";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAllColumn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbWorkSheetName);
            this.groupBox2.Controls.Add(this.lbOriginCell1);
            this.groupBox2.Controls.Add(this.tbRange);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbTargetColumn);
            this.groupBox2.Location = new System.Drawing.Point(53, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 138);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轉換代碼設定";
            // 
            // btnAllColumn
            // 
            this.btnAllColumn.Location = new System.Drawing.Point(257, 109);
            this.btnAllColumn.Name = "btnAllColumn";
            this.btnAllColumn.Size = new System.Drawing.Size(75, 23);
            this.btnAllColumn.TabIndex = 19;
            this.btnAllColumn.UseVisualStyleBackColor = true;
            this.btnAllColumn.Click += new System.EventHandler(this.btnAllColumn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "執行前請先將欲轉換 Excel 檔案關閉";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "儲存設定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(336, 83);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 24;
            this.btnDefault.Text = "還原設定";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 456);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbWorkSheet);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbExcelPath);
            this.Controls.Add(this.tbTargetExcelPath);
            this.Controls.Add(this.btnExcelTargetPath);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcelTargetPath;
        private System.Windows.Forms.TextBox tbTargetExcelPath;
        private System.Windows.Forms.Label lbExcelPath;
        private System.Windows.Forms.OpenFileDialog openFileExcelTarget;
        private System.Windows.Forms.Label lbOriginCell1;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTargetColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFormCode;
        private System.Windows.Forms.TextBox tbChangeCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOriginCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox tbWorkSheet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbWorkSheetName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbIsNewCode;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnAllColumn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDefault;
    }
}

