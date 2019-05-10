namespace Kmeans
{
    partial class Form2
    {

        private OxyPlot.WindowsForms.PlotView pv;
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
            this.pv = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // pv
            // 
            this.pv.Location = new System.Drawing.Point(0, 0);
            this.pv.Name = "pv";
            this.pv.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pv.Size = new System.Drawing.Size(1000, 600);
            this.pv.TabIndex = 0;
            this.pv.Text = "Graph";
            this.pv.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pv.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pv.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 510);
            this.Name = "Form2";
            this.Text = "Error Graph";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}