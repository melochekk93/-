using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Гонки_кнопок
{
    
    public partial class Form1 : Form
    {
         #region Fields
        public delegate void HelperToCall(Button btn); //помощник для манипулирования объектами из разных потоков
        HelperToCall htc; // делегат для вызова методом Invoke()
        Thread t1; //поток для движения CAR1
        Thread t2; //поток для движения CAR2    
        Thread t3; //поток для движения CAR3
        Thread t4; //поток для движения CAR4
       static Random r; // создание объекта рандома
        ButtonCompare[] button; //массив кнопок
        SoundPlayer running, background; 
        #endregion
        #region Form1
        public Form1()
        {
            InitializeComponent();
            htc = new HelperToCall(Motion); //указание конкретного метода для делегата
            r = new Random(); //объявление объекта класса рандом
          button = new ButtonCompare[] {CAR1, CAR2, CAR3, CAR4}; //массив кнопок
            running = new SoundPlayer(Properties.Resources._94_Truck_snd_run03);
            background = new SoundPlayer(Properties.Resources.Final__iz_filma_Usatyi_njan_);
            background.Play();
        }
        #endregion
        #region START_Click
        /// <summary>
        /// логика кнопки старт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void START_Click(object sender, EventArgs e)
        {
         //   running.Load();
            running.Play();
            PAUSE.Enabled = STOP.Enabled = true;
            ((Button)sender).Enabled = false;

            if (t1 != null) //если потоки существуют - кнопки двигаются, но приостановлены
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                t4.Resume();
                return;
            }

            t1 = new Thread(Movement1);
            t2 = new Thread(Movement2);
            t3 = new Thread(Movement3);
            t4 = new Thread(Movement4);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = t4.IsBackground = true;
            
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
        }
        #endregion
        #region Motion
        void Motion(Button button)
            {
                button.Location = new Point(button.Location.X + r.Next(0,10), button.Location.Y);
            Leader();
            Finish(button);

        }
        #endregion
        #region Finish
        private void Finish(Button button)
        {
            if (button.Location.X > (pictureBox1.Location.X - button.Width))
            {
                PAUSE_Click(new object(), new EventArgs { });
                START.Enabled = false;
                MessageBox.Show("Выиграла кнопка " + button.Text);
            }
        }
        #endregion
        #region Leader
        private void Leader()
        {
            Array.Sort(button);
            button[0].BackColor = Color.Yellow;
            for (int i = 1; i < button.Length; i++)
                button[i].BackColor = SystemColors.Control;
        }
        #endregion
        #region Movement1
        void Movement1()
            {
                while (true)
                {
                    Thread.Sleep(r.Next(5,40));
                Invoke(htc, CAR1);
                }
            }
        #endregion
        #region Movement2
        void Movement2()
            {
                while (true)
                {
                    Thread.Sleep(r.Next(5, 40));
                Invoke(htc, CAR2);
            }
        }
        #endregion
        #region Movement3
        void Movement3()
            {
                while (true)
                {
                    Thread.Sleep(r.Next(5, 40));
                Invoke(htc, CAR3);
            }
        }
        #endregion
        #region Movement4
        void Movement4()
            {
                while (true)
                {
                    Thread.Sleep(r.Next(5, 40));
                Invoke(htc, CAR4);
            }
            }
        #endregion
        #region PAUSE_Click

        private void PAUSE_Click(object sender, EventArgs e)
        {
            running.Stop();
            background.Play();
            PAUSE.Enabled = false;
            START.Enabled = true;
            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
                t4.Suspend();

            } 
        }
        #endregion
        #region STOP_Click
        private void STOP_Click(object sender, EventArgs e)
        {
            running.Stop();
            background.Play();
            PAUSE.Enabled = STOP.Enabled = false;
            PAUSE_Click(sender,e);
            Reset();
        }
        #endregion
        #region Reset
        private void Reset()
        {
            CAR1.Location = new Point(29, CAR1.Location.Y);
            CAR2.Location = new Point(29, CAR2.Location.Y);
            CAR3.Location = new Point(29, CAR3.Location.Y);
            CAR4.Location = new Point(29, CAR4.Location.Y);
            foreach(ButtonCompare btn in button)
            { btn.BackColor = SystemColors.Control;   }
        }
        #endregion
        #region panel1_Paint
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
        #region Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region CAR1_Click
        private void CAR1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region CAR1_Click
        private void CAR2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region CAR3_Click
        private void CAR3_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region CAR4_Click
        private void CAR4_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Form1_FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            STOP_Click(sender,e);
        }
        #endregion
    }
   
}
