using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Pacman : Form
    {
        public int leftghost1, leftghost2, leftghost3, leftghost4, left;
        public int topghost1, topghost2, topghost3, topghost4, top;
        public int next, direzione, temp = 1;
        public bool pacturn, ghost1turn, ghost2turn, ghost3turn, ghost4turn, start, ghost1caneat, ghost2caneat, ghost3caneat, ghost4caneat, g1aftertaste, g2aftertaste, g3aftertaste, g4aftertaste;


        public bool dir1, dir2, dir3, dir4, c, Supermod, Supermod1, Supermod2, Supermod3, Supermod4, v1, v2, v3, v4, tresec = true;
        public int random1, random2, random3, random4, vita = 3, tic4, tic5, tic6, point;
        public int prec1, prec2, prec3, prec4, startdirection = 1, ghost1velocity = 2, ghost2velocity = 2, ghost3velocity = 2, ghost4velocity = 2;
        public Random rand = new Random();
        public List<object> pacmanObjects = new List<object>();

        public Pacman()
        {
            InitializeComponent();
            pacmanObjects.Add(label4);
            pacmanObjects.Add(label5);
            pacmanObjects.Add(label6);
            pacmanObjects.Add(label7);
            pacmanObjects.Add(label8);
            pacmanObjects.Add(label9);
            pacmanObjects.Add(label10);
            pacmanObjects.Add(label11);
            pacmanObjects.Add(label12);
            pacmanObjects.Add(label13);
            pacmanObjects.Add(label14);
            pacmanObjects.Add(label15);
            pacmanObjects.Add(label16);
            pacmanObjects.Add(label17);
            pacmanObjects.Add(label18);
            pacmanObjects.Add(label19);
            pacmanObjects.Add(label20);
            pacmanObjects.Add(label21);
            pacmanObjects.Add(label22);
            pacmanObjects.Add(label23);
            pacmanObjects.Add(label24);
            pacmanObjects.Add(label25);
            pacmanObjects.Add(label26);
            pacmanObjects.Add(label27);
            pacmanObjects.Add(label28);
            pacmanObjects.Add(label29);
            pacmanObjects.Add(label30);
            pacmanObjects.Add(label31);
            pacmanObjects.Add(label32);
            pacmanObjects.Add(label33);
            pacmanObjects.Add(label34);
            pacmanObjects.Add(label35);
            pacmanObjects.Add(label36);
            pacmanObjects.Add(label37);
            pacmanObjects.Add(label38);
            pacmanObjects.Add(label39);
            pacmanObjects.Add(label40);
            pacmanObjects.Add(label41);
            pacmanObjects.Add(label42);
            pacmanObjects.Add(label43);
            pacmanObjects.Add(label44);
            pacmanObjects.Add(label45);
            pacmanObjects.Add(label46);
            pacmanObjects.Add(label47);
            pacmanObjects.Add(label48);
            pacmanObjects.Add(label49);
            pacmanObjects.Add(label50);
            pacmanObjects.Add(label51);
            pacmanObjects.Add(label52);
            pacmanObjects.Add(label53);
            pacmanObjects.Add(label54);
            pacmanObjects.Add(label55);
            pacmanObjects.Add(label56);
            pacmanObjects.Add(label57);
            pacmanObjects.Add(label58);
            pacmanObjects.Add(label59);
            pacmanObjects.Add(label60);
            pacmanObjects.Add(label61);
            pacmanObjects.Add(label62);
            pacmanObjects.Add(label63);
            pacmanObjects.Add(label64);
            pacmanObjects.Add(label65);
            pacmanObjects.Add(label66);
            pacmanObjects.Add(label67);
            pacmanObjects.Add(label68);
            pacmanObjects.Add(label69);
            pacmanObjects.Add(label70);
            pacmanObjects.Add(label71);
            pacmanObjects.Add(label72);
            pacmanObjects.Add(label73);
            pacmanObjects.Add(label74);
            pacmanObjects.Add(label75);
            pacmanObjects.Add(label76);
            pacmanObjects.Add(label77);
            pacmanObjects.Add(label78);
            pacmanObjects.Add(label79);
            pacmanObjects.Add(label80);
            pacmanObjects.Add(label81);
            pacmanObjects.Add(label82);
            pacmanObjects.Add(label83);
            pacmanObjects.Add(label84);
            pacmanObjects.Add(label85);
            pacmanObjects.Add(label86);
            pacmanObjects.Add(label87);
            pacmanObjects.Add(label88);
            pacmanObjects.Add(label89);
            pacmanObjects.Add(label90);
            pacmanObjects.Add(label91);
            pacmanObjects.Add(label92);
            pacmanObjects.Add(label93);
            pacmanObjects.Add(label94);
            pacmanObjects.Add(label95);
            pacmanObjects.Add(label96);
            pacmanObjects.Add(label97);
            pacmanObjects.Add(label98);
            pacmanObjects.Add(label99);
            pacmanObjects.Add(label100);
            pacmanObjects.Add(label101);
            pacmanObjects.Add(label102);
            pacmanObjects.Add(label103);
            pacmanObjects.Add(label104);
            pacmanObjects.Add(label105);
            pacmanObjects.Add(label106);
            pacmanObjects.Add(label107);
            pacmanObjects.Add(label108);
            pacmanObjects.Add(label109);
            pacmanObjects.Add(label110);
            pacmanObjects.Add(label111);
            pacmanObjects.Add(label112);
            pacmanObjects.Add(label113);
            pacmanObjects.Add(label114);
            pacmanObjects.Add(label115);
            pacmanObjects.Add(label116);
            pacmanObjects.Add(label117);
            pacmanObjects.Add(label118);
            pacmanObjects.Add(label119);
            pacmanObjects.Add(label120);
            pacmanObjects.Add(label121);
            pacmanObjects.Add(label122);
            pacmanObjects.Add(label123);
            pacmanObjects.Add(label125);
            pacmanObjects.Add(label126);
            pacmanObjects.Add(label127);
            pacmanObjects.Add(label128);
            pacmanObjects.Add(label129);
            pacmanObjects.Add(label130);
            pacmanObjects.Add(label131);
            pacmanObjects.Add(label132);
            pacmanObjects.Add(label133);
            pacmanObjects.Add(label134);
            pacmanObjects.Add(label135);
            pacmanObjects.Add(label136);
            pacmanObjects.Add(label137);
            pacmanObjects.Add(label138);
            pacmanObjects.Add(label139);
            pacmanObjects.Add(label140);
            pacmanObjects.Add(label143);
            pacmanObjects.Add(label144);
            pacmanObjects.Add(label145);
            pacmanObjects.Add(label146);
            pacmanObjects.Add(label147);
            pacmanObjects.Add(label148);
            pacmanObjects.Add(label149);
            pacmanObjects.Add(label150);
            pacmanObjects.Add(label151);
            pacmanObjects.Add(label152);
            pacmanObjects.Add(label153);
            pacmanObjects.Add(label154);
            pacmanObjects.Add(label155);
            pacmanObjects.Add(label156);
            pacmanObjects.Add(label157);
            pacmanObjects.Add(label158);
            pacmanObjects.Add(label159);
            pacmanObjects.Add(label160);
            pacmanObjects.Add(label161);
            pacmanObjects.Add(label162);
            pacmanObjects.Add(label163);
            pacmanObjects.Add(label164);
            pacmanObjects.Add(label165);
            pacmanObjects.Add(label166);
            pacmanObjects.Add(label167);
            pacmanObjects.Add(label168);
            pacmanObjects.Add(label169);
            pacmanObjects.Add(label170);
            pacmanObjects.Add(label171);
            pacmanObjects.Add(label172);
            pacmanObjects.Add(label173);
            pacmanObjects.Add(label174);
            pacmanObjects.Add(label175);
            pacmanObjects.Add(label176);
            pacmanObjects.Add(label177);
            pacmanObjects.Add(label178);
            pacmanObjects.Add(label179);
            pacmanObjects.Add(label180);
            pacmanObjects.Add(label181);
            pacmanObjects.Add(label182);
            pacmanObjects.Add(label183);
            pacmanObjects.Add(label184);
            pacmanObjects.Add(label185);
            pacmanObjects.Add(label186);
            pacmanObjects.Add(label187);
            pacmanObjects.Add(label188);
            pacmanObjects.Add(label189);
            pacmanObjects.Add(label190);
            pacmanObjects.Add(label191);
            pacmanObjects.Add(label192);
            pacmanObjects.Add(label193);
            pacmanObjects.Add(label194);
            pacmanObjects.Add(label195);
            pacmanObjects.Add(label196);
            pacmanObjects.Add(label197);
            pacmanObjects.Add(label198);
            pacmanObjects.Add(label199);
            pacmanObjects.Add(label200);
            pacmanObjects.Add(label201);
            pacmanObjects.Add(label202);
            pacmanObjects.Add(label203);
            pacmanObjects.Add(label204);
            pacmanObjects.Add(label205);
            pacmanObjects.Add(label206);
            pacmanObjects.Add(label207);
            pacmanObjects.Add(label208);
            pacmanObjects.Add(label209);
            pacmanObjects.Add(label210);
            pacmanObjects.Add(label211);
            pacmanObjects.Add(label212);
            pacmanObjects.Add(label213);
            pacmanObjects.Add(label214);
            pacmanObjects.Add(label215);
            pacmanObjects.Add(label216);
            pacmanObjects.Add(label217);
            pacmanObjects.Add(label218);
            pacmanObjects.Add(label219);
            pacmanObjects.Add(label220);
            pacmanObjects.Add(label221);
            pacmanObjects.Add(label222);
            pacmanObjects.Add(label223);
            pacmanObjects.Add(label224);
            pacmanObjects.Add(label225);
            pacmanObjects.Add(label226);
            pacmanObjects.Add(label227);
            pacmanObjects.Add(label228);
            pacmanObjects.Add(label229);
            pacmanObjects.Add(label230);
            pacmanObjects.Add(label231);
            pacmanObjects.Add(label232);
            pacmanObjects.Add(label233);
            pacmanObjects.Add(label234);
            pacmanObjects.Add(label235);
            pacmanObjects.Add(label236);
            pacmanObjects.Add(label237);
            pacmanObjects.Add(label238);
            pacmanObjects.Add(label239);
            pacmanObjects.Add(label240);
            pacmanObjects.Add(label241);
            pacmanObjects.Add(label242);
            pacmanObjects.Add(label243);
            pacmanObjects.Add(label244);
            pacmanObjects.Add(label245);
            pacmanObjects.Add(label246);
            pacmanObjects.Add(label247);
            pacmanObjects.Add(label248);
            pacmanObjects.Add(label249);
            pacmanObjects.Add(label250);
            pacmanObjects.Add(label251);
            pacmanObjects.Add(label252);
            pacmanObjects.Add(label256);
            pacmanObjects.Add(label257);
            pacmanObjects.Add(label258);
            pacmanObjects.Add(label259);
            pacmanObjects.Add(label260);
            pacmanObjects.Add(label261);
            pacmanObjects.Add(label262);
            pacmanObjects.Add(label263);
            pacmanObjects.Add(label264);
            pacmanObjects.Add(label265);
            pacmanObjects.Add(label266);
            pacmanObjects.Add(label267);
            pacmanObjects.Add(label268);
            pacmanObjects.Add(label269);
            pacmanObjects.Add(label270);
            pacmanObjects.Add(label271);
            pacmanObjects.Add(label272);
            pacmanObjects.Add(label273);
            pacmanObjects.Add(label274);
            pacmanObjects.Add(label275);
            pacmanObjects.Add(label276);
            pacmanObjects.Add(label277);
            pacmanObjects.Add(label278);
            pacmanObjects.Add(label279);
            pacmanObjects.Add(label280);
            pacmanObjects.Add(label281);
            pacmanObjects.Add(label282);
            pacmanObjects.Add(label283);
            pacmanObjects.Add(label284);
            pacmanObjects.Add(label285);
            pacmanObjects.Add(label286);
            pacmanObjects.Add(label287);
            pacmanObjects.Add(label288);
            pacmanObjects.Add(label289);
            pacmanObjects.Add(label290);
            pacmanObjects.Add(label291);
            pacmanObjects.Add(label292);
            pacmanObjects.Add(label293);
            pacmanObjects.Add(label294);
            pacmanObjects.Add(label295);
            pacmanObjects.Add(label296);
            pacmanObjects.Add(label297);
            pacmanObjects.Add(label298);
            pacmanObjects.Add(label299);
            pacmanObjects.Add(label300);
            pacmanObjects.Add(label301);
            pacmanObjects.Add(label302);
            pacmanObjects.Add(label303);
            pacmanObjects.Add(label304);
            pacmanObjects.Add(label305);
            pacmanObjects.Add(label306);
            pacmanObjects.Add(label307);
            pacmanObjects.Add(label308);
            pacmanObjects.Add(label309);
            pacmanObjects.Add(label310);
            pacmanObjects.Add(label311);
            pacmanObjects.Add(label312);
            pacmanObjects.Add(label313);
            pacmanObjects.Add(label314);
            pacmanObjects.Add(label315);
            pacmanObjects.Add(label316);
            pacmanObjects.Add(label317);
            pacmanObjects.Add(label318);
            pacmanObjects.Add(label319);
            pacmanObjects.Add(label320);
            pacmanObjects.Add(label321);
            pacmanObjects.Add(label322);
            pacmanObjects.Add(label323);
            pacmanObjects.Add(label324);
            pacmanObjects.Add(label325);
            pacmanObjects.Add(label326);
            pacmanObjects.Add(label327);
            pacmanObjects.Add(label328);
            pacmanObjects.Add(label329);
            pacmanObjects.Add(label330);
            pacmanObjects.Add(label331);
            pacmanObjects.Add(label332);
            pacmanObjects.Add(label333);
            pacmanObjects.Add(label334);
            pacmanObjects.Add(label335);
            pacmanObjects.Add(label336);
            pacmanObjects.Add(label337);
            pacmanObjects.Add(label338);
            pacmanObjects.Add(label339);
            pacmanObjects.Add(label340);
            pacmanObjects.Add(label341);

            buttonPlay.Click += (s, a) =>
            {
                start = true;
                Life();
                Points();
                panel1.Visible = false;
                Resetall();
            };

            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Left) next = 1;
                if (e.KeyCode == Keys.Right) next = 2;
                if (e.KeyCode == Keys.Up) next = 3;
                if (e.KeyCode == Keys.Down) next = 4;
                if (e.KeyCode == Keys.Escape) Close();
                temp = next;
            };

            buttonPlay.MouseLeave += (s, a) =>
            {
                buttonPlay.Image = Properties.Resources.playgame;
            };

            buttonPlay.MouseEnter += (s, a) =>
            {
                buttonPlay.Image = Properties.Resources.playgame2;
            };

            timer1.Tick += (s, a) =>
            {
                if (pacmanPlayer.Enabled)
                {
                    Direction();
                    Freedirection();
                }
                if (ghost1.Enabled || ghost2.Enabled || ghost3.Enabled || ghost4.Enabled)
                {
                    Ghost();
                }
                if (c) Control();
                Smod();
                Points();
                Collision();
            };

            timer2.Tick += (s, a) =>
            {
                label3.Visible = false;
                timer1.Enabled = true;
                timer2.Enabled = false;
                c = true;
            };

            timer3.Tick += (s, a) =>
            {
                if (ghost2.Top == 180) startdirection = 2;
                if (ghost2.Top == 192) startdirection = 1;
                if (startdirection == 1)
                {
                    ghost2.Top--;
                    ghost4.Top--;
                }
                if (startdirection == 2)
                {
                    ghost2.Top++;
                    ghost4.Top++;
                }
            };

            timer4.Tick += (s, a) =>
            {
                tic4++;
                if (ghost3.Top > 150 && tic4 > 100) { prec1 = 3; ghost3.Top--; }
                if (ghost3.Top == 150) timer4.Enabled = false;
            };

            timer5.Tick += (s, a) =>
            {
                tic5++;
                if (ghost2.Left > 153 && ghost2.Left < 176 && tic5 > 300) ghost2.Left++;
                if (ghost2.Top > 150 && ghost2.Left == 176) { ghost2.Top--; }
                if (ghost2.Top == 150) { timer6.Enabled = true; timer5.Enabled = false; }
            };

            timer6.Tick += (s, a) =>
            {
                tic6++;
                if (ghost4.Left > 176 && ghost4.Left < 200 && tic6 > 100) ghost4.Left--;
                if (ghost4.Top > 150 && ghost4.Left == 176) { ghost4.Top--; }
                if (ghost4.Top == 150) timer6.Enabled = false;
            };

            powermod.Tick += (s, a) =>
            {
                tresec = false;
                if (!g1aftertaste)
                {
                    v1 = false;
                    ghost1caneat = true;
                    Supermod1 = false;
                    ghost1velocity = 2;
                }
                if (!g2aftertaste)
                {
                    v2 = false;
                    ghost2caneat = true;
                    Supermod2 = false;
                    ghost2velocity = 2;
                }
                if (!g3aftertaste)
                {
                    v3 = false;
                    ghost3caneat = true;
                    Supermod3 = false;
                    ghost3velocity = 2;
                }
                if (!g4aftertaste)
                {
                    v4 = false;
                    ghost4caneat = true;
                    Supermod4 = false;
                    ghost4velocity = 2;
                }
                Supermod = false;
                powermod.Enabled = false;
                powermod1.Enabled = false;
                if (prec1 == 1 && !g1aftertaste) { if (ghost1.Left % 2 == 0) leftghost1 = ghost1velocity; ghost1.Image = Properties.Resources.rdx; }
                if (prec1 == 2 && !g1aftertaste) { if (ghost1.Left % 2 == 0) leftghost1 = -ghost1velocity; ghost1.Image = Properties.Resources.rsx; }
                if (prec1 == 3 && !g1aftertaste) { if (ghost1.Top % 2 == 0) topghost1 = -ghost1velocity; ghost1.Image = Properties.Resources.rup; }
                if (prec1 == 4 && !g1aftertaste) { if (ghost1.Top % 2 == 0) topghost1 = ghost1velocity; ghost1.Image = Properties.Resources.rdown; }

                if (prec2 == 1 && !g2aftertaste) { if (ghost2.Left % 2 == 0) leftghost2 = ghost2velocity; ghost2.Image = Properties.Resources.adx; }
                if (prec2 == 2 && !g2aftertaste) { if (ghost2.Left % 2 == 0) leftghost2 = -ghost2velocity; ghost2.Image = Properties.Resources.asx; }
                if (prec2 == 3 && !g2aftertaste) { if (ghost2.Top % 2 == 0) topghost2 = -ghost2velocity; ghost2.Image = Properties.Resources.aup; }
                if (prec2 == 4 && !g2aftertaste) { if (ghost2.Top % 2 == 0) topghost2 = ghost2velocity; ghost2.Image = Properties.Resources.adown; }

                if (prec3 == 1 && !g3aftertaste) { if (ghost3.Left % 2 == 0) leftghost3 = ghost3velocity; ghost3.Image = Properties.Resources.vdx; }
                if (prec3 == 2 && !g3aftertaste) { if (ghost3.Left % 2 == 0) leftghost3 = -ghost3velocity; ghost3.Image = Properties.Resources.vsx; }
                if (prec3 == 3 && !g3aftertaste) { if (ghost3.Top % 2 == 0) topghost3 = -ghost3velocity; ghost3.Image = Properties.Resources.vup; }
                if (prec3 == 4 && !g3aftertaste) { if (ghost3.Top % 2 == 0) topghost3 = ghost3velocity; ghost3.Image = Properties.Resources.vdown; }

                if (prec4 == 1 && !g4aftertaste) { if (ghost4.Left % 2 == 0) leftghost4 = ghost4velocity; ghost4.Image = Properties.Resources.gdx; }
                if (prec4 == 2 && !g4aftertaste) { if (ghost4.Left % 2 == 0) leftghost4 = -ghost4velocity; ghost4.Image = Properties.Resources.gsx; }
                if (prec4 == 3 && !g4aftertaste) { if (ghost4.Top % 2 == 0) topghost4 = -ghost4velocity; ghost4.Image = Properties.Resources.gup; }
                if (prec4 == 4 && !g4aftertaste) { if (ghost4.Top % 2 == 0) topghost4 = ghost4velocity; ghost1.Image = Properties.Resources.gdown; }
            };

            timer7.Tick += (s, a) =>
            {
                timer7.Enabled = false;
                panel1.Visible = true;
                careful.Enabled = true;
            };

            timer8.Tick += (s, a) =>
            {
                pacmanPlayer.SetBounds(pacmanPlayer.Left, pacmanPlayer.Top, 0, 0);
                g1aftertaste = false;
                g2aftertaste = false;
                g3aftertaste = false;
                g4aftertaste = false;
                v1 = false;
                v2 = false;
                v3 = false;
                v4 = false;
                ghost1caneat = true;
                ghost2caneat = true;
                ghost3caneat = true;
                ghost4caneat = true;
                ghost1.Visible = false;
                ghost2.Visible = false;
                ghost3.Visible = false;
                ghost4.Visible = false;
                pacmanPlayer.Visible = false;
                tic4 = 0;
                tic5 = 0;
                tic6 = 0;
                Supermod = false;
                Supermod1 = false;
                Supermod2 = false;
                Supermod3 = false;
                Supermod4 = false;
                ghost1velocity = 2;
                ghost2velocity = 2;
                ghost3velocity = 2;
                ghost4velocity = 2;
                vita--;
                Life();
                prec1 = 0;
                prec2 = 0;
                prec3 = 0;
                prec4 = 0;
                startdirection = 1;
                dir1 = false;
                dir2 = false;
                dir3 = false;
                dir4 = false;
                c = false;
                next = 0;
                temp = 1;
                direzione = 0;
                pacmanPlayer.Left = 24;
                pacmanPlayer.Top = 364;
                ghost1.Left = 176;
                ghost1.Top = 150;
                ghost2.Left = 154;
                ghost2.Top = 185;
                ghost3.Left = 176;
                ghost3.Top = 185;
                ghost4.Left = 199;
                ghost4.Top = 185;
                leftghost1 = 0;
                leftghost2 = 0;
                leftghost3 = 0;
                leftghost4 = 0;
                topghost1 = 0;
                topghost2 = 0;
                topghost3 = 0;
                topghost4 = 0;
                left = 0;
                top = 0;
                timer8.Enabled = false;
                pacmanPlayer.Image = Properties.Resources._1dx;
                ghost1.Image = Properties.Resources.rup;
                ghost2.Image = Properties.Resources.aup;
                ghost3.Image = Properties.Resources.vup;
                ghost4.Image = Properties.Resources.gup;
                ghost1.Visible = true;
                ghost2.Visible = true;
                ghost3.Visible = true;
                ghost4.Visible = true;
                pacmanPlayer.SetBounds(pacmanPlayer.Left, pacmanPlayer.Top, 22, 22);
                pacmanPlayer.Visible = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer8.Interval = 1900;
            };

            timer9.Tick += (s, a) =>
            {
                logotypePacman.Visible = true;
                buttonPlay.Visible = true;
                timer9.Enabled = false;
            };

            careful.Tick += (s, a) =>
            {
                Resetall();
                careful.Enabled = false;
            };

            powermod1.Tick += (s, a) =>
            {
                tresec = true;
                powermod1.Enabled = false;
            };

            ghosteaten.Tick += (s, a) =>
            {
                timer1.Enabled = true;
                ghosteaten.Enabled = false;
            };
        }

        private void Resetall()
        {
            g1aftertaste = false;
            g2aftertaste = false;
            g3aftertaste = false;
            g4aftertaste = false;
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            ghost1caneat = true;
            ghost2caneat = true;
            ghost3caneat = true;
            ghost4caneat = true;
            label124.Visible = false;
            label141.Visible = false;
            pacmanPlayer.SetBounds(pacmanPlayer.Left, pacmanPlayer.Top, 22, 22);
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;
            Supermod = false;
            Supermod1 = false;
            Supermod2 = false;
            Supermod3 = false;
            Supermod4 = false;
            ghost1velocity = 2;
            ghost2velocity = 2;
            ghost3velocity = 2;
            ghost4velocity = 2;
            Life();
            prec1 = 0;
            prec2 = 0;
            prec3 = 0;
            prec4 = 0;
            startdirection = 1;
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direzione = 0;
            pacmanPlayer.Left = 24;
            pacmanPlayer.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;
            leftghost1 = 0;
            leftghost2 = 0;
            leftghost3 = 0;
            leftghost4 = 0;
            topghost1 = 0;
            topghost2 = 0;
            topghost3 = 0;
            topghost4 = 0;
            left = 0;
            top = 0;
            pacmanPlayer.Image = Properties.Resources._1dx;
            ghost1.Image = Properties.Resources.rup;
            ghost2.Image = Properties.Resources.aup;
            ghost3.Image = Properties.Resources.vup;
            ghost4.Image = Properties.Resources.gup;
            timer1.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            powermod.Enabled = false;
            powermod1.Enabled = false;
            if (start)
            {
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            start = false;
            for (int i = 0; i < 332; i++) ((Label)pacmanObjects[i]).Visible = true;
        }

        private void Control()
        {
            if (ghost2.Top == 185) { timer3.Enabled = false; timer4.Enabled = true; c = false; timer5.Enabled = true; }
        }

        private void Life()
        {
            if (vita == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            if (vita == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            if (vita == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
        private void Smod()
        {
            if (pacmanPlayer.Bounds.IntersectsWith(label173.Bounds) && label173.Visible == true) Smod2();
            if (pacmanPlayer.Bounds.IntersectsWith(label307.Bounds) && label307.Visible == true) Smod2();
            if (pacmanPlayer.Bounds.IntersectsWith(label220.Bounds) && label220.Visible == true) Smod2();
            if (pacmanPlayer.Bounds.IntersectsWith(label71.Bounds) && label71.Visible == true) Smod2();
        }
        private void Smod2()
        {
            if (!g1aftertaste)
            {
                v1 = false;
                ghost1velocity = 2;
                Supermod1 = true;
                ghost1.Image = Properties.Resources.crazy;
                ghost1caneat = true;
            }
            if (!g2aftertaste)
            {
                v2 = false;
                ghost2velocity = 2;
                Supermod2 = true;
                ghost2.Image = Properties.Resources.crazy;
                ghost2caneat = true;
            }
            if (!g3aftertaste)
            {
                v3 = false;
                ghost3velocity = 2;
                Supermod3 = true;
                ghost3.Image = Properties.Resources.crazy;
                ghost3caneat = true;
            }
            if (!g4aftertaste)
            {
                v4 = false;
                ghost4velocity = 2;
                Supermod4 = true;
                ghost4.Image = Properties.Resources.crazy;
                ghost4caneat = true;
            }
            powermod.Enabled = false;
            powermod1.Enabled = false;
            powermod1.Enabled = true;
            tresec = false;
            powermod.Enabled = true;
            Supermod = true;
        }
   
        private void Collision()
        {
            if (pacmanPlayer.Bounds.IntersectsWith(ghost1.Bounds) || pacmanPlayer.Bounds.IntersectsWith(ghost2.Bounds) || pacmanPlayer.Bounds.IntersectsWith(ghost3.Bounds) || pacmanPlayer.Bounds.IntersectsWith(ghost4.Bounds))
            {
                if (pacmanPlayer.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1) Aftertaste();
                if (pacmanPlayer.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2) Aftertaste();
                if (pacmanPlayer.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3) Aftertaste();
                if (pacmanPlayer.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4) Aftertaste();
                if (Supermod)
                {
                    if (pacmanPlayer.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1) Aftertaste();
                    if (pacmanPlayer.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2) Aftertaste();
                    if (pacmanPlayer.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3) Aftertaste();
                    if (pacmanPlayer.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4) Aftertaste();
                }
                if (pacmanPlayer.Bounds.IntersectsWith(ghost1.Bounds) && ghost1caneat && Supermod1)
                {
                    g1aftertaste = true;
                    v1 = true;
                    ghost1caneat = false;
                    timer1.Enabled = false;
                    ghosteaten.Enabled = true;
                    ghost1velocity = 4;
                }
                if (pacmanPlayer.Bounds.IntersectsWith(ghost2.Bounds) && ghost2caneat && Supermod2)
                {
                    g2aftertaste = true;
                    v2 = true;
                    ghost2caneat = false;
                    timer1.Enabled = false;
                    ghosteaten.Enabled = true;
                    ghost2velocity = 4;
                }
                if (pacmanPlayer.Bounds.IntersectsWith(ghost3.Bounds) && ghost3caneat && Supermod3)
                {
                    g3aftertaste = true;
                    v3 = true;
                    ghost3caneat = false;
                    timer1.Enabled = false;
                    ghosteaten.Enabled = true;
                    ghost3velocity = 4;
                }
                if (pacmanPlayer.Bounds.IntersectsWith(ghost4.Bounds) && ghost4caneat && Supermod4)
                {
                    g4aftertaste = true;
                    v4 = true;
                    ghost4caneat = false;
                    timer1.Enabled = false;
                    ghosteaten.Enabled = true;
                    ghost4velocity = 4;
                }
            }
        }

        private void Aftertaste()
        {
            pacmanPlayer.Image = Properties.Resources.pacmorto;
            if (vita - 1 <= 0)
            {
                label124.Visible = true;
                Finepartite();
            }
            else
            {
                top = 0;
                left = 0;
                topghost1 = 0;
                topghost2 = 0;
                topghost3 = 0;
                topghost4 = 0;
                leftghost1 = 0;
                leftghost2 = 0;
                leftghost3 = 0;
                leftghost4 = 0;
                timer1.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                pacturn = false;
                ghost1turn = false;
                ghost2turn = false;
                ghost3turn = false;
                ghost4turn = false;
                timer8.Enabled = true;
            }
        }

        private void Points()
        {
            for (int i = 0; i < 332; i++)
            {
                if (((Label)pacmanObjects[i]).Visible == true && pacmanPlayer.Bounds.IntersectsWith(((Label)pacmanObjects[i]).Bounds))
                {
                    point += 1;
                    ((Label)pacmanObjects[i]).Visible = false;
                }
            }
            score.Text = point.ToString();
            if (point >= 332) { Finepartite(); label141.Visible = true; }
        }

        private void Finepartite()
        {
            point = 0;
            vita = 3;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            powermod1.Enabled = false;
            powermod.Enabled = false;
            timer7.Enabled = true;
        }

        private void Freedirection()
        {
            switch (direzione)
            {
                case 1:
                    if (next == 2)
                    {
                        left = 2;
                        pacmanPlayer.Image = Properties.Resources.pacdx;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 2:
                    if (next == 1)
                    {
                        left = -2;
                        pacmanPlayer.Image = Properties.Resources.pacsx;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 3:
                    if (next == 4)
                    {
                        top = 2;
                        pacmanPlayer.Image = Properties.Resources.pacdown;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 4:
                    if (next == 3)
                    {
                        top = -2;
                        pacmanPlayer.Image = Properties.Resources.pacup;
                        direzione = next;
                        temp = next;
                    }
                    break;
            }
        }

        private void Leftright(int i, int y, int n, int m)
        {
            if (ghost1turn)
            {
                if (Supermod1 && !ghost1caneat)
                {
                    if (ghost1.Left < 180 && ghost1.Top == 150 || ghost1.Left > 170 && ghost1.Top == 150) { ghost1velocity = 2; Supermod1 = false; v1 = false; ghost1caneat = true; g1aftertaste = false; }
                    else
                    {
                        if (ghost1.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost1.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost1.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost1.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost1 = 0;
                leftghost1 = 0;
                while (!dir1)
                {
                    random1 = rand.Next(1, 5);
                    if (random1 == 1 && !dir1 && random1 != prec1) if (i == 1) { leftghost1 = -ghost1velocity; dir1 = true; if (!Supermod1 && ghost1caneat) ghost1.Image = Properties.Resources.rsx; else if (!tresec || g1aftertaste) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1aftertaste) ghost1.Image = Properties.Resources.msx; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 2 && !dir1 && random1 != prec1) if (y == 1) { leftghost1 = ghost1velocity; dir1 = true; if (!Supermod1 && ghost1caneat) ghost1.Image = Properties.Resources.rdx; else if (!tresec || g1aftertaste) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1aftertaste) ghost1.Image = Properties.Resources.mdx; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 3 && !dir1 && random1 != prec1) if (m == 1) { topghost1 = ghost1velocity; dir1 = true; if (!Supermod1 && ghost1caneat) ghost1.Image = Properties.Resources.rdown; else if (!tresec || g1aftertaste) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1aftertaste) ghost1.Image = Properties.Resources.mdown; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 4 && !dir1 && random1 != prec1) if (n == 1) { topghost1 = -ghost1velocity; dir1 = true; if (!Supermod1 && ghost1caneat) ghost1.Image = Properties.Resources.rup; else if (!tresec || g1aftertaste) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1aftertaste) ghost1.Image = Properties.Resources.mup1; } else ghost1.Image = Properties.Resources.tempo; }
                }
                if (random1 == 1) prec1 = 2;
                if (random1 == 2) prec1 = 1;
                if (random1 == 3) prec1 = 4;
                if (random1 == 4) prec1 = 3;
                dir1 = false;
            }
            if (ghost2turn)
            {
                if (Supermod2 && !ghost2caneat)
                {
                    if (ghost2.Left < 180 && ghost2.Top == 150 || ghost2.Left > 170 && ghost2.Top == 150) { ghost2velocity = 2; Supermod2 = false; v2 = false; ghost2caneat = true; g2aftertaste = false; }
                    else
                    {
                        if (ghost2.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost2.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost2.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost2.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost2 = 0;
                leftghost2 = 0;
                while (!dir2)
                {
                    random2 = rand.Next(1, 5);
                    if (random2 == 1 && !dir2 && random2 != prec2) if (i == 1) { leftghost2 = -ghost2velocity; dir2 = true; if (!Supermod2 && ghost2caneat) ghost2.Image = Properties.Resources.asx; else if (!tresec || g2aftertaste) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2aftertaste) ghost2.Image = Properties.Resources.msx; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 2 && !dir2 && random2 != prec2) if (y == 1) { leftghost2 = ghost2velocity; dir2 = true; if (!Supermod2 && ghost2caneat) ghost2.Image = Properties.Resources.adx; else if (!tresec || g2aftertaste) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2aftertaste) ghost2.Image = Properties.Resources.mdx; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 3 && !dir2 && random2 != prec2) if (m == 1) { topghost2 = ghost2velocity; dir2 = true; if (!Supermod2 && ghost2caneat) ghost2.Image = Properties.Resources.adown; else if (!tresec || g2aftertaste) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2aftertaste) ghost2.Image = Properties.Resources.mdown; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 4 && !dir2 && random2 != prec2) if (n == 1) { topghost2 = -ghost2velocity; dir2 = true; if (!Supermod2 && ghost2caneat) ghost2.Image = Properties.Resources.aup; else if (!tresec || g2aftertaste) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2aftertaste) ghost2.Image = Properties.Resources.mup1; } else ghost2.Image = Properties.Resources.tempo; }
                }
                if (random2 == 1) prec2 = 2;
                if (random2 == 2) prec2 = 1;
                if (random2 == 3) prec2 = 4;
                if (random2 == 4) prec2 = 3;
                dir2 = false;
            }
            if (ghost3turn)
            {
                if (Supermod3 && !ghost3caneat)
                {
                    if (ghost3.Left < 180 && ghost3.Top == 150 || ghost3.Left > 170 && ghost3.Top == 150) { ghost3velocity = 2; Supermod3 = false; v3 = false; ghost3caneat = true; g3aftertaste = false; }
                    else
                    {
                        if (ghost3.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost3.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost3.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost3.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost3 = 0;
                leftghost3 = 0;
                while (!dir3)
                {
                    random3 = rand.Next(1, 5);
                    if (random3 == 1 && !dir3 && random3 != prec3) if (i == 1) { leftghost3 = -ghost3velocity; dir3 = true; if (!Supermod3 && ghost3caneat) ghost3.Image = Properties.Resources.vsx; else if (!tresec || g3aftertaste) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3aftertaste) ghost3.Image = Properties.Resources.msx; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 2 && !dir3 && random3 != prec3) if (y == 1) { leftghost3 = ghost3velocity; dir3 = true; if (!Supermod3 && ghost3caneat) ghost3.Image = Properties.Resources.vdx; else if (!tresec || g3aftertaste) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3aftertaste) ghost3.Image = Properties.Resources.mdx; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 3 && !dir3 && random3 != prec3) if (m == 1) { topghost3 = ghost3velocity; dir3 = true; if (!Supermod3 && ghost3caneat) ghost3.Image = Properties.Resources.vdown; else if (!tresec || g3aftertaste) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3aftertaste) ghost3.Image = Properties.Resources.mdown; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 4 && !dir3 && random3 != prec3) if (n == 1) { topghost3 = -ghost3velocity; dir3 = true; if (!Supermod3 && ghost3caneat) ghost3.Image = Properties.Resources.vup; else if (!tresec || g3aftertaste) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3aftertaste) ghost3.Image = Properties.Resources.mup1; } else ghost3.Image = Properties.Resources.tempo; }
                }
                if (random3 == 1) prec3 = 2;
                if (random3 == 2) prec3 = 1;
                if (random3 == 3) prec3 = 4;
                if (random3 == 4) prec3 = 3;
                dir3 = false;
            }
            if (ghost4turn)
            {
                if (Supermod4 && !ghost4caneat)
                {
                    if (ghost4.Left < 180 && ghost4.Top == 150 || ghost4.Left > 170 && ghost4.Top == 150) { ghost4velocity = 2; Supermod4 = false; v4 = false; ghost4caneat = true; g4aftertaste = false; }
                    else
                    {
                        if (ghost4.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost4.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost4.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost4.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost4 = 0;
                leftghost4 = 0;
                while (!dir4)
                {
                    random4 = rand.Next(1, 5);
                    if (random4 == 1 && !dir4 && random4 != prec4) if (i == 1) { leftghost4 = -ghost4velocity; dir4 = true; if (!Supermod4 && ghost4caneat) ghost4.Image = Properties.Resources.gsx; else if (!tresec || g4aftertaste) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4aftertaste) ghost4.Image = Properties.Resources.msx; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 2 && !dir4 && random4 != prec4) if (y == 1) { leftghost4 = ghost4velocity; dir4 = true; if (!Supermod4 && ghost4caneat) ghost4.Image = Properties.Resources.gdx; else if (!tresec || g4aftertaste) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4aftertaste) ghost4.Image = Properties.Resources.mdx; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 3 && !dir4 && random4 != prec4) if (m == 1) { topghost4 = ghost4velocity; dir4 = true; if (!Supermod4 && ghost4caneat) ghost4.Image = Properties.Resources.gdown; else if (!tresec || g4aftertaste) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4aftertaste) ghost4.Image = Properties.Resources.mdown; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 4 && !dir4 && random4 != prec4) if (n == 1) { topghost4 = -ghost4velocity; dir4 = true; if (!Supermod4 && ghost4caneat) ghost4.Image = Properties.Resources.gup; else if (!tresec || g4aftertaste) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4aftertaste) ghost4.Image = Properties.Resources.mup1; } else ghost4.Image = Properties.Resources.tempo; }
                }
                if (random4 == 1) prec4 = 2;
                if (random4 == 2) prec4 = 1;
                if (random4 == 3) prec4 = 4;
                if (random4 == 4) prec4 = 3;
                dir4 = false;
            }
            if (pacturn)
            {
                top = 0;
                left = 0;
                if (temp == 1 && i == 1 || temp == 2 && y == 1 || temp == 3 && n == 1 || temp == 4 && m == 1)
                {
                    next = temp;
                }
                if (next == 1 && i == 1)
                {
                    left = -2;
                    pacmanPlayer.Image = Properties.Resources.pacsx;
                    direzione = next;
                }
                if (next == 2 && y == 1)
                {
                    left = 2;
                    pacmanPlayer.Image = Properties.Resources.pacdx;
                    direzione = next;
                }
                if (next == 3 && n == 1)
                {
                    top = -2;
                    pacmanPlayer.Image = Properties.Resources.pacup;
                    direzione = next;
                }
                if (next == 4 && m == 1)
                {
                    top = 2;
                    pacmanPlayer.Image = Properties.Resources.pacdown;
                    direzione = next;
                }
                if (top == 0 && left == 0)
                {
                    temp = next;
                    next = direzione;
                    if (next == 1) pacmanPlayer.Image = Properties.Resources._1sx;
                    if (next == 2) pacmanPlayer.Image = Properties.Resources._1dx;
                    if (next == 3) pacmanPlayer.Image = Properties.Resources._1up;
                    if (next == 4) pacmanPlayer.Image = Properties.Resources._1down;
                }
            }
        }

        private void Direction()
        {
            pacturn = true;
            CrossingMap(pacmanPlayer.Left, pacmanPlayer.Top);
            pacmanPlayer.Left += left;
            pacmanPlayer.Top += top;
        }

        private void CrossingMap(int left, int top)
        {
            if (pacturn)
            {
                switch (left)
                {
                    case 174:
                        if (top == 148) { Leftright(1, 1, 0, 0); break; }
                        break;
                    case 24:
                        if (top == 364) { Leftright(0, 1, 1, 0); break; }
                        if (top == 328) { Leftright(0, 1, 0, 1); break; }
                        if (top == 292) { Leftright(0, 1, 1, 0); break; }
                        if (top == 256) { Leftright(0, 1, 0, 1); break; }
                        if (top == 112) { Leftright(0, 1, 1, 0); break; }
                        if (top == 76) { Leftright(0, 1, 1, 1); break; }
                        if (top == 28) { Leftright(0, 1, 0, 1); break; }
                        break;
                    case 48:
                        if (top == 328) { Leftright(1, 1, 1, 0); break; }
                        if (top == 292) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 84:
                        if (top == 256) { Leftright(1, 1, 1, 1); break; }
                        if (top == 328) { Leftright(1, 0, 1, 0); break; }
                        if (top == 292) { Leftright(0, 1, 1, 1); break; }
                        if (top == 184) { Leftright(1, 1, 1, 1); break; }
                        if (top == 112) { Leftright(1, 0, 1, 1); break; }
                        if (top == 28) { Leftright(1, 1, 0, 1); break; }
                        if (top == 76) { Leftright(1, 1, 1, 1); break; }
                        break;
                    case 120:
                        if (top == 292) { Leftright(1, 1, 0, 1); break; }
                        if (top == 328) { Leftright(0, 1, 1, 0); break; }
                        if (top == 256) { Leftright(1, 1, 1, 0); break; }
                        if (top == 220) { Leftright(0, 1, 1, 1); break; }
                        if (top == 76) { Leftright(1, 1, 0, 1); break; }
                        if (top == 112) { Leftright(0, 1, 1, 0); break; }
                        if (top == 148) { Leftright(0, 1, 0, 1); break; }
                        if (top == 184) { Leftright(1, 0, 1, 1); break; }
                        break;
                    case 156:
                        if (top == 328) { Leftright(1, 0, 0, 1); break; }
                        if (top == 364) { Leftright(1, 1, 1, 0); break; }
                        if (top == 256) { Leftright(1, 0, 0, 1); break; }
                        if (top == 292) { Leftright(1, 1, 1, 0); break; }
                        if (top == 76) { Leftright(1, 1, 1, 0); break; }
                        if (top == 112) { Leftright(1, 0, 0, 1); break; }
                        if (top == 148) { Leftright(1, 1, 1, 0); break; }
                        if (top == 28) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 192:
                        if (top == 292) { Leftright(1, 1, 1, 0); break; }
                        if (top == 256) { Leftright(0, 1, 0, 1); break; }
                        if (top == 364) { Leftright(1, 1, 1, 0); break; }
                        if (top == 328) { Leftright(0, 1, 0, 1); break; }
                        if (top == 28) { Leftright(0, 1, 0, 1); break; }
                        if (top == 76) { Leftright(1, 1, 1, 0); break; }
                        if (top == 112) { Leftright(0, 1, 0, 1); break; }
                        if (top == 148) { Leftright(1, 1, 1, 0); break; }
                        break;
                    case 228:
                        if (top == 256) { Leftright(1, 1, 1, 0); break; }
                        if (top == 328) { Leftright(1, 0, 1, 0); break; }
                        if (top == 292) { Leftright(1, 1, 0, 1); break; }
                        if (top == 220) { Leftright(1, 0, 1, 1); break; }
                        if (top == 184) { Leftright(0, 1, 1, 1); break; }
                        if (top == 76) { Leftright(1, 1, 0, 1); break; }
                        if (top == 112) { Leftright(1, 0, 1, 0); break; }
                        if (top == 148) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 264:
                        if (top == 256) { Leftright(1, 1, 1, 1); break; }
                        if (top == 292) { Leftright(1, 0, 1, 1); break; }
                        if (top == 328) { Leftright(0, 1, 1, 0); break; }
                        if (top == 184) { Leftright(1, 1, 1, 1); break; }
                        if (top == 112) { Leftright(0, 1, 1, 1); break; }
                        if (top == 28) { Leftright(1, 1, 0, 1); break; }
                        if (top == 76) { Leftright(1, 1, 1, 1); break; }
                        break;
                    case 324:
                        if (top == 256) { Leftright(1, 0, 0, 1); break; }
                        if (top == 292) { Leftright(1, 0, 1, 0); break; }
                        if (top == 328) { Leftright(1, 0, 0, 1); break; }
                        if (top == 364) { Leftright(1, 0, 1, 0); break; }
                        if (top == 112) { Leftright(1, 0, 1, 0); break; }
                        if (top == 76) { Leftright(1, 0, 1, 1); break; }
                        if (top == 28) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 300:
                        if (top == 292) { Leftright(0, 1, 0, 1); break; }
                        if (top == 328) { Leftright(1, 1, 1, 0); break; }
                        break;
                    case 374:
                        if (top == 184) { Transport(0, 1); break; }
                        break;
                    case -26:
                        if (top == 184) { Transport(1, 0); break; }
                        break;
                }
            }
            else
            {
                switch (left)
                {
                    case 176:
                        if (top == 150) { Leftright(1, 1, 0, 0); break; }
                        break;
                    case 26:
                        if (top == 366) { Leftright(0, 1, 1, 0); break; }
                        if (top == 330) { Leftright(0, 1, 0, 1); break; }
                        if (top == 294) { Leftright(0, 1, 1, 0); break; }
                        if (top == 258) { Leftright(0, 1, 0, 1); break; }
                        if (top == 114) { Leftright(0, 1, 1, 0); break; }
                        if (top == 78) { Leftright(0, 1, 1, 1); break; }
                        if (top == 30) { Leftright(0, 1, 0, 1); break; }
                        break;
                    case 50:
                        if (top == 330) { Leftright(1, 1, 1, 0); break; }
                        if (top == 294) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 86:
                        if (top == 258) { Leftright(1, 1, 1, 1); break; }
                        if (top == 330) { Leftright(1, 0, 1, 0); break; }
                        if (top == 294) { Leftright(0, 1, 1, 1); break; }
                        if (top == 186) { Leftright(1, 1, 1, 1); break; }
                        if (top == 114) { Leftright(1, 0, 1, 1); break; }
                        if (top == 30) { Leftright(1, 1, 0, 1); break; }
                        if (top == 78) { Leftright(1, 1, 1, 1); break; }
                        break;
                    case 122:
                        if (top == 294) { Leftright(1, 1, 0, 1); break; }
                        if (top == 330) { Leftright(0, 1, 1, 0); break; }
                        if (top == 258) { Leftright(1, 1, 1, 0); break; }
                        if (top == 222) { Leftright(0, 1, 1, 1); break; }
                        if (top == 78) { Leftright(1, 1, 0, 1); break; }
                        if (top == 114) { Leftright(0, 1, 1, 0); break; }
                        if (top == 150) { Leftright(0, 1, 0, 1); break; }
                        if (top == 186) { Leftright(1, 0, 1, 1); break; }
                        break;
                    case 158:
                        if (top == 330) { Leftright(1, 0, 0, 1); break; }
                        if (top == 366) { Leftright(1, 1, 1, 0); break; }
                        if (top == 258) { Leftright(1, 0, 0, 1); break; }
                        if (top == 294) { Leftright(1, 1, 1, 0); break; }
                        if (top == 78) { Leftright(1, 1, 1, 0); break; }
                        if (top == 114) { Leftright(1, 0, 0, 1); break; }
                        if (top == 150) { Leftright(1, 1, 1, 0); break; }
                        if (top == 30) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 194:
                        if (top == 294) { Leftright(1, 1, 1, 0); break; }
                        if (top == 258) { Leftright(0, 1, 0, 1); break; }
                        if (top == 366) { Leftright(1, 1, 1, 0); break; }
                        if (top == 330) { Leftright(0, 1, 0, 1); break; }
                        if (top == 30) { Leftright(0, 1, 0, 1); break; }
                        if (top == 78) { Leftright(1, 1, 1, 0); break; }
                        if (top == 114) { Leftright(0, 1, 0, 1); break; }
                        if (top == 150) { Leftright(1, 1, 1, 0); break; }
                        break;
                    case 230:
                        if (top == 258) { Leftright(1, 1, 1, 0); break; }
                        if (top == 330) { Leftright(1, 0, 1, 0); break; }
                        if (top == 294) { Leftright(1, 1, 0, 1); break; }
                        if (top == 222) { Leftright(1, 0, 1, 1); break; }
                        if (top == 186) { Leftright(0, 1, 1, 1); break; }
                        if (top == 78) { Leftright(1, 1, 0, 1); break; }
                        if (top == 114) { Leftright(1, 0, 1, 0); break; }
                        if (top == 150) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 266:
                        if (top == 258) { Leftright(1, 1, 1, 1); break; }
                        if (top == 294) { Leftright(1, 0, 1, 1); break; }
                        if (top == 330) { Leftright(0, 1, 1, 0); break; }
                        if (top == 186) { Leftright(1, 1, 1, 1); break; }
                        if (top == 114) { Leftright(0, 1, 1, 1); break; }
                        if (top == 30) { Leftright(1, 1, 0, 1); break; }
                        if (top == 78) { Leftright(1, 1, 1, 1); break; }
                        break;
                    case 326:
                        if (top == 258) { Leftright(1, 0, 0, 1); break; }
                        if (top == 294) { Leftright(1, 0, 1, 0); break; }
                        if (top == 330) { Leftright(1, 0, 0, 1); break; }
                        if (top == 366) { Leftright(1, 0, 1, 0); break; }
                        if (top == 114) { Leftright(1, 0, 1, 0); break; }
                        if (top == 78) { Leftright(1, 0, 1, 1); break; }
                        if (top == 30) { Leftright(1, 0, 0, 1); break; }
                        break;
                    case 302:
                        if (top == 294) { Leftright(0, 1, 0, 1); break; }
                        if (top == 330) { Leftright(1, 1, 1, 0); break; }
                        break;
                    case 376:
                        if (top == 186) { Transport(0, 1); break; }
                        break;
                    case -28:
                        if (top == 186) { Transport(1, 0); break; }
                        break;
                }
            }
            pacturn = false;
            ghost1turn = false;
            ghost2turn = false;
            ghost3turn = false;
            ghost4turn = false;
        }

        private void Transport(int i, int n)
        {
            if (pacturn)
            {
                if (i == 0) pacmanPlayer.Left = -26;
                if (n == 0) pacmanPlayer.Left = 374;
            }
            if (ghost1turn)
            {
                if (i == 0) ghost1.Left = -26;
                if (n == 0) ghost1.Left = 374;
            }
            if (ghost2turn)
            {
                if (i == 0) ghost2.Left = -26;
                if (n == 0) ghost2.Left = 374;
            }
            if (ghost3turn)
            {
                if (i == 0) ghost3.Left = -26;
                if (n == 0) ghost3.Left = 374;
            }
            if (ghost4turn)
            {
                if (i == 0) ghost4.Left = -26;
                if (n == 0) ghost4.Left = 374;
            }
        }

        private void Ghost()
        {
            if (ghost1.Enabled == true)
            {
                ghost1.Left += leftghost1;
                ghost1.Top += topghost1;
                ghost1turn = true;
                CrossingMap(ghost1.Left, ghost1.Top);
            }
            if (ghost2.Enabled == true)
            {
                ghost2.Left += leftghost2;
                ghost2.Top += topghost2;
                ghost2turn = true;
                CrossingMap(ghost2.Left, ghost2.Top);
            }
            if (ghost3.Enabled == true)
            {
                ghost3.Left += leftghost3;
                ghost3.Top += topghost3;
                ghost3turn = true;
                CrossingMap(ghost3.Left, ghost3.Top);
            }
            if (ghost4.Enabled == true)
            {
                ghost4.Left += leftghost4;
                ghost4.Top += topghost4;
                ghost4turn = true;
                CrossingMap(ghost4.Left, ghost4.Top);
            }
        }
    }
}
