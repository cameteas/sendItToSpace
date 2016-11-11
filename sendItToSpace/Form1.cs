using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
                                   //Cameron Teasdale, Text Adventure Game, 11/10/16
namespace sendItToSpace
{
    public partial class Form1 : Form
    {
        int scene = 1;
        Random rand = new Random();
        int cannonKill;
        int teleChanceLow;
        int teleChanceMed;


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
        //button 1 commands
        private void button1_Click(object sender, EventArgs e)
        {
            switch (scene)
            {
                case 1:
                    scene = 3;
                    break;
                case 2:
                    scene = 997;
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
                case 8:
                    scene = 6;
                    break;
                case 11:
                    scene = 14;
                    break;
                case 12:
                    scene = 14;
                    break;
                case 13:
                case 15:
                    scene = 500;

                    break;
                case 14:
                    scene = 996;
                    break;
                case 107:
                    scene = 997;
                    break;
                case 109:
                case 996:
                    scene = 997;
                    break;
                case 113:
                    scene = 3;
                    break;
                case 500:
                case 997:
                    scene = 1;
                    break;
            }

            switch (scene)
            {
                case 1:
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
                    break;
                case 3:
                    textOutput.Text = "your supervisor bursts through the door. He screams at you for accepting a bad order \nhe sends you to jeffs office to decide your fate with the company, jeff is extatic that you accepted the order\nJeff sends you to blue origins research facilities to find a solution to get the parcel to space\n at blue origin you give the engineers some of your bright ideas to get the parcel into space";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "Use a Cannon";
                    button2.Text = "Use a teleporter";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
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
                    cannonKill = rand.Next(0, 5);
                    if (cannonKill == 1)
                    {
                        textOutput.Text = "'using less than you think is definetely a good rule of thumb' the engineers say\nyou go outside the engineers load the cannon with much less powder than you would think\n you load the parcel into the cannon, and an engineer lights the cannon\n\n the fuse runs down, 3,2,1 BOOM\n the cannon launches the parcel up up up\n but then you see it start to come down from the sky, not even close to getting into orbit. \nas the parcel returns to the earth you hear an earpearcing shriek as someone is struck by the falling package";
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "cry yourself to sleep for the next few days then go to the jail and confess confess to the police how you killed someone in a freak accident, spend the rest of your life in jail.";
                        button2.Text = null;
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;
                        scene = 107;
                    }
                    else
                    {
                        textOutput.Text = "'using less than you think is definetely a good rule of thumb' the engineers say\nyou go outside the engineers load the cannon with much less powder than you would think\n you load the parcel into the cannon, and an engineer lights the cannon\n\n the fuse runs down, 3,2,1 BOOM\n the cannon launches the parcel up up up\n but then you see it start to come down from the sky, not even close to getting into orbit.";
                        button1.Visible = true;
                        button2.Visible = true;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "try again with a different amount of gunpowder";
                        button2.Text = "go back to the drawing board";
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;

                    }
                    break;
                case 14:
                    textOutput.Text = "'ok' the engineers say\n\n they return to you in 12 hours,they are very close to finishing the entire calculation\n do you let them finish the calculation?";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "let them finish the calculation";
                    button2.Text = "teleport the parcel with the nearly finished calculations";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 500:
                    textOutput.Text = "YOU WIN \n\n would you like to play again?";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "Play Again";
                    button2.Text = "quit";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 996:
                    textOutput.Text = "While the engineers are just finishing up the orbital calculation, a giant wallaby breaks through the window and tears them all limb from limbn ";
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "Sit down and have a good cry after the giant wallaby leaves. You continue to live your life past the event but every once in a while you flash back to that giant wallaby crashing through the window and killing those people that could have been your friends maybe. You live to be an old man, but behind your happy demeanor you always have a lingering feeling of guilt for not stopping that giant wallaby. You Lie down in your old man bed, have a good cry, have a stress induced anurism and die.";
                    button1.Height = 200;
                    button2.Text = null;
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 997:
                    textOutput.Text = "You Lost \n\n Would you like to play again";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "Play Again";
                    button1.Height = 46;
                    button2.Text = "quit";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;


            }

        }
        //button 2 commands 
        private void button2_Click(object sender, EventArgs e)
        {
            switch (scene)
            {
                case 1:
                    scene = 2;
                    break;
                case 3:
                    scene = 11;
                    break;
                case 6:
                    scene = 8;
                    break;
                case 7:
                    scene = 3;
                    break;
                case 8:
                    scene = 3;
                    break;
                case 11:
                    scene = 13;
                    break;
                case 14:
                    scene = 15;
                    break;
                case 500:
                case 997:
                    scene = 998;
                    break;

            }

            switch (scene)
            {
                case 2:
                    textOutput.Text = "your supervisor bursts through the door, he screams at you and then fires you";
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "cry your heart out as you lost your job";
                    button2.Text = null;
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 3:
                    textOutput.Text = "you give the engineers some of your other bright ideas to get the parcel into space";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "Use a Cannon";
                    button2.Text = "Use a teleporter";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 8:
                    cannonKill = rand.Next(0, 10);
                    if (cannonKill == 1)
                    {
                        textOutput.Text = "'yes of course just eyeball it, its not like we are being paid thousands everyday to do work anyways' an engineer says\ndespite the engineers's sarcasm you eyeball it 'perfect you say as you dump the last of the gunpowder into the cannon \n\n an engineer reluctantly lights the fuse for you 3,2,1 BOOOOOM, the parcel moves blisteringly fast into the clouds\n you lose track of it in the sky, but the astronaut doesn't review the products on amazon.com so \nyou assume it never got to him, in reality the parcel made it all the way up to the ISS but no one had prepared for a parcel \n so the parce tapped against the ISS unbeknownst to anyone, although it did quite scare a small multicellular\nalien organism growing inside the ship. as the parcel falls back to earth the pointed nosecone of the modified amazon parcel\n falls at blistering speed and just happens to impale the billionair warren buffet as he is on his morning jog\n ";
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "cry yourself to sleep for multiple nights, you can't believe you killed warren buffet. confess to the police, go to jail for the rest of your life";
                        button2.Text = null;
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;
                        scene = 107;
                    }
                    else
                    {
                        textOutput.Text = "'yes of course just eyeball it, its not like we are being paid thousands everyday to do work anyways' an engineer says\ndespite the engineers's sarcasm you eyeball it 'perfect you say as you dump the last of the gunpowder into the cannon \n\n an engineer reluctantly lights the fuse for you 3,2,1 BOOOOOM, the parcel moves blisteringly fast into the clouds\n you lose track of it in the sky, but the astronaut doesn't review the products on amazon.com so \nyou assume it never got to him, in reality the parcel made it all the way up to the ISS but no one had prepared for a parcel \n so the parce tapped against the ISS unbeknownst to anyone, although it did quite scare a small multicellular\nalien organism growing inside the ship.";
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
                    }

                    break;
                case 11:
                    textOutput.Text = "'oh yeah We have a few of those, we don't like to use them becuase they can be faulty, but we can definitely give it a try'\n an engineer says'. 15 minutes later an engineer leads you to a room where they keep the teleporter.\n the engineers pose a problem, in order to make sure that you port it in the right place they need to do some calculations\n\n do you let the engineers take the time to calculate the port? ";
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "Yes, tell them to do some calculations";
                    button2.Text = "Nah, just eyeball it";
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    break;
                case 13:
                    textOutput.Text = "You put the parcel into the teleporter, the engineers scoff at you, you will never get it they think\n you don't have a clue of where it would be so you just mash the keypad to enter in coordinates of where the ISS will be\n you press the button, a flash of light fills the room and then you wait";
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = null;
                    button2.Text = null;
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;

                    Thread.Sleep(3000);
                    teleChanceLow = rand.Next(0, 10);
                    if (teleChanceLow == 1)
                    {
                        textOutput.Text = "You put the parcel into the teleporter, the engineers scoff at you, you will never get it they think\n you don't have a clue of where it would be so you just mash the keypad to enter in coordinates of where the ISS will be\n you press the button, a flash of light fills the room and then you wait\n\n you look at your phone to see that the astronaut rated the products meaning that he recieved them\n ";
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "throw your arms up in victory";
                        button2.Text = null;
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;
                    }
                    else
                    {
                        textOutput.Text = "You put the parcel into the teleporter, the engineers scoff at you, you will never get it they think\n you don't have a clue of where it would be so you just mash the keypad to enter in coordinates of where the ISS will be\n you press the button, a flash of light fills the room and then you wait\n\n you look at your phone to see that the astronaut has not yet rated the product meaning that he probably hasn't gotten them. ";
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "go back to the drawing board";
                        button2.Text = null;
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;
                        scene = 113;
                    }
                    break;

                case 15:
                    textOutput.Text = "You put the parcel into the teleporter, the engineers aren't really sure if it will work\n you sort of have an idea of where the ISS will be, so you put in the coordinates with some thought\n you press the button, a flash of light fills the room and then you wait";
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = null;
                    button2.Text = null;
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;

                    Thread.Sleep(3000);
                    teleChanceMed = rand.Next(0, 5);
                    if (teleChanceMed == 1)
                    {
                        textOutput.Text = "You put the parcel into the teleporter, the engineers aren't really sure if it will work\n you sort of have an idea of where the ISS will be, so you put in the coordinates with some thought\n you press the button, a flash of light fills the room and then you wait\n\n you look at your phone to see that the astronaut rated the products meaning that he recieved them\n ";
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "throw your arms up in victory";
                        button2.Text = null;
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;
                    }
                    else
                    {
                        textOutput.Text = "You put the parcel into the teleporter, the engineers aren't really sure if it will work\n you sort of have an idea of where the ISS will be, so you put in the coordinates with some thought\n you press the button, a flash of light fills the room and then you wait\n\n you look at your phone to see that the astronaut has not yet rated the product meaning that he probably hasn't gotten them. ";
                        button1.Visible = true;
                        button2.Visible = false;
                        button3.Visible = false;
                        button4.Visible = false;
                        button5.Visible = false;

                        button1.Text = "go back to the drawing board";
                        button2.Text = null;
                        button3.Text = null;
                        button4.Text = null;
                        button5.Text = null;
                        scene = 113;
                    }
                    break;
                case 998:
                    this.Close();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (scene)
            {
                case 6:
                    scene = 9;
                    break;
            }
            switch (scene)
            {
                case 9:
                    textOutput.Text = "'using more than you would think is probably a good idea' the engineers say\n with the help of the engineers you get truckload upon truckloads of gunpowder to the launch site\n the engineers construct a huge barrel for the cannon\n after a day the cannon is finally ready to be fired, you hide behind cover while\n a generally unliked engineer lights the fuse \n 3,2,1, BOOM.\n the parcel soars into the sky faster than sound.\n a few minutes later on the news you see that a projectile a has blasted into the hull of the \n multibillion dollar ISS, you are held accountable for the deaths of all the astronauts and the damage. ";
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;

                    button1.Text = "get arrested and go to jail for homocide and damage to international property";
                    button2.Text = null;
                    button3.Text = null;
                    button4.Text = null;
                    button5.Text = null;
                    scene = 109;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
