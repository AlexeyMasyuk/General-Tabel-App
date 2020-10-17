namespace generalSQL_Table
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.TableNameBox = new System.Windows.Forms.TextBox();
            this.ColumnNumberBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstColBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondColBox = new System.Windows.Forms.TextBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.ThirdColBox = new System.Windows.Forms.TextBox();
            this.ThirdLabel = new System.Windows.Forms.Label();
            this.FourthColBox = new System.Windows.Forms.TextBox();
            this.FourthLabel = new System.Windows.Forms.Label();
            this.FifthColBox = new System.Windows.Forms.TextBox();
            this.FifthLabel = new System.Windows.Forms.Label();
            this.SixthColBox = new System.Windows.Forms.TextBox();
            this.SixthLabel = new System.Windows.Forms.Label();
            this.SeventhColBox = new System.Windows.Forms.TextBox();
            this.SeventhLabel = new System.Windows.Forms.Label();
            this.EightColBox = new System.Windows.Forms.TextBox();
            this.EigthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(189, 565);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(134, 52);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // TableNameBox
            // 
            this.TableNameBox.Location = new System.Drawing.Point(264, 57);
            this.TableNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TableNameBox.Name = "TableNameBox";
            this.TableNameBox.Size = new System.Drawing.Size(152, 26);
            this.TableNameBox.TabIndex = 1;
            // 
            // ColumnNumberBox
            // 
            this.ColumnNumberBox.AccessibleDescription = "Number of columns in your tabel";
            this.ColumnNumberBox.FormattingEnabled = true;
            this.ColumnNumberBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ColumnNumberBox.Location = new System.Drawing.Point(264, 114);
            this.ColumnNumberBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColumnNumberBox.Name = "ColumnNumberBox";
            this.ColumnNumberBox.Size = new System.Drawing.Size(94, 28);
            this.ColumnNumberBox.TabIndex = 2;
            this.ColumnNumberBox.Text = "2";
            this.ColumnNumberBox.SelectedIndexChanged += new System.EventHandler(this.ColumnNumberBox_SelectedIndexChanged);
            this.ColumnNumberBox.TextUpdate += new System.EventHandler(this.ColumnNumberBox_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column Number";
            // 
            // FirstColBox
            // 
            this.FirstColBox.Location = new System.Drawing.Point(300, 191);
            this.FirstColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstColBox.Name = "FirstColBox";
            this.FirstColBox.Size = new System.Drawing.Size(142, 26);
            this.FirstColBox.TabIndex = 5;
            this.FirstColBox.Visible = false;
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(112, 202);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(144, 20);
            this.FirstLabel.TabIndex = 6;
            this.FirstLabel.Text = "First Column Name";
            this.FirstLabel.Visible = false;
            // 
            // SecondColBox
            // 
            this.SecondColBox.Location = new System.Drawing.Point(300, 231);
            this.SecondColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondColBox.Name = "SecondColBox";
            this.SecondColBox.Size = new System.Drawing.Size(142, 26);
            this.SecondColBox.TabIndex = 5;
            this.SecondColBox.Visible = false;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(112, 242);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(168, 20);
            this.SecondLabel.TabIndex = 6;
            this.SecondLabel.Text = "Second Column Name";
            this.SecondLabel.Visible = false;
            // 
            // ThirdColBox
            // 
            this.ThirdColBox.Location = new System.Drawing.Point(300, 272);
            this.ThirdColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThirdColBox.Name = "ThirdColBox";
            this.ThirdColBox.Size = new System.Drawing.Size(142, 26);
            this.ThirdColBox.TabIndex = 5;
            this.ThirdColBox.Visible = false;
            // 
            // ThirdLabel
            // 
            this.ThirdLabel.AutoSize = true;
            this.ThirdLabel.Location = new System.Drawing.Point(112, 283);
            this.ThirdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThirdLabel.Name = "ThirdLabel";
            this.ThirdLabel.Size = new System.Drawing.Size(148, 20);
            this.ThirdLabel.TabIndex = 6;
            this.ThirdLabel.Text = "Third Column Name";
            this.ThirdLabel.Visible = false;
            // 
            // FourthColBox
            // 
            this.FourthColBox.Location = new System.Drawing.Point(300, 312);
            this.FourthColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FourthColBox.Name = "FourthColBox";
            this.FourthColBox.Size = new System.Drawing.Size(142, 26);
            this.FourthColBox.TabIndex = 5;
            this.FourthColBox.Visible = false;
            // 
            // FourthLabel
            // 
            this.FourthLabel.AutoSize = true;
            this.FourthLabel.Location = new System.Drawing.Point(112, 323);
            this.FourthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FourthLabel.Name = "FourthLabel";
            this.FourthLabel.Size = new System.Drawing.Size(160, 20);
            this.FourthLabel.TabIndex = 6;
            this.FourthLabel.Text = "Fourth Column Name";
            this.FourthLabel.Visible = false;
            // 
            // FifthColBox
            // 
            this.FifthColBox.Location = new System.Drawing.Point(300, 352);
            this.FifthColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FifthColBox.Name = "FifthColBox";
            this.FifthColBox.Size = new System.Drawing.Size(142, 26);
            this.FifthColBox.TabIndex = 5;
            this.FifthColBox.Visible = false;
            // 
            // FifthLabel
            // 
            this.FifthLabel.AutoSize = true;
            this.FifthLabel.Location = new System.Drawing.Point(112, 363);
            this.FifthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FifthLabel.Name = "FifthLabel";
            this.FifthLabel.Size = new System.Drawing.Size(145, 20);
            this.FifthLabel.TabIndex = 6;
            this.FifthLabel.Text = "Fifth Column Name";
            this.FifthLabel.Visible = false;
            // 
            // SixthColBox
            // 
            this.SixthColBox.Location = new System.Drawing.Point(300, 392);
            this.SixthColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SixthColBox.Name = "SixthColBox";
            this.SixthColBox.Size = new System.Drawing.Size(142, 26);
            this.SixthColBox.TabIndex = 5;
            this.SixthColBox.Visible = false;
            // 
            // SixthLabel
            // 
            this.SixthLabel.AutoSize = true;
            this.SixthLabel.Location = new System.Drawing.Point(112, 403);
            this.SixthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SixthLabel.Name = "SixthLabel";
            this.SixthLabel.Size = new System.Drawing.Size(148, 20);
            this.SixthLabel.TabIndex = 6;
            this.SixthLabel.Text = "Sixth Column Name";
            this.SixthLabel.Visible = false;
            // 
            // SeventhColBox
            // 
            this.SeventhColBox.Location = new System.Drawing.Point(300, 434);
            this.SeventhColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeventhColBox.Name = "SeventhColBox";
            this.SeventhColBox.Size = new System.Drawing.Size(142, 26);
            this.SeventhColBox.TabIndex = 5;
            this.SeventhColBox.Visible = false;
            // 
            // SeventhLabel
            // 
            this.SeventhLabel.AutoSize = true;
            this.SeventhLabel.Location = new System.Drawing.Point(112, 445);
            this.SeventhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeventhLabel.Name = "SeventhLabel";
            this.SeventhLabel.Size = new System.Drawing.Size(172, 20);
            this.SeventhLabel.TabIndex = 6;
            this.SeventhLabel.Text = "Seventh Column Name";
            this.SeventhLabel.Visible = false;
            // 
            // EightColBox
            // 
            this.EightColBox.Location = new System.Drawing.Point(300, 475);
            this.EightColBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EightColBox.Name = "EightColBox";
            this.EightColBox.Size = new System.Drawing.Size(142, 26);
            this.EightColBox.TabIndex = 5;
            this.EightColBox.Visible = false;
            // 
            // EigthLabel
            // 
            this.EigthLabel.AutoSize = true;
            this.EigthLabel.Location = new System.Drawing.Point(112, 486);
            this.EigthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EigthLabel.Name = "EigthLabel";
            this.EigthLabel.Size = new System.Drawing.Size(150, 20);
            this.EigthLabel.TabIndex = 6;
            this.EigthLabel.Text = "Eigth Column Name";
            this.EigthLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 666);
            this.Controls.Add(this.EigthLabel);
            this.Controls.Add(this.EightColBox);
            this.Controls.Add(this.SeventhLabel);
            this.Controls.Add(this.SeventhColBox);
            this.Controls.Add(this.SixthLabel);
            this.Controls.Add(this.SixthColBox);
            this.Controls.Add(this.FifthLabel);
            this.Controls.Add(this.FifthColBox);
            this.Controls.Add(this.FourthLabel);
            this.Controls.Add(this.FourthColBox);
            this.Controls.Add(this.ThirdLabel);
            this.Controls.Add(this.ThirdColBox);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.SecondColBox);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.FirstColBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnNumberBox);
            this.Controls.Add(this.TableNameBox);
            this.Controls.Add(this.CreateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox TableNameBox;
        private System.Windows.Forms.ComboBox ColumnNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstColBox;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.TextBox SecondColBox;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.TextBox ThirdColBox;
        private System.Windows.Forms.Label ThirdLabel;
        private System.Windows.Forms.TextBox FourthColBox;
        private System.Windows.Forms.Label FourthLabel;
        private System.Windows.Forms.TextBox FifthColBox;
        private System.Windows.Forms.Label FifthLabel;
        private System.Windows.Forms.TextBox SixthColBox;
        private System.Windows.Forms.Label SixthLabel;
        private System.Windows.Forms.TextBox SeventhColBox;
        private System.Windows.Forms.Label SeventhLabel;
        private System.Windows.Forms.TextBox EightColBox;
        private System.Windows.Forms.Label EigthLabel;
    }
}

