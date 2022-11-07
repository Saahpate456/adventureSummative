using System;
using System.Threading;
using System.Windows.Forms;

namespace adventureSummative
{
    /// <summary> 
    /// 
    /// I have to add a button 3 for one option
    /// 
    /// I have to generate the page 10 randoms
    /// 
    /// I have to check to see if the storyline works
    /// 
    /// Make sure item works
    /// 
    /// I have to make sure that all images and sounds are added for each of the scenes
    ///     *EXTRA* I have to make sure that the lives are displayed through images throughout the story
    /// 
    /// I have to clean up code and check it over
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        int page = 0;
        int lives = 3;
        bool item;

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            int chance = randGen.Next(1, 101);

            if (lives <= 0)
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
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
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
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
            {
                page = 52;
            }

            else if (page == 52)
            {
                page = 1;
            }
            ///Rand 70%
            if (page == 22 && chance > 81)
            {
                page = 25;

                if (page == 25)
                {
                    page = 50;
                }
                ///25% rand
                if (page == 50 && chance > 1 && chance < 25)
                {
                    page = 51;

                    if (page == 51)
                    {
                        outputLabel.Text = "You can't respawn anymore.";
                        Thread.Sleep(3000);
                        Application.Exit();
                    }
                }
                else if (page == 50 && chance > 25)
                {
                    page = 52;
                }
            }
            else if (page == 22 && chance > 1 && chance < 71)
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
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
            {
                page = 52;
            }

