﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using logInApp.Model;
using logInApp.ViewModel;

namespace logInApp.View
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Close_App_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addTheStudent_Click(object sender, RoutedEventArgs e)
        {

            //create a new student by adding a new student to the data base
            using (ViewModel.DataContext context = new ViewModel.DataContext())
            {
                //craete the model properties
                
                var SFname = SFirstName.Text;
                var SSName = SSecondName.Text;
                var Sgpa = SGPA.Text;
                var SDoB = SDateOfBirth.Text;

                //checck

                if (SFname != null && SSName != null && Sgpa != null && SDoB != null)
                {
                    context.Students.Add(new Model.Student()
                    {
                        SFirstName = SFname,
                        SSecondName = SSName,
                        SGPA = Sgpa,
                        SDateOfBirth = SDoB
                    });

                    context.SaveChanges();

                    SFirstName.Text = null;
                    SSecondName.Text = null;
                    SGPA.Text = null;
                    SDateOfBirth.Text = null;

                    MessageBox.Show("Added the details sucessfull!");
                    Application.Current.MainWindow.Show();
                }

                else
                {
                    MessageBox.Show("Fill All the fields");
                }

            }




        }

        private void addImagePath_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
