using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureSummative
{
    public partial class Form1 : Form
    {
        int page = 0;
        int lives = 7;
        string item = "bag";
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            int chance = randGen.Next(1, 101);

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
                page = 6;
            }
            else if (page == 6)
            {
                page = 50;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 50;
            }

            //

            //else if (page == 12)
            //{
            //    page = 53 || 50;
            //}
            else if (page == 15)
            {
                page = 53;
            }
            else if (page == 16)
            {
                page = 50;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 50;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 50;
            }

            //

            //else if (page == 21)
            //{
            //    page = 22 || page = 23;
            //}
            else if (page == 22)
            {
                page = 53;
            }
            else if (page == 23)
            {
                page = 50;
            }
            else if (page == 24)
            {
                page = 53;
            }
            else if (page == 25)
            {
                page = 50;
            }
            else if (page == 50)
            {
                page = 52;
            }
            else if (page == 53)
            {
                page = 50;
            }
            else if (page == 52)
            {
                page = 0;
            }


            //

            switch (page)
            {
                case 0:
                    outputLabel.Text = $"You have {lives} remaining";
                    
                    break;
                case 1:
                    outputLabel.Text = "You wake up in the middle of nowhere in a strange realm different to your own\n. You begin to walk around and stumble upon a small bag.\n Would you like to pick it up?";
                    optionOutput1.Text = "No";

                    break;
                case 2:
                    outputLabel.Text = "You are starving trying to find food.\n You walk 1 kilometer North and thankfully you find a village.\n Will you explore it or will you continue walking?";
                    optionOutput1.Text = "Continue Walking";



                    break;
                case 3:
                    outputLabel.Text = "You are attacked by a strange man. Will you fight?";
                    optionOutput1.Text = "Fight";



                    break;
                case 5:
                    outputLabel.Text = "You decide to fight, however, the strange man pulls out a knife.\n What do you decide to do?";
                    optionOutput1.Text = "Fight";



                    break;
                case 6:
                    outputLabel.Text = "You leave but don't find any food which results in you starving to death.\n Would you like to play again?";
                    optionOutput1.Text = "Yes";



                    break;
                case 9:
                    outputLabel.Text = "You find a magic sword in the bag. Do you fight?";


                    break;
                case 10:
                    outputLabel.Text = "You tried to run away, in your attempt, you tripped. The strange man killed you. Would you like to play again?";


                    break;
                case 12:
                    outputLabel.Text = "You win the fight and the strange man tells you that you have been transported into a different realm where you must find a portal that leads back to Earth if you wish to return." +
                        "\r\n\r\nHe shows you 2 portals." +
                        "\r\n\r\nPortal 1 goes to a world where you have to fight your way through hundreds of monsters in order to get to another portal." +
                        "\r\n\r\nBeing unsure about portal 2, the man says that there is a 50% chance that it leads back to Earth.";



                    break;
                case 15:
                    outputLabel.Text = "You got through the portal safely and made it back to Earth. ";


                    break;
                case 16:
                    outputLabel.Text = "The portal led to deep space and you died. Unlucky. Would you like to play again?";


                    break;
                case 17:
                    outputLabel.Text = "You explore the village and stumble upon an elder, he explains that in order to get back to Earth, you must find a certain portal. " +
                        "\r\n\r\nYou see a bar and a tower, which one do you visit.";


                    break;
                case 18:
                    outputLabel.Text = "You meet a guy who buys you a drink and you become friends.\r\n\r\n" +
                        "You got poisoned and you died. Would you like to play again?";


                    break;
                case 19:
                    outputLabel.Text = "You feel a strong force coming from the other side of the door. Its a massive portal with someone guarding it.";


                    break;
                case 20:
                    outputLabel.Text = "You turn back. You trip on the stairs and you fall all the way down. You are then robbed by a few people and thrown into a void. Would you like to play again?";


                    break;
                case 21:
                    outputLabel.Text = "You try to run to the portal, but the portal guard stops you and tells you to choose between 2 magic pills. " +
                        "One will let you survive and go home, the other will kill you instantly. Which one will u choose?";


                    break;
                case 22:
                    outputLabel.Text = "The magic pill healed you of all wounds. You safely go through the portal and arrive back on Earth.";


                    break;
                case 23:
                    outputLabel.Text = "You die from the magic pill.\r\nWould you like to play again?";


                    break;
                case 24:
                    outputLabel.Text = "The magic pill healed you of all wounds. You safely go through the portal and arrive back on Earth.";


                    break;
                case 25:
                    outputLabel.Text = "You die from the magic pill.\r\nWould you like to play again?";


                    break;
                case 50:
                    outputLabel.Text = "Do you want to play again?";


                    break;
                case 53:
                    outputLabel.Text = "Congratulations! You finally made it to the end!";

                    break;
                default:
                    outputLabel.Text = $"{lives}";
                    optionOutput1.Text ="";
                    optionOutput1.Text ="";
                    break;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
