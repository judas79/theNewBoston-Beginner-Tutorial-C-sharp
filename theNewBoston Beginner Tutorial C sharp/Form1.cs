﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// to use Directory for creation of folder
using System.IO;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
        }

        // L170 class Person, with public string get and set properties
        class Person
            {
            public string Name
            {
                get;
                set;
            }
            public string Email
            {
                get;
                set;
            }
            public string StreetAddress
            {
                get;
                set;
            }
            public string Phone
            {
                get;
                set;
            }
            // L170 date time picker type birthday
            public DateTimePicker Birthday
            {
                get;
                set;
            }
            public string AdditionalNotes
            {
                get;
                set;
            }
        }

        // L170 create a folder if one hasn't already been created, create a xml file in that folder     
        private void Form1_Load(object sender, EventArgs e)
        {
            // L170 string to hold folder path for app data
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // L170 check to see if AddressBook - Rody already exists in this file path
            if (!Directory.Exists(path + "\\AddressBook - Roddy"))
            {
                // L170 create directory (folder) in our app data, path then directory name we choose to give it
                Directory.CreateDirectory(path + "\\AddressBook - Roddy");
            }
            // L170 create a xml file in the directory, above, if one hasn't already been created
            if (!File.Exists(path + "\\AddressBook - Roddy\\Settings"))
            {
                File.Create(path + "\\AddressBook - Roddy\\settings.xml");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // L171 list hold data about people in class Person
        List<Person> people = new List<Person>();
        private void button2_Click(object sender, EventArgs e)
        {
            // L171 instance name of Person class
            Person Ip = new Person();

            // L171 set property to corresponding textboxs' value, that is next to it in our address book
            Ip.Name = textBox1.Text;
            Ip.Email = textBox2.Text;
            Ip.StreetAddress = textBox3.Text.ToString();
            Ip.Phone = textBox3.Text.ToString();
            Ip.Birthday = dateTimePicker1;
            Ip.AdditionalNotes = textBox4.Text.ToString();

            // L171 add people to our class People list
            people.Add(Ip);

            // L171 add entered items Name to our listView1.
            listView1.Items.Add(Ip.Name);
            

            // L171 clear all the textBoxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            // L171 reset dateTimePicker to now
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}