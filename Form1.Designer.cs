namespace Sort_By_Filename
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_Open = new System.Windows.Forms.CheckBox();
            this.checkBox_Close = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_dirpath = new System.Windows.Forms.Label();
            this.label_text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtn_Makefolder = new System.Windows.Forms.RadioButton();
            this.radiobtn_simple = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_folderload = new System.Windows.Forms.Button();
            this.label_SpecificNumber = new System.Windows.Forms.Label();
            this.textBox_SpecificNumber = new System.Windows.Forms.TextBox();
            this.button_Fileload = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_1000 = new System.Windows.Forms.RadioButton();
            this.rdb_100 = new System.Windows.Forms.RadioButton();
            this.rdb_10 = new System.Windows.Forms.RadioButton();
            this.rdb_No = new System.Windows.Forms.RadioButton();
            this.btn_reloadFloder = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.checkBox_reset = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_lastnumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_SaveFolder = new System.Windows.Forms.Label();
            this.button_SaveTargetFolderSelect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_filename
            // 
            this.tb_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filename.Location = new System.Drawing.Point(29, 470);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(200, 28);
            this.tb_filename.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "변경하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // checkBox_Open
            // 
            this.checkBox_Open.AutoSize = true;
            this.checkBox_Open.Location = new System.Drawing.Point(6, 24);
            this.checkBox_Open.Name = "checkBox_Open";
            this.checkBox_Open.Size = new System.Drawing.Size(144, 19);
            this.checkBox_Open.TabIndex = 3;
            this.checkBox_Open.Text = "변환후 폴더 열기";
            this.checkBox_Open.UseVisualStyleBackColor = true;
            // 
            // checkBox_Close
            // 
            this.checkBox_Close.AutoSize = true;
            this.checkBox_Close.Location = new System.Drawing.Point(6, 50);
            this.checkBox_Close.Name = "checkBox_Close";
            this.checkBox_Close.Size = new System.Drawing.Size(174, 19);
            this.checkBox_Close.TabIndex = 4;
            this.checkBox_Close.Text = "변환후 프로그램 종료";
            this.checkBox_Close.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Open);
            this.groupBox1.Controls.Add(this.checkBox_Close);
            this.groupBox1.Location = new System.Drawing.Point(29, 551);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label_dirpath
            // 
            this.label_dirpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_dirpath.Location = new System.Drawing.Point(33, 119);
            this.label_dirpath.Name = "label_dirpath";
            this.label_dirpath.Size = new System.Drawing.Size(373, 24);
            this.label_dirpath.TabIndex = 6;
            // 
            // label_text1
            // 
            this.label_text1.AutoSize = true;
            this.label_text1.Location = new System.Drawing.Point(30, 101);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(87, 15);
            this.label_text1.TabIndex = 7;
            this.label_text1.Text = "불러올 폴더";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "파일 갯수";
            // 
            // label_count
            // 
            this.label_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_count.Location = new System.Drawing.Point(426, 605);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(70, 22);
            this.label_count.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtn_Makefolder);
            this.groupBox2.Controls.Add(this.radiobtn_simple);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(23, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 94);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모드 선택";
            // 
            // radiobtn_Makefolder
            // 
            this.radiobtn_Makefolder.AutoSize = true;
            this.radiobtn_Makefolder.Location = new System.Drawing.Point(17, 64);
            this.radiobtn_Makefolder.Name = "radiobtn_Makefolder";
            this.radiobtn_Makefolder.Size = new System.Drawing.Size(158, 19);
            this.radiobtn_Makefolder.TabIndex = 16;
            this.radiobtn_Makefolder.TabStop = true;
            this.radiobtn_Makefolder.Text = "폴더 안에 집어넣기";
            this.radiobtn_Makefolder.UseVisualStyleBackColor = true;
            // 
            // radiobtn_simple
            // 
            this.radiobtn_simple.AutoSize = true;
            this.radiobtn_simple.Checked = true;
            this.radiobtn_simple.Location = new System.Drawing.Point(17, 33);
            this.radiobtn_simple.Name = "radiobtn_simple";
            this.radiobtn_simple.Size = new System.Drawing.Size(163, 19);
            this.radiobtn_simple.TabIndex = 11;
            this.radiobtn_simple.TabStop = true;
            this.radiobtn_simple.Text = "단순 이름변경, 정렬";
            this.radiobtn_simple.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "폴더 이름 설정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "확장자 보기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.ItemHeight = 15;
            this.listBox_Files.Location = new System.Drawing.Point(424, 139);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(205, 424);
            this.listBox_Files.TabIndex = 11;
            this.listBox_Files.DoubleClick += new System.EventHandler(this.listBox_Files_DoubleClick);
            //  
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "변경하고자 하는 파일 이름";
            // 
            // button_folderload
            // 
            this.button_folderload.Location = new System.Drawing.Point(137, 43);
            this.button_folderload.Name = "button_folderload";
            this.button_folderload.Size = new System.Drawing.Size(101, 52);
            this.button_folderload.TabIndex = 13;
            this.button_folderload.Text = "폴더\r\n불러오기";
            this.button_folderload.UseVisualStyleBackColor = true;
            this.button_folderload.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label_SpecificNumber
            // 
            this.label_SpecificNumber.AutoSize = true;
            this.label_SpecificNumber.Location = new System.Drawing.Point(140, 525);
            this.label_SpecificNumber.Name = "label_SpecificNumber";
            this.label_SpecificNumber.Size = new System.Drawing.Size(242, 15);
            this.label_SpecificNumber.TabIndex = 15;
            this.label_SpecificNumber.Text = "특정 번호부터 시작 (비우면 1부터)";
            // 
            // textBox_SpecificNumber
            // 
            this.textBox_SpecificNumber.Location = new System.Drawing.Point(29, 519);
            this.textBox_SpecificNumber.Name = "textBox_SpecificNumber";
            this.textBox_SpecificNumber.Size = new System.Drawing.Size(100, 25);
            this.textBox_SpecificNumber.TabIndex = 16;
            // 
            // button_Fileload
            // 
            this.button_Fileload.Location = new System.Drawing.Point(29, 43);
            this.button_Fileload.Name = "button_Fileload";
            this.button_Fileload.Size = new System.Drawing.Size(96, 52);
            this.button_Fileload.TabIndex = 17;
            this.button_Fileload.Text = "파일\r\n불러오기";
            this.button_Fileload.UseVisualStyleBackColor = true;
            this.button_Fileload.Click += new System.EventHandler(this.button_Fileload_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_1000);
            this.groupBox3.Controls.Add(this.rdb_100);
            this.groupBox3.Controls.Add(this.rdb_10);
            this.groupBox3.Controls.Add(this.rdb_No);
            this.groupBox3.Location = new System.Drawing.Point(21, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 73);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "자릿수 설정";
            // 
            // rdb_1000
            // 
            this.rdb_1000.AutoSize = true;
            this.rdb_1000.Location = new System.Drawing.Point(190, 46);
            this.rdb_1000.Name = "rdb_1000";
            this.rdb_1000.Size = new System.Drawing.Size(110, 19);
            this.rdb_1000.TabIndex = 0;
            this.rdb_1000.Text = "1000의 자리";
            this.rdb_1000.UseVisualStyleBackColor = true;
            // 
            // rdb_100
            // 
            this.rdb_100.AutoSize = true;
            this.rdb_100.Location = new System.Drawing.Point(17, 46);
            this.rdb_100.Name = "rdb_100";
            this.rdb_100.Size = new System.Drawing.Size(102, 19);
            this.rdb_100.TabIndex = 0;
            this.rdb_100.Text = "100의 자리";
            this.rdb_100.UseVisualStyleBackColor = true;
            // 
            // rdb_10
            // 
            this.rdb_10.AutoSize = true;
            this.rdb_10.Location = new System.Drawing.Point(190, 21);
            this.rdb_10.Name = "rdb_10";
            this.rdb_10.Size = new System.Drawing.Size(94, 19);
            this.rdb_10.TabIndex = 0;
            this.rdb_10.Text = "10의 자리";
            this.rdb_10.UseVisualStyleBackColor = true;
            // 
            // rdb_No
            // 
            this.rdb_No.AutoSize = true;
            this.rdb_No.Checked = true;
            this.rdb_No.Location = new System.Drawing.Point(17, 21);
            this.rdb_No.Name = "rdb_No";
            this.rdb_No.Size = new System.Drawing.Size(88, 19);
            this.rdb_No.TabIndex = 0;
            this.rdb_No.TabStop = true;
            this.rdb_No.Text = "변경없음";
            this.rdb_No.UseVisualStyleBackColor = true;
            // 
            // btn_reloadFloder
            // 
            this.btn_reloadFloder.Location = new System.Drawing.Point(246, 560);
            this.btn_reloadFloder.Name = "btn_reloadFloder";
            this.btn_reloadFloder.Size = new System.Drawing.Size(82, 52);
            this.btn_reloadFloder.TabIndex = 14;
            this.btn_reloadFloder.Text = "폴더 다시 불러오기";
            this.btn_reloadFloder.UseVisualStyleBackColor = true;
            this.btn_reloadFloder.Click += new System.EventHandler(this.btn_reloadFloder_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(534, 94);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(95, 30);
            this.button_reset.TabIndex = 19;
            this.button_reset.Text = "수동초기화";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // checkBox_reset
            // 
            this.checkBox_reset.AutoSize = true;
            this.checkBox_reset.Checked = true;
            this.checkBox_reset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_reset.Location = new System.Drawing.Point(424, 101);
            this.checkBox_reset.Name = "checkBox_reset";
            this.checkBox_reset.Size = new System.Drawing.Size(74, 19);
            this.checkBox_reset.TabIndex = 20;
            this.checkBox_reset.Text = "초기화";
            this.checkBox_reset.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "마지막 숫자 : ";
            // 
            // label_lastnumber
            // 
            this.label_lastnumber.AutoSize = true;
            this.label_lastnumber.Location = new System.Drawing.Point(134, 399);
            this.label_lastnumber.Name = "label_lastnumber";
            this.label_lastnumber.Size = new System.Drawing.Size(0, 15);
            this.label_lastnumber.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "저장할 폴더";
            // 
            // label_SaveFolder
            // 
            this.label_SaveFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_SaveFolder.Location = new System.Drawing.Point(33, 172);
            this.label_SaveFolder.Name = "label_SaveFolder";
            this.label_SaveFolder.Size = new System.Drawing.Size(373, 24);
            this.label_SaveFolder.TabIndex = 24;
            // 
            // button_SaveTargetFolderSelect
            // 
            this.button_SaveTargetFolderSelect.Location = new System.Drawing.Point(254, 43);
            this.button_SaveTargetFolderSelect.Name = "button_SaveTargetFolderSelect";
            this.button_SaveTargetFolderSelect.Size = new System.Drawing.Size(101, 52);
            this.button_SaveTargetFolderSelect.TabIndex = 25;
            this.button_SaveTargetFolderSelect.Text = "저장할 폴더 선택";
            this.button_SaveTargetFolderSelect.UseVisualStyleBackColor = true;
            this.button_SaveTargetFolderSelect.Click += new System.EventHandler(this.button_SaveTargetFolderSelect_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 645);
            this.Controls.Add(this.button_SaveTargetFolderSelect);
            this.Controls.Add(this.label_SaveFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_lastnumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_reset);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Fileload);
            this.Controls.Add(this.textBox_SpecificNumber);
            this.Controls.Add(this.label_SpecificNumber);
            this.Controls.Add(this.btn_reloadFloder);
            this.Controls.Add(this.button_folderload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Files);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_text1);
            this.Controls.Add(this.label_dirpath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Sort By Filename";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_Open;
        private System.Windows.Forms.CheckBox checkBox_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_dirpath;
        private System.Windows.Forms.Label label_text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radiobtn_simple;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox_Files;
        public System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button_folderload;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_SpecificNumber;
        private System.Windows.Forms.TextBox textBox_SpecificNumber;
        private System.Windows.Forms.Button button_Fileload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_1000;
        private System.Windows.Forms.RadioButton rdb_100;
        private System.Windows.Forms.RadioButton rdb_10;
        private System.Windows.Forms.RadioButton rdb_No;
        private System.Windows.Forms.Button btn_reloadFloder;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.CheckBox checkBox_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_lastnumber;
        private System.Windows.Forms.RadioButton radiobtn_Makefolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_SaveFolder;
        private System.Windows.Forms.Button button_SaveTargetFolderSelect;
    }
}

