
namespace WindowsFormsAppClock
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clock = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxH = new System.Windows.Forms.ComboBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.stopwatch = new System.Windows.Forms.TabPage();
            this.countdown = new System.Windows.Forms.TabPage();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerAlert = new System.Windows.Forms.Timer(this.components);
            this.time1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.clock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clock);
            this.tabControl1.Controls.Add(this.stopwatch);
            this.tabControl1.Controls.Add(this.countdown);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // clock
            // 
            this.clock.Controls.Add(this.label1);
            this.clock.Controls.Add(this.comboBoxM);
            this.clock.Controls.Add(this.button2);
            this.clock.Controls.Add(this.button1);
            this.clock.Controls.Add(this.comboBoxH);
            this.clock.Controls.Add(this.TB3);
            this.clock.Controls.Add(this.TB2);
            this.clock.Controls.Add(this.TB1);
            this.clock.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clock.Location = new System.Drawing.Point(4, 22);
            this.clock.Name = "clock";
            this.clock.Padding = new System.Windows.Forms.Padding(3);
            this.clock.Size = new System.Drawing.Size(768, 400);
            this.clock.TabIndex = 1;
            this.clock.Text = "時鐘";
            this.clock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(150, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxM
            // 
            this.comboBoxM.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(170, 304);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 32);
            this.comboBoxM.TabIndex = 8;
            this.comboBoxM.SelectedIndexChanged += new System.EventHandler(this.comboBoxM_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(567, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "刪除鬧鐘";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(367, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "設定鬧鐘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxH
            // 
            this.comboBoxH.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxH.FormattingEnabled = true;
            this.comboBoxH.Location = new System.Drawing.Point(23, 304);
            this.comboBoxH.Name = "comboBoxH";
            this.comboBoxH.Size = new System.Drawing.Size(121, 32);
            this.comboBoxH.TabIndex = 4;
            this.comboBoxH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TB3
            // 
            this.TB3.Enabled = false;
            this.TB3.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB3.HideSelection = false;
            this.TB3.Location = new System.Drawing.Point(456, 147);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(305, 93);
            this.TB3.TabIndex = 3;
            this.TB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB2
            // 
            this.TB2.Enabled = false;
            this.TB2.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB2.Location = new System.Drawing.Point(6, 147);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(444, 93);
            this.TB2.TabIndex = 2;
            this.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB1
            // 
            this.TB1.Enabled = false;
            this.TB1.Font = new System.Drawing.Font("微軟正黑體", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TB1.HideSelection = false;
            this.TB1.Location = new System.Drawing.Point(6, 6);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(756, 135);
            this.TB1.TabIndex = 1;
            this.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stopwatch
            // 
            this.stopwatch.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopwatch.Location = new System.Drawing.Point(4, 22);
            this.stopwatch.Name = "stopwatch";
            this.stopwatch.Padding = new System.Windows.Forms.Padding(3);
            this.stopwatch.Size = new System.Drawing.Size(768, 400);
            this.stopwatch.TabIndex = 0;
            this.stopwatch.Text = "碼表";
            this.stopwatch.UseVisualStyleBackColor = true;
            // 
            // countdown
            // 
            this.countdown.Location = new System.Drawing.Point(4, 22);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(768, 400);
            this.countdown.TabIndex = 2;
            this.countdown.Text = "倒數";
            this.countdown.UseVisualStyleBackColor = true;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerAlert
            // 
            this.timerAlert.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.clock.ResumeLayout(false);
            this.clock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stopwatch;
        private System.Windows.Forms.TabPage clock;
        private System.Windows.Forms.TabPage countdown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxH;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer time1;
    }
}

