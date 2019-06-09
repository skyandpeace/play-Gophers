namespace Dgitarrange
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
            this.tmrout = new System.Windows.Forms.Timer(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.easy = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.evil = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrout
            // 
            this.tmrout.Tick += new System.EventHandler(this.tmrout_Tick);
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnstart.Location = new System.Drawing.Point(730, 338);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(151, 44);
            this.btnstart.TabIndex = 0;
            this.btnstart.Text = "啟動遊戲";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("新細明體", 24F);
            this.lblscore.Location = new System.Drawing.Point(730, 15);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(102, 32);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "分數:0";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("新細明體", 24F);
            this.lbltime.Location = new System.Drawing.Point(730, 61);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(117, 32);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "時間:60";
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Location = new System.Drawing.Point(34, 23);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(47, 16);
            this.easy.TabIndex = 3;
            this.easy.Text = "簡單";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.CheckedChanged += new System.EventHandler(this.easy_CheckedChanged);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(34, 46);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(47, 16);
            this.hard.TabIndex = 4;
            this.hard.Text = "困難";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // evil
            // 
            this.evil.AutoSize = true;
            this.evil.Location = new System.Drawing.Point(34, 68);
            this.evil.Name = "evil";
            this.evil.Size = new System.Drawing.Size(47, 16);
            this.evil.TabIndex = 5;
            this.evil.Text = "魔鬼";
            this.evil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.evil);
            this.groupBox1.Controls.Add(this.easy);
            this.groupBox1.Controls.Add(this.hard);
            this.groupBox1.Location = new System.Drawing.Point(736, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "難度";
            // 
            // rebtn
            // 
            this.rebtn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rebtn.Location = new System.Drawing.Point(730, 288);
            this.rebtn.Name = "rebtn";
            this.rebtn.Size = new System.Drawing.Size(151, 44);
            this.rebtn.TabIndex = 7;
            this.rebtn.Text = "重新開始";
            this.rebtn.UseVisualStyleBackColor = true;
            this.rebtn.Click += new System.EventHandler(this.rebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 455);
            this.Controls.Add(this.rebtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "打地鼠";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer tmrout;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton evil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rebtn;
    }
}

