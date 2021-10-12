
namespace VideoConvertExample
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.VideoTxt = new System.Windows.Forms.TextBox();
            this.Mp3Txt = new System.Windows.Forms.TextBox();
            this.BtnFromTo = new System.Windows.Forms.Button();
            this.BtnSaveTo = new System.Windows.Forms.Button();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // VideoTxt
            // 
            this.VideoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VideoTxt.Location = new System.Drawing.Point(39, 15);
            this.VideoTxt.Name = "VideoTxt";
            this.VideoTxt.Size = new System.Drawing.Size(336, 35);
            this.VideoTxt.TabIndex = 0;
            // 
            // Mp3Txt
            // 
            this.Mp3Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mp3Txt.Location = new System.Drawing.Point(39, 73);
            this.Mp3Txt.Name = "Mp3Txt";
            this.Mp3Txt.Size = new System.Drawing.Size(336, 35);
            this.Mp3Txt.TabIndex = 1;
            // 
            // BtnFromTo
            // 
            this.BtnFromTo.Location = new System.Drawing.Point(381, 12);
            this.BtnFromTo.Name = "BtnFromTo";
            this.BtnFromTo.Size = new System.Drawing.Size(228, 42);
            this.BtnFromTo.TabIndex = 2;
            this.BtnFromTo.Text = "Open Video";
            this.BtnFromTo.UseVisualStyleBackColor = true;
            this.BtnFromTo.Click += new System.EventHandler(this.BtnFromTo_Click);
            // 
            // BtnSaveTo
            // 
            this.BtnSaveTo.Location = new System.Drawing.Point(381, 71);
            this.BtnSaveTo.Name = "BtnSaveTo";
            this.BtnSaveTo.Size = new System.Drawing.Size(228, 42);
            this.BtnSaveTo.TabIndex = 3;
            this.BtnSaveTo.Text = "Save MP3";
            this.BtnSaveTo.UseVisualStyleBackColor = true;
            this.BtnSaveTo.Click += new System.EventHandler(this.BtnSaveTo_Click);
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(39, 119);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(570, 44);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "CONVERT";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 169);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(570, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 219);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.BtnSaveTo);
            this.Controls.Add(this.BtnFromTo);
            this.Controls.Add(this.Mp3Txt);
            this.Controls.Add(this.VideoTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VideoTxt;
        private System.Windows.Forms.TextBox Mp3Txt;
        private System.Windows.Forms.Button BtnFromTo;
        private System.Windows.Forms.Button BtnSaveTo;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

