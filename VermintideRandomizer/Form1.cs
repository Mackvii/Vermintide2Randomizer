using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace VermintideRandomizer
{
    public partial class Randomizer : Form
    {
        private static object rnd;
        static public Random rand = new Random((int)DateTime.Now.Ticks);
        public Randomizer()
        {
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hero = 0, career = 0, meleeWep = 0, rangedWep = 0, heroes = 5,

                kruberCareerCount = 4, bardinCareerCount = 4, kerillianCareerCount = 4, viktorCareerCount = 3, siennaCareerCount = 3,

                KruMeleeCar1 = 12, KruMeleeCar2 = 12, KruMeleeCar3 = 11, KruMeleeAndRangedCar4 = 10, KruRangedCar1 = 3, KruRangedCar2 = 4, KruRangedCar3 = 3,

                BarMeleeCar1 = 9, BarMeleeCar2 = 9,  BarMeleeAndRangedCar3 = 8, BarMeleeCar4 = 9, BarRangedCar1 = 5, BarRangedCar2 = 7, BarRangedCar4 = 6,

                KerMeleeCar1 = 8, KerMeleeCar2 = 9, KerMeleeCar3 = 8, KerMeleeCar4 = 8, KerRangedCar1 = 5, KerRangedCar2 = 5, KerRangedCar3 = 6, KerRangedCar4 = 6,

                VikMeleeCar1 = 7, VikMeleeCar2 = 7, VikMeleeCar3 = 7, VikRangedCar1 = 5, VikRangedCar2 = 5, VikRangedCar3 = 5,

                SieMeleeCar1 = 6, SieMeleeCar2 = 6, SieMeleeCar3 = 6, SieRangedCar1 = 6, SieRangedCar2 = 6, SieRangedCar3 = 6;

            string heroGotten, CareerGotten;


            // Kruber career 1 melee weapons (Kru = Kruber, Mel = melee, Car = career)  count = 12
            string[] KruMelCar1 = { "Bretonnian Longsword", "Executioner Sword", "Great hammer", "great sword",
                "halberd", "Mace", "mace and shield", "Spear and shield",
                "Sword",  "Sword and Shield", "Mace and Sword", "Tuskgor Spear"};

            // Kruber career 1 melee weapons (Kru = Kruber, Mel = melee, Car = career)  count = 12
            string[] KruMelCar2 = { "Bretonnian Longsword", "Executioner Sword", "Great hammer", "great sword",
                "halberd", "Mace", "mace and shield", "Spear and shield",
                "Sword",  "Sword and Shield", "Mace and Sword", "Tuskgor Spear"};

            // Kruber career 1 melee weapons (Kru = Kruber, Mel = melee, Car = career)  count = 11
            string[] KruMelCar3 = { "Bretonnian Longsword", "Executioner Sword", "Great hammer", "great sword",
                "halberd", "Mace", "mace and shield", "Spear and shield",
                "Sword",  "Sword and Shield", "Mace and Sword"};

            // Grail Knight has same ranged as melee      count = 10
            string[] KruMelAndRanCar4 = {"Bretonnian Longsword", "Executioner Sword", "Great hammer", "great sword",
                "Mace", "mace and shield", "Bretonnian Sword and Shield", "Sword", "Sword and Shield", "Mace and Sword"};
            
            //Kruber Career 1 Ranged weapons (Kru = Kruber, Ran = Ranged, Car = career)  count = 3
            string[] KruRanCar1 = { "Blunderbuss", "handgun", "Repeater handgun" };

            //Kruber Career 2 Ranged weapons count = 4
            string[] KruRanCar2 = { "Blunderbuss", "handgun", "Repeater handgun", "longbow"};

            //Kruber Career 3 Ranged weapons (Kru = Kruber, Ran = Ranged, Car = career)  count = 3
            string[] KruRanCar3 = { "Blunderbuss", "handgun", "Repeater handgun" };

            // Bardin career 1 melee weapons count = 9
            string[] BarMelCar1 = {"Axe", "Axe and Shield", "Cog hammer", "Dual hammers",
                "Great axe",  "Great Hammer", "hammer and shield",
                "hammer", "Pickaxe"};

            // Bardin career 2 melee weapons count = 9
            string[] BarMelCar2 = {"Axe", "Axe and Shield", "Cog hammer", "Dual hammers",
                "Great axe",  "Great Hammer", "hammer and shield",
                "hammer", "Pickaxe"};

            //Bardin career 3 same melee as ranged count = 8
            string[] BarMelCar3 = {"Axe", "dual Axes",  "Cog hammer", "Dual hammers",
                "Great axe", "Great Hammer", "hammer", "Pickaxe"};

            // Bardin career 4 melee weapons count = 9
            string[] BarMelCar4 = {"Axe", "Axe and Shield", "Cog hammer", "Dual hammers",
                "Great axe",  "Great Hammer", "hammer and shield",
                "hammer", "Pickaxe"};

            //bardin career 1 ranged weapons count = 5
            string[] BarRanCar1 = { "Crossbow", "Grude-Raker", "Handgun", "Masterwork Pistol", "Trowing axes" };

            //bardin career 2 ranged weapons count = 7

            string[] BarRanCar2 = {"Crossbow", "Grude-Raker", "Handgun", "Masterwork Pistol", "Trollhammer Torpedo",
                "Drakefire Pistols", "Drakegun" };

            //bardin career 4 ranged weapons count = 6

            string[] BarRanCar4 = {"Grude-Raker", "Handgun", "Masterwork Pistol", "Trollhammer Torpedo",
                "Drakefire Pistols", "Drakegun" };

            //Kerillian career 1 melee weapons  count = 8

            string[] KerMelCar1 = {"Dual daggers", "Dual swords", "Elven Axe", "Elven spear",
                "Glaive", "Sword", "Sword and dagger", "Great sword"};

            //Kerillian handmaiden melee weapons count = 9

            string[] KerMelCar2 = {"Dual daggers", "Dual swords", "Elven Axe", "Elven spear", "Glaive", "Sword", "Sword and dagger", "Great sword", "Spear and shield" };

            //Kerillian career 3 melee weapons  count = 8

            string[] KerMelCar3 = {"Dual daggers", "Dual swords", "Elven Axe", "Elven spear",
                "Glaive", "Sword", "Sword and dagger", "Great sword"};

            //Kerillian career 4 melee weapons  count = 8

            string[] KerMelCar4 = {"Dual daggers", "Dual swords", "Elven Axe", "Elven spear",
                "Glaive", "Sword", "Sword and dagger", "Great sword"};


            //Kerillian career1 ranged weapons count = 5

            string[] KerRanCar1 = {"Briar Javelin", "Hagbane Shortbow", "Longbow", "Moonfire bow", "Swift bow"};

            //Kerillian career2 ranged weapons count = 5

            string[] KerRanCar2 = { "Briar Javelin", "Hagbane Shortbow", "Longbow", "Moonfire bow", "Swift bow" };

            //Kerillian career3 ranged weapons count = 6

            string[] KerRanCar3 = {"Briar Javelin", "Hagbane Shortbow", "Longbow", "Moonfire bow", "Swift bow", "Volley Crossbow" };

            //Kerillian career4 ranged weapons count = 6

            string[] KerRanCar4 = {"Briar Javelin", "Hagbane Shortbow",  "Longbow", "Moonfire bow", "Swift bow", "Deepwood Staff"};


            //Viktor career 1 melee weapons count = 7
            string[] VikMelCar1 = {"Axe", "Axe and falchion","Bill hook","Falchion", "Flail","Greatsword", "Rapier" };

            //Viktor career 2 melee weapons count = 7
            string[] VikMelCar2 = { "Axe", "Axe and falchion", "Bill hook", "Falchion", "Flail", "Greatsword", "Rapier" };

            //Viktor career 3 melee weapons count = 7
            string[] VikMelCar3 = { "Axe", "Axe and falchion", "Bill hook", "Falchion", "Flail", "Greatsword", "Rapier" };

            //Viktor career 1 ranged weapons count = 5
            string[] VikRanCar1 = {"Brace of Pistols", "Crossbow", "Griffon-foot", "Repeater Pistol", "Volley Crossbow"};

            //Viktor career 2 ranged weapons count = 5
            string[] VikRanCar2 = { "Brace of Pistols", "Crossbow", "Griffon-foot", "Repeater Pistol", "Volley Crossbow" };

            //Viktor career 3 ranged weapons count = 5
            string[] VikRanCar3 = { "Brace of Pistols", "Crossbow", "Griffon-foot", "Repeater Pistol", "Volley Crossbow" };
            
            //Sienna career 1 melee weapons count = 6
            string[] SieMelCar1 = {"Dagger", "Fire Sword", "Flaming Flail", "Mace", "Sword", "Crowbill"};

            //Sienna career 2 melee weapons count = 6
            string[] SieMelCar2 = { "Dagger", "Fire Sword", "Flaming Flail", "Mace", "Sword", "Crowbill" };

            //Sienna career 3 melee weapons count = 6
            string[] SieMelCar3 = { "Dagger", "Fire Sword", "Flaming Flail", "Mace", "Sword", "Crowbill" };

            //Sienna career 1 ranged weapons count = 6
            string[] SieRanCar1 = { "Beam staff", "Bolt Staff", "Conflagration Staff", "Coruscation Staff", "Fireball Staff", "Flamestorm Staff" };

            //Sienna career 2 ranged weapons count = 6
            string[] SieRanCar2 = { "Beam staff", "Bolt Staff", "Conflagration Staff", "Coruscation Staff", "Fireball Staff", "Flamestorm Staff" };

            //Sienna career 3 ranged weapons count = 6
            string[] SieRanCar3 = { "Beam staff", "Bolt Staff", "Conflagration Staff", "Coruscation Staff", "Fireball Staff", "Flamestorm Staff" };


            int RollDie(int anumber)
            {
                int number;
                
                number = rand.Next(1, anumber+1);

                return number;
            }

            void PrintInfo(string Hero, string Career, string[] meleeString, string[] rangeString, int meleeNumber, int rangedWeapon)
            {
                
               // MessageBox.Show("Heronumber was: " + hero + "\nCareernumber was: " + career + "\nMeleewepnumber: " + meleeWep + "\nlRangednumber: " + rangedWep);  // just to check if the numbers was represented correctly
                MessageBox.Show("Your hero: " + heroGotten + "\nYour career: " + CareerGotten + "\nYour melee weapon: " + meleeString[meleeWep - 1] + "\nYour Ranged weapon: " + rangeString[rangedWep - 1]);
            }

            
            hero = RollDie(heroes);
            switch (hero)
            {
                case 1:
                    heroGotten = "Markus Kruber";
                    career = RollDie(kruberCareerCount);
                    switch (career)
                    {
                        case 1:
                            CareerGotten = "Mercenary";
                            meleeWep = RollDie(KruMeleeCar1);
                            rangedWep = RollDie(KruRangedCar1);
                            PrintInfo(heroGotten, CareerGotten, KruMelCar1, KruRanCar1, meleeWep, rangedWep);
                            break;

                        case 2:
                            CareerGotten = "Huntsman";
                            meleeWep = RollDie(KruMeleeCar2);
                            rangedWep = RollDie(KruRangedCar2);
                            PrintInfo(heroGotten, CareerGotten, KruMelCar2, KruRanCar2, meleeWep, rangedWep);
                            break;
                            
                        case 3:
                            CareerGotten = "Foot Knight";
                            meleeWep = RollDie(KruMeleeCar3);
                            rangedWep = RollDie(KruRangedCar3);
                            PrintInfo(heroGotten, CareerGotten, KruMelCar3, KruRanCar3, meleeWep, rangedWep);
                            break;

                        case 4:
                            CareerGotten = "Grail Knight";
                            meleeWep = RollDie(KruMeleeAndRangedCar4);

                            while ((rangedWep = RollDie(KruMeleeAndRangedCar4)) == meleeWep) ;

                            PrintInfo(heroGotten, CareerGotten, KruMelAndRanCar4, KruMelAndRanCar4, meleeWep, rangedWep);
                             break;

                        default:
                            MessageBox.Show("error");
                            break;
                    }
                        break;
                case 2:
                    heroGotten = "Bardin Goreksson";
                    career = RollDie(bardinCareerCount);
                    switch (career)
                    {
                        case 1:
                            CareerGotten = "Ranger Veteran";
                            meleeWep = RollDie(BarMeleeCar1);
                            rangedWep = RollDie(BarRangedCar1);
                            PrintInfo(heroGotten, CareerGotten, BarMelCar1, BarRanCar1, meleeWep, rangedWep);
                            break;

                        case 2:
                            CareerGotten = "Ironbreaker";
                            meleeWep = RollDie(BarMeleeCar2);
                            rangedWep = RollDie(BarRangedCar2);
                            PrintInfo(heroGotten, CareerGotten, BarMelCar2, BarRanCar2, meleeWep, rangedWep);
                            break;

                        case 3:
                            CareerGotten = "Slayer";
                            meleeWep = RollDie(BarMeleeAndRangedCar3);
                            while ((rangedWep = RollDie(BarMeleeAndRangedCar3)) == meleeWep) ;
                            PrintInfo(heroGotten, CareerGotten, BarMelCar3, BarMelCar3, meleeWep, rangedWep);
                            break;

                        case 4:
                            CareerGotten = "Outcast Engineer";
                            meleeWep = RollDie(BarMeleeCar4);
                            rangedWep = RollDie(BarRangedCar4);
                            PrintInfo(heroGotten, CareerGotten, BarMelCar4, BarRanCar4, meleeWep, rangedWep);
                            break;

                        default:
                            MessageBox.Show("error");
                            break;
                    }
                    break;
                case 3:
                    heroGotten = "Kerillian";
                    career = RollDie(kerillianCareerCount);

                    switch (career)
                    {
                        case 1:
                            CareerGotten = "Waystalker";
                            meleeWep = RollDie(KerMeleeCar1);
                            rangedWep = RollDie(KerRangedCar1);
                            PrintInfo(heroGotten, CareerGotten, KerMelCar1, KerRanCar1, meleeWep, rangedWep);
                            break;

                        case 2:
                            CareerGotten = "Handmaiden";
                            meleeWep = RollDie(KerMeleeCar2);
                            rangedWep = RollDie(KerRangedCar2);
                            PrintInfo(heroGotten, CareerGotten, KerMelCar2, KerRanCar2, meleeWep, rangedWep);
                            break;

                        case 3:
                            CareerGotten = "Shade";
                            meleeWep = RollDie(KerMeleeCar3);
                            rangedWep = RollDie(KerRangedCar3);
                            PrintInfo(heroGotten, CareerGotten, KerMelCar3, KerRanCar3, meleeWep, rangedWep);
                            break;

                        case 4:
                            CareerGotten = "Sister of the Thorne";
                            meleeWep = RollDie(KerMeleeCar4);
                            rangedWep = RollDie(KerRangedCar4);
                            PrintInfo(heroGotten, CareerGotten, KerMelCar4, KerRanCar4, meleeWep, rangedWep);
                            break;

                        default:
                            MessageBox.Show("error");
                            break;
                    }

                    break;
                case 4:
                    heroGotten = "Viktor Saltzpyre";
                    career = RollDie(viktorCareerCount);

                    switch (career)
                    {
                        case 1:
                            CareerGotten = "Witch Hunter Captain";
                            meleeWep = RollDie(VikMeleeCar1);
                            rangedWep = RollDie(VikRangedCar1);
                            PrintInfo(heroGotten, CareerGotten, VikMelCar1, VikRanCar1, meleeWep, rangedWep);
                            break;

                        case 2:
                            CareerGotten = "Bounty Hunter";
                            meleeWep = RollDie(VikMeleeCar2);
                            rangedWep = RollDie(VikRangedCar2);
                            PrintInfo(heroGotten, CareerGotten, VikMelCar2, VikRanCar2, meleeWep, rangedWep);
                            break;

                        case 3:
                            CareerGotten = "Zealot";
                            meleeWep = RollDie(VikMeleeCar3);
                            rangedWep = RollDie(VikRangedCar3);
                            PrintInfo(heroGotten, CareerGotten, VikMelCar3, VikRanCar3, meleeWep, rangedWep);
                            break;

                        default:
                            MessageBox.Show("error");
                            break;
                    }

                    break;
                case 5:
                    heroGotten = "Sienna Fuegonasus";
                    career = RollDie(siennaCareerCount);

                    switch (career)
                    {
                        case 1:
                            CareerGotten = "Battle Wizard";
                            meleeWep = RollDie(SieMeleeCar1);
                            rangedWep = RollDie(SieRangedCar1);
                            PrintInfo(heroGotten, CareerGotten, SieMelCar1, SieRanCar1, meleeWep, rangedWep);
                            break;

                        case 2:
                            CareerGotten = "Pyromancer";
                            meleeWep = RollDie(SieMeleeCar2);
                            rangedWep = RollDie(SieRangedCar2);
                            PrintInfo(heroGotten, CareerGotten, SieMelCar2, SieRanCar2, meleeWep, rangedWep);
                            break;

                        case 3:
                            CareerGotten = "Unchained";
                            meleeWep = RollDie(SieMeleeCar3);
                            rangedWep = RollDie(SieRangedCar3);
                            PrintInfo(heroGotten, CareerGotten, SieMelCar3, SieRanCar3, meleeWep, rangedWep);
                            break;

                        default:
                            MessageBox.Show("error");
                            break;
                    }

                    break;

            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }
        
    }
}
