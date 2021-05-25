
namespace Ceylon_TimeTableManagement
{
    partial class PreferredandUnavailableTime
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prUnTimeDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_tablekind = new System.Windows.Forms.ComboBox();
            this.textBox_autoId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_prandnotime = new System.Windows.Forms.Label();
            this.textBox_lectureId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lecturer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_session = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_group = new System.Windows.Forms.TextBox();
            this.textBox_subgroup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_room = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.lable_prandun = new System.Windows.Forms.Label();
            this.comboBox_starttime = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_endtime = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prnotime_refresh = new System.Windows.Forms.Button();
            this.prnotime_delete = new System.Windows.Forms.Button();
            this.prnotime_update = new System.Windows.Forms.Button();
            this.prnotime_save = new System.Windows.Forms.Button();
            this.lable_showmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prUnTimeDbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 550);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1127, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox_tablekind
            // 
            this.comboBox_tablekind.Font = new System.Drawing.Font("Cambria", 9F);
            this.comboBox_tablekind.FormattingEnabled = true;
            this.comboBox_tablekind.Items.AddRange(new object[] {
            "NONETIME",
            "PRTIME",
            "UNTIME"});
            this.comboBox_tablekind.Location = new System.Drawing.Point(249, 145);
            this.comboBox_tablekind.Name = "comboBox_tablekind";
            this.comboBox_tablekind.Size = new System.Drawing.Size(121, 22);
            this.comboBox_tablekind.TabIndex = 27;
            this.comboBox_tablekind.SelectedValueChanged += new System.EventHandler(this.comboBox_tablekind_SelectedValueChanged);
            // 
            // textBox_autoId
            // 
            this.textBox_autoId.Location = new System.Drawing.Point(249, 98);
            this.textBox_autoId.Name = "textBox_autoId";
            this.textBox_autoId.ReadOnly = true;
            this.textBox_autoId.Size = new System.Drawing.Size(173, 20);
            this.textBox_autoId.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F);
            this.label3.Location = new System.Drawing.Point(43, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Table Kind";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F);
            this.label1.Location = new System.Drawing.Point(42, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Auto ID";
            // 
            // label_prandnotime
            // 
            this.label_prandnotime.AutoSize = true;
            this.label_prandnotime.BackColor = System.Drawing.Color.AliceBlue;
            this.label_prandnotime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prandnotime.Location = new System.Drawing.Point(481, 9);
            this.label_prandnotime.Name = "label_prandnotime";
            this.label_prandnotime.Size = new System.Drawing.Size(229, 19);
            this.label_prandnotime.TabIndex = 34;
            this.label_prandnotime.Text = "Preferred and Unavailable Time";
            this.label_prandnotime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_lectureId
            // 
            this.textBox_lectureId.Location = new System.Drawing.Point(250, 191);
            this.textBox_lectureId.Name = "textBox_lectureId";
            this.textBox_lectureId.Size = new System.Drawing.Size(173, 20);
            this.textBox_lectureId.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F);
            this.label2.Location = new System.Drawing.Point(42, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Lecture ID";
            // 
            // textBox_lecturer
            // 
            this.textBox_lecturer.Location = new System.Drawing.Point(250, 239);
            this.textBox_lecturer.Name = "textBox_lecturer";
            this.textBox_lecturer.Size = new System.Drawing.Size(173, 20);
            this.textBox_lecturer.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F);
            this.label5.Location = new System.Drawing.Point(44, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Lecturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F);
            this.label4.Location = new System.Drawing.Point(44, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F);
            this.label6.Location = new System.Drawing.Point(44, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Sub Group";
            // 
            // comboBox_session
            // 
            this.comboBox_session.Font = new System.Drawing.Font("Cambria", 9F);
            this.comboBox_session.FormattingEnabled = true;
            this.comboBox_session.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006"});
            this.comboBox_session.Location = new System.Drawing.Point(250, 387);
            this.comboBox_session.Name = "comboBox_session";
            this.comboBox_session.Size = new System.Drawing.Size(121, 22);
            this.comboBox_session.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F);
            this.label7.Location = new System.Drawing.Point(44, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Session";
            // 
            // textBox_group
            // 
            this.textBox_group.Location = new System.Drawing.Point(249, 291);
            this.textBox_group.Name = "textBox_group";
            this.textBox_group.Size = new System.Drawing.Size(173, 20);
            this.textBox_group.TabIndex = 45;
            // 
            // textBox_subgroup
            // 
            this.textBox_subgroup.Location = new System.Drawing.Point(249, 341);
            this.textBox_subgroup.Name = "textBox_subgroup";
            this.textBox_subgroup.Size = new System.Drawing.Size(173, 20);
            this.textBox_subgroup.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F);
            this.label8.Location = new System.Drawing.Point(47, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "Room";
            // 
            // textBox_room
            // 
            this.textBox_room.Location = new System.Drawing.Point(250, 441);
            this.textBox_room.Name = "textBox_room";
            this.textBox_room.Size = new System.Drawing.Size(173, 20);
            this.textBox_room.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F);
            this.label9.Location = new System.Drawing.Point(533, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Day";
            // 
            // comboBox_day
            // 
            this.comboBox_day.Font = new System.Drawing.Font("Cambria", 9F);
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.comboBox_day.Location = new System.Drawing.Point(654, 102);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(121, 22);
            this.comboBox_day.TabIndex = 50;
            // 
            // lable_prandun
            // 
            this.lable_prandun.AutoSize = true;
            this.lable_prandun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_prandun.Location = new System.Drawing.Point(44, 43);
            this.lable_prandun.Name = "lable_prandun";
            this.lable_prandun.Size = new System.Drawing.Size(177, 15);
            this.lable_prandun.TabIndex = 51;
            this.lable_prandun.Text = "lable preferred and unavailable";
            // 
            // comboBox_starttime
            // 
            this.comboBox_starttime.Font = new System.Drawing.Font("Cambria", 9F);
            this.comboBox_starttime.FormattingEnabled = true;
            this.comboBox_starttime.Items.AddRange(new object[] {
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM"});
            this.comboBox_starttime.Location = new System.Drawing.Point(654, 147);
            this.comboBox_starttime.Name = "comboBox_starttime";
            this.comboBox_starttime.Size = new System.Drawing.Size(121, 22);
            this.comboBox_starttime.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F);
            this.label10.Location = new System.Drawing.Point(533, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Start Time";
            // 
            // comboBox_endtime
            // 
            this.comboBox_endtime.Font = new System.Drawing.Font("Cambria", 9F);
            this.comboBox_endtime.FormattingEnabled = true;
            this.comboBox_endtime.Items.AddRange(new object[] {
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM"});
            this.comboBox_endtime.Location = new System.Drawing.Point(654, 191);
            this.comboBox_endtime.Name = "comboBox_endtime";
            this.comboBox_endtime.Size = new System.Drawing.Size(121, 22);
            this.comboBox_endtime.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F);
            this.label11.Location = new System.Drawing.Point(533, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 54;
            this.label11.Text = "End Time";
            // 
            // prnotime_refresh
            // 
            this.prnotime_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prnotime_refresh.Font = new System.Drawing.Font("Cambria", 12F);
            this.prnotime_refresh.Location = new System.Drawing.Point(885, 331);
            this.prnotime_refresh.Name = "prnotime_refresh";
            this.prnotime_refresh.Size = new System.Drawing.Size(75, 50);
            this.prnotime_refresh.TabIndex = 59;
            this.prnotime_refresh.Text = "Refresh";
            this.prnotime_refresh.UseVisualStyleBackColor = true;
            this.prnotime_refresh.Click += new System.EventHandler(this.prnotime_refresh_Click);
            // 
            // prnotime_delete
            // 
            this.prnotime_delete.BackColor = System.Drawing.Color.AliceBlue;
            this.prnotime_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prnotime_delete.Font = new System.Drawing.Font("Cambria", 12F);
            this.prnotime_delete.Location = new System.Drawing.Point(885, 255);
            this.prnotime_delete.Name = "prnotime_delete";
            this.prnotime_delete.Size = new System.Drawing.Size(75, 50);
            this.prnotime_delete.TabIndex = 58;
            this.prnotime_delete.Text = "Delete";
            this.prnotime_delete.UseVisualStyleBackColor = false;
            this.prnotime_delete.Click += new System.EventHandler(this.prnotime_delete_Click);
            // 
            // prnotime_update
            // 
            this.prnotime_update.BackColor = System.Drawing.Color.AliceBlue;
            this.prnotime_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prnotime_update.Font = new System.Drawing.Font("Cambria", 12F);
            this.prnotime_update.Location = new System.Drawing.Point(885, 172);
            this.prnotime_update.Name = "prnotime_update";
            this.prnotime_update.Size = new System.Drawing.Size(75, 50);
            this.prnotime_update.TabIndex = 57;
            this.prnotime_update.Text = "Update";
            this.prnotime_update.UseVisualStyleBackColor = false;
            this.prnotime_update.Click += new System.EventHandler(this.prnotime_update_Click);
            // 
            // prnotime_save
            // 
            this.prnotime_save.BackColor = System.Drawing.Color.AliceBlue;
            this.prnotime_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prnotime_save.Font = new System.Drawing.Font("Cambria", 12F);
            this.prnotime_save.Location = new System.Drawing.Point(885, 97);
            this.prnotime_save.Name = "prnotime_save";
            this.prnotime_save.Size = new System.Drawing.Size(75, 50);
            this.prnotime_save.TabIndex = 56;
            this.prnotime_save.Text = "Save";
            this.prnotime_save.UseVisualStyleBackColor = false;
            this.prnotime_save.Click += new System.EventHandler(this.prnotime_save_Click);
            // 
            // lable_showmessage
            // 
            this.lable_showmessage.AutoSize = true;
            this.lable_showmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_showmessage.Location = new System.Drawing.Point(48, 510);
            this.lable_showmessage.Name = "lable_showmessage";
            this.lable_showmessage.Size = new System.Drawing.Size(117, 15);
            this.lable_showmessage.TabIndex = 60;
            this.lable_showmessage.Text = "lable showmessage";
            // 
            // PreferredandUnavailableTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1251, 773);
            this.Controls.Add(this.lable_showmessage);
            this.Controls.Add(this.prnotime_refresh);
            this.Controls.Add(this.prnotime_delete);
            this.Controls.Add(this.prnotime_update);
            this.Controls.Add(this.prnotime_save);
            this.Controls.Add(this.comboBox_endtime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_starttime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lable_prandun);
            this.Controls.Add(this.comboBox_day);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_room);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_subgroup);
            this.Controls.Add(this.textBox_group);
            this.Controls.Add(this.comboBox_session);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_lecturer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_lectureId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_prandnotime);
            this.Controls.Add(this.comboBox_tablekind);
            this.Controls.Add(this.textBox_autoId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PreferredandUnavailableTime";
            this.Text = "PreferredandUnavailableTime";
            this.Load += new System.EventHandler(this.PreferredandUnavailableTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prUnTimeDbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.BindingSource prUnTimeDbBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn autoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablekindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox_tablekind;
        private System.Windows.Forms.TextBox textBox_autoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_prandnotime;
        private System.Windows.Forms.TextBox textBox_lectureId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lecturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_session;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_group;
        private System.Windows.Forms.TextBox textBox_subgroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_room;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.Label lable_prandun;
        private System.Windows.Forms.ComboBox comboBox_starttime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_endtime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button prnotime_refresh;
        private System.Windows.Forms.Button prnotime_delete;
        private System.Windows.Forms.Button prnotime_update;
        private System.Windows.Forms.Button prnotime_save;
        private System.Windows.Forms.Label lable_showmessage;
    }
}