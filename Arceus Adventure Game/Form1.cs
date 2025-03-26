using Arceus_Adventure_Game.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Arceus_Adventure_Game
{
    public partial class Form1 : Form
    {
        private Player player = new Player("Skitty", 100, 10, 100, 100);
        private Enemy enemy = new Enemy("Skelly", 100, 10, 100, 100);

        public WindowsMediaPlayer backgroundPlayer = new WindowsMediaPlayer();
        public WindowsMediaPlayer soundEffectPlayer = new WindowsMediaPlayer();
        public WindowsMediaPlayer healingsound = new WindowsMediaPlayer();
        public WindowsMediaPlayer attacksound = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            GameStart();
            UpdateUi();
            PlayBackground();
        }

        // Play background music
        private void PlayBackground()
        {
            backgroundPlayer.URL = "E:\\GAME DEV\\Arceus Adventure Game\\Arceus Adventure Game\\Resources\\Ludum Dare 38 09.wav"; // Use relative path
            backgroundPlayer.settings.setMode("loop", true);
            backgroundPlayer.controls.play();
        }

        // Play sound effects
        public async Task PlaySoundEffect()
        {
            soundEffectPlayer.URL = "E:\\GAME DEV\\Arceus Adventure Game\\Arceus Adventure Game\\Resources\\Explosion 5 - Sound effects Pack 2.wav";
            soundEffectPlayer.controls.play();
            await Task.Delay(500); // Simulate sound duration
        }

        // Play healing sound
        public async Task PlayHealingSound()
        {
            healingsound.URL = "E:\\GAME DEV\\Arceus Adventure Game\\Arceus Adventure Game\\Resources\\Powerup 2 - Sound effects Pack 2.wav"; // Use relative path
            healingsound.controls.play();
            await Task.Delay(500); // Simulate sound duration
        }
        // Play Attack sound 
        public async Task PlayAttackSound()
        {
            attacksound.URL = "E:\\GAME DEV\\Arceus Adventure Game\\Arceus Adventure Game\\Resources\\Explosion 5 - Sound effects Pack 2.wav";
            attacksound.controls.play();
            await Task.Delay(500);
        }

        // Delay method
        public async Task Delay(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }

        // Update the UI
        public void UpdateUi()
        {
            // Update HP and Mana labels
            PlayerHpLabel.Text = $"{player.Name}: {player.Health} HP";
            EnemyHpLabel.Text = $"{enemy.Name}: {enemy.Health} HP";
            PlayerManaLabel.Text = $"Mana: {player.Mana}";
            EnemyManaLabel.Text = $"Mana: {enemy.Mana}";

            // Update progress bars
            PlayerHpProgressBar.Value = player.Health;
            PlayerManaProgressBar.Value = player.Mana;
            EnemyHpProgressBar.Value = enemy.Health;
            EnemyManaProgressBar.Value = enemy.Mana;

            // Enable/disable buttons based on mana
            HealButton.Enabled = player.Mana > 19;
            CriticalButton.Enabled = player.Mana > 19;
        }

        // Initialize game settings
        public void GameStart()
        {
            PlayerHpProgressBar.Maximum = PlayerManaProgressBar.Maximum = 100;
            EnemyHpProgressBar.Maximum = EnemyManaProgressBar.Maximum = 100;
            UpdateUi();
        }

        // Handle game over
        private void CheckGameOver()
        {
            UpdateUi();
            if (enemy.Health <= 0)
            {
                enemy.Health = 0;
                MessageBox.Show($"{player.Name} wins!", "Game Over");
                Close();
            }
            else if (player.Health <= 0)
            {
                player.Health = 0;
                MessageBox.Show($"{enemy.Name} wins!", "Game Over");
                Close();
            }
            else if (enemy.Mana <= 0)
            {
                enemy.Mana = 0;
            }
            else if (player.Mana <= 0)
            {
                player.Mana = 0;
            }

        }

        // Handle player attack
        private async Task HandlePlayerAttack(Func<Task<bool>> attackAction)
        {
            bool attackSuccess = await attackAction();

            if (attackSuccess)
            {

                UpdateUi();
                CheckGameOver();
                EnemyPictureBox.Image = Properties.Resources.Fire_Sparks;
                await PlayAttackSound();
                await Delay(500);
                EnemyPictureBox.Image = Properties.Resources.bat;

                await enemy.Attackai(player, enemy, healingsound, attacksound, PlayerPictureBox, EnemyPictureBox);

                PlayerPictureBox.Image = Properties.Resources.skelidle;
                await Delay(500);



                CheckGameOver();
                UpdateUi();
            }
            else
            {

                await enemy.Attackai(player, enemy, healingsound, attacksound, PlayerPictureBox, EnemyPictureBox);
                PlayerPictureBox.Image = Properties.Resources.Poison_Cloud;
                await Delay(500);
                PlayerPictureBox.Image = Properties.Resources.skelidle;
                UpdateUi();
                CheckGameOver();
            }
            UpdateUi();
            CheckGameOver();
        }

        // Attack button click
        private async void AttackButton_Click(object sender, EventArgs e)
        {

            await HandlePlayerAttack(() => player.AttackEnemyAsync(enemy, soundEffectPlayer));
            UpdateUi();
            CheckGameOver();
        }

        // Critical attack button click
        private async void CriticalButton_Click(object sender, EventArgs e)
        {
            await HandlePlayerAttack(() => player.CriticalAttackAsync(enemy));
            UpdateUi();
            CheckGameOver();
        }

        // Heal button click
        private async void HealButton_Click(object sender, EventArgs e)
        {
            if (player.HpRecovery(healingsound))
            {
                CheckGameOver();
                UpdateUi();
                await PlayHealingSound();

                await enemy.Attackai(player, enemy, healingsound, soundEffectPlayer, PlayerPictureBox, EnemyPictureBox);

                PlayerPictureBox.Image = Properties.Resources.skelidle;
                UpdateUi();


            }
            UpdateUi();
            CheckGameOver();
        }

        // Block button click
        private async void BlockButton_Click(object sender, EventArgs e)
        {
            if (player.Block(enemy))
            {
                CheckGameOver();
                UpdateUi();
                PlayerPictureBox.Image = Properties.Resources.Poison_Cloud;
                await Delay(500);
                PlayerPictureBox.Image = Properties.Resources.skelidle;


                UpdateUi();
            }
            UpdateUi();
            CheckGameOver();
        }
    }
}