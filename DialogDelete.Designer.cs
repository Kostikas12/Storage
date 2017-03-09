namespace Cards
{
    partial class DialogDelete
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
            this.btYes = new System.Windows.Forms.Button();
            this.btNo = new System.Windows.Forms.Button();
            this.lbtext = new System.Windows.Forms.Label();
            this.tbDeckName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btYes
            // 
            this.btYes.BackColor = System.Drawing.Color.Linen;
            this.btYes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btYes.Location = new System.Drawing.Point(189, 111);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(105, 27);
            this.btYes.TabIndex = 2;
            this.btYes.Text = "Да, удалить";
            this.btYes.UseVisualStyleBackColor = false;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Linen;
            this.btNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNo.Location = new System.Drawing.Point(38, 111);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(105, 27);
            this.btNo.TabIndex = 3;
            this.btNo.Text = "Нет";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.Location = new System.Drawing.Point(117, 33);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(98, 13);
            this.lbtext.TabIndex = 4;
            this.lbtext.Text = "Удаление колоды";
            // 
            // tbDeckName
            // 
            this.tbDeckName.Location = new System.Drawing.Point(89, 49);
            this.tbDeckName.Name = "tbDeckName";
            this.tbDeckName.Size = new System.Drawing.Size(160, 20);
            this.tbDeckName.TabIndex = 5;
            // 
            // DialogDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(333, 150);
            this.Controls.Add(this.tbDeckName);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btYes);
            this.Name = "DialogDelete";
            this.Text = "Удаление элемента";
            this.Load += new System.EventHandler(this.DialogDeleteDeck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.TextBox tbDeckName;

    }
}