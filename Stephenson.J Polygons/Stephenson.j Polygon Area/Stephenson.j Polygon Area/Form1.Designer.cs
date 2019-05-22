namespace Stephenson.j_Polygon_Area
{
    partial class Polygons
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
            this.cmbxPolygons = new System.Windows.Forms.ComboBox();
            this.txtbxSideLength = new System.Windows.Forms.TextBox();
            this.lblSideLength = new System.Windows.Forms.Label();
            this.lblPolygon = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxPolygons
            // 
            this.cmbxPolygons.FormattingEnabled = true;
            this.cmbxPolygons.Items.AddRange(new object[] {
            "Triangle",
            "Square",
            "Pentagon",
            "Hexagon",
            "Octagon"});
            this.cmbxPolygons.Location = new System.Drawing.Point(12, 38);
            this.cmbxPolygons.Name = "cmbxPolygons";
            this.cmbxPolygons.Size = new System.Drawing.Size(121, 21);
            this.cmbxPolygons.TabIndex = 0;
            // 
            // txtbxSideLength
            // 
            this.txtbxSideLength.Location = new System.Drawing.Point(218, 39);
            this.txtbxSideLength.Name = "txtbxSideLength";
            this.txtbxSideLength.Size = new System.Drawing.Size(100, 20);
            this.txtbxSideLength.TabIndex = 1;
            // 
            // lblSideLength
            // 
            this.lblSideLength.AutoSize = true;
            this.lblSideLength.Location = new System.Drawing.Point(215, 9);
            this.lblSideLength.Name = "lblSideLength";
            this.lblSideLength.Size = new System.Drawing.Size(117, 13);
            this.lblSideLength.TabIndex = 2;
            this.lblSideLength.Text = "Side Length of Polygon";
            // 
            // lblPolygon
            // 
            this.lblPolygon.AutoSize = true;
            this.lblPolygon.Location = new System.Drawing.Point(12, 9);
            this.lblPolygon.Name = "lblPolygon";
            this.lblPolygon.Size = new System.Drawing.Size(88, 13);
            this.lblPolygon.TabIndex = 3;
            this.lblPolygon.Text = "Name of Polygon";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(138, 103);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(218, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Polygons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 702);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPolygon);
            this.Controls.Add(this.lblSideLength);
            this.Controls.Add(this.txtbxSideLength);
            this.Controls.Add(this.cmbxPolygons);
            this.Name = "Polygons";
            this.Text = "Polygons";
            this.Load += new System.EventHandler(this.Polygons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxPolygons;
        private System.Windows.Forms.TextBox txtbxSideLength;
        private System.Windows.Forms.Label lblSideLength;
        private System.Windows.Forms.Label lblPolygon;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

