﻿using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebApp
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // This line of code will be used for making sure that the inputs are not empty. 
            if (string.IsNullOrWhiteSpace(teFullName.Text) ||
               string.IsNullOrWhiteSpace(teAge.Text) ||
               string.IsNullOrWhiteSpace(teGender.Text) ||
               string.IsNullOrWhiteSpace(teAddress.Text) ||
               string.IsNullOrWhiteSpace(teContactNumber.Text))
            {
                // Validates if the inputs are not filled.
                XtraMessageBox.Show("All fields are required. Please fill in all details.",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creates a Student object
            Student student = new Student();
            // Generates a student ID in the format YYYY-####, where #### is a zero-padded sequence number.
            string currentYear = DateTime.Now.Year.ToString();
            string studentId = $"{currentYear}-{(students.Count + 1).ToString("D4")}";
            // Populates the object student with data based on the inputted details.
            student.StudentID = studentId;
            student.FullName = teFullName.Text;
            student.Age = int.Parse(teAge.Text);
            student.Gender = teGender.Text;
            student.Address = teAddress.Text;
            student.ContactNumber = int.Parse(teContactNumber.Text);

            // Checks whether a student with the same Student ID or Full Name
            // already exists in the students collection
            if (students.Any(s => s.StudentID == studentId || s.FullName.Equals(teFullName.Text, StringComparison.OrdinalIgnoreCase)))
            {
                XtraMessageBox.Show("A student with the same Student ID or Full Name already exists!",
                                "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Displays a confirmation message before adding the student's information.
            DialogResult result = XtraMessageBox.Show("Are you sure you want to add this student's information?",
                                 "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Adds the new student to the list and updates the grid display.
            students.Add(student);
            gcStudents.DataSource = students;
            gcStudents.RefreshDataSource();
            // Clears input fields after successful addition.
            clearInput();
        }

        // Stores the Student ID of the currently selected student.
        private string selectedStudentID;

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Gets the index of the currently focused row in the grid view.
            int selectedRow = gvStudents.FocusedRowHandle;
            // If a valid row is selected, it retrieves the student's details
            // and display them in the input fields.
            if (selectedRow >= 0)
            {
                Student student = students[selectedRow];
                selectedStudentID = student.StudentID;
                teFullName.Text = student.FullName;
                teAge.Text = student.Age.ToString();
                teGender.Text = student.Gender;
                teAddress.Text = student.Address;
                teContactNumber.Text = student.ContactNumber.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedRow = gvStudents.FocusedRowHandle;
            if (selectedRow >= 0)
            {
                if (string.IsNullOrWhiteSpace(teFullName.Text) ||
                    string.IsNullOrWhiteSpace(teAge.Text) ||
                    string.IsNullOrWhiteSpace(teGender.Text) ||
                    string.IsNullOrWhiteSpace(teAddress.Text) ||
                    string.IsNullOrWhiteSpace(teContactNumber.Text))
                {
                    XtraMessageBox.Show("All fields are required. Please fill in all details.",
                                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string studentId = students[selectedRow].StudentID; 

                if (students.Any(s => s.FullName.Equals(teFullName.Text, StringComparison.OrdinalIgnoreCase) && s.StudentID != studentId))
                {
                    XtraMessageBox.Show("A student with the same Full Name already exists!",
                                    "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                DialogResult result = XtraMessageBox.Show("Are you sure you want to update this student's information?",
                                        "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                students[selectedRow].FullName = teFullName.Text;
                students[selectedRow].Age = int.Parse(teAge.Text);
                students[selectedRow].Gender = teGender.Text;
                students[selectedRow].Address = teAddress.Text;
                students[selectedRow].ContactNumber = int.Parse(teContactNumber.Text);

                gcStudents.RefreshDataSource();
                clearInput();
            }
            else
            {
                MessageBox.Show("No student selected for updating.",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = gvStudents.FocusedRowHandle;
            if (selectedRow >= 0 && selectedRow < students.Count)
            {
                DialogResult result = XtraMessageBox.Show("Are you sure you want to remove this student's information?",
                                        "Confirm Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                students.RemoveAt(selectedRow);
                gcStudents.RefreshDataSource();
            }
        }

        private void teContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void teAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void clearInput()
        {
            teFullName.Text = "";
            teAge.Text = "";
            teGender.Text = "";
            teAddress.Text = "";
            teContactNumber.Text = "";
        }

    }
}

