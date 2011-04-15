using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool callMissing = false;
        public bool callReturn = false;
        public bool callTowerDives = false;
        public bool callGlobalSpells = false;
        public bool lastHitAssist = false;

        public bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void start()
        {
            isRunning = true;
            //inject DLL, pass lastHitAssist in the constructor to the DLL
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start();
        }

        public void toggleMia()
        {
            callMissing = !callMissing;
        }

        public void toggleRe()
        {
            callReturn = !callReturn;
        }

        public void toggleTower()
        {
            callTowerDives = !callTowerDives;
        }

        public void toggleGlobal()
        {
            callGlobalSpells = !callGlobalSpells;
        }

        public void toggleAssist()
        {
            lastHitAssist = !lastHitAssist;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            toggleMia();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            toggleRe();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            toggleTower();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            toggleGlobal();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            toggleAssist();
        }

        private void MainGameLoop_Tick(object sender, EventArgs e)
        {
            while (isRunning)
            {
                //logic to handle player information and throw events
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            end();
        }

        private void end()
        {
            isRunning = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://honbot.freeforums.org");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
