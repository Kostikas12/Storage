namespace Cards
{
    partial class AddCardControl
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
            this.lbAddCard = new System.Windows.Forms.Label();
            this.lbDeckName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btBack = new System.Windows.Forms.Button();
            this.lbListImages = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.btUpdateList = new System.Windows.Forms.Button();
            this.tbTwo = new System.Windows.Forms.TextBox();
            this.lbTwo = new System.Windows.Forms.Label();
            this.tbOne = new System.Windows.Forms.TextBox();
            this.lbOne = new System.Windows.Forms.Label();
            this.btAddCard = new System.Windows.Forms.Button();
            this.tbCardName = new System.Windows.Forms.TextBox();
            this.lbCardName = new System.Windows.Forms.Label();
            this.lstbValueParams = new System.Windows.Forms.ListBox();
            this.lbListValues = new System.Windows.Forms.Label();
            this.lbNumParams = new System.Windows.Forms.Label();
            this.btSaveValue = new System.Windows.Forms.Button();
            this.lbMess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddCard
            // 
            this.lbAddCard.AutoSize = true;
            this.lbAddCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddCard.Location = new System.Drawing.Point(21, 11);
            this.lbAddCard.Name = "lbAddCard";
            this.lbAddCard.Size = new System.Drawing.Size(215, 16);
            this.lbAddCard.TabIndex = 9;
            this.lbAddCard.Text = "Добавление карт в колоду: ";
            // 
            // lbDeckName
            // 
            this.lbDeckName.AutoSize = true;
            this.lbDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDeckName.Location = new System.Drawing.Point(242, 11);
            this.lbDeckName.Name = "lbDeckName";
            this.lbDeckName.Size = new System.Drawing.Size(15, 16);
            this.lbDeckName.TabIndex = 10;
            this.lbDeckName.Text = "x";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 212);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(185, 73);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(160, 210);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(160, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 210);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Linen;
            this.btBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(46, 313);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(105, 27);
            this.btBack.TabIndex = 13;
            this.btBack.Text = "Назад к меню";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbListImages
            // 
            this.lbListImages.AutoSize = true;
            this.lbListImages.Location = new System.Drawing.Point(26, 57);
            this.lbListImages.Name = "lbListImages";
            this.lbListImages.Size = new System.Drawing.Size(136, 13);
            this.lbListImages.TabIndex = 14;
            this.lbListImages.Text = "Доступные рубашки карт";
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Location = new System.Drawing.Point(243, 57);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(37, 13);
            this.lbImage.TabIndex = 15;
            this.lbImage.Text = "Карта";
            // 
            // btUpdateList
            // 
            this.btUpdateList.BackColor = System.Drawing.Color.Linen;
            this.btUpdateList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btUpdateList.Location = new System.Drawing.Point(216, 313);
            this.btUpdateList.Name = "btUpdateList";
            this.btUpdateList.Size = new System.Drawing.Size(105, 27);
            this.btUpdateList.TabIndex = 16;
            this.btUpdateList.Text = "Очистить";
            this.btUpdateList.UseVisualStyleBackColor = false;
            this.btUpdateList.Click += new System.EventHandler(this.btUpdateList_Click);
            // 
            // tbTwo
            // 
            this.tbTwo.Location = new System.Drawing.Point(458, 125);
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.Size = new System.Drawing.Size(110, 20);
            this.tbTwo.TabIndex = 20;
            this.tbTwo.TextChanged += new System.EventHandler(this.tbTwo_TextChanged);
            // 
            // lbTwo
            // 
            this.lbTwo.AutoSize = true;
            this.lbTwo.Location = new System.Drawing.Point(351, 128);
            this.lbTwo.Name = "lbTwo";
            this.lbTwo.Size = new System.Drawing.Size(58, 13);
            this.lbTwo.TabIndex = 19;
            this.lbTwo.Text = "Значение:";
            // 
            // tbOne
            // 
            this.tbOne.Location = new System.Drawing.Point(458, 99);
            this.tbOne.Name = "tbOne";
            this.tbOne.Size = new System.Drawing.Size(110, 20);
            this.tbOne.TabIndex = 18;
            this.tbOne.TextChanged += new System.EventHandler(this.tbOne_TextChanged);
            // 
            // lbOne
            // 
            this.lbOne.AutoSize = true;
            this.lbOne.Location = new System.Drawing.Point(351, 102);
            this.lbOne.Name = "lbOne";
            this.lbOne.Size = new System.Drawing.Size(99, 13);
            this.lbOne.TabIndex = 17;
            this.lbOne.Text = "Имя параметра 1:";
            // 
            // btAddCard
            // 
            this.btAddCard.BackColor = System.Drawing.Color.Linen;
            this.btAddCard.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddCard.Location = new System.Drawing.Point(405, 313);
            this.btAddCard.Name = "btAddCard";
            this.btAddCard.Size = new System.Drawing.Size(105, 27);
            this.btAddCard.TabIndex = 23;
            this.btAddCard.Text = "Добавить карту";
            this.btAddCard.UseVisualStyleBackColor = false;
            this.btAddCard.Click += new System.EventHandler(this.btAddCard_Click);
            // 
            // tbCardName
            // 
            this.tbCardName.Location = new System.Drawing.Point(458, 73);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(110, 20);
            this.tbCardName.TabIndex = 25;
            this.tbCardName.TextChanged += new System.EventHandler(this.tbCardName_TextChanged);
            // 
            // lbCardName
            // 
            this.lbCardName.AutoSize = true;
            this.lbCardName.Location = new System.Drawing.Point(351, 76);
            this.lbCardName.Name = "lbCardName";
            this.lbCardName.Size = new System.Drawing.Size(97, 13);
            this.lbCardName.TabIndex = 24;
            this.lbCardName.Text = "Название карты: ";
            // 
            // lstbValueParams
            // 
            this.lstbValueParams.FormattingEnabled = true;
            this.lstbValueParams.Location = new System.Drawing.Point(354, 201);
            this.lstbValueParams.Name = "lstbValueParams";
            this.lstbValueParams.Size = new System.Drawing.Size(205, 82);
            this.lstbValueParams.TabIndex = 26;
            this.lstbValueParams.SelectedIndexChanged += new System.EventHandler(this.lstbValueParams_SelectedIndexChanged);
            // 
            // lbListValues
            // 
            this.lbListValues.AutoSize = true;
            this.lbListValues.Location = new System.Drawing.Point(351, 185);
            this.lbListValues.Name = "lbListValues";
            this.lbListValues.Size = new System.Drawing.Size(119, 13);
            this.lbListValues.TabIndex = 27;
            this.lbListValues.Text = "Значения параметров";
            // 
            // lbNumParams
            // 
            this.lbNumParams.AutoSize = true;
            this.lbNumParams.Location = new System.Drawing.Point(351, 48);
            this.lbNumParams.Name = "lbNumParams";
            this.lbNumParams.Size = new System.Drawing.Size(113, 13);
            this.lbNumParams.TabIndex = 28;
            this.lbNumParams.Text = "Всего параметров: 0";
            // 
            // btSaveValue
            // 
            this.btSaveValue.BackColor = System.Drawing.Color.Linen;
            this.btSaveValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSaveValue.Location = new System.Drawing.Point(463, 151);
            this.btSaveValue.Name = "btSaveValue";
            this.btSaveValue.Size = new System.Drawing.Size(105, 27);
            this.btSaveValue.TabIndex = 29;
            this.btSaveValue.Text = "Сохранить";
            this.btSaveValue.UseVisualStyleBackColor = false;
            this.btSaveValue.Click += new System.EventHandler(this.btSaveValue_Click);
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMess.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMess.Location = new System.Drawing.Point(429, 11);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(141, 15);
            this.lbMess.TabIndex = 30;
            this.lbMess.Text = "КАРТА НЕ ВЫБРАНА";
            // 
            // AddCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.btSaveValue);
            this.Controls.Add(this.lbNumParams);
            this.Controls.Add(this.lbListValues);
            this.Controls.Add(this.lstbValueParams);
            this.Controls.Add(this.tbCardName);
            this.Controls.Add(this.lbCardName);
            this.Controls.Add(this.btAddCard);
            this.Controls.Add(this.tbTwo);
            this.Controls.Add(this.lbTwo);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.lbOne);
            this.Controls.Add(this.btUpdateList);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.lbListImages);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbDeckName);
            this.Controls.Add(this.lbAddCard);
            this.MaximumSize = new System.Drawing.Size(584, 362);
            this.MinimumSize = new System.Drawing.Size(584, 362);
            this.Name = "AddCardControl";
            this.Size = new System.Drawing.Size(584, 362);
            this.Load += new System.EventHandler(this.AddCardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddCard;
        private System.Windows.Forms.Label lbDeckName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbListImages;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.Button btUpdateList;
        private System.Windows.Forms.TextBox tbTwo;
        private System.Windows.Forms.Label lbTwo;
        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.Label lbOne;
        private System.Windows.Forms.Button btAddCard;
        private System.Windows.Forms.TextBox tbCardName;
        private System.Windows.Forms.Label lbCardName;
        private System.Windows.Forms.ListBox lstbValueParams;
        private System.Windows.Forms.Label lbListValues;
        private System.Windows.Forms.Label lbNumParams;
        private System.Windows.Forms.Button btSaveValue;
        private System.Windows.Forms.Label lbMess;
    }
}
