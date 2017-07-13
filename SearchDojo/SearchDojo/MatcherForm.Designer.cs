namespace SearchDojo
{
    partial class MatcherForm
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.matchesListView = new System.Windows.Forms.ListView();
            this.patternBox = new System.Windows.Forms.TextBox();
            this.textLbl = new System.Windows.Forms.Label();
            this.matchesLbl = new System.Windows.Forms.Label();
            this.patternLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 49);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(380, 255);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // matchesListView
            // 
            this.matchesListView.Location = new System.Drawing.Point(399, 49);
            this.matchesListView.Name = "matchesListView";
            this.matchesListView.Size = new System.Drawing.Size(230, 255);
            this.matchesListView.TabIndex = 1;
            this.matchesListView.UseCompatibleStateImageBehavior = false;
            this.matchesListView.View = System.Windows.Forms.View.List;
            // 
            // patternBox
            // 
            this.patternBox.Location = new System.Drawing.Point(181, 323);
            this.patternBox.Name = "patternBox";
            this.patternBox.Size = new System.Drawing.Size(297, 20);
            this.patternBox.TabIndex = 2;
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Location = new System.Drawing.Point(12, 33);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(31, 13);
            this.textLbl.TabIndex = 3;
            this.textLbl.Text = "Text:";
            // 
            // matchesLbl
            // 
            this.matchesLbl.AutoSize = true;
            this.matchesLbl.Location = new System.Drawing.Point(396, 33);
            this.matchesLbl.Name = "matchesLbl";
            this.matchesLbl.Size = new System.Drawing.Size(51, 13);
            this.matchesLbl.TabIndex = 4;
            this.matchesLbl.Text = "Matches:";
            // 
            // patternLbl
            // 
            this.patternLbl.AutoSize = true;
            this.patternLbl.Location = new System.Drawing.Point(131, 326);
            this.patternLbl.Name = "patternLbl";
            this.patternLbl.Size = new System.Drawing.Size(44, 13);
            this.patternLbl.TabIndex = 5;
            this.patternLbl.Text = "Pattern:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(484, 320);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // MatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 369);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.patternLbl);
            this.Controls.Add(this.matchesLbl);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.patternBox);
            this.Controls.Add(this.matchesListView);
            this.Controls.Add(this.textBox);
            this.Name = "MatcherForm";
            this.Text = "Matcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ListView matchesListView;
        private System.Windows.Forms.TextBox patternBox;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Label matchesLbl;
        private System.Windows.Forms.Label patternLbl;
        private System.Windows.Forms.Button searchBtn;
    }
}

