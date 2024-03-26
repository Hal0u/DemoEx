using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Demo
{
    public partial class CreateShift : Form
    {
        UserController UserController;
        ShiftController ShiftController;
        private struct AddedData
        {
            public string name { get; set; }
            public DateTime time { get; set; }
        }

        List<AddedData> ShiftHistory = new List<AddedData>(); 
        DataTable Employees;

        public CreateShift(UserController userController, ShiftController shiftController)
        {
            InitializeComponent();
            UserController = userController;
            ShiftController = shiftController; 
        }

        private void CreateShift_Load(object sender, EventArgs e)
        {
            List<string> usernames = new List<string>();

            foreach (User user in UserController.Users)
            {
                usernames.Add(user.Username);
            }

            User_ComboBox.DataSource = usernames;
        }

        public void UpdateGrid()
        {
            Employees = new DataTable();
            Employees.Columns.Add("Пользователь", typeof(string));
            Employees.Columns.Add("Дата", typeof(DateTime));

            foreach (AddedData info in ShiftHistory)
            {
                Employees.Rows.Add(info.name, info.time.Date);
            }

            Employees_DataGridView.DataSource = Employees;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string user = User_ComboBox.Text;
            ShiftController.AddShift(DateTimePicker.Value.Date, user);
            ShiftHistory.Add(new AddedData { name = user, time = DateTimePicker.Value });
            UpdateGrid();
        }
    }
}
