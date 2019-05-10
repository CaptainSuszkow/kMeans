namespace Kmeans
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BLoadFromFile = new System.Windows.Forms.Button();
            this.BTrain = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BShowGraph = new System.Windows.Forms.Button();
            this.PtD = new System.Windows.Forms.NumericUpDown();
            this.NiDCentroidsAmount = new System.Windows.Forms.NumericUpDown();
            this.BCredits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiDCentroidsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pB
            // 
            this.pB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pB.Location = new System.Drawing.Point(12, 12);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(706, 583);
            this.pB.TabIndex = 0;
            this.pB.TabStop = false;
            this.pB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pB_MouseDown);
            this.pB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pB_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Points to draw";
            // 
            // BLoadFromFile
            // 
            this.BLoadFromFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BLoadFromFile.Location = new System.Drawing.Point(751, 189);
            this.BLoadFromFile.Name = "BLoadFromFile";
            this.BLoadFromFile.Size = new System.Drawing.Size(100, 37);
            this.BLoadFromFile.TabIndex = 3;
            this.BLoadFromFile.Text = "Load Points";
            this.BLoadFromFile.UseVisualStyleBackColor = false;
            this.BLoadFromFile.Click += new System.EventHandler(this.BLoadFormFile_Click);
            // 
            // BTrain
            // 
            this.BTrain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTrain.Location = new System.Drawing.Point(751, 143);
            this.BTrain.Name = "BTrain";
            this.BTrain.Size = new System.Drawing.Size(100, 40);
            this.BTrain.TabIndex = 4;
            this.BTrain.Text = "k Means";
            this.BTrain.UseVisualStyleBackColor = false;
            this.BTrain.Click += new System.EventHandler(this.BTrain_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(751, 277);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(100, 35);
            this.BClear.TabIndex = 5;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount of Centroods";
            // 
            // BShowGraph
            // 
            this.BShowGraph.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BShowGraph.Location = new System.Drawing.Point(751, 232);
            this.BShowGraph.Name = "BShowGraph";
            this.BShowGraph.Size = new System.Drawing.Size(100, 39);
            this.BShowGraph.TabIndex = 11;
            this.BShowGraph.Text = "Show Error";
            this.BShowGraph.UseVisualStyleBackColor = false;
            this.BShowGraph.Click += new System.EventHandler(this.BShowGraph_Click);
            // 
            // PtD
            // 
            this.PtD.Location = new System.Drawing.Point(751, 68);
            this.PtD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PtD.Name = "PtD";
            this.PtD.Size = new System.Drawing.Size(103, 20);
            this.PtD.TabIndex = 12;
            this.PtD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // NiDCentroidsAmount
            // 
            this.NiDCentroidsAmount.Location = new System.Drawing.Point(751, 107);
            this.NiDCentroidsAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NiDCentroidsAmount.Name = "NiDCentroidsAmount";
            this.NiDCentroidsAmount.Size = new System.Drawing.Size(103, 20);
            this.NiDCentroidsAmount.TabIndex = 13;
            this.NiDCentroidsAmount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // BCredits
            // 
            this.BCredits.Location = new System.Drawing.Point(828, 572);
            this.BCredits.Name = "BCredits";
            this.BCredits.Size = new System.Drawing.Size(75, 23);
            this.BCredits.TabIndex = 14;
            this.BCredits.Text = "Credits";
            this.BCredits.UseVisualStyleBackColor = true;
            this.BCredits.Click += new System.EventHandler(this.BCredits_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 607);
            this.Controls.Add(this.BCredits);
            this.Controls.Add(this.NiDCentroidsAmount);
            this.Controls.Add(this.PtD);
            this.Controls.Add(this.BShowGraph);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BTrain);
            this.Controls.Add(this.BLoadFromFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KMeans";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NiDCentroidsAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLoadFromFile;
        private System.Windows.Forms.Button BTrain;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BShowGraph;
        private System.Windows.Forms.NumericUpDown PtD;
        private System.Windows.Forms.NumericUpDown NiDCentroidsAmount;
        private System.Windows.Forms.Button BCredits;
    }
}

