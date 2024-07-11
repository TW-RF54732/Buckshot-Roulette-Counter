namespace BRC
{
    public partial class Form1 : Form
    {
        int SetBullet;
        int FileCount = 0;
        //data
        double BulletAmount = 0;
        double RedBulletAmount = 0;
        double GrayBulletAmount = 0;
        int[] SetBulletList = new int[9];
        int turn = 0, setRed = 0, setGray = 0, showRed = 0, showGray = 0;
        //data
        //database
        double[] D_BulletAmount = new double[50];
        double[] D_RedBulletAmount = new double[50];
        double[] D_GrayBulletAmount = new double[50];
        int[,] D_SetBulletList = new int[50,9];
        int[] D_turn = new int[50], D_setRed = new int[50], D_setGray = new int[50], D_showRed = new int[50], D_showGray = new int[50];
        //database
        bool start = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void File_Save(int file)
        {
            D_BulletAmount[file] = BulletAmount;
            D_RedBulletAmount[file] = RedBulletAmount;
            D_GrayBulletAmount[file] = GrayBulletAmount;
            D_showRed[file] = showRed;
            D_showGray[file] = showGray;
            for(int i = 0; i < 9; i++)
            {
                D_SetBulletList[file,i] = SetBulletList[i];
            }
            D_turn[file] = turn;
            D_setRed[file] = setRed;
            D_setGray[file] = setGray;
        }

        void File_Read(int file)
        {
            BulletAmount = D_BulletAmount[file];
            RedBulletAmount = D_RedBulletAmount[file];
            GrayBulletAmount = D_GrayBulletAmount[file];
            showGray = D_showGray[file];
            showRed = D_showRed[file];
            turn = D_turn[file];
            setRed = D_setRed[file];
            setGray = D_setGray[file];
            for(int i = 0;i < 9;i++)
            {
                SetBulletList[i] = D_SetBulletList[file,i];
            }
            double showB = turn + BulletAmount;
            if (showB >= 1) { button1.Visible = true; }
            if (showB >= 2) { button2.Visible = true; }
            if (showB >= 3) { button3.Visible = true; }
            if (showB >= 4) { button4.Visible = true; }
            if (showB >= 5) { button5.Visible = true; }
            if (showB >= 6) { button6.Visible = true; }
            if (showB >= 7) { button7.Visible = true; }
            if (showB >= 8) { button8.Visible = true; }
            ReloadView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        void reset()
        {
            RedBullet_button.Enabled = true;
            GrayBullet_button.Enabled = true;
            start = false;
            BulletAmount = 0;
            RedBulletAmount = 0;
            GrayBulletAmount = 0;
            turn = 0;
            BulletAmount = 0;
            setGray = 0;
            setRed = 0;
            showGray = 0;
            showRed = 0;
            RedOut.Enabled = true;
            GrayOut.Enabled = true;
            SaveList.Items.Clear();
            FileCount = 0;
            for (int i = 0; i < 8; i++)
            {
                SetBulletList[i] = 0;
            }
            turn = 0;
            start = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            ReloadView();
        }
        void turnView()
        {
            if (turn >= 1) { button1.Visible = false; }
            if (turn >= 2) { button2.Visible = false; }
            if (turn >= 3) { button3.Visible = false; }
            if (turn >= 4) { button4.Visible = false; }
            if(turn >= 5) { button5.Visible = false; }
            if(turn >= 6) { button6.Visible = false; }
            if(turn >= 7) { button7.Visible = false; }
            if(turn >= 8) { button8.Visible = false; }
        }
        void ReloadView()
        {
            Bullet_Amount.Text = BulletAmount.ToString();
            if (BulletAmount >= 8) { RedBullet_button.Enabled = false; GrayBullet_button.Enabled = false; }

            if (start == false)
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                if (BulletAmount >= 1) { button1.Visible = true; }
                if (BulletAmount >= 2) { button2.Visible = true; }
                if (BulletAmount >= 3) { button3.Visible = true; }
                if (BulletAmount >= 4) { button4.Visible = true; }
                if (BulletAmount >= 5) { button5.Visible = true; }
                if (BulletAmount >= 6) { button6.Visible = true; }
                if (BulletAmount >= 7) { button7.Visible = true; }
                if (BulletAmount >= 8) { button8.Visible = true; }
            }
            else
            {
                if (RedBulletAmount - setRed == 0 && SetBulletList[turn] != 1) { RedOut.Enabled = false; }
                if (GrayBulletAmount - setGray == 0 && SetBulletList[turn] != -1) { GrayOut.Enabled = false; }
                if (SetBulletList[turn] == 1) { RedOut.Enabled = true; GrayOut.Enabled = false; RedBulletAmount++; showRed++; }
                if (SetBulletList[turn] == -1) { GrayOut.Enabled = true; RedOut.Enabled = false; GrayBulletAmount++; showGray++; }

            }

            textBox1.Text = (RedBulletAmount - showRed).ToString();
            textBox2.Text = (GrayBulletAmount - showGray).ToString();
            turnView();

            if (SetBulletList[turn] == 0)
            {
                RedChance.Text = Convert.ToString(Math.Round((RedBulletAmount - setRed) / (GrayBulletAmount + RedBulletAmount - setGray - setRed), 2) * 100) + "%";
                GrayChance.Text = Convert.ToString(Math.Round((GrayBulletAmount - setGray) / (GrayBulletAmount + RedBulletAmount - setGray - setRed), 2) * 100) + "%";
            }
            else
            {
                if (SetBulletList[turn] == 1) { RedChance.Text = "100%"; GrayChance.Text = "0%"; }
                else { RedChance.Text = "0%"; GrayChance.Text = "100%"; }
            }

        }
        void Set(int type)
        {
            start = true;
            Color tmp = new Color();
            if (type == -1) { tmp = Color.Gray; setGray++; }
            if (type == 1) { tmp = Color.IndianRed; setRed++; }

            SetBulletList[SetBullet - 1] = type;
            if (SetBullet == 1) { button1.BackColor = tmp; }
            if (SetBullet == 2) { button2.BackColor = tmp; }
            if (SetBullet == 3) { button3.BackColor = tmp; }
            if (SetBullet == 4) { button4.BackColor = tmp; }
            if (SetBullet == 5) { button5.BackColor = tmp; }
            if (SetBullet == 6) { button6.BackColor = tmp; }
            if (SetBullet == 7) { button7.BackColor = tmp; }
            if (SetBullet == 8) { button8.BackColor = tmp; }

            SetBullet = 0;
            SetRed.Visible = false;
            SetGray.Visible = false;
        }

        private void RedBullet_button_Click(object sender, EventArgs e)
        {
            RedBulletAmount++;
            BulletAmount++;
            ReloadView();
        }

        private void GrayBullet_button_Click(object sender, EventArgs e)
        {
            GrayBulletAmount++;
            BulletAmount++;
            ReloadView();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void SetRed_Click(object sender, EventArgs e)
        {
            Set(1);
            ReloadView();
        }

        private void SetGray_Click(object sender, EventArgs e)
        {
            Set(-1);
            ReloadView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetBullet = 1; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetBullet = 2; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetBullet = 3; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetBullet = 4; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetBullet = 5; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetBullet = 6; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetBullet = 7; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetBullet = 8; SetRed.Visible = true;
            SetGray.Visible = true;
        }

        private void RedOut_Click(object sender, EventArgs e)
        {
            start = true;
            RedBulletAmount--;
            BulletAmount--;
            turn++;
            ReloadView();
            RoundSave();
        }

        private void GrayOut_Click(object sender, EventArgs e)
        {
            start = true;
            GrayBulletAmount--;
            BulletAmount--;
            turn++;
            ReloadView();
            RoundSave();
        }
        void RoundSave()
        {
            SaveList.Items.Add($"²Ä{turn}¦^¦X");
            File_Save(FileCount);
            FileCount++;
        }

        private void SaveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = SaveList.SelectedIndex;
            File_Read(choice);
        }
    }
}
