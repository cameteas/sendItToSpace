using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendItToSpace
{
    public partial class Form1 : Form
    {
        int scene = 1;



        public Form1()
        {
            InitializeComponent();
            textOutput.Text = "you work at amazon processing orders. You authorize or reject all orders that are placed on the website\n today you come into work and find that someone has ordered an hdmi cable and a toothbrush to the International space station\n\n what do you do with the order?";
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            button1.Text = "Authorize the order";
            button2.Text = "reject the order";
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (scene)
            {
                case 1:
                    scene = 3;
                    break;
                case 3:
                    scene = 6;
                    break;
                case 6:
                    scene = 7;
                    break;
                case 7:
                    scene = 6;
                    break;
            }
            
            switch (scene)
            {
                case 3:
                    textOutput.Text = "your supervisor bursts through the door. He screams at you for accepting a bad order \nhe sends you to jeffs office to decide your fate with the company, jeff is extatic that you accepted the order\nJeff sends you to blue origins research facilities to find a solution to get the parcel to space\n at blue origin you give the engineers some of your bright ideas to get the parcel into space";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;

                    button1.Text = "Use a Cannon";
                    button2.Text = "Use a teleporter";
                    button3.Text = "use an improbability drive";
                    button4.Text = "use santa";
                    button5.Text = "use Space X";
                    break;

                case 6:
                    textOutput.Text = "'A cannon' they say, 'brilliant' \n\nhow much gun powder are you going to put into the cannon?";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "a little bit";
                    button2.Text = "just the right amount";
                    button3.Text = "way too much";
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 7:
                    textOutput.Text = "'using less than you think is definetely a good rule of thumb' the engineers say\nyou go outside the engineers load the cannon with much less powder than you would think\n you load the parcel into the cannon, and an engineer lights the cannon\n\n the fuse runs down, 3,2,1 BOOM\n the cannon launches the parcel up up up\n but then you see it start to come down from the sky, not even close to getting into orbit.";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "try again with a different amount of gunpowder";
                    button2.Text = "go back to the drawing board";
                    button3.Text = "null";
                    button4.Text = null;
                    button5.Text = null;
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (scene)
            {
                case 1:
                    scene = 2;
                    break;
                case 6:
                    scene = 8;
                    break;
            }
                    
            switch (scene)
            {
                case 2:
                    textOutput.Text = "your supervisor bursts through the door, he screams at you and then fires you";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "a little bit";
                    button2.Text = "just the right amount";
                    button3.Text = "way too much";
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 8:
                    textOutput.Text = "'yes of course just eyeball it, its not like we are being paid thousands everyday to do work anyways,\ndespite the engineers's sarcasm you eyeball it 'perfect you say as you dump the last of the gunpowder into the cannon \n\n an engineer reluctantly lights the fuse for you 3,2,1 BOOOOOM, the parcel moves blisteringly fast into the clouds\n you lose track of it in the sky, but the astronaut doesn't review the products on amazon.com so \nyou assume it never got to him, in reality the parcel made it all the way up to the ISS but no one had prepared for a parcel \n so the parce tapped against the ISS unbeknownst to anyone, although it did quite scare a small multicellular\nalien organism growing inside the ship.";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "try with a different amount of gunpowder";
                    button2.Text = "go back to the drawing board";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }  
}
