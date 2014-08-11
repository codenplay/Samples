using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isEditing = false;
        private int rowClicked = -1;
        List<Student> students = new List<Student>();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Department department = (Department)departmentComboBox.SelectedItem;

            if (isEditing)
            {
                students[rowClicked].Name = nameTextBox.Text;
                students[rowClicked].Phone = phoneTextBox.Text;
                students[rowClicked].Email = emailTextBox.Text;
                students[rowClicked].Department = department;
            }
            else
            {
                // create a new student
                Student student = new Student
                {
                    Id = students.Count + 1,
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    Department = department
                };
                // add that student into a collection/array/list/ whatever
                students.Add(student);                
            }
            
            // load that list into a grid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
            isEditing = false;
            rowClicked = -1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the info of the row which is clicked
            int rowIndex = e.RowIndex;
            nameTextBox.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            phoneTextBox.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            emailTextBox.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            isEditing = true;
            rowClicked = rowIndex;

            // set the info of the row to the textboxes
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Department> departments = new List<Department>();
            Department department = new Department();
            department.Id = 1;
            department.Name = "CSE";
            departments.Add(department);

            Department department1 = new Department();
            department1.Id = 1;
            department1.Name = "EEE";
            departments.Add(department1);

            Department department2 = new Department();
            department2.Id = 1;
            department2.Name = "ME";
            departments.Add(department2);

            Department department3 = new Department();
            department3.Id = 1;
            department3.Name = "CE";
            departments.Add(department3);

            departmentComboBox.DataSource = departments;
            departmentComboBox.DisplayMember = "Name";
            departmentComboBox.ValueMember = "Id";
        }
    }
}
