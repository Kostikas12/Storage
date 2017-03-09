namespace Cards
{
    partial class AddDeckControl
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
            this.btCreate = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbNewDeck = new System.Windows.Forms.Label();
            this.tbOne = new System.Windows.Forms.TextBox();
            this.lbOne = new System.Windows.Forms.Label();
            this.tbNumParams = new System.Windows.Forms.TextBox();
            this.lbNumParams = new System.Windows.Forms.Label();
            this.btSaveParam = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbListParams = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.rbNewType = new System.Windows.Forms.RadioButton();
            this.rbExistType = new System.Windows.Forms.RadioButton();
            this.lstbExistsTypes = new System.Windows.Forms.ListBox();
            this.lbNoTypes = new System.Windows.Forms.Label();
            this.lbMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.Linen;
            this.btCreate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreate.Location = new System.Drawing.Point(390, 322);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(105, 27);
            this.btCreate.TabIndex = 1;
            this.btCreate.Text = "Создать колоду";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.bt_Click);
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.Linen;
            this.btClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClear.Location = new System.Drawing.Point(230, 322);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(105, 27);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Очистить";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Linen;
            this.btBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(73, 322);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(105, 27);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "Назад к меню";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(163, 61);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Название колоды: ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(282, 58);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 5;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lbNewDeck
            // 
            this.lbNewDeck.AutoSize = true;
            this.lbNewDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewDeck.Location = new System.Drawing.Point(209, 9);
            this.lbNewDeck.Name = "lbNewDeck";
            this.lbNewDeck.Size = new System.Drawing.Size(188, 16);
            this.lbNewDeck.TabIndex = 8;
            this.lbNewDeck.Text = "Создание новой колоды";
            // 
            // tbOne
            // 
            this.tbOne.Location = new System.Drawing.Point(162, 172);
            this.tbOne.Name = "tbOne";
            this.tbOne.Size = new System.Drawing.Size(170, 20);
            this.tbOne.TabIndex = 10;
            this.tbOne.TextChanged += new System.EventHandler(this.tbOne_TextChanged);
            // 
            // lbOne
            // 
            this.lbOne.AutoSize = true;
            this.lbOne.Location = new System.Drawing.Point(21, 175);
            this.lbOne.Name = "lbOne";
            this.lbOne.Size = new System.Drawing.Size(127, 13);
            this.lbOne.TabIndex = 9;
            this.lbOne.Text = "Название параметра 1:";
            // 
            // tbNumParams
            // 
            this.tbNumParams.Location = new System.Drawing.Point(162, 146);
            this.tbNumParams.Name = "tbNumParams";
            this.tbNumParams.Size = new System.Drawing.Size(170, 20);
            this.tbNumParams.TabIndex = 12;
            this.tbNumParams.TextChanged += new System.EventHandler(this.tbNumParams_TextChanged);
            // 
            // lbNumParams
            // 
            this.lbNumParams.AutoSize = true;
            this.lbNumParams.Location = new System.Drawing.Point(21, 149);
            this.lbNumParams.Name = "lbNumParams";
            this.lbNumParams.Size = new System.Drawing.Size(108, 13);
            this.lbNumParams.TabIndex = 11;
            this.lbNumParams.Text = "Кол-во параметров:";
            // 
            // btSaveParam
            // 
            this.btSaveParam.BackColor = System.Drawing.Color.Linen;
            this.btSaveParam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSaveParam.Location = new System.Drawing.Point(24, 191);
            this.btSaveParam.Name = "btSaveParam";
            this.btSaveParam.Size = new System.Drawing.Size(105, 27);
            this.btSaveParam.TabIndex = 13;
            this.btSaveParam.Text = "Сохранить";
            this.btSaveParam.UseVisualStyleBackColor = false;
            this.btSaveParam.Click += new System.EventHandler(this.btSaveParam_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(162, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 82);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbListParams
            // 
            this.lbListParams.AutoSize = true;
            this.lbListParams.Location = new System.Drawing.Point(215, 211);
            this.lbListParams.Name = "lbListParams";
            this.lbListParams.Size = new System.Drawing.Size(147, 13);
            this.lbListParams.TabIndex = 15;
            this.lbListParams.Text = "Названия параметров карт";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(162, 120);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(170, 20);
            this.tbType.TabIndex = 17;
            this.tbType.TextChanged += new System.EventHandler(this.tbType_TextChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(21, 123);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(73, 13);
            this.lbType.TabIndex = 16;
            this.lbType.Text = "Вид колоды: ";
            // 
            // rbNewType
            // 
            this.rbNewType.AutoSize = true;
            this.rbNewType.Location = new System.Drawing.Point(162, 84);
            this.rbNewType.Name = "rbNewType";
            this.rbNewType.Size = new System.Drawing.Size(123, 17);
            this.rbNewType.TabIndex = 18;
            this.rbNewType.TabStop = true;
            this.rbNewType.Text = "Создать новый вид";
            this.rbNewType.UseVisualStyleBackColor = true;
            this.rbNewType.CheckedChanged += new System.EventHandler(this.rbNewType_CheckedChanged);
            // 
            // rbExistType
            // 
            this.rbExistType.AutoSize = true;
            this.rbExistType.Location = new System.Drawing.Point(377, 84);
            this.rbExistType.Name = "rbExistType";
            this.rbExistType.Size = new System.Drawing.Size(170, 17);
            this.rbExistType.TabIndex = 19;
            this.rbExistType.TabStop = true;
            this.rbExistType.Text = "Выбрать существующий вид";
            this.rbExistType.UseVisualStyleBackColor = true;
            this.rbExistType.CheckedChanged += new System.EventHandler(this.rbExistType_CheckedChanged);
            // 
            // lstbExistsTypes
            // 
            this.lstbExistsTypes.FormattingEnabled = true;
            this.lstbExistsTypes.Location = new System.Drawing.Point(377, 120);
            this.lstbExistsTypes.Name = "lstbExistsTypes";
            this.lstbExistsTypes.Size = new System.Drawing.Size(182, 69);
            this.lstbExistsTypes.TabIndex = 20;
            this.lstbExistsTypes.SelectedIndexChanged += new System.EventHandler(this.lstbExistsTypes_SelectedIndexChanged);
            // 
            // lbNoTypes
            // 
            this.lbNoTypes.AutoSize = true;
            this.lbNoTypes.Location = new System.Drawing.Point(413, 104);
            this.lbNoTypes.Name = "lbNoTypes";
            this.lbNoTypes.Size = new System.Drawing.Size(99, 13);
            this.lbNoTypes.TabIndex = 21;
            this.lbNoTypes.Text = "Виды не найдены!";
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMess.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMess.Location = new System.Drawing.Point(176, 40);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(267, 15);
            this.lbMess.TabIndex = 22;
            this.lbMess.Text = "ЗАПОЛНИТЕ ВСЕ ПОЛЯ И ПАРАМЕТРЫ";
            // 
            // AddDeckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.lbNoTypes);
            this.Controls.Add(this.lstbExistsTypes);
            this.Controls.Add(this.rbExistType);
            this.Controls.Add(this.rbNewType);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbListParams);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btSaveParam);
            this.Controls.Add(this.tbNumParams);
            this.Controls.Add(this.lbNumParams);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.lbOne);
            this.Controls.Add(this.lbNewDeck);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCreate);
            this.MaximumSize = new System.Drawing.Size(584, 362);
            this.MinimumSize = new System.Drawing.Size(584, 362);
            this.Name = "AddDeckControl";
            this.Size = new System.Drawing.Size(584, 362);
            this.Load += new System.EventHandler(this.AddDeckControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbNewDeck;
        private System.Windows.Forms.TextBox tbOne;
        private System.Windows.Forms.Label lbOne;
        private System.Windows.Forms.TextBox tbNumParams;
        private System.Windows.Forms.Label lbNumParams;
        private System.Windows.Forms.Button btSaveParam;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbListParams;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.RadioButton rbNewType;
        private System.Windows.Forms.RadioButton rbExistType;
        private System.Windows.Forms.ListBox lstbExistsTypes;
        private System.Windows.Forms.Label lbNoTypes;
        private System.Windows.Forms.Label lbMess;

    }
}
