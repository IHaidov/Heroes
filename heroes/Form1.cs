using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heroes
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;

        }
         Hero hero_1;
         Hero hero_2;
        int turn = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> heroes = new List<string>();
            heroes.Add("Spearmen");
            heroes.Add("Swordmen");
            heroes.Add("Bowmen");
            heroes.Add("Wizard");
            comboBox1.DataSource = heroes;
            List<string> heroes_2 = new List<string>();
            heroes_2.Add("Spearmen");
            heroes_2.Add("Swordmen");
            heroes_2.Add("Bowmen");
            heroes_2.Add("Wizard");
            comboBox2.DataSource = heroes_2;
            List<string> weap_1 = new List<string>();
            weap_1.Add("Spear");
            weap_1.Add("Sword");
            weap_1.Add("Bow");
            weap_1.Add("Staff");
            comboBox3.DataSource = weap_1;
            List<string> weap_2 = new List<string>();
            weap_2.Add("Spear");
            weap_2.Add("Sword");
            weap_2.Add("Bow");
            weap_2.Add("Staff");
            comboBox4.DataSource = weap_2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
           
            switch (comboBox1.SelectedItem.ToString())
            {
                
                case "Spearmen": {pictureBox1.Image = Image.FromFile("spearmen.png"); pictureBox3.Image = Image.FromFile("spear.png"); break; }
                case "Swordmen": { pictureBox1.Image = Image.FromFile("swordmen.png"); pictureBox3.Image = Image.FromFile("sword.jpg"); break; }
                case "Bowmen":   { pictureBox1.Image = Image.FromFile("bowman.jpg"); pictureBox3.Image = Image.FromFile("bow.jpg"); break; }
                case "Wizard":   { pictureBox1.Image = Image.FromFile("wizard.jpg"); pictureBox3.Image = Image.FromFile("staff.png"); break; }
            }
           // comboBox1.Enabled = false;
           
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox2.SelectedItem.ToString();
            switch (comboBox2.SelectedItem.ToString())
            {

                case "Spearmen": { pictureBox2.Image = Image.FromFile("spearmen.png"); pictureBox5.Image = Image.FromFile("spear.png"); break; }
                case "Swordmen": { pictureBox2.Image = Image.FromFile("swordmen.png"); pictureBox5.Image = Image.FromFile("sword.jpg"); break; }
                case "Bowmen": { pictureBox2.Image = Image.FromFile("bowman.jpg"); pictureBox5.Image = Image.FromFile("bow.jpg"); break; }
                case "Wizard": { pictureBox2.Image = Image.FromFile("wizard.jpg"); pictureBox5.Image = Image.FromFile("staff.png"); break; }
            }
           // comboBox2.Enabled = false;
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
            else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            else
            {
                int d = hero_1.Hit(); ;
                hero_2.HP += d;
                if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); progressBar1.Value = 0; }
                else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); progressBar2.Value = 0; }
                else
                {
                    progressBar2.Value = hero_2.HP;
                }
                label7.Text = "HP: " + hero_2.HP;
                button1.Enabled = false;
                button2.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                turn++;
                label4.Text = "Turn: " + turn;
                textBox1.Text = "Hero_1 " + comboBox1.SelectedItem.ToString() + " attacked Hero_2 and made damage: " + d;
                if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
                else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
            else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            else
            {
                if (radioButton1.Checked)
                {
                    int d = hero_1.Hit();

                    hero_2.HP += d;
                    if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); progressBar1.Value = 0; }
                    else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); progressBar2.Value = 0; }
                    else
                    {
                        progressBar2.Value = hero_2.HP;
                    }
                    label7.Text = "HP: " + hero_2.HP;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    turn++;
                    label4.Text = "Turn: " + turn;
                    textBox1.Text = "Hero_1 " + comboBox1.SelectedItem.ToString() + " attacked Hero_2 and made damage: " + d;
                }
                else if (radioButton2.Checked)
                {
                    int d = hero_1.Heal();
                    hero_1.HP += d;
                    if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); progressBar1.Value = 0; }
                    else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); progressBar2.Value = 0; }
                    else
                    {
                        if (hero_1.HP > 100)
                        {
                            hero_1.HP=100;
                            progressBar1.Value = hero_1.HP;
                        } 
                        else progressBar1.Value = hero_1.HP;
                    }
                    label8.Text = "HP: " + hero_1.HP;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    turn++;
                    label4.Text = "Turn: " + turn;
                    textBox1.Text = "Hero_1 " + comboBox1.SelectedItem.ToString() + " healed " + d + " points of HP";
                }
                if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
                else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
            else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            else
            {
                int d = hero_2.Hit();
                hero_1.HP += d;
                if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); progressBar1.Value = 0; }
                else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); progressBar2.Value = 0; }
                else
                {
                    progressBar1.Value = hero_1.HP;
                }
                label8.Text = "HP: " + hero_1.HP;
                button3.Enabled = false;
                button4.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                turn++;
                label4.Text = "Turn: " + turn;
                textBox1.Text = "Hero_2 " + comboBox1.SelectedItem.ToString() + " attacked Hero_1 and made damage: " + d;
                if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
                else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
            else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            else
            {
                if (radioButton3.Checked)
                {
                    int d = hero_2.Hit();
                    hero_1.HP += d;
                    if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); progressBar1.Value = 0; }
                    else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); progressBar2.Value = 0; }
                    else
                    {
                        progressBar1.Value = hero_1.HP;
                    }
                    label8.Text = "HP: " + hero_1.HP;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    turn++;
                    label4.Text = "Turn: " + turn;
                    textBox1.Text = "Hero_2 " + comboBox2.SelectedItem.ToString() + " attacked Hero_1 and made damage: " + d;
                }
                else if (radioButton4.Checked)
                {
                    int d = hero_2.Heal();
                    hero_2.HP += d;
                    if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); progressBar1.Value = 0; }
                    else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); progressBar2.Value = 0; }
                    else
                    {
                        if (hero_2.HP > 100)
                        {
                            hero_2.HP = 100;
                            progressBar2.Value = hero_2.HP;
                        }
                        else progressBar2.Value = hero_2.HP;
                    }
                    label7.Text = "HP: " + hero_2.HP;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    turn++;
                    label4.Text = "Turn: " + turn;
                    textBox1.Text = "Hero_2 " + comboBox2.SelectedItem.ToString() + " healed " + d + " points of HP";
                }
                if (hero_1.HP <= 0) { MessageBox.Show("Hero_1 dies, Hero_2 has won!!!"); }
                else if (hero_2.HP <= 0) { MessageBox.Show("Hero_2 dies, Hero_1 has won!!!"); }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            comboBox1.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
             hero_1 = null;
            switch (comboBox1.SelectedItem.ToString())
            {

                case "Spearmen": {  hero_1 = new Hero(new SpearFactory()); break; }
                case "Swordmen": {  hero_1 = new Hero(new SwordFactory()); break; }
                case "Bowmen": {    hero_1 = new Hero(new BowFactory()); break; }
                case "Wizard": {    hero_1 = new Hero(new StaffFactory()); break; }
            }
            label8.Text = "HP: " + hero_1.HP;
            label3.Text = "Damage: "+Math.Abs(hero_1.weapon.Hit());
            label9.Text = "Heal: " + Math.Abs(hero_1.weapon.Heal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = true;
            comboBox2.Enabled = false;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
             hero_2=null;
            switch (comboBox2.SelectedItem.ToString())
            {

                case "Spearmen": {  hero_2 = new Hero(new SpearFactory());  break; }
                case "Swordmen": {  hero_2 = new Hero(new SwordFactory()); break; }
                case "Bowmen": {    hero_2 = new Hero(new BowFactory()); break; }
                case "Wizard": {    hero_2 = new Hero(new StaffFactory()); break; }
            }
            label5.Text = "Damage: " + Math.Abs(hero_2.weapon.Hit());
            label7.Text = "HP: "+hero_2.HP;
            label10.Text = "Heal: " + hero_2.weapon.Heal();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {

                case "Spear": { hero_1 = new Hero(new SpearFactory()); pictureBox3.Image = Image.FromFile("spear.png"); break; }
                case "Sword": { hero_1 = new Hero(new SwordFactory()); pictureBox3.Image = Image.FromFile("sword.jpg"); break; }
                case "Bow": {   hero_1 = new Hero(new BowFactory());   pictureBox3.Image = Image.FromFile("bow.jpg"); break; }
                case "Staff": { hero_1 = new Hero(new StaffFactory()); pictureBox3.Image = Image.FromFile("staff.png"); break; }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedItem.ToString())
            {

                case "Spear": { hero_2 = new Hero(new SpearFactory()); pictureBox5.Image = Image.FromFile("spear.png"); break; }
                case "Sword": { hero_2 = new Hero(new SwordFactory()); pictureBox5.Image = Image.FromFile("sword.jpg"); break; }
                case "Bow": {   hero_2 = new Hero(new BowFactory());   pictureBox5.Image = Image.FromFile("bow.jpg"); break; }
                case "Staff": { hero_2 = new Hero(new StaffFactory()); pictureBox5.Image = Image.FromFile("staff.png"); break; }
            }
        }
    }
}
