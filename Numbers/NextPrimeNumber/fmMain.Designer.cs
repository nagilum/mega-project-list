namespace NextPrimeNumber {
  partial class fmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.nmNumberToStartWith = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.btStart = new System.Windows.Forms.Button();
      this.btStop = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbCurrentNumber = new System.Windows.Forms.Label();
      this.tbFoundPrimes = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.nmNumberToStartWith)).BeginInit();
      this.SuspendLayout();
      // 
      // nmNumberToStartWith
      // 
      this.nmNumberToStartWith.Location = new System.Drawing.Point(12, 34);
      this.nmNumberToStartWith.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
      this.nmNumberToStartWith.Name = "nmNumberToStartWith";
      this.nmNumberToStartWith.Size = new System.Drawing.Size(166, 20);
      this.nmNumberToStartWith.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Number to start with:";
      // 
      // btStart
      // 
      this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btStart.Location = new System.Drawing.Point(376, 25);
      this.btStart.Name = "btStart";
      this.btStart.Size = new System.Drawing.Size(98, 29);
      this.btStart.TabIndex = 1;
      this.btStart.Text = "Start";
      this.btStart.UseVisualStyleBackColor = true;
      this.btStart.Click += new System.EventHandler(this.btStart_Click);
      // 
      // btStop
      // 
      this.btStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btStop.Enabled = false;
      this.btStop.Location = new System.Drawing.Point(480, 25);
      this.btStop.Name = "btStop";
      this.btStop.Size = new System.Drawing.Size(98, 29);
      this.btStop.TabIndex = 2;
      this.btStop.Text = "Stop";
      this.btStop.UseVisualStyleBackColor = true;
      this.btStop.Click += new System.EventHandler(this.btStop_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 97);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Found primes:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 71);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(82, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Current number:";
      // 
      // lbCurrentNumber
      // 
      this.lbCurrentNumber.AutoSize = true;
      this.lbCurrentNumber.Location = new System.Drawing.Point(109, 71);
      this.lbCurrentNumber.Name = "lbCurrentNumber";
      this.lbCurrentNumber.Size = new System.Drawing.Size(13, 13);
      this.lbCurrentNumber.TabIndex = 5;
      this.lbCurrentNumber.Text = "0";
      // 
      // tbFoundPrimes
      // 
      this.tbFoundPrimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tbFoundPrimes.Location = new System.Drawing.Point(12, 113);
      this.tbFoundPrimes.Multiline = true;
      this.tbFoundPrimes.Name = "tbFoundPrimes";
      this.tbFoundPrimes.ReadOnly = true;
      this.tbFoundPrimes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tbFoundPrimes.Size = new System.Drawing.Size(566, 212);
      this.tbFoundPrimes.TabIndex = 6;
      // 
      // fmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(590, 337);
      this.Controls.Add(this.tbFoundPrimes);
      this.Controls.Add(this.lbCurrentNumber);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btStop);
      this.Controls.Add(this.btStart);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nmNumberToStartWith);
      this.MinimumSize = new System.Drawing.Size(475, 312);
      this.Name = "fmMain";
      this.Text = "Next Prime Number";
      ((System.ComponentModel.ISupportInitialize)(this.nmNumberToStartWith)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown nmNumberToStartWith;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btStart;
    private System.Windows.Forms.Button btStop;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lbCurrentNumber;
    private System.Windows.Forms.TextBox tbFoundPrimes;
  }
}