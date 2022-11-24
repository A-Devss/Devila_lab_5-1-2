namespace CreatingTextFile
{
    partial class FrmStudentRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Record";
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(16, 45);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(389, 233);
            this.lvShowText.TabIndex = 2;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.List;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(462, 45);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 39);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(462, 145);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(119, 39);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}