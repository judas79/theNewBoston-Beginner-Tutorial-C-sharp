﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theNewBoston_Beginner_Tutorial_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // L99 create the first node in treeView1
            treeView1.Nodes.Add("People");
            // sub nodes for this node
            treeView1.Nodes[0].Nodes.Add("Doug");
            treeView1.Nodes[0].Nodes.Add("Oscar");
            // sub node to a sub node to a node
            treeView1.Nodes[0].Nodes[1].Nodes.Add("Oscar balls");
            treeView1.Nodes[0].Nodes.Add("George");

            // L99 add more nodes
            treeView1.Nodes.Add("Animals");
            // sub nodes for this node
            treeView1.Nodes[1].Nodes.Add("Bob");
            treeView1.Nodes[1].Nodes.Add("Rex");

            treeView1.Nodes.Add("Insects");
            // sub nodes for this node
            treeView1.Nodes[2].Nodes.Add("flee");
            // sub node to a sub node to a node
            treeView1.Nodes[2].Nodes[0].Nodes.Add("flee balls");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}


