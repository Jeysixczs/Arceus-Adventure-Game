using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Arceus_Adventure_Game
{
    public class Enemy : Player
    {
        Random rnd = new Random();

        public Enemy(string name, int health, int attack, int defense, int mana) : base(name, health, attack, defense, mana)
        {
        }

        public async Task Delay(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }


        public async Task Attackai(Player player, Player enemy, WindowsMediaPlayer healingsound, WindowsMediaPlayer attacksound, PictureBox PlayerPictureBox, PictureBox EnemyPictureBox)
        {


            int attack = rnd.Next(1, 5);
            if (attack == 1)
            {
                MessageBox.Show("AI used Basic Attack!");
                attacksound.settings.volume = 100;
                PlayerPictureBox.Image = Properties.Resources.Poison_Cloud;
                attacksound.controls.play();


                player.Health -= 10;
                enemy.Mana += 10;
                if (enemy.Mana >= 100)
                {
                    enemy.Mana = 100;
                }
            }
            else if (attack == 2)
            {
                PlayerPictureBox.Image = Properties.Resources.Poison_Cloud;
                attacksound.controls.play();
                MessageBox.Show("AI used Growl!");
                player.Health -= 20;
                enemy.Mana -= 20;

            }
            else if (attack == 3)
            {
                PlayerPictureBox.Image = Properties.Resources.Poison_Cloud;
                attacksound.controls.play();
                MessageBox.Show("AI used Tail Whip!");
                player.Health -= 30;

            }
            else if (attack == 4)
            {
                healingsound.controls.play();
                if (enemy.Mana >= 30)
                {
                    PlayerPictureBox.Image = Properties.Resources.skelidle;
                    MessageBox.Show("AI used Healing");
                    enemy.Health += 40;

                    enemy.Mana -= 30;

                    if (enemy.Health > 100)
                    {
                        enemy.Health = 100;
                    }
                }
                else
                {
                    MessageBox.Show("Enemy tried to heal but failed due to low mana");
                }
            }

            else if (attack == 5)
            {
                MessageBox.Show("Ai Missed You");
                player.Health += 0;


            }

            if (player.Health < 0)
            {
                player.Health = 0;
            }
            await Delay(300);

        }
    }
}
