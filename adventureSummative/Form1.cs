using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureSummative
{
    /// <summary>
    /// Finish button 1
    /// 
    /// I have to finish button 2
    /// 
    /// I have to add a button 3 for one option
    /// 
    /// I have to add the item and make it affect the timeline
    /// 
    /// I have to generate the randoms
    /// 
    /// I have to check to see if the storyline works
    /// 
    /// I have to make sure that all images and sounds are added for each of the scenes
    /// 
    /// *EXTRA* I have to make sure that the lives are displayed through images throughout the story
    /// 
    /// I have to clean up code and check it over
    /// 
    /// I have to submit everything on time
    /// </summary>
    public partial class Form1 : Form
    {
        int page = 0;
        int lives = 3;
        bool item = false;

        Random randGen = new Random();
        
    public Form1()
        {
            InitializeComponent();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            optionButton1.Text = "";
            int chance = randGen.Next(1, 101);

            if (lives < 0)
            {
                outputLabel.Text = "You have run out of lives,\n thanks for playing!";
                Thread.Sleep(5000);
                Application.Exit();
            }



            if (page == 0)
            {
                page = 1;
            }
            else if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }





            else if (page == 12)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }


            else if (page == 22)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 54;
            }
            else if (page == 54)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }



            else if (page == 22)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }

            //from here

            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }


            else if (page == 6)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }


            else if (page == 10)
            {
                page = 19;
            }
            else if (page == 19)
            {
                page = 54;
            }
            else if (page == 54)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }


            else if (page == 10)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }



            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 54;
            }
            else if (page == 54)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }


            else if (page == 10)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 52)
            {
                page = 1;
            }

            switch (page)
            {
                case 0:
                    outputLabel.Text = "";
                    optionOutput1.Text = "";

                    break;
                case 1:
                    outputLabel.Text = $"you have {lives} lives left.";
                    optionOutput1.Text = "Ok";
                    Thread.Sleep(3000);

                    break;
                case 2:
                    outputLabel.Text = "You wake up in the middle of nowhere in a strange realm different to your own.\n You begin to walk around and stumble upon a small bag.\n Would you like to pick it up?";
                    optionOutput1.Text = "No";


                    break;
                case 3:
                    outputLabel.Text = "You are starving trying to find food.\n You walk 1 kilometer North and thankfully you find a village.\n Will you explore it or will you continue walking?";
                    optionOutput1.Text = "Continue walking";

                    break;
                case 5:
                    outputLabel.Text = "You are attacked by a strange man. Will you fight?";
                    optionOutput1.Text = "Fight";


                    break;
                case 9:
                    outputLabel.Text = "You decide to fight, however, the strange man pulls out a knife.\n What do you decide to do?";
                    optionOutput1.Text = "Continue to fight";


                    break;
                case 14:
                    outputLabel.Text = "You tried to fight him but he killed you right away.";
                    Thread.Sleep(5000);
                    optionOutput1.Text = "Continue";

                    break;
                case 15:
                    outputLabel.Text = "Would you like to play again?";
                    optionOutput1.Text = "Yes";


                    break;
                case 52:
                    outputLabel.Text = "You have respawned!";
                    optionOutput1.Text = "Continue";
                    lives = lives - 1;
                    
                    break;
                case 12:
                    outputLabel.Text = "You find a magic sword in the bag. Do you fight or run?";
                    optionOutput1.Text = "Run";
                    

                    break;
                case 20:
                    outputLabel.Text = "You tried to run away, in your attempt, you tripped.\n The strange man killed you.\n Would you like to play again?";
                    optionOutput1.Text = "Yes";


                    break;
                case 22:
                    outputLabel.Text = "You win the fight and the strange man tells you that you have been transported\n into a different realm where you must find a portal that\n leads back to Earth if you wish to return.\n\r\n\r\n\n" +
                        "He shows you 2 portals.\r\n\r\nPortal 1 goes\n to a world where you have to fight your way through\n hundreds of monsters in order to get to another portal.\nr\n\r\nBeing unsure about portal 2, the man says that\n there is a 50% chance that it leads back to Earth.";
                    optionOutput1.Text = "Portal 1";


                    break;
                case 26:
                    outputLabel.Text = "You got through the portal safely and made it back to Earth.";
                    optionOutput1.Text = "Continue";


                    break;
                case 54:
                    outputLabel.Text = "Congratulations! You finally made it to the end!";
                    optionOutput1.Text = "Continue";
                    lives = lives + 3;
                    Thread.Sleep(4000);
                    outputLabel.Text = "With these extra lives you shall go find a new ending!";

                    break;
                case 25:
                    outputLabel.Text = "The portal led to deep space and you died.\n Unlucky. Would you like to play again?";
                    optionOutput1.Text = "Yes";


                    break;
                case 4:
                    outputLabel.Text = "You explore the village and stumble upon an elder,\n he explains that in order to get back to Earth,\n you must find a certain portal. " +
                        "\r\n\r\nYou see a bar and a tower,\n which one do you visit.";
                    optionOutput1.Text = "Bar";


                    break;
                case 7:
                    outputLabel.Text = "You meet a guy who buys you a drink and you become friends.\n\r\n\r\nYou got poisoned and you died. Would you like to play again?";
                    optionOutput1.Text = "Yes";


                    break;
                case 6:
                    outputLabel.Text = "You feel a strong force coming from the other side of the door.\n Its a massive portal with someone guarding it.";
                    optionOutput1.Text = "No";


                    break;
                case 11:
                    outputLabel.Text = "You turn back. You trip on the stairs and you fall all the way down.\n You are then robbed by a few people and thrown into a void.\n Would you like to play again?";
                    optionOutput1.Text = "Yes";


                    break;
                case 10:
                    outputLabel.Text = "";
                    optionOutput1.Text = "";


                    break;
            }
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            optionButton2.Text = "";

            if (page == 0)
            {
                page = 1;
            }
            else if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 10;
            }

            else if (page == 10)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 53;
            }



            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 54;
            }
            else if (page == 54)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 53;
            }

            

            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 53;
            }
            

            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 53;
            }


            //switch (page)
            //{
            //    case 0:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;

            //        break;
            //    case 1:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 2:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 3:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 4:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 5:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 6:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 7:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 8:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 9:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 10:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 11:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 12:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 13:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 14:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //    case 15:
            //        outputLabel.Text = ;
            //        optionOutput1.Text = ;


            //        break;
            //}
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
