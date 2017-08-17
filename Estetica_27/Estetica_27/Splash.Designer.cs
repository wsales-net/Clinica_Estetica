namespace Estetica_27
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pbxSplash = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgbIniciar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSplash
            // 
            this.pbxSplash.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pbxSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxSplash.Image = ((System.Drawing.Image)(resources.GetObject("pbxSplash.Image")));
            this.pbxSplash.Location = new System.Drawing.Point(0, 0);
            this.pbxSplash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxSplash.Name = "pbxSplash";
            this.pbxSplash.Size = new System.Drawing.Size(772, 398);
            this.pbxSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSplash.TabIndex = 0;
            this.pbxSplash.TabStop = false;
            this.pbxSplash.Click += new System.EventHandler(this.pbxSplash_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbIniciar
            // 
            this.pgbIniciar.BackColor = System.Drawing.Color.Red;
            this.pgbIniciar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pgbIniciar.ForeColor = System.Drawing.Color.Coral;
            this.pgbIniciar.Location = new System.Drawing.Point(0, 385);
            this.pgbIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbIniciar.Name = "pgbIniciar";
            this.pgbIniciar.Size = new System.Drawing.Size(772, 12);
            this.pgbIniciar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbIniciar.TabIndex = 1;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(772, 398);
            this.Controls.Add(this.pgbIniciar);
            this.Controls.Add(this.pbxSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Splash";
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgbIniciar;
    }
}