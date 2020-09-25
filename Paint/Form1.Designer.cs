namespace Paint
{
    partial class frmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            this.pnlShapes = new System.Windows.Forms.Panel();
            this.btnBezier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRhombus = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPyramid = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColors = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPenSize = new System.Windows.Forms.Panel();
            this.KhungVe = new Paint.KhungVe();
            this.pnlXoay = new System.Windows.Forms.Panel();
            this.cbXoayHinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.pnlShapes.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPenSize.SuspendLayout();
            this.pnlXoay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShapes
            // 
            this.pnlShapes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlShapes.Controls.Add(this.btnBezier);
            this.pnlShapes.Controls.Add(this.label1);
            this.pnlShapes.Controls.Add(this.btnRhombus);
            this.pnlShapes.Controls.Add(this.btnPolygon);
            this.pnlShapes.Controls.Add(this.btnRectangle);
            this.pnlShapes.Controls.Add(this.btnSquare);
            this.pnlShapes.Controls.Add(this.btnPyramid);
            this.pnlShapes.Controls.Add(this.btnCircle);
            this.pnlShapes.Controls.Add(this.btnEllipse);
            this.pnlShapes.Controls.Add(this.btnLine);
            this.pnlShapes.Location = new System.Drawing.Point(1, 1);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(456, 89);
            this.pnlShapes.TabIndex = 0;
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.White;
            this.btnBezier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBezier.FlatAppearance.BorderSize = 0;
            this.btnBezier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezier.Image = ((System.Drawing.Image)(resources.GetObject("btnBezier.Image")));
            this.btnBezier.Location = new System.Drawing.Point(398, 3);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(50, 50);
            this.btnBezier.TabIndex = 9;
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Shapes";
            // 
            // btnRhombus
            // 
            this.btnRhombus.BackColor = System.Drawing.Color.White;
            this.btnRhombus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRhombus.FlatAppearance.BorderSize = 0;
            this.btnRhombus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRhombus.Image = ((System.Drawing.Image)(resources.GetObject("btnRhombus.Image")));
            this.btnRhombus.Location = new System.Drawing.Point(348, 3);
            this.btnRhombus.Name = "btnRhombus";
            this.btnRhombus.Size = new System.Drawing.Size(50, 50);
            this.btnRhombus.TabIndex = 7;
            this.btnRhombus.UseVisualStyleBackColor = false;
            this.btnRhombus.Click += new System.EventHandler(this.btnRhombus_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.White;
            this.btnPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPolygon.FlatAppearance.BorderSize = 0;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnPolygon.Image")));
            this.btnPolygon.Location = new System.Drawing.Point(298, 3);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(50, 50);
            this.btnPolygon.TabIndex = 6;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(52, 3);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(50, 50);
            this.btnRectangle.TabIndex = 5;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.White;
            this.btnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Image = ((System.Drawing.Image)(resources.GetObject("btnSquare.Image")));
            this.btnSquare.Location = new System.Drawing.Point(101, 3);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(50, 50);
            this.btnSquare.TabIndex = 4;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnPyramid
            // 
            this.btnPyramid.BackColor = System.Drawing.Color.White;
            this.btnPyramid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPyramid.FlatAppearance.BorderSize = 0;
            this.btnPyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyramid.Image = ((System.Drawing.Image)(resources.GetObject("btnPyramid.Image")));
            this.btnPyramid.Location = new System.Drawing.Point(249, 3);
            this.btnPyramid.Name = "btnPyramid";
            this.btnPyramid.Size = new System.Drawing.Size(50, 50);
            this.btnPyramid.TabIndex = 3;
            this.btnPyramid.UseVisualStyleBackColor = false;
            this.btnPyramid.Click += new System.EventHandler(this.btnPyramid_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.White;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.Location = new System.Drawing.Point(200, 3);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(50, 50);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.White;
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(151, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(50, 50);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(3, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 50);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTools.Controls.Add(this.label2);
            this.pnlTools.Controls.Add(this.btnDelete);
            this.pnlTools.Controls.Add(this.btnSelect);
            this.pnlTools.Location = new System.Drawing.Point(459, 1);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(104, 89);
            this.pnlTools.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tools";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(52, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.Location = new System.Drawing.Point(3, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 50);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.White;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.Location = new System.Drawing.Point(3, 3);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(50, 50);
            this.btnFill.TabIndex = 2;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnFill);
            this.panel1.Location = new System.Drawing.Point(565, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 89);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fill";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnColors);
            this.panel2.Location = new System.Drawing.Point(624, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 89);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Colors";
            // 
            // btnColors
            // 
            this.btnColors.BackColor = System.Drawing.Color.Black;
            this.btnColors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColors.Location = new System.Drawing.Point(3, 3);
            this.btnColors.Name = "btnColors";
            this.btnColors.Size = new System.Drawing.Size(50, 50);
            this.btnColors.TabIndex = 2;
            this.btnColors.UseVisualStyleBackColor = false;
            this.btnColors.Click += new System.EventHandler(this.btnColors_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbSize.Location = new System.Drawing.Point(78, 29);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(82, 24);
            this.cbSize.TabIndex = 6;
            this.cbSize.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pen Size";
            // 
            // pnlPenSize
            // 
            this.pnlPenSize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPenSize.Controls.Add(this.cbSize);
            this.pnlPenSize.Controls.Add(this.label5);
            this.pnlPenSize.Location = new System.Drawing.Point(685, 1);
            this.pnlPenSize.Name = "pnlPenSize";
            this.pnlPenSize.Size = new System.Drawing.Size(166, 89);
            this.pnlPenSize.TabIndex = 6;
            // 
            // KhungVe
            // 
            this.KhungVe.BackColor = System.Drawing.Color.White;
            this.KhungVe.Location = new System.Drawing.Point(1, 92);
            this.KhungVe.Name = "KhungVe";
            this.KhungVe.Size = new System.Drawing.Size(1274, 661);
            this.KhungVe.TabIndex = 5;
            this.KhungVe.Paint += new System.Windows.Forms.PaintEventHandler(this.KhungVe_Paint);
            this.KhungVe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.KhungVe_MouseDoubleClick);
            this.KhungVe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KhungVe_MouseDown);
            this.KhungVe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KhungVe_MouseMove);
            this.KhungVe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KhungVe_MouseUp);
            // 
            // pnlXoay
            // 
            this.pnlXoay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlXoay.Controls.Add(this.cbXoayHinh);
            this.pnlXoay.Controls.Add(this.label6);
            this.pnlXoay.Location = new System.Drawing.Point(854, 1);
            this.pnlXoay.Name = "pnlXoay";
            this.pnlXoay.Size = new System.Drawing.Size(200, 89);
            this.pnlXoay.TabIndex = 7;
            // 
            // cbXoayHinh
            // 
            this.cbXoayHinh.FormattingEnabled = true;
            this.cbXoayHinh.Items.AddRange(new object[] {
            "0",
            "90",
            "180",
            "270"});
            this.cbXoayHinh.Location = new System.Drawing.Point(99, 26);
            this.cbXoayHinh.Name = "cbXoayHinh";
            this.cbXoayHinh.Size = new System.Drawing.Size(82, 24);
            this.cbXoayHinh.TabIndex = 14;
            this.cbXoayHinh.Text = "0";
            this.cbXoayHinh.SelectedIndexChanged += new System.EventHandler(this.cbXoayHinh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Xoay hình";
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Location = new System.Drawing.Point(1060, 27);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(139, 44);
            this.btnHuongDan.TabIndex = 8;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // frmPaint
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1278, 755);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.pnlXoay);
            this.Controls.Add(this.pnlPenSize);
            this.Controls.Add(this.KhungVe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.pnlShapes);
            this.Name = "frmPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaint_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPaint_KeyUp);
            this.pnlShapes.ResumeLayout(false);
            this.pnlShapes.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPenSize.ResumeLayout(false);
            this.pnlPenSize.PerformLayout();
            this.pnlXoay.ResumeLayout(false);
            this.pnlXoay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRhombus;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPyramid;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColors;
        private KhungVe KhungVe;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlPenSize;
        private System.Windows.Forms.Panel pnlXoay;
        private System.Windows.Forms.ComboBox cbXoayHinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuongDan;
    }
}

