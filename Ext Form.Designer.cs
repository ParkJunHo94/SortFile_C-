namespace Sort_By_Filename
{
    partial class Ext_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_original = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.listBox_tochnage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_original
            // 
            this.listBox_original.FormattingEnabled = true;
            this.listBox_original.ItemHeight = 15;
            this.listBox_original.Location = new System.Drawing.Point(42, 63);
            this.listBox_original.Name = "listBox_original";
            this.listBox_original.Size = new System.Drawing.Size(207, 289);
            this.listBox_original.TabIndex = 0;
            this.listBox_original.DoubleClick += new System.EventHandler(this.listBox_original_DoubleClick);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(275, 142);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "추가";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(275, 234);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // listBox_tochnage
            // 
            this.listBox_tochnage.FormattingEnabled = true;
            this.listBox_tochnage.ItemHeight = 15;
            this.listBox_tochnage.Location = new System.Drawing.Point(374, 63);
            this.listBox_tochnage.Name = "listBox_tochnage";
            this.listBox_tochnage.Size = new System.Drawing.Size(207, 289);
            this.listBox_tochnage.TabIndex = 0;
            this.listBox_tochnage.DoubleClick += new System.EventHandler(this.listBox_tochnage_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "현재 폴더 안의 확장자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "변경할 파일의 확장자";
            // 
            // Ext_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_tochnage);
            this.Controls.Add(this.listBox_original);
            this.Name = "Ext_Form";
            this.Text = "Ext_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ext_Form_FormClosing);
            this.Load += new System.EventHandler(this.Ext_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_original;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ListBox listBox_tochnage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}