using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ceylon_TimeTableManagement
{
    public partial class PreferredandUnavailableTime : Form
    {
        public PreferredandUnavailableTime()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        override public void Refresh()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM PrUnTimeDb";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            cmd.ExecuteNonQuery();
            connection.Close();
            lable_showmessage.Text = "";
            lable_prandun.Text = "";
            textBox_autoId.Text = "";
            textBox_group.Text = "";
            textBox_lectureId.Text = "";
            textBox_lecturer.Text = "";
            textBox_room.Text = "";
            textBox_subgroup.Text = "";
            comboBox_tablekind.SelectedIndex = 0;
            comboBox_session.SelectedIndex = 0;
            comboBox_day.SelectedIndex = 0;
            comboBox_starttime.SelectedIndex = 0;
            comboBox_endtime.SelectedIndex = 0;           

        }

        private void PreferredandUnavailableTime_Load(object sender, EventArgs e)
        {
            Refresh();
        }      


        private void prnotime_save_Click(object sender, EventArgs e)
        {
            if ((comboBox_tablekind.SelectedItem !=null) && (comboBox_day.SelectedItem !=null) &&
                (comboBox_starttime.SelectedItem !=null) && (comboBox_endtime.SelectedItem !=null) && (comboBox_session.SelectedItem !=null))
            {
                String tablekind = comboBox_tablekind.SelectedItem.ToString();
                String session = comboBox_session.SelectedItem.ToString();
                String day = comboBox_day.SelectedItem.ToString();
                String starttime = comboBox_starttime.SelectedItem.ToString();
                String endtime = comboBox_endtime.SelectedItem.ToString();
                textBox_autoId.Text = "";
                String autoid = "AU00"+dataGridView1.Rows.Count.ToString();
                textBox_autoId.Text = autoid;

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO [PrUnTimeDb] ([autoid], [tablekind], [lecturerid], [lecturer], [group], [subgroup], [session], [room], [day], [starttime], [endtime]) " +
                               "VALUES ('" + textBox_autoId.Text + "','" + tablekind + "','" + textBox_lectureId.Text + "','" + textBox_lecturer.Text + "','" + textBox_group.Text + "','" +
                               textBox_subgroup.Text + "','" + session + "','" + textBox_room.Text + "','" + day + "','" + starttime + "','" + endtime + "')";

                cmd.ExecuteNonQuery();
                connection.Close();
                lable_showmessage.ForeColor = Color.Blue;
                lable_showmessage.Text = "Data Inserted Successfully";
            }
            else
            {
                lable_showmessage.ForeColor = Color.Brown;
                lable_showmessage.Text = "Fields need to fill";
            }


        }

        private void prnotime_delete_Click(object sender, EventArgs e)
        {
            if (textBox_autoId.Text != "")
            {
                String Deletedata = textBox_autoId.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM [PrUnTimeDb] WHERE autoid = ('" + Deletedata + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                lable_showmessage.ForeColor = Color.Red;
                lable_showmessage.Text = "Data Deleted Successfully";
            }
            else
            {
                lable_showmessage.ForeColor = Color.Brown;
                lable_showmessage.Text = "Fields need to fill";
            }
        }

        private void prnotime_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void prnotime_update_Click(object sender, EventArgs e)
        {
            if ((comboBox_tablekind.SelectedItem != null) && (comboBox_day.SelectedItem != null) &&
                (comboBox_starttime.SelectedItem != null) && (comboBox_endtime.SelectedItem != null) && (comboBox_session.SelectedItem != null))
            {
                String autoid = textBox_autoId.Text;
                String tablekind = comboBox_tablekind.SelectedItem.ToString();
                String session = comboBox_session.SelectedItem.ToString();
                String day = comboBox_day.SelectedItem.ToString();
                String starttime = comboBox_starttime.SelectedItem.ToString();
                String endtime = comboBox_endtime.SelectedItem.ToString();

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE [PrUnTimeDb] SET [tablekind]='" + tablekind + "', [lecturerid]='" + textBox_lectureId.Text + "', [lecturer]='" + textBox_lecturer.Text + "', [group]='"
                                   + textBox_group.Text + "', [subgroup]='" + textBox_subgroup.Text + "', [session]='" + session + "', [room]='" + textBox_room.Text + "', [day]='"
                                   + day + "', [starttime]='" + starttime + "', [endtime]='" + endtime + "'  WHERE [autoid] = ('" +autoid + "')";

                cmd.ExecuteNonQuery();
                connection.Close();
                lable_showmessage.ForeColor = Color.Green;
                lable_showmessage.Text = "Data Updated Successfully";

            }
            else
            {
                lable_showmessage.ForeColor = Color.Brown;
                lable_showmessage.Text = "Fields need to fill";
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectrow = dataGridView1.Rows[index];
                textBox_autoId.Text = selectrow.Cells[0].Value.ToString();
                comboBox_tablekind.SelectedItem = selectrow.Cells[1].Value.ToString();
                textBox_lectureId.Text = selectrow.Cells[2].Value.ToString();
                textBox_lecturer.Text = selectrow.Cells[3].Value.ToString();
                textBox_group.Text = selectrow.Cells[4].Value.ToString();
                textBox_subgroup.Text = selectrow.Cells[5].Value.ToString();
                comboBox_session.SelectedItem = selectrow.Cells[6].Value.ToString();
                textBox_room.Text = selectrow.Cells[7].Value.ToString();
                comboBox_day.SelectedItem = selectrow.Cells[8].Value.ToString();
                comboBox_starttime.SelectedItem = selectrow.Cells[9].Value.ToString();
                comboBox_endtime.SelectedItem = selectrow.Cells[10].Value.ToString();
            }
        }

        private void comboBox_tablekind_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_tablekind.SelectedItem.ToString() == "PRTIME")
            {
                lable_prandun.ForeColor = Color.Green;
                lable_prandun.Text = "Preferred Time";
            }
            else if (comboBox_tablekind.SelectedItem.ToString() == "UNTIME")
            {
                lable_prandun.ForeColor = Color.Red;
                lable_prandun.Text = "Unavailable Time";
            }
            else
            {
                lable_prandun.Text = "";
            }
        }

 
    }
}
