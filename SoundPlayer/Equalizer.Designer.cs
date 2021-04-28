namespace SoundPlayer
{
    partial class Equalizer
    {
        //eq which controls highs, mids, and lows
        private System.ComponentModel.IContainer components = null;

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

        
         
        private void InitializeComponent()
        {
            this.tbarLows = new System.Windows.Forms.TrackBar();
            this.tbarHighs = new System.Windows.Forms.TrackBar();
            this.tbarMids = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHighs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMids)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarLows
            // 
            this.tbarLows.Location = new System.Drawing.Point(99, 141);
            this.tbarLows.Name = "tbarLows";
            this.tbarLows.Size = new System.Drawing.Size(238, 56);
            this.tbarLows.TabIndex = 0;
            this.tbarLows.Value = 5;
            this.tbarLows.ValueChanged += new System.EventHandler(this.tbarLows_ValueChanged);
            // 
            // tbarHighs
            // 
            this.tbarHighs.Location = new System.Drawing.Point(99, 24);
            this.tbarHighs.Name = "tbarHighs";
            this.tbarHighs.Size = new System.Drawing.Size(238, 56);
            this.tbarHighs.TabIndex = 1;
            this.tbarHighs.Value = 5;
            this.tbarHighs.ValueChanged += new System.EventHandler(this.tbarHighs_ValueChanged);
            // 
            // tbarMids
            // 
            this.tbarMids.Location = new System.Drawing.Point(99, 86);
            this.tbarMids.Name = "tbarMids";
            this.tbarMids.Size = new System.Drawing.Size(238, 56);
            this.tbarMids.TabIndex = 2;
            this.tbarMids.Value = 5;
            this.tbarMids.ValueChanged += new System.EventHandler(this.tbarMids_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Highs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mids";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lows";
            // 
            // Equalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbarMids);
            this.Controls.Add(this.tbarHighs);
            this.Controls.Add(this.tbarLows);
            this.Name = "Equalizer";
            this.Text = "Equalizer";
            ((System.ComponentModel.ISupportInitialize)(this.tbarLows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHighs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMids)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbarLows;
        private System.Windows.Forms.TrackBar tbarHighs;
        private System.Windows.Forms.TrackBar tbarMids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}