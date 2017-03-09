namespace Cards
{
    partial class MainControl
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
            this.components = new System.ComponentModel.Container();
            this.btNewDeck = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lbDecks = new System.Windows.Forms.Label();
            this.lbMainPage = new System.Windows.Forms.Label();
            this.tbExit = new System.Windows.Forms.Button();
            this.btAddCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbCardName = new System.Windows.Forms.TextBox();
            this.lbCardImage = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbListView = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btNewDeck
            // 
            this.btNewDeck.BackColor = System.Drawing.Color.Linen;
            this.btNewDeck.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btNewDeck.Location = new System.Drawing.Point(44, 322);
            this.btNewDeck.Name = "btNewDeck";
            this.btNewDeck.Size = new System.Drawing.Size(105, 27);
            this.btNewDeck.TabIndex = 0;
            this.btNewDeck.Text = "Новая колода";
            this.btNewDeck.UseVisualStyleBackColor = false;
            this.btNewDeck.Click += new System.EventHandler(this.btNewDeck_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(29, 65);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(137, 210);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lbDecks
            // 
            this.lbDecks.AutoSize = true;
            this.lbDecks.Location = new System.Drawing.Point(45, 49);
            this.lbDecks.Name = "lbDecks";
            this.lbDecks.Size = new System.Drawing.Size(101, 13);
            this.lbDecks.TabIndex = 2;
            this.lbDecks.Text = "Колоды с картами";
            // 
            // lbMainPage
            // 
            this.lbMainPage.AutoSize = true;
            this.lbMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMainPage.Location = new System.Drawing.Point(224, 13);
            this.lbMainPage.Name = "lbMainPage";
            this.lbMainPage.Size = new System.Drawing.Size(143, 16);
            this.lbMainPage.TabIndex = 3;
            this.lbMainPage.Text = "Главная страница";
            // 
            // tbExit
            // 
            this.tbExit.BackColor = System.Drawing.Color.Linen;
            this.tbExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExit.Location = new System.Drawing.Point(423, 322);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(105, 27);
            this.tbExit.TabIndex = 4;
            this.tbExit.Text = "Выход";
            this.tbExit.UseVisualStyleBackColor = false;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // btAddCard
            // 
            this.btAddCard.BackColor = System.Drawing.Color.Linen;
            this.btAddCard.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddCard.Location = new System.Drawing.Point(237, 322);
            this.btAddCard.Name = "btAddCard";
            this.btAddCard.Size = new System.Drawing.Size(105, 27);
            this.btAddCard.TabIndex = 5;
            this.btAddCard.Text = "Добавить карты";
            this.btAddCard.UseVisualStyleBackColor = false;
            this.btAddCard.Click += new System.EventHandler(this.btAddCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(393, 65);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(160, 210);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(160, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 210);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // tbCardName
            // 
            this.tbCardName.Location = new System.Drawing.Point(393, 275);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(160, 20);
            this.tbCardName.TabIndex = 17;
            this.tbCardName.TextChanged += new System.EventHandler(this.tbCardName_TextChanged);
            // 
            // lbCardImage
            // 
            this.lbCardImage.AutoSize = true;
            this.lbCardImage.Location = new System.Drawing.Point(420, 49);
            this.lbCardImage.Name = "lbCardImage";
            this.lbCardImage.Size = new System.Drawing.Size(117, 13);
            this.lbCardImage.TabIndex = 18;
            this.lbCardImage.Text = "Карта для выделения";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(195, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(172, 210);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbListView
            // 
            this.lbListView.AutoSize = true;
            this.lbListView.Location = new System.Drawing.Point(224, 49);
            this.lbListView.Name = "lbListView";
            this.lbListView.Size = new System.Drawing.Size(113, 13);
            this.lbListView.TabIndex = 20;
            this.lbListView.Text = "Содержимое колоды";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(29, 275);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(137, 20);
            this.tbType.TabIndex = 21;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Linen;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDelete.Location = new System.Drawing.Point(237, 281);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(105, 27);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lbListView);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbCardImage);
            this.Controls.Add(this.tbCardName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddCard);
            this.Controls.Add(this.tbExit);
            this.Controls.Add(this.lbMainPage);
            this.Controls.Add(this.lbDecks);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btNewDeck);
            this.MaximumSize = new System.Drawing.Size(584, 362);
            this.MinimumSize = new System.Drawing.Size(584, 362);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(584, 362);
            this.Load += new System.EventHandler(this.MainControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewDeck;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lbDecks;
        private System.Windows.Forms.Label lbMainPage;
        private System.Windows.Forms.Button tbExit;
        private System.Windows.Forms.Button btAddCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbCardName;
        private System.Windows.Forms.Label lbCardImage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbListView;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Timer timer1;
    }
}
