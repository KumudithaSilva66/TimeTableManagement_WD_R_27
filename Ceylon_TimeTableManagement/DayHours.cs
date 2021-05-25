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
    public partial class DayHours : Form
    {
         
        public DayHours()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        override public void Refresh()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM DayHoursDb";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;
            cmd.ExecuteNonQuery();
            connection.Close();
            label_message.Text = "";
            textBox_workId.Text = "";
            checkBox_sunday.Checked = false;
            checkBox_monday.Checked = false;
            checkBox_tuesday.Checked = false;
            checkBox_wednesday.Checked = false;
            checkBox_thursday.Checked = false;
            checkBox_friday.Checked = false;
            checkBox_saturday.Checked = false;
            comboBox_workperiod.SelectedIndex = 0;
            comboBox_workhours.SelectedIndex  = 0;
            comboBox_workmintue.SelectedIndex = 0;
        }

        private void DayHours_Load(object sender, EventArgs e)
        {           
            Refresh();          
        }

        private void dayhours_save_Click(object sender, EventArgs e)
        {            
            String Sundaystatus;
            String Mondaystatus;
            String Tuesdaystatus;
            String Wednesdaystatus;
            String Thursdaystatus;
            String Fridaystatus;
            String Saturdaystatus;
           
            if (checkBox_sunday.Checked == true)
            {
                    Sundaystatus = "True";
            }else{

                    Sundaystatus = "False";
            }


            if (checkBox_monday.Checked == true)
            {
                     Mondaystatus = "True";
            }else{
                     Mondaystatus = "False";
            }


            if (checkBox_tuesday.Checked == true)
            {
                     Tuesdaystatus = "True";
            }else{
                     Tuesdaystatus = "False";
            }


            if (checkBox_wednesday.Checked == true)
            {
                    Wednesdaystatus = "True";
            }
            else{
                    Wednesdaystatus = "False";
            }


            if (checkBox_thursday.Checked == true)
            {
                     Thursdaystatus = "True";
            }else
            {
                     Thursdaystatus = "False";
            }


            if (checkBox_friday.Checked == true)
            {
                    Fridaystatus = "True";
            }else{
                    Fridaystatus = "False";
            }


            if (checkBox_saturday.Checked == true)
            {
                    Saturdaystatus = "True";
            }else{
                    Saturdaystatus = "False";
            }



            String workperiod = comboBox_workperiod.SelectedItem.ToString();
            String workhours = comboBox_workhours.SelectedItem.ToString();
            String workmintue = comboBox_workmintue.SelectedItem.ToString();

            if ((textBox_workId.Text != "") && (checkBox_sunday.Checked == true || checkBox_monday.Checked == true || checkBox_tuesday.Checked == true
                || checkBox_wednesday.Checked == true || checkBox_thursday.Checked == true || checkBox_friday.Checked == true || checkBox_saturday.Checked == true))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO [DayHoursDb] ([workdayid],[sunday],[monday],[tuesday],[wednesday],[thursday],[friday],[saturDay],[workperiod],[workhours],[workmintue]) " +
                                   "VALUES ('" + textBox_workId.Text + "','" + Sundaystatus + "','" + Mondaystatus + "','" + Tuesdaystatus + "','" + Wednesdaystatus + "','" +
                                    Thursdaystatus + "','" + Fridaystatus + "','" + Saturdaystatus + "','" + workperiod + "','" + workhours + "','" + workmintue + "')";

                cmd.ExecuteNonQuery();
                connection.Close();
                label_message.ForeColor = Color.Blue;
                label_message.Text = "Data Inserted Successfully";
            }
            else
            {
                label_message.ForeColor = Color.Brown;
                label_message.Text = "Fields need to fill";
            }


            

        }

        private void dayhours_delete_Click(object sender, EventArgs e)
        {
            if (textBox_workId.Text != "")    
            {
                String Deletedata = textBox_workId.Text;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM [DayHoursDb] WHERE workdayid = ('" + Deletedata + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                label_message.ForeColor = Color.Red;
                label_message.Text = "Data Deleted Successfully";
            }
            else
            {
                label_message.ForeColor = Color.Brown;
                label_message.Text = "Fields need to fill";
            }


            
        }     

        private void dayhours_refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dayhours_update_Click(object sender, EventArgs e)
        {
            String Sundaystatus;
            String Mondaystatus;
            String Tuesdaystatus;
            String Wednesdaystatus;
            String Thursdaystatus;
            String Fridaystatus;
            String Saturdaystatus;

            if (checkBox_sunday.Checked == true)
            {
                     Sundaystatus = "True";
            }else{

                     Sundaystatus = "False";
            }


            if (checkBox_monday.Checked == true)
            {
                     Mondaystatus = "True";
            }else{
                     Mondaystatus = "False";
            }


            if (checkBox_tuesday.Checked == true)
            {
                    Tuesdaystatus = "True";
            }else{
                    Tuesdaystatus = "False";
            }


            if (checkBox_wednesday.Checked == true)
            {
                    Wednesdaystatus = "True";
            }else{
                    Wednesdaystatus = "False";
            }


            if (checkBox_thursday.Checked == true)
            {
                    Thursdaystatus = "True";
            }else{
                    Thursdaystatus = "False";
            }


            if (checkBox_friday.Checked == true)
            {
                    Fridaystatus = "True";
            }else{
                    Fridaystatus = "False";
            }


            if (checkBox_saturday.Checked == true)
            {
                    Saturdaystatus = "True";
            }else{
                    Saturdaystatus = "False";
            }


            String workid = textBox_workId.Text;
            String workperiod = comboBox_workperiod.SelectedItem.ToString();
            String workhours = comboBox_workhours.SelectedItem.ToString();
            String workmintue = comboBox_workmintue.SelectedItem.ToString();

            if  ((textBox_workId.Text != "") && (checkBox_sunday.Checked == true || checkBox_monday.Checked == true|| checkBox_tuesday.Checked == true 
                || checkBox_wednesday.Checked == true || checkBox_thursday.Checked == true|| checkBox_friday.Checked == true || checkBox_saturday.Checked == true))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE [DayHoursDb] SET [sunday]='" + Sundaystatus + "', [monday]='" + Mondaystatus + "', [tuesday]='" + Tuesdaystatus + "', [wednesday]='"
                                   + Wednesdaystatus + "', [thursday]='" + Thursdaystatus + "', [friday]='" + Fridaystatus + "', [saturDay]='" + Saturdaystatus + "', [workperiod]='"
                                   + workperiod + "', [workhours]='" + workhours + "', [workmintue]='" + workmintue + "'  WHERE [workdayid] = ('" + workid + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                label_message.ForeColor = Color.Green;
                label_message.Text = "Data Updated Successfully";
            }
            else
            {
                label_message.ForeColor = Color.Brown;
                label_message.Text = "Fields need to fill";
            }         
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectrow = dataGrid.Rows[index];
                textBox_workId.Text = selectrow.Cells[0].Value.ToString();
                String sunday = selectrow.Cells[1].Value.ToString();
                String monday = selectrow.Cells[2].Value.ToString();
                String tuesday = selectrow.Cells[3].Value.ToString();
                String wednesday = selectrow.Cells[4].Value.ToString();
                String thursday = selectrow.Cells[5].Value.ToString();
                String friday = selectrow.Cells[6].Value.ToString();
                String saturDay = selectrow.Cells[7].Value.ToString();
                comboBox_workperiod.SelectedItem = selectrow.Cells[8].Value.ToString();
                comboBox_workhours.SelectedItem = selectrow.Cells[9].Value.ToString();
                comboBox_workmintue.SelectedItem = selectrow.Cells[10].Value.ToString();

                if (sunday == "True")
                {
                         checkBox_sunday.Checked = true;
                }else{
                         checkBox_sunday.Checked = false;
                }

                if (monday == "True")
                {
                        checkBox_monday.Checked = true;
                }else{
                        checkBox_monday.Checked = false;
                }

                if (tuesday == "True")
                {
                        checkBox_tuesday.Checked = true;
                }else{
                        checkBox_tuesday.Checked = false;
                }


                if (wednesday == "True")
                {
                        checkBox_wednesday.Checked = true;
                }else{
                        checkBox_wednesday.Checked = false;
                }


                if (thursday == "True")
                {
                        checkBox_thursday.Checked = true;
                }else{
                        checkBox_thursday.Checked = false;
                }


                if (friday == "True")
                {
                        checkBox_friday.Checked = true;
                }else{
                        checkBox_friday.Checked = false;
                }


                if (saturDay == "True")
                {
                        checkBox_saturday.Checked = true;
                }else{
                        checkBox_saturday.Checked = false;
                }

            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
