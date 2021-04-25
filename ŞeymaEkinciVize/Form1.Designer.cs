
namespace ŞeymaEkinciVize
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
            this.label_drc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_drm = new System.Windows.Forms.Label();
            this.picture_bulutlu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).BeginInit();
            this.SuspendLayout();
            // 
            // label_drc
            // 
            this.label_drc.AutoSize = true;
            this.label_drc.Location = new System.Drawing.Point(83, 53);
            this.label_drc.Name = "label_drc";
            this.label_drc.Size = new System.Drawing.Size(46, 17);
            this.label_drc.TabIndex = 0;
            this.label_drc.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label_drm
            // 
            this.label_drm.AutoSize = true;
            this.label_drm.Location = new System.Drawing.Point(83, 143);
            this.label_drm.Name = "label_drm";
            this.label_drm.Size = new System.Drawing.Size(46, 17);
            this.label_drm.TabIndex = 3;
            this.label_drm.Text = "label4";
            // 
            // picture_bulutlu
            // 
            this.picture_bulutlu.Image = global::ŞeymaEkinciVize.Properties.Resources._47528110_sunny_weather_condition;
            this.picture_bulutlu.Location = new System.Drawing.Point(278, 94);
            this.picture_bulutlu.Name = "picture_bulutlu";
            this.picture_bulutlu.Size = new System.Drawing.Size(128, 115);
            this.picture_bulutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_bulutlu.TabIndex = 2;
            this.picture_bulutlu.TabStop = false;
            this.picture_bulutlu.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(567, 363);
            this.Controls.Add(this.label_drm);
            this.Controls.Add(this.picture_bulutlu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_drc);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_bulutlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_drc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_bulutlu;
        private System.Windows.Forms.Label label_drm;
    }
}

