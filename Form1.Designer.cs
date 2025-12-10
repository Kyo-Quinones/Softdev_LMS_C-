namespace _2ndLabExamOOP
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
            btnItem1 = new Button();
            btnItem2 = new Button();
            SuspendLayout();
            // 
            // btnItem1
            // 
            btnItem1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnItem1.Location = new Point(12, 12);
            btnItem1.Name = "btnItem1";
            btnItem1.Size = new Size(462, 120);
            btnItem1.TabIndex = 0;
            btnItem1.Text = "(40 Points) Regular Employee";
            btnItem1.UseVisualStyleBackColor = true;
            btnItem1.Click += btnItem1_Click;
            // 
            // btnItem2
            // 
            btnItem2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnItem2.Location = new Point(12, 138);
            btnItem2.Name = "btnItem2";
            btnItem2.Size = new Size(462, 120);
            btnItem2.TabIndex = 1;
            btnItem2.Text = "(10 Points) Add Contract Employee";
            btnItem2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnItem2.UseVisualStyleBackColor = true;
            btnItem2.Click += btnItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 276);
            Controls.Add(btnItem2);
            Controls.Add(btnItem1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnItem1;
        private Button btnItem2;
    }
}
