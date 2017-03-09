namespace Cards
{
    partial class CardViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btBack = new System.Windows.Forms.Button();
            this.lbCardImage = new System.Windows.Forms.Label();
            this.tbCardName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCardViewPage = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbParamValues = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Linen;
            this.btBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(248, 314);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(105, 27);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Назад к меню";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbCardImage
            // 
            this.lbCardImage.AutoSize = true;
            this.lbCardImage.Location = new System.Drawing.Point(138, 54);
            this.lbCardImage.Name = "lbCardImage";
            this.lbCardImage.Size = new System.Drawing.Size(37, 13);
            this.lbCardImage.TabIndex = 21;
            this.lbCardImage.Text = "Карта";
            // 
            // tbCardName
            // 
            this.tbCardName.Location = new System.Drawing.Point(73, 280);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(160, 20);
            this.tbCardName.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(73, 70);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(160, 210);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(160, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 210);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lbCardViewPage
            // 
            this.lbCardViewPage.AutoSize = true;
            this.lbCardViewPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCardViewPage.Location = new System.Drawing.Point(235, 20);
            this.lbCardViewPage.Name = "lbCardViewPage";
            this.lbCardViewPage.Size = new System.Drawing.Size(129, 16);
            this.lbCardViewPage.TabIndex = 22;
            this.lbCardViewPage.Text = "Просмотр карты";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(311, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 199);
            this.listBox1.TabIndex = 23;
            // 
            // lbParamValues
            // 
            this.lbParamValues.AutoSize = true;
            this.lbParamValues.Location = new System.Drawing.Point(366, 54);
            this.lbParamValues.Name = "lbParamValues";
            this.lbParamValues.Size = new System.Drawing.Size(114, 13);
            this.lbParamValues.TabIndex = 24;
            this.lbParamValues.Text = "Параметр - значение";
            // 
            // CardViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.lbParamValues);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbCardViewPage);
            this.Controls.Add(this.lbCardImage);
            this.Controls.Add(this.tbCardName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btBack);
            this.MaximumSize = new System.Drawing.Size(584, 362);
            this.MinimumSize = new System.Drawing.Size(584, 362);
            this.Name = "CardViewControl";
            this.Size = new System.Drawing.Size(584, 362);
            this.Load += new System.EventHandler(this.CardViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbCardImage;
        private System.Windows.Forms.TextBox tbCardName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCardViewPage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbParamValues;
    }
}
