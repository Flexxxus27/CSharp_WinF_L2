namespace CSharp_WinF_L2
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
            lstSource = new ListBox();
            lstDest = new ListBox();
            btnAddDestAll = new Button();
            btnAddDest = new Button();
            btnClearDest = new Button();
            chbDelSource = new CheckBox();
            lstAddRes = new Button();
            lstAddResAll = new Button();
            pbSource = new ProgressBar();
            pbDest = new ProgressBar();
            btnForm2 = new Button();
            SuspendLayout();
            // 
            // lstSource
            // 
            lstSource.FormattingEnabled = true;
            lstSource.ItemHeight = 15;
            lstSource.Items.AddRange(new object[] { "Физика", "Химия", "Математика", "черчение", "Музыка" });
            lstSource.Location = new Point(112, 53);
            lstSource.Name = "lstSource";
            lstSource.SelectionMode = SelectionMode.MultiSimple;
            lstSource.Size = new Size(150, 259);
            lstSource.TabIndex = 0;
            // 
            // lstDest
            // 
            lstDest.FormattingEnabled = true;
            lstDest.ItemHeight = 15;
            lstDest.Location = new Point(320, 53);
            lstDest.Name = "lstDest";
            lstDest.Size = new Size(150, 259);
            lstDest.TabIndex = 1;
            // 
            // btnAddDestAll
            // 
            btnAddDestAll.Location = new Point(268, 82);
            btnAddDestAll.Name = "btnAddDestAll";
            btnAddDestAll.Size = new Size(46, 23);
            btnAddDestAll.TabIndex = 2;
            btnAddDestAll.Text = "->->";
            btnAddDestAll.UseVisualStyleBackColor = true;
            btnAddDestAll.Click += btnAddDestAll_Click;
            // 
            // btnAddDest
            // 
            btnAddDest.Location = new Point(268, 53);
            btnAddDest.Name = "btnAddDest";
            btnAddDest.Size = new Size(46, 23);
            btnAddDest.TabIndex = 3;
            btnAddDest.Text = "->";
            btnAddDest.UseVisualStyleBackColor = true;
            btnAddDest.Click += btnAddDest_Click;
            // 
            // btnClearDest
            // 
            btnClearDest.Location = new Point(268, 289);
            btnClearDest.Name = "btnClearDest";
            btnClearDest.Size = new Size(46, 23);
            btnClearDest.TabIndex = 4;
            btnClearDest.Text = "C";
            btnClearDest.UseVisualStyleBackColor = true;
            btnClearDest.Click += btnClearDest_Click;
            // 
            // chbDelSource
            // 
            chbDelSource.AutoSize = true;
            chbDelSource.Location = new Point(497, 53);
            chbDelSource.Name = "chbDelSource";
            chbDelSource.Size = new Size(146, 19);
            chbDelSource.TabIndex = 5;
            chbDelSource.Text = "Удалить из источника";
            chbDelSource.UseVisualStyleBackColor = true;
            // 
            // lstAddRes
            // 
            lstAddRes.Location = new Point(268, 154);
            lstAddRes.Name = "lstAddRes";
            lstAddRes.Size = new Size(46, 23);
            lstAddRes.TabIndex = 6;
            lstAddRes.Text = "<-";
            lstAddRes.UseVisualStyleBackColor = true;
            lstAddRes.Click += lstAddRes_Click;
            // 
            // lstAddResAll
            // 
            lstAddResAll.Location = new Point(268, 183);
            lstAddResAll.Name = "lstAddResAll";
            lstAddResAll.Size = new Size(46, 23);
            lstAddResAll.TabIndex = 7;
            lstAddResAll.Text = "<-<-";
            lstAddResAll.UseVisualStyleBackColor = true;
            lstAddResAll.Click += lstAddResAll_Click;
            // 
            // pbSource
            // 
            pbSource.Location = new Point(112, 327);
            pbSource.Name = "pbSource";
            pbSource.Size = new Size(150, 23);
            pbSource.TabIndex = 8;
            pbSource.Click += pbSource_Click;
            // 
            // pbDest
            // 
            pbDest.Location = new Point(320, 327);
            pbDest.Name = "pbDest";
            pbDest.Size = new Size(150, 23);
            pbDest.TabIndex = 9;
            pbDest.Click += pbDest_Click;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(573, 152);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(138, 84);
            btnForm2.TabIndex = 10;
            btnForm2.Text = "Открыть";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnOpen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm2);
            Controls.Add(pbDest);
            Controls.Add(pbSource);
            Controls.Add(lstAddResAll);
            Controls.Add(lstAddRes);
            Controls.Add(chbDelSource);
            Controls.Add(btnClearDest);
            Controls.Add(btnAddDest);
            Controls.Add(btnAddDestAll);
            Controls.Add(lstDest);
            Controls.Add(lstSource);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSource;
        private ListBox lstDest;
        private Button btnAddDestAll;
        private Button btnAddDest;
        private Button btnClearDest;
        private CheckBox chbDelSource;
        private Button lstAddRes;
        private Button lstAddResAll;
        private ProgressBar pbSource;
        private ProgressBar pbDest;
        private Button btnForm2;
    }
}
