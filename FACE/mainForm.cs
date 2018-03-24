using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using DataDaL;
using System.Threading;

namespace FACE
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            Console.Write(1);
            InitializeComponent();
            for (int i1 = 0; i1 < 6; i1++)
            {
                button[i1] = new Button();
            }
            
        }
        List<string> songList = new List<string>();//保存歌曲列表
        TextBox tx = new TextBox();
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds = new DataSet();
        DataGridView dataGridview;
        DataTable SongTable;
        Button[] button = new Button[6];        
        string sql;
        int haveSong=0;
        int willSong=0;
        ComponentResourceManager resources;
        private Label label4;
        Random rand = new Random();
        BOFANG form2;
        int oldscore = 90;

        private void mainForm_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL= @"E:\KTV\KTV---Manager\KTV---Manager\FACE\Resources\杨幂-爱的供养.mp3";
          
            //ListBox list = new ListBox(); 
            //list.Width=100;
            //list .Height=100;
            //axWindowsMediaPlayer1.Ctlcontrols.play(); 

            this.Width = 980;
            this.Height = 750;
            panel1.Width = this.Width;
            //panel2.Width = this.Width;
            //panel1.Height = this.Height - panel2.Height - 19 - 69;
            //pictureBox2.Left = this.Width - 100;
            label2.Left = this.Width - label2.Width - 20; //初始化主界面
            mainLink();//添加主菜单
            
        }
        /// <summary>
        /// 绘制主界面
        /// </summary>

        public void mainLink()
        {
            int widths = 193;
            int heights = 201;
            panel1.Controls.Clear();//清空之前界面
            //添加第一按钮
            for (int i = 0; i < 4 ; i++)
            {
                PictureBox b_ping = new PictureBox();
                b_ping.Width = widths;
                b_ping.Height = heights;//设置按钮的大小
                b_ping.Top = (panel1.Height - heights) / 4;//确定其纵坐标
                b_ping.Left = (panel1.Width - 4 * widths - 3 * 50) / 2+(widths +50)*i;
                switch (i)
                {
                    case 0: b_ping.Image = FACE.Properties.Resources.ping; b_ping.Tag = 1; break;
                    case 1: b_ping.Image = FACE.Properties.Resources.star; b_ping.Tag = 1; break;
                    case 2: b_ping.Image = FACE.Properties.Resources.count; b_ping.Tag = 1; break;
                    case 3: b_ping.Image = FACE.Properties.Resources.typeJPG; b_ping.Tag = 1; break;
                }
              b_ping.Click+=new EventHandler(b_ping_Click);
                panel1.Controls.Add(b_ping);
            }
            for (int i = 0; i < 4; i++)
            {
                PictureBox b_ping = new PictureBox();
                b_ping.Width = widths;
                b_ping.Height = heights;//设置按钮的大小
                b_ping.Top = (panel1.Height - heights)*2*2/5 ;//确定其纵坐标
                b_ping.Left = (panel1.Width - 4 * widths - 3 * 50) / 2 + (widths + 50) * i;
                switch (i)
                {
                    case 0: b_ping.Image = FACE.Properties.Resources.xiqing; b_ping.Tag = 1; break;
                    case 1: b_ping.Image = FACE.Properties.Resources.geming; b_ping.Tag = 1; break;
                    case 2: b_ping.Image = FACE.Properties.Resources.digao; b_ping.Tag = 1; break;
                    case 3: b_ping.Image = FACE.Properties.Resources.jiaoji; b_ping.Tag = 1; break;
                }
                b_ping.Click += new EventHandler(b_ping_Click);
                panel1.Controls.Add(b_ping);
            }
            //axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            //resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            //this.axWindowsMediaPlayer1.Enabled = true;
            //this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 550);
            //this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            //this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            //this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(980, 170);
            //this.axWindowsMediaPlayer1.TabIndex = 1;
            //this.axWindowsMediaPlayer1.UseWaitCursor = true;
            //this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            //this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);

            label4 = new Label();
            label4.BackColor = System.Drawing.Color.Black;
            label4.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label4.ForeColor = System.Drawing.Color.Turquoise;
            label4.Location = new System.Drawing.Point(310,520);
            label4.Name = "label4s";
            label4.Size = new System.Drawing.Size(panel1.Width, 40);
            label4.TabIndex = 8;
            
            //label4.Text = "您的分数为：" + rand.Next(90, 100);


            // 
            // pictureBox1
            //
            //this.pictureBox1 = new System.Windows.Forms.PictureBox();
            //this.pictureBox2 = new System.Windows.Forms.PictureBox();
            //this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ////this.pictureBox1.Image = global::FACE.Properties.Resources.top;
            //this.pictureBox1.Location = new System.Drawing.Point(-8, 558);
            //this.pictureBox1.Name = "pictureBox1";
            //this.pictureBox1.Size = new System.Drawing.Size(93, 91);
            //this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.pictureBox1.TabIndex = 5;
            //this.pictureBox1.TabStop = false;
            //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            //// 
            // pictureBox2
            // 
            //this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ////this.pictureBox2.Image = global::FACE.Properties.Resources.return1;
            //this.pictureBox2.Location = new System.Drawing.Point(890, 558);
            //this.pictureBox2.Name = "pictureBox2";
            //this.pictureBox2.Size = new System.Drawing.Size(93, 91);
            //this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.pictureBox2.TabIndex = 6;
            //this.pictureBox2.TabStop = false;
            //this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
        }
        //
        void b_ping_Click(object sender, EventArgs args)
        {
            PictureBox bu = sender as PictureBox;
            if (bu == null)
                return;
            int i = (int)bu.Tag;
            panel1.Controls.Clear();
           
            switch (i)
            {
                case 1: Enter_Ping(); break;
                case 2: Enter_Star(); break;
                case 3: Enter_Num();  break;
                case 4: Enter_Type(); break;
            }
        }
        #region   进入第二步骤
        /// <summary>
        ///进入拼音点歌 
        /// </summary>

        public void Enter_Ping()
        {
            label3.Text = null;
            Form mainForm = ActiveForm;
            mainForm.BackgroundImage = null;
            becomeChar();//生成字母键盘
            becomeSong();//生成歌曲列表
            //panel1.Controls.Add(axWindowsMediaPlayer1);
            
            

        }
        /// <summary>
        /// 进入明星点歌
        /// </summary>

        public void Enter_Star()
        {
            label3.Text = null;
            Form mainForm = ActiveForm;
            mainForm.Controls.Add(this.pictureBox2);
            mainForm.Controls.Add(this.pictureBox1);
            mainForm.BackgroundImage = null;
            becomeChar();//生成字母键盘
            becomeSong();//生成歌曲列表
        }
        /// <summary>
        /// 进入字数点歌
        /// </summary>

        public void Enter_Num()
        {
 
        }
        /// <summary>
        /// 进入分类点歌
        /// </summary>

        public void Enter_Type()
        {
 
        }
        #endregion
        /// <summary>
        /// 生成字母键盘
        /// </summary>

        public void becomeChar()
        {
            int widths = 65;
            int heights = 61;
            Panel pan = new Panel();
            pan.Width = widths  * 5 + 10*6;
            pan.Height = 7 * heights + 8 * 10;//设置面板的大小
            pan.Top = 12;
            pan.Left = this.Width - (widths * 5 + 10)-90;
            //pan.BackColor = Color.Red;
            panel1.Controls.Add(pan);//添加存放字母的面板
            int i = 65;
            for (int j = 0; j < 7; j++)
                for (int k = 0; k < 5; k++)
                {
                    if (i < 91)
                    {
                        PictureBox box = new PictureBox();
                        box.Width = widths;
                        box.Height = heights;
                        box.Top = (heights + 10) * j + 10;
                        box.Left = (widths + 10) * k + 10;
                        //Application.StartupPath + "\\" + ((Convert.ToChar(i)).ToString()) + ".jpg";
                        box.Image = Image.FromFile(Application.StartupPath + "\\img\\" + ((Convert.ToChar(i)).ToString()) + ".jpg");
                        box.Click += new EventHandler(box_Click);
                        box.Tag = (Convert.ToChar(i)).ToString();
                        pan.Controls.Add(box);
                    }
                    if (k == 1&&j==5)
                    {
                        TextBox box = new TextBox();
                        box.Width = 4 * widths + 4 * 10;
                        box.Height = heights-60;
                        box.Top = (heights + 10) * j + 10;
                        box.Left = (widths + 10) * k + 10;
                        box.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        box.ForeColor = System.Drawing.Color.Red;
                        box.TextChanged += new EventHandler(box_change);
   
                        pan.Controls.Add(box);
                        tx = box;
                    }
                    if (k == 2 && j == 6)
                    {
                        PictureBox box = new PictureBox();
                        box.Width = widths+40;
                        box.Height = heights;
                        box.Top = (heights + 10) * j-10 ;
                        box.Left = (widths + 10) * k + 10;
                        //Application.StartupPath + "\\" + ((Convert.ToChar(i)).ToString()) + ".jpg";
                        box.Image = Image.FromFile(Application.StartupPath + "\\img\\"  + "clear.jpg");
                        box.Click += new EventHandler(clear_Click);
                        pan.Controls.Add(box);


                        PictureBox box1 = new PictureBox();
                        box1.Width = widths + 90;
                        box1.Height = heights;
                        box1.Top = (heights + 10) * j - 10 ;
                        box1.Left = (widths + 10) * k + 10 + widths+60 ;
                        //Application.StartupPath + "\\" + ((Convert.ToChar(i)).ToString()) + ".jpg";
                        box1.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "delete.jpg");
                        box1.Click += new EventHandler(delete_Click);
                        pan.Controls.Add(box1);
                      
                    }
                    i++;
                }

        }

        private void box_change(object sender, EventArgs e) {
            SongTable.Clear();
            if (tx.Text == "") {
                sql = "select * from KTV.dbo.songlist";
            }
            else {
                sql = "select * from KTV.dbo.songlist where Name like'" + tx.Text+ '%'  + "'";
            }        
            string tableName = "songlist";
            SongTable = getSong(sql, tableName);
            if (SongTable.Rows.Count > 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    button[i].Text = SongTable.Rows[i][2].ToString().Trim();
                    button[i].Tag = SongTable.Rows[i][3].ToString().Trim();
                }
            }
            else
            {
                for (int i = 0; i < SongTable.Rows.Count; i++)
                {
                    button[i].Text = SongTable.Rows[i][2].ToString().Trim();
                    button[i].Tag = SongTable.Rows[i][3].ToString().Trim();
                }
                for (int i = SongTable.Rows.Count; i < 6; i++)
                {
                    button[i].Text = null;
                }
            }
           
        }
        private DataTable getSong(string sql, string tableName)
        {
            
            //string sql = "select * from KTV where Name='" + tx.Text + "'";
            ConString ConString = new ConString();
            SqlConnection con = ConString.GetConn();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(ds, tableName);
            dt = ds.Tables[tableName];
            con.Close();
            return dt;
            
            //SqlHelper sqlhelper = new SqlHelper();
            //Console.Write(sqlhelper.DoSqlCommand(sql));
            //string str = ConfigurationManager.ConnectionStrings["MyConnect"].ToString();
            //SqlConnection con = new SqlConnection(str);          
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = sql;
        }

        /// <summary>
        /// 生成歌词界面
        /// </summary>

        public void becomeSong()
        {

            //生成面板
            Panel pan = new Panel();
            pan.Top = 0;
            pan.Left = 15;//位置
            int widths=68;
            int heights=63;
            int b_width=470;
            SongTable = getSong("select * from KTV.dbo.songlist", "songlist");
            pan.Width = widths + 3 * 10 + b_width;
            pan.Height = heights * 7 + 10 *8;//面板大小
            panel1.Controls.Add(pan);
            for (int i = 0; i < 7; i++)
            {
                //for (int j = 0; j < 2; j++)
                //{
                    if (i == 6)
                    {
                       //添加“上页”按钮
                        PictureBox b1 = new PictureBox();
                        b1.Top = 10 + (heights + 10) * i-10;
                        b1.Left = widths + 20;
                        b1.Width = 97;
                        b1.Height = heights;
                        b1.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "up.jpg");
                        pan.Controls.Add(b1);

                        //添加“下页”按钮
                        PictureBox b2 = new PictureBox();
                        b2.Top = 8 + (heights + 10) * i - 10;
                        b2.Left = widths + 20+b1.Width +8;
                        b2.Width = 95;
                        b2.Height = heights;
                        b2.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "down.jpg");
                        pan.Controls.Add(b2);

                        //添加返回
                        PictureBox b3 = new PictureBox();
                        b3.Top = 12 + (heights + 10) * i - 10;
                        b3.Left = widths + 20 + b1.Width+b2.Width  + 20;
                        b3.Width = 99;
                        b3.Height = heights;
                        b3.Image = Image.FromFile(Application.StartupPath + "\\img\\" + "s_return.jpg");
                        b3.Click += new EventHandler(pictureBox1_Click);
                        pan.Controls.Add(b3);
                        break;
                    }
                    //if (j == 0)
                    //{
                        PictureBox box = new PictureBox();
                        box.Top = 10 + (heights + 10) * i;
                        box.Left = 10;
                        box.Width = widths;
                        box.Height = heights;
                        box.Image = Image.FromFile(Application.StartupPath + "\\img\\" + (i + 1).ToString() + ".jpg");
                        pan.Controls.Add(box);//在面板上添加此图片
                                              //}

                /*{*///存放歌曲的按钮
                       
                        button[i].Text = SongTable.Rows[i][2].ToString().Trim();
                        button[i].Tag = SongTable.Rows[i][3].ToString().Trim();
                        button[i].Top = 10 + (heights + 10) * i;
                        button[i].Left = 10 + widths;
                        button[i].Width = b_width;
                        button[i].Height = heights;
                        button[i].BackgroundImage = Image.FromFile(Application.StartupPath + "\\img\\" + "background.jpg");
                        button[i].Font= new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        button[i].Click += new EventHandler(button_Click);
               
                        pan.Controls.Add(button[i]);
                    //}
                //}
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
           
            if (b.Tag == null|| b.Tag.ToString() =="") {
                return;
            }
            willSong++;
            label2.Text = "已点：" + willSong + "首";
            //Thread.Sleep(1000);
            string songName = b.Tag.ToString();
            songList.Add(songName);
            if (songList.Count == 1) {
                //if (songList.First() == "null")
                //{
                //    //Thread.Sleep(1000);

                //    songList.Remove(songList.First());
                //    willSong--;
                //    label2.Text = "已点：" + willSong + "首";
                //    haveSong++;
                //    label1.Text = "已唱：" + haveSong + "首";
                //}
                //else {
                //this.Hide();  //调用Form1的Hide()方法隐藏Form1窗口
                form2 = new BOFANG(); //生成一个Form2对象
                form2.FormClosed += Form2_FormClosed;
                //form2.label1.Text = "100分";
                axWindowsMediaPlayer1 = form2.axWindowsMediaPlayer1;
                axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
                form2.Show();  //将Form2窗体显示为模式对话框。
                axWindowsMediaPlayer1.URL = @"F:\新建文件夹\KTV---Manager\FACE\Resources\" + songList.First();
                //axWindowsMediaPlayer1.currentPlaylist.appendItem();
                //form2.axWindowsMediaPlayer1.playlistCollection.getAll().Item(0);
                        try
                        {

                        form2.axWindowsMediaPlayer1.Ctlcontrols.play();
                            //axWindowsMediaPlayer1.fullScreen = true;
                        }
                        catch (System.Runtime.InteropServices.COMException) { }
                    
                //}
            } 
            //string SongName= sender.ToString();
            //Console.WriteLine(songName);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            songList.Remove(songList.First());
            willSong--;
            label2.Text = "已点：" + willSong + "首";
            haveSong++;
            label1.Text = "已唱：" + haveSong + "首";
        }

        /// <summary>
        /// 点击字母事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void box_Click(object sender, EventArgs e)
        {
           PictureBox pic = sender as PictureBox;
           tx.Text+= pic.Tag.ToString();
           Console.WriteLine(pic.Tag.ToString());
        }
        /// <summary>
        /// 清空文本点击字母文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void clear_Click(object sender, EventArgs e)
        {
            tx.Text = "";
        }
        /// <summary>
        /// 回删所点击字母文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        void delete_Click(object sender, EventArgs e)
        {
            if (tx.Text.Length!=0)
            tx.Text = tx.Text.Substring(0, tx.Text.Length - 1);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        //评分
        void socer() {
           
            //form2.label1.Text = "正在计算您的分数";
            //label4.Text = "正在计算您的分数";
            //panel1.Controls.Add(label4);
            //Delay(2000);
            int goal = rand.Next(90, 96);
            while (goal==oldscore) {
                goal = rand.Next(90, 96);
            }
            oldscore = goal;
            string text="分数：";
            for (int i=0;i<80;i++) {
                Delay(25);
                form2.label1.Text = text + i + "分";
            }
            for (int i = 80; i < 85; i++)
            {
                Delay(50);
                form2.label1.Text = text + i + "分";
            }
            for (int i = 85; i < 89; i++)
            {
                Delay(100);
                form2.label1.Text = text + i + "分";
            }
            if (goal < 93)
            {
                for (int i = 89; i < goal; i++)
                {
                    Delay(200);
                    form2.label1.Text = text + i + "分";
                }
            }
            else {
                for (int i = 89; i < 92; i++)
                {
                    Delay(200);
                    form2.label1.Text = text + i + "分";
                }
                for (int i = 92; i < goal; i++)
                {
                    Delay(300);
                    form2.label1.Text = text + i + "分";
                }
            }
            
            if (goal == 90) { text = "您已经征服了全场观众"; form2.pictureBox3.Visible = true; }
            if (goal == 91) { text = "您的歌声打动了我的灵魂"; form2.pictureBox5.Visible = true; }
            if (goal == 92) { text = "您就是我们的华理歌王"; form2.pictureBox1.Visible = true; }
            if (goal == 93) { text = "明明可以靠嗓音却要写代码"; form2.pictureBox4.Visible = true; }
            if (goal == 94) { text = "您的天赋不比周杰伦差"; form2.pictureBox6.Visible = true; }
            if (goal == 95) { text = "在我看来天空才是您的极限"; form2.pictureBox7.Visible = true; }
            //if (goal < 93)
            //{
            //    text = "您将是下一个歌王！";
            //}
            //else if (goal < 97) { text = "新一代歌王诞生了！"; }
            //else { text = "您已经征服了全宇宙！"; }

            form2.label1.Text = "分数：" + goal + "分" ;
            form2.label2.Text = text;
            //form2.Controls.Add(form2.pictureBox1);
            
            //panel1.Controls.Add(label4);
        }
        
        /// <summary>
        /// 当一首歌播放完之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            string status = axWindowsMediaPlayer1.status.ToString();          
            if (status == "已停止") {
                form2.Close();

                form2 = new BOFANG();
                form2.Show();
                socer();
            }
            //    axWindowsMediaPlayer1.URL = @"E:\KTV\KTV---Manager\KTV---Manager\FACE\Resources\杨幂-爱的供养.mp3";
            if (status == "已完成")
            {
                if (songList.Count > 1) {
                    //songList.Remove(songList.First());
                    //if (songList.First() != null)
                    //{

                    //label4.Text = "您的分数为：" + rand.Next(90, 100);
                    //axWindowsMediaPlayer1.Controls.Add(label4);

                    axWindowsMediaPlayer1.URL = @"F:\新建文件夹\KTV---Manager\FACE\Resources\" + songList.First();
                    //}
                    //else {
                    //    haveSong++;
                    //    label1.Text = "已唱：" + haveSong + "首";
                    //    willSong--;
                    //    label2.Text = "已点：" + willSong + "首";
                    //}
                    
                } else if(songList.Count==1)
                {


                    //label4.Text = "您的分数为：" ;
                    //panel1.Controls.Add(label4);
                    //songList.Remove(songList.First());
                    
                }
                //haveSong++;
                label1.Text = "已唱："+ haveSong + "首";
                //if (willSong > 0)
                //{ willSong--; }
                label2.Text = "已点：" + willSong + "首";
                //Delay(2000);
                //label4.Text = "您的分数为：" + rand.Next(90, 100);
                //panel1.Controls.Add(label4);
            }
            else if (status == "准备就绪")
            {
                try
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (System.Runtime.InteropServices.COMException) { }
            }
            //ListBox list = new ListBox();
            //list.Width = 100;
            //list.Height = 100;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        Login logo;
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }
        /// <summary>
        /// 进入管理界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Thread th = new Thread(new ThreadStart(aa));
            //th.Start();
            if (logo != null)
                logo.Dispose();
            logo = new Login();
            logo.Show();//进入管理员界面?
        }
        /// <summary>
        /// 转入到主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form mainform = ActiveForm;
            label3.Text = "信院出品 必属精品";
            mainform.Controls.Add(label3);
            resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            panel1.Controls.Clear();//清空当前界面，便于转入主界面
            mainLink();//进入到主界面
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();//清空当前界面，便于转入主界面
            mainLink();//进入到主界面
            //this.Controls.Clear();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
