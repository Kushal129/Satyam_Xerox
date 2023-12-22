namespace LoginPage
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.date_Date = new System.Windows.Forms.DateTimePicker();
            this.combo_alldata = new System.Windows.Forms.ComboBox();
            this.txt_myamount = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.gv_alldata = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_adminname = new System.Windows.Forms.Label();
            this.txt_usersend = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pay_status = new System.Windows.Forms.Label();
            this.btn_export_excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_alldata)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txt_name
            // 
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_phonenumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            resources.ApplyResources(this.txt_phonenumber, "txt_phonenumber");
            this.txt_phonenumber.Name = "txt_phonenumber";
            // 
            // date_Date
            // 
            this.date_Date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.date_Date.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.date_Date.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.date_Date, "date_Date");
            this.date_Date.Name = "date_Date";
            this.date_Date.Value = new System.DateTime(2023, 5, 30, 15, 50, 8, 0);
            // 
            // combo_alldata
            // 
            this.combo_alldata.AllowDrop = true;
            this.combo_alldata.FormattingEnabled = true;
            resources.ApplyResources(this.combo_alldata, "combo_alldata");
            this.combo_alldata.Items.AddRange(new object[] {
            resources.GetString("combo_alldata.Items"),
            resources.GetString("combo_alldata.Items1"),
            resources.GetString("combo_alldata.Items2"),
            resources.GetString("combo_alldata.Items3"),
            resources.GetString("combo_alldata.Items4"),
            resources.GetString("combo_alldata.Items5"),
            resources.GetString("combo_alldata.Items6"),
            resources.GetString("combo_alldata.Items7"),
            resources.GetString("combo_alldata.Items8"),
            resources.GetString("combo_alldata.Items9"),
            resources.GetString("combo_alldata.Items10"),
            resources.GetString("combo_alldata.Items11"),
            resources.GetString("combo_alldata.Items12"),
            resources.GetString("combo_alldata.Items13"),
            resources.GetString("combo_alldata.Items14"),
            resources.GetString("combo_alldata.Items15")});
            this.combo_alldata.Name = "combo_alldata";
            this.combo_alldata.SelectedIndexChanged += new System.EventHandler(this.combo_alldata_SelectedIndexChanged);
            // 
            // txt_myamount
            // 
            resources.ApplyResources(this.txt_myamount, "txt_myamount");
            this.txt_myamount.Name = "txt_myamount";
            this.txt_myamount.Tag = "levana";
            this.txt_myamount.TextChanged += new System.EventHandler(this.txt_amount_TextChanged);
            // 
            // txt_note
            // 
            this.txt_note.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txt_note.CausesValidation = false;
            resources.ApplyResources(this.txt_note, "txt_note");
            this.txt_note.Name = "txt_note";
            this.txt_note.TextChanged += new System.EventHandler(this.txt_note_TextChanged);
            // 
            // btn_search
            // 
            resources.ApplyResources(this.btn_search, "btn_search");
            this.btn_search.Name = "btn_search";
            this.btn_search.Tag = "Search The Reord";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_insert
            // 
            resources.ApplyResources(this.btn_insert, "btn_insert");
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            resources.ApplyResources(this.btn_update, "btn_update");
            this.btn_update.Name = "btn_update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            resources.ApplyResources(this.btn_delete, "btn_delete");
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // gv_alldata
            // 
            this.gv_alldata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gv_alldata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_alldata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_alldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_alldata.GridColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.gv_alldata, "gv_alldata");
            this.gv_alldata.Name = "gv_alldata";
            this.gv_alldata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gv_alldata.RowTemplate.Height = 24;
            this.gv_alldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_alldata_CellContentClick);
            // 
            // btn_refresh
            // 
            resources.ApplyResources(this.btn_refresh, "btn_refresh");
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_clr
            // 
            resources.ApplyResources(this.btn_clr, "btn_clr");
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(227)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.btn_mini);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.txt_adminname);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_mini
            // 
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btn_mini, "btn_mini");
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_adminname
            // 
            resources.ApplyResources(this.txt_adminname, "txt_adminname");
            this.txt_adminname.Name = "txt_adminname";
            // 
            // txt_usersend
            // 
            resources.ApplyResources(this.txt_usersend, "txt_usersend");
            this.txt_usersend.Name = "txt_usersend";
            this.txt_usersend.Tag = "apya";
            this.txt_usersend.TextChanged += new System.EventHandler(this.txt_total_g_TextChanged);
            // 
            // txt_final
            // 
            resources.ApplyResources(this.txt_final, "txt_final");
            this.txt_final.Name = "txt_final";
            this.txt_final.ReadOnly = true;
            this.txt_final.Tag = "dhya";
            this.txt_final.TextChanged += new System.EventHandler(this.txt_final_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Name = "label6";
            // 
            // pay_status
            // 
            resources.ApplyResources(this.pay_status, "pay_status");
            this.pay_status.Name = "pay_status";
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.btn_export_excel, "btn_export_excel");
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.UseVisualStyleBackColor = false;
            this.btn_export_excel.Click += new System.EventHandler(this.btn_export_excel_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(222)))));
            this.CancelButton = this.btn_close;
            this.Controls.Add(this.btn_export_excel);
            this.Controls.Add(this.pay_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.txt_usersend);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gv_alldata);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_myamount);
            this.Controls.Add(this.combo_alldata);
            this.Controls.Add(this.date_Date);
            this.Controls.Add(this.txt_phonenumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_alldata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label txt_adminname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DateTimePicker date_Date;
        private System.Windows.Forms.ComboBox combo_alldata;
        private System.Windows.Forms.TextBox txt_myamount;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView gv_alldata;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.TextBox txt_usersend;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pay_status;
        private System.Windows.Forms.TextBox txt_phonenumber;
        public System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Button btn_export_excel;
    }
}