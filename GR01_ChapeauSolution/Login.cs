using ChapeauLogic;
using ChapeauModel;
using ChapeauUI;
using ChapeauUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GR01_ChapeauSolution
{
    public partial class Login : Form
    {
        EmployeeService employeeService = new EmployeeService();
        public Login()
        {
            InitializeComponent();
        }

        private void txtBox_Login_EmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow to enter numbers in the employeeID
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            PasswordService passwordService = new PasswordService();
            MessageBox_Ok messageBox;

            //Check if the fields are empty
            if (!string.IsNullOrEmpty(txtBox_Login_EmployeeID.Text) && !string.IsNullOrEmpty(txtBox_Login_Password.Text))
            {
                // Get employee info
                int employeeID = int.Parse(txtBox_Login_EmployeeID.Text);
                string employeePassword = txtBox_Login_Password.Text;

                // Get the employee form the database
                Employee employee = employeeService.GetEmployee(employeeID);
               
                if (employee.EmployeeId != 0) // Check if the employee exists
                {                    
                    if (passwordService.CheckPassword(employee, employeePassword))
                    {
                        OpenView(employee);
                        return;
                    }
                    else
                        messageBox = new MessageBox_Ok("Login", "Incorrect password");
                }
                else
                    messageBox = new MessageBox_Ok("Login", "Employee doesn't exist");
            }
            else
                messageBox = new MessageBox_Ok("Login", "Please fill in all your information");
            
            messageBox.ShowDialog();
        }

        private void OpenView(Employee employee) // Open view depending on the employee's role
        {
            if (employee.EmployeeRole == "Waiter")
            {
                this.Hide();
                Form_Chapeau Chapeau = new Form_Chapeau(employee);
                Chapeau.Show();
            }
            else if (employee.EmployeeRole == "Chef" || employee.EmployeeRole == "Bartender")
            {
                // Kitchen and bar view is not yet created
                this.Hide();
                KitchenBar_UI kitchenBar_View = new KitchenBar_UI(employee);
                kitchenBar_View.Show();
            }
        }

        private void CreateUser() // Create users to add in the database
        {
            string password = "password1";
            PasswordService passwordWithSaltHasher = new PasswordService();
            HashWithSaltResult hashWithSaltResult = passwordWithSaltHasher.HashWithSalt(password, 64, SHA256.Create());

            string password2 = "password2";
            PasswordService passwordWithSaltHasher2 = new PasswordService();
            HashWithSaltResult hashWithSaltResult2 = passwordWithSaltHasher2.HashWithSalt(password2, 64, SHA256.Create());

            string password3 = "password3";
            PasswordService passwordWithSaltHasher3 = new PasswordService();
            HashWithSaltResult hashWithSaltResult3 = passwordWithSaltHasher3.HashWithSalt(password3, 64, SHA256.Create());

            string password4 = "password4";
            PasswordService passwordWithSaltHasher4 = new PasswordService();
            HashWithSaltResult hashWithSaltResult4 = passwordWithSaltHasher4.HashWithSalt(password4, 64, SHA256.Create());

            string password5 = "password5";
            PasswordService passwordWithSaltHasher5 = new PasswordService();
            HashWithSaltResult hashWithSaltResult5 = passwordWithSaltHasher5.HashWithSalt(password5, 64, SHA256.Create());

            employeeService.CreateEmployee("Alba Placeres", "Waiter", hashWithSaltResult.Salt, hashWithSaltResult.Digest);
            employeeService.CreateEmployee("Johnny Depp", "Waiter", hashWithSaltResult2.Salt, hashWithSaltResult2.Digest);
            employeeService.CreateEmployee("Rafa Nadal", "Waiter", hashWithSaltResult3.Salt, hashWithSaltResult3.Digest);
            employeeService.CreateEmployee("Pepe", "Chef", hashWithSaltResult4.Salt, hashWithSaltResult4.Digest);
            employeeService.CreateEmployee("Ana de Armas", "Bartender", hashWithSaltResult5.Salt, hashWithSaltResult5.Digest);
        } 
    }
}
