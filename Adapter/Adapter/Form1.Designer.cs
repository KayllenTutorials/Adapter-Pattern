namespace Adapter
{
  partial class Form1
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
      this.m_pnlOrigShapeDrawing = new System.Windows.Forms.Panel();
      this.m_pnlNewShapeDrawing = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.m_cbUseOriginalShapeDrawing = new System.Windows.Forms.CheckBox();
      this.m_nudPenWidth = new System.Windows.Forms.NumericUpDown();
      this.m_btnPenColor = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_nudPenWidth)).BeginInit();
      this.SuspendLayout();
      // 
      // m_pnlOrigShapeDrawing
      // 
      this.m_pnlOrigShapeDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_pnlOrigShapeDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.m_pnlOrigShapeDrawing.Location = new System.Drawing.Point(9, 26);
      this.m_pnlOrigShapeDrawing.Name = "m_pnlOrigShapeDrawing";
      this.m_pnlOrigShapeDrawing.Size = new System.Drawing.Size(216, 257);
      this.m_pnlOrigShapeDrawing.TabIndex = 0;
      this.m_pnlOrigShapeDrawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_pnlOrigShapeDrawing_MouseClick);
      // 
      // m_pnlNewShapeDrawing
      // 
      this.m_pnlNewShapeDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_pnlNewShapeDrawing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.m_pnlNewShapeDrawing.Location = new System.Drawing.Point(12, 26);
      this.m_pnlNewShapeDrawing.Name = "m_pnlNewShapeDrawing";
      this.m_pnlNewShapeDrawing.Size = new System.Drawing.Size(222, 209);
      this.m_pnlNewShapeDrawing.TabIndex = 0;
      this.m_pnlNewShapeDrawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_pnlNewShapeDrawing_MouseClick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.m_pnlOrigShapeDrawing);
      this.groupBox1.Location = new System.Drawing.Point(35, 30);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(265, 359);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Original Shape Drawing";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.m_cbUseOriginalShapeDrawing);
      this.groupBox2.Controls.Add(this.m_nudPenWidth);
      this.groupBox2.Controls.Add(this.m_btnPenColor);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.m_pnlNewShapeDrawing);
      this.groupBox2.Location = new System.Drawing.Point(355, 30);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(265, 359);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "New Shape Drawing";
      // 
      // m_cbUseOriginalShapeDrawing
      // 
      this.m_cbUseOriginalShapeDrawing.AutoSize = true;
      this.m_cbUseOriginalShapeDrawing.Location = new System.Drawing.Point(12, 315);
      this.m_cbUseOriginalShapeDrawing.Name = "m_cbUseOriginalShapeDrawing";
      this.m_cbUseOriginalShapeDrawing.Size = new System.Drawing.Size(199, 17);
      this.m_cbUseOriginalShapeDrawing.TabIndex = 5;
      this.m_cbUseOriginalShapeDrawing.Text = "Use Original Shape Drawing Adapter";
      this.m_cbUseOriginalShapeDrawing.UseVisualStyleBackColor = true;
      // 
      // m_nudPenWidth
      // 
      this.m_nudPenWidth.Location = new System.Drawing.Point(72, 250);
      this.m_nudPenWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.m_nudPenWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.m_nudPenWidth.Name = "m_nudPenWidth";
      this.m_nudPenWidth.Size = new System.Drawing.Size(39, 20);
      this.m_nudPenWidth.TabIndex = 4;
      this.m_nudPenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // m_btnPenColor
      // 
      this.m_btnPenColor.Location = new System.Drawing.Point(12, 276);
      this.m_btnPenColor.Name = "m_btnPenColor";
      this.m_btnPenColor.Size = new System.Drawing.Size(75, 23);
      this.m_btnPenColor.TabIndex = 3;
      this.m_btnPenColor.Text = "Pen Color";
      this.m_btnPenColor.UseVisualStyleBackColor = true;
      this.m_btnPenColor.Click += new System.EventHandler(this.m_btnPenColor_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 252);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Pen Width";
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(49, 395);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(571, 150);
      this.textBox1.TabIndex = 4;
      this.textBox1.Text = "Left click in a drawing panel to draw a rectangle.  Right click to draw a circle " +
    ".  Pen color on the right makes sense only when the check box to use the origina" +
    "l shape drawing adapter is UNchecked.";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(746, 555);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Original Shape Drawing Form";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_nudPenWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel m_pnlOrigShapeDrawing;
    private System.Windows.Forms.Panel m_pnlNewShapeDrawing;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button m_btnPenColor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown m_nudPenWidth;
    private System.Windows.Forms.CheckBox m_cbUseOriginalShapeDrawing;
    private System.Windows.Forms.TextBox textBox1;
  }
}