            else if (page == 52)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 50;
            }
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
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
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
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
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
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
            ///25% rand
            if (page == 50 && chance > 1 && chance < 25)
            {
                page = 51;

                if (page == 51)
                {
                    outputLabel.Text = "You can't respawn anymore.";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 50 && chance > 25)
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
                    optionButton1.Text = "";
                    optionButton2.Text = "";
                    break;
                case 1:
                    outputLabel.Text = $"you have {lives} lives left.";
                    optionOutput1.Text = "Ok";
                    optionOutput2.Text = "Continue";

                    optionButton1.Text = "";
                    optionButton2.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "You wake up in the middle of nowhere in a\n strange realm different to your own. You begin to walk\n around and stumble upon a small bag.\n Would you like to pick it up?";
                    optionOutput1.Text = "No";
                    optionOutput2.Text = "Yes";
                    break;
                case 3:
                    outputLabel.Text = "You are starving trying to find food.\n You walk 1 kilometer North and thankfully you find a village.\n Will you explore it or will you continue walking?";
                    optionOutput1.Text = "Continue walking";
                    optionOutput2.Text = "Explore";
                    break;
                case 5:
                    outputLabel.Text = "You are attacked by a strange man. Will you fight?";
                    optionOutput1.Text = "Fight";
                    optionOutput2.Text = "Run";
                    break;
                case 9:
                    outputLabel.Text = "You decide to fight, however, the strange man pulls out a knife.\n What do you decide to do?";
                    optionOutput1.Text = "Continue to fight";
                    optionOutput2.Text = "Search Bag";
                    break;
                case 14:
                    outputLabel.Text = "You tried to fight him but he killed you right away.";
                    optionOutput1.Text = "Continue";
                    optionOutput2.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "Would you like to play again?";
                    optionOutput1.Text = "Yes";
                    optionOutput2.Text = "No";
                    break;
                case 52:
                    outputLabel.Text = "You have respawned!";
                    optionOutput1.Text = "Continue";
                    optionOutput2.Text = "";
                    lives = lives - 1;
                    break;
                case 12:
                    outputLabel.Text = "You find a magic sword in the bag. Do you fight or run?";
                    optionOutput1.Text = "Run";
                    optionOutput2.Text = "Fight";
                    break;
                case 20:
                    outputLabel.Text = "You tried to run away, in your attempt, you tripped.\n The strange man killed you.\n Would you like to play again?";
                    optionOutput1.Text = "Yes";
                    optionOutput2.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "You win the fight and the \nstrange man tells you that you have been transported\n into a different realm where you must find a portal that\n leads back to Earth if you wish to return.\n" +
                        "He shows you 2 portals.\nPortal 1 goes\n to a world where you have to fight your way through\n hundreds of monsters in order to get to another portal.\nBeing unsure about portal 2, the man says that\n there is a 50% chance that it leads back to Earth.";
                    optionOutput1.Text = "Portal 1";
                    optionOutput2.Text = "Portal 2";
                    break;
                case 26:
                    outputLabel.Text = "You got through the portal safely and made it back to Earth.";
                    optionOutput1.Text = "Continue";
                    optionOutput2.Text = "";
                    break;
                case 54:
                    outputLabel.Text = "Congratulations! You finally made it to the end!";
                    optionOutput1.Text = "Continue";
                    optionOutput2.Text = "";
                    lives = lives + 3;
                    Thread.Sleep(4000);
                    outputLabel.Text = "With these extra 3 lives you shall go find a new ending!";
                    break;
                case 25:
                    outputLabel.Text = "The portal led to deep space and you died.\n Unlucky. \nWould you like to play again?";
                    optionOutput1.Text = "Yes";
                    optionOutput2.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "You explore the village and stumble upon an elder,\n he explains that in order to get back to Earth,\n you must find a certain portal. " +
                        "\r\n\r\nYou see a bar and a tower,\n which one do you visit.";
                    optionOutput1.Text = "Bar";
                    optionOutput2.Text = "Tower";
                    break;
                case 7:
                    outputLabel.Text = "You meet a guy who buys you a drink and you become friends.\nYou got poisoned and you died. \nWould you like to play again?";
                    optionOutput1.Text = "Yes";
                    optionOutput2.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "You feel a strong force coming\n from the other side of the door.\n Its a massive portal with someone guarding it.\n Do you approach?";
                    optionOutput1.Text = "No";
                    optionOutput2.Text = "Yes";
                    break;
                case 11:
                    outputLabel.Text = "You turn back. You trip on the\n stairs and you fall all the way down.\n You are then robbed by a few people and thrown into a void.\n Would you like to play again?";
                    optionOutput1.Text = "Yes";
                    optionOutput2.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You try to run to the portal, but the portal \nguard stops you and tells you to choose between 2 magic pills.\n One will let you survive and go home, \nthe other will kill you instantly. Which one will u choose?";
                    optionOutput1.Text = "Blue";
                    optionOutput2.Text = "Red";
                    break;
            }
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            int chance = randGen.Next(1, 101);
            if (lives <= 0)
            {
                outputLabel.Text = "You have run out of lives,\n thanks for playing!";
                Thread.Sleep(5000);
                Application.Exit();
            }

            if (page == 0)
            {
                page = 53;
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
            ///25% rand
            if (page == 12 && chance > 81)
            {
                page = 21;

                if (page == 21)
                {
                    page = 50;
                }
                else if (page == 50)
                {
                    page = 53;
                }
                else if (page == 53)
                {
                    outputLabel.Text = "Thanks for playing!";
                    Thread.Sleep(3000);
                    Application.Exit();
                }
            }
            else if (page == 12 && chance > 1 && chance < 81)
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
            switch (page)
            {
                case 0:
                    outputLabel.Text = "";
                    optionButton2.Text = "";
                    break;
                case 1:
                    outputLabel.Text = $"you have {lives} lives left.";
                    optionOutput2.Text = "Continue";
                    optionOutput1.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "You wake up in the middle of nowhere\n in a strange realm different to your own.\n You begin to walk around and stumble upon a small bag.\n Would you like to pick it up?";
                    optionOutput2.Text = "Yes";
                    optionOutput1.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "You are starving trying to find food.\n You walk 1 kilometer North and thankfully you find a village.\n Will you explore it or will you continue walking?";
                    optionOutput2.Text = "Explore";
                    optionOutput1.Text = "Continue Walking";
                    break;
                case 4:
                    outputLabel.Text = "You explore the village and stumble upon an elder,\n he explains that in order to get back to Earth,\n you must find a certain portal. \nYou see a bar and a tower, which one do you visit.";
                    optionOutput2.Text = "Tower";
                    optionOutput1.Text = "Bar";
                    break;
                case 6:
                    outputLabel.Text = "You feel a strong force coming from the other side of the door.\n Its a massive portal with someone guarding it. Do you approach?";
                    optionOutput2.Text = "Yes";
                    optionOutput1.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You try to run to the portal, \nbut the portal guard stops you and tells you to choose between 2 magic pills. \nOne will let you survive and go home, the other will\n kill you instantly. Which one will u choose?";
                    optionOutput2.Text = "Red";
                    optionOutput1.Text = "Blue";
                    break;
                case 16:
                    outputLabel.Text = "You die from the magic pill.\n Would you like to play again?";
                    optionOutput2.Text = "No";
                    optionOutput1.Text = "Yes";
                    break;
                case 17:
                    outputLabel.Text = "The magic pill healed you of all wounds.\n You safely go through the portal and arrive back on Earth.";
                    optionOutput2.Text = "Continue";
                    optionOutput2.Text = "";
                    break;
                case 54:
                    outputLabel.Text = "Congratulations! You finally made it to the end!";
                    optionOutput2.Text = "Continue";
                    optionOutput1.Text = "";
                    lives = lives + 3;
                    break;
                case 50:
                    outputLabel.Text = "Do you want to play again?";
                    optionOutput2.Text = "Yes";
                    optionOutput1.Text = "No";
                    break;
                case 52:
                    outputLabel.Text = "You have respawned!";
                    optionOutput2.Text = "Continue";
                    optionOutput1.Text = "";
                    lives = lives - 1;
                    break;
                case 53:
                    outputLabel.Text = "Thanks for playing!";
                    optionOutput2.Text = "";
                    optionOutput1.Text = "";
                    Thread.Sleep(3000);
                    Application.Exit();
                    break;
                case 5:
                    outputLabel.Text = "You are attacked by a strange man. Will you fight?";
                    optionOutput2.Text = "Run";
                    optionOutput1.Text = "Fight";
                    break;
                case 8:
                    outputLabel.Text = "You tried to run away, in your attempt, you tripped.\n The strange man killed you. Would you like to play again?";
                    optionOutput2.Text = "No";
                    optionOutput1.Text = "Yes";
                    break;
                case 9:
                    outputLabel.Text = "You decide to fight, however, the strange man\n pulls out a knife. What do you decide to do?";
                    optionOutput2.Text = "Search Bag";
                    optionOutput1.Text = "Continue to Fight";
                    break;
                case 12:
                    outputLabel.Text = "You find a magic sword in the bag.\n Do you fight?";
                    optionOutput2.Text = "Fight";
                    optionOutput1.Text = "Run";
                    
                    break;
                case 21:
                    outputLabel.Text = "You tried to fight but missed the finishing attack and died.\n Would you like to play again?";
                    optionOutput2.Text = "No";
                    optionOutput1.Text = "Yes";
                    break;
                case 22:
                    outputLabel.Text = "You win the fight and the strange man tells\n you that you have been transported \ninto a different realm where you must find a portal that leads\n back to Earth if you wish to return. He shows you 2 portals.\nPortal 1 goes to a world where you have to fight your way\n through hundreds of monsters in order to get to another portal.\nBeing unsure about portal 2, the man says that there is a \n50% chance that it leads back to Earth.";
                    optionOutput2.Text = "Portal 1";
                    optionOutput1.Text = "Portal 2";
                    break;
                case 23:
                    outputLabel.Text = "You entered the new realm and defeated many monsters but then you died\n falling into the void. Would you like to play again?";
                    optionOutput2.Text = "No";
                    optionOutput1.Text = "Yes";
                    break;
            }
        }

        private void extraButton_Click(object sender, EventArgs e)
        {

        }

        private void background3_Click(object sender, EventArgs e)
        {

        }

        private void extraOutput_Click(object sender, EventArgs e)
        {

        }

        private void optionOutput2_Click(object sender, EventArgs e)
        {

        }

        private void optionOutput1_Click(object sender, EventArgs e)
        {

        }
    }
}
