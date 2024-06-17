using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;           // 音效檔播放器函式庫
using System.IO;             // 檔案讀取的IO函式庫
using System.Diagnostics; // 引用「系統診斷」的函式庫

namespace WindowsFormsAppClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboboxInitialzation();  // 下拉選單初始化
            timerClock.Start();
        }
        List<string> hours = new List<string>();            // 小時清單
        List<string> minutes = new List<string>();          // 分鐘清單   

        private string strSelectTime;                       // 鬧鐘時間設定

        private WaveOutEvent waveOut;                       // 音效檔播放器
        private AudioFileReader audioFileReader;            // 音效檔讀取器

        List<string> StopWatchLog = new List<string>();         // 碼表紀錄清單 
        Stopwatch sw = new Stopwatch();                         // 宣告一個碼表物件


        // 指定聲音檔的相對路徑，可以使用MP3
        string audioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "9convert.com - This Is Halloween The Actual Instrumental");


        private void comboboxInitialzation()
        {
            // 設定小時下拉選單的選單內容，建立小時的清單，數字範圍為00-23
            for (int i = 0; i <= 23; i++)
                comboBoxH.Items.Add(string.Format("{0:00}", i));
            comboBoxH.SelectedIndex = 0;

            // 設定分鐘下拉選單的選單內容，建立分鐘的清單，數字範圍為00-59
            for (int i = 0; i <= 59; i++)
                comboBoxM.Items.Add(string.Format("{0:00}", i));
            comboBoxM.SelectedIndex = 0;


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            TB1.Text = DateTime.Now.ToString("HH:mm:ss");    // 顯示時間
            TB2.Text = DateTime.Now.ToString("yyyy-MM-dd");  // 顯示日期
            TB3.Text = DateTime.Now.ToString("dddd");     // 顯示星期幾
        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            // 判斷現在時間是不是已經是鬧鐘設定時間？如果時間到了，就要播放鬧鐘聲音
            if (strSelectTime == DateTime.Now.ToString("HH:mm"))
            {
                try
                {
                    stopWaveOut();

                    // 指定聲音檔的相對路徑，可以使用MP3
                    string audioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "alert.wav");

                    // 使用 AudioFileReader 來讀取聲音檔
                    audioFileReader = new AudioFileReader(audioFilePath);

                    // 初始化 WaveOutEvent
                    waveOut = new WaveOutEvent();
                    waveOut.Init(audioFileReader);

                    // 播放聲音檔
                    waveOut.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法播放聲音檔，錯誤資訊: " + ex.Message);
                }
                finally
                {
                    timerAlert.Stop(); // 停止鬧鐘計時器
                }
            }
        }
        // 停止之前的播放
        private void stopWaveOut()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerAlert.Start(); // 啟動鬧鐘計時器
            button1.Enabled = false;
            button2.Enabled = true;
            strSelectTime = comboBoxH.SelectedItem.ToString() + ":" + comboBoxM.SelectedItem.ToString(); // 擷取小時和分鐘的下拉選單文字，用來設定鬧鐘時間
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWaveOut();     // 停止之前的播放
            timerAlert.Stop(); // 停止鬧鐘計時器
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            txtStopWatch.Text = sw.Elapsed.ToString("hh':'mm':'ss':'fff");    // 顯示碼表時間
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();             // 啟動碼表
            timerStopWatch.Start(); // 開始讓碼表文字顯示
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sw.Reset();                           // 停止並歸零碼表
            timerStopWatch.Stop();                // 停止讓碼表文字顯示     
            txtStopWatch.Text = "00:00:00:000";   // 讓碼表文字「歸零」
            listStopWatchLog.Items.Clear();       // 清空 ListBox 中的元素
            StopWatchLog.Clear();                 // 清除暫存碼表紀錄清單
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 如果碼表還在跑，就紀錄目前的時間，最後歸零再啟動碼錶
            if (sw.IsRunning)
            {
                logRecord();
                sw.Restart(); // 歸零碼表，碼表仍繼續進行  
            }
            else
            {
                sw.Reset(); // 如果碼表沒在跑，停止並歸零碼表
                txtStopWatch.Text = "00:00:00:000";   // 讓碼表文字「歸零」
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            sw.Stop();                  // 停止碼表，但不歸零
            timerStopWatch.Stop();      // 停止讓碼表文字顯示  
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            logRecord();
        }
        // 碼表時間紀錄
        private void logRecord()
        {
            listStopWatchLog.Items.Clear(); // 清空 ListBox 中的元素
            StopWatchLog.Add(txtStopWatch.Text); // 將碼表時間增加到暫存碼表紀錄清單裡

            // 依照碼表紀錄清單「依照最新時間順序」顯示
            int i = StopWatchLog.Count;
            while (i > 0)
            {
                listStopWatchLog.Items.Add(String.Format("第 {0} 筆紀錄：{1}", i.ToString(), StopWatchLog[i - 1] + "\n"));
                i--;
            }

        }
    }
}

