namespace Dictionary
{
    partial class AddForm
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
            this.EngTB = new System.Windows.Forms.TextBox();
            this.BenTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addFrmWrd = new System.Windows.Forms.Button();
            this.closefrmBtn = new System.Windows.Forms.Button();
            this.updateFrmWrd = new System.Windows.Forms.Button();
            this.searchFrmTB = new System.Windows.Forms.TextBox();
            this.searchFrmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EngTB
            // 
            this.EngTB.Location = new System.Drawing.Point(127, 52);
            this.EngTB.Multiline = true;
            this.EngTB.Name = "EngTB";
            this.EngTB.Size = new System.Drawing.Size(139, 23);
            this.EngTB.TabIndex = 0;
            // 
            // BenTB
            // 
            this.BenTB.Location = new System.Drawing.Point(127, 90);
            this.BenTB.Multiline = true;
            this.BenTB.Name = "BenTB";
            this.BenTB.Size = new System.Drawing.Size(139, 24);
            this.BenTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "English Word";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bangla Word";
            // 
            // addFrmWrd
            // 
            this.addFrmWrd.BackColor = System.Drawing.Color.LightGreen;
            this.addFrmWrd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFrmWrd.Location = new System.Drawing.Point(18, 137);
            this.addFrmWrd.Name = "addFrmWrd";
            this.addFrmWrd.Size = new System.Drawing.Size(70, 23);
            this.addFrmWrd.TabIndex = 4;
            this.addFrmWrd.Text = "Add";
            this.addFrmWrd.UseVisualStyleBackColor = false;
            this.addFrmWrd.Click += new System.EventHandler(this.addFrmWrd_Click);
            // 
            // closefrmBtn
            // 
            this.closefrmBtn.BackColor = System.Drawing.Color.LightGreen;
            this.closefrmBtn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closefrmBtn.Location = new System.Drawing.Point(203, 137);
            this.closefrmBtn.Name = "closefrmBtn";
            this.closefrmBtn.Size = new System.Drawing.Size(70, 23);
            this.closefrmBtn.TabIndex = 5;
            this.closefrmBtn.Text = "Close";
            this.closefrmBtn.UseVisualStyleBackColor = false;
            this.closefrmBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateFrmWrd
            // 
            this.updateFrmWrd.BackColor = System.Drawing.Color.LightGreen;
            this.updateFrmWrd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFrmWrd.Location = new System.Drawing.Point(112, 137);
            this.updateFrmWrd.Name = "updateFrmWrd";
            this.updateFrmWrd.Size = new System.Drawing.Size(70, 23);
            this.updateFrmWrd.TabIndex = 6;
            this.updateFrmWrd.Text = "Update";
            this.updateFrmWrd.UseVisualStyleBackColor = false;
            this.updateFrmWrd.Click += new System.EventHandler(this.updateFrmWrd_Click);
            // 
            // searchFrmTB
            // 
            this.searchFrmTB.Location = new System.Drawing.Point(18, 12);
            this.searchFrmTB.Multiline = true;
            this.searchFrmTB.Name = "searchFrmTB";
            this.searchFrmTB.Size = new System.Drawing.Size(184, 20);
            this.searchFrmTB.TabIndex = 7;
            // 
            // searchFrmBtn
            // 
            this.searchFrmBtn.BackColor = System.Drawing.Color.Beige;
            this.searchFrmBtn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFrmBtn.Location = new System.Drawing.Point(208, 10);
            this.searchFrmBtn.Name = "searchFrmBtn";
            this.searchFrmBtn.Size = new System.Drawing.Size(58, 23);
            this.searchFrmBtn.TabIndex = 8;
            this.searchFrmBtn.Text = "Search";
            this.searchFrmBtn.UseVisualStyleBackColor = false;
            this.searchFrmBtn.Click += new System.EventHandler(this.searchFrmBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(285, 174);
            this.Controls.Add(this.searchFrmBtn);
            this.Controls.Add(this.searchFrmTB);
            this.Controls.Add(this.updateFrmWrd);
            this.Controls.Add(this.closefrmBtn);
            this.Controls.Add(this.addFrmWrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BenTB);
            this.Controls.Add(this.EngTB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(301, 213);
            this.MinimumSize = new System.Drawing.Size(301, 213);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EngTB;
        private System.Windows.Forms.TextBox BenTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addFrmWrd;
        private System.Windows.Forms.Button closefrmBtn;
        private System.Windows.Forms.Button updateFrmWrd;
        private System.Windows.Forms.TextBox searchFrmTB;
        private System.Windows.Forms.Button searchFrmBtn;
    }
}