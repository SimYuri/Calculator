using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Display = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonPM = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEgiht = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClearEntry = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(426, 136);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.ButtonResult, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.ButtonPoint, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.ButtonZero, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.ButtonPM, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.ButtonAdd, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonThree, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonTwo, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonOne, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonSubtract, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonSix, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonFive, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonFour, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonMultiply, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonNine, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonEgiht, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonSeven, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonDivide, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.ButtonClear, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.ButtonClearEntry, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.ButtonPercent, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 136);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(426, 376);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // ButtonResult
            // 
            this.ButtonResult.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonResult.Location = new System.Drawing.Point(321, 302);
            this.ButtonResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(102, 72);
            this.ButtonResult.TabIndex = 19;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = true;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonPoint.Location = new System.Drawing.Point(215, 302);
            this.ButtonPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(100, 72);
            this.ButtonPoint.TabIndex = 18;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonZero.Location = new System.Drawing.Point(109, 302);
            this.ButtonZero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(100, 72);
            this.ButtonZero.TabIndex = 17;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonPM
            // 
            this.ButtonPM.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonPM.Location = new System.Drawing.Point(3, 302);
            this.ButtonPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPM.Name = "ButtonPM";
            this.ButtonPM.Size = new System.Drawing.Size(100, 72);
            this.ButtonPM.TabIndex = 16;
            this.ButtonPM.Text = "%";
            this.ButtonPM.UseVisualStyleBackColor = true;
            this.ButtonPM.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonAdd.Location = new System.Drawing.Point(321, 227);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(102, 71);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonThree.Location = new System.Drawing.Point(215, 227);
            this.ButtonThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(100, 71);
            this.ButtonThree.TabIndex = 14;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonTwo.Location = new System.Drawing.Point(109, 227);
            this.ButtonTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(100, 71);
            this.ButtonTwo.TabIndex = 13;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonOne.Location = new System.Drawing.Point(3, 227);
            this.ButtonOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(100, 71);
            this.ButtonOne.TabIndex = 12;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonSubtract.Location = new System.Drawing.Point(321, 152);
            this.ButtonSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(102, 71);
            this.ButtonSubtract.TabIndex = 11;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonSix.Location = new System.Drawing.Point(215, 152);
            this.ButtonSix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(100, 71);
            this.ButtonSix.TabIndex = 10;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonFive.Location = new System.Drawing.Point(109, 152);
            this.ButtonFive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(100, 71);
            this.ButtonFive.TabIndex = 9;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonFour.Location = new System.Drawing.Point(3, 152);
            this.ButtonFour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(100, 71);
            this.ButtonFour.TabIndex = 8;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonMultiply.Location = new System.Drawing.Point(321, 77);
            this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(102, 71);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "×";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonNine.Location = new System.Drawing.Point(215, 77);
            this.ButtonNine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(100, 71);
            this.ButtonNine.TabIndex = 6;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEgiht
            // 
            this.ButtonEgiht.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonEgiht.Location = new System.Drawing.Point(109, 77);
            this.ButtonEgiht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEgiht.Name = "ButtonEgiht";
            this.ButtonEgiht.Size = new System.Drawing.Size(100, 71);
            this.ButtonEgiht.TabIndex = 5;
            this.ButtonEgiht.Text = "8";
            this.ButtonEgiht.UseVisualStyleBackColor = true;
            this.ButtonEgiht.Click += new System.EventHandler(this.ButtonEgiht_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonSeven.Location = new System.Drawing.Point(3, 77);
            this.ButtonSeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(100, 71);
            this.ButtonSeven.TabIndex = 4;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonDivide.Location = new System.Drawing.Point(321, 2);
            this.ButtonDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(102, 71);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "÷";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonClear.Location = new System.Drawing.Point(215, 2);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(100, 71);
            this.ButtonClear.TabIndex = 2;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonClearEntry
            // 
            this.ButtonClearEntry.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonClearEntry.Location = new System.Drawing.Point(109, 2);
            this.ButtonClearEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonClearEntry.Name = "ButtonClearEntry";
            this.ButtonClearEntry.Size = new System.Drawing.Size(100, 71);
            this.ButtonClearEntry.TabIndex = 1;
            this.ButtonClearEntry.Text = "CE";
            this.ButtonClearEntry.UseVisualStyleBackColor = true;
            this.ButtonClearEntry.Click += new System.EventHandler(this.ButtonClearEntry_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Font = new System.Drawing.Font("새굴림", 20F, System.Drawing.FontStyle.Bold);
            this.ButtonPercent.Location = new System.Drawing.Point(3, 2);
            this.ButtonPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(100, 71);
            this.ButtonPercent.TabIndex = 0;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 510);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.Display);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label Display;
        private TableLayoutPanel tableLayoutPanel;
        private Button ButtonResult;
        private Button ButtonPoint;
        private Button ButtonZero;
        private Button ButtonPM;
        private Button ButtonAdd;
        private Button ButtonThree;
        private Button ButtonTwo;
        private Button ButtonOne;
        private Button ButtonSubtract;
        private Button ButtonSix;
        private Button ButtonFive;
        private Button ButtonFour;
        private Button ButtonMultiply;
        private Button ButtonNine;
        private Button ButtonEgiht;
        private Button ButtonSeven;
        private Button ButtonDivide;
        private Button ButtonClear;
        private Button ButtonClearEntry;
        private Button ButtonPercent;
    }
}