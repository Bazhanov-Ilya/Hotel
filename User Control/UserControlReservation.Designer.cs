
namespace Hotel.User_Control
{
    partial class UserControlReservation
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxClientLN = new System.Windows.Forms.ComboBox();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.comboBoxClientFN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchRoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUapdateAndCancelReservation = new System.Windows.Forms.TabPage();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClientID1 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxRoomNo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxClientLN1 = new System.Windows.Forms.ComboBox();
            this.comboBoxClientFN1 = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageReservationHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewReservationHistory = new System.Windows.Forms.DataGridView();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageUapdateAndCancelReservation.SuspendLayout();
            this.tabPageReservationHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUapdateAndCancelReservation);
            this.tabControlReservation.Controls.Add(this.tabPageReservationHistory);
            this.tabControlReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlReservation.Location = new System.Drawing.Point(32, 24);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1039, 415);
            this.tabControlReservation.TabIndex = 0;
            this.tabControlReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.BackColor = System.Drawing.Color.White;
            this.tabPageAddReservation.Controls.Add(this.labelPrice);
            this.tabPageAddReservation.Controls.Add(this.label21);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.label12);
            this.tabPageAddReservation.Controls.Add(this.label11);
            this.tabPageAddReservation.Controls.Add(this.comboBoxClientLN);
            this.tabPageAddReservation.Controls.Add(this.comboBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.comboBoxClientFN);
            this.tabPageAddReservation.Controls.Add(this.label9);
            this.tabPageAddReservation.Controls.Add(this.label19);
            this.tabPageAddReservation.Controls.Add(this.label18);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomNo);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomType);
            this.tabPageAddReservation.Controls.Add(this.buttonAdd);
            this.tabPageAddReservation.Controls.Add(this.label10);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1031, 386);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            this.tabPageAddReservation.Enter += new System.EventHandler(this.tabPageAddReservation_Enter);
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(593, 280);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(19, 20);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "?";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(535, 280);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "Price";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(538, 69);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(295, 22);
            this.dateTimePickerOut.TabIndex = 14;
            this.dateTimePickerOut.ValueChanged += new System.EventHandler(this.dateTimePickerOut_ValueChanged);
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Enabled = false;
            this.dateTimePickerIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerIn.Location = new System.Drawing.Point(154, 69);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(295, 22);
            this.dateTimePickerIn.TabIndex = 13;
            this.dateTimePickerIn.CloseUp += new System.EventHandler(this.dateTimePickerIn_ValueChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(535, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Out";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(150, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "In";
            // 
            // comboBoxClientLN
            // 
            this.comboBoxClientLN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClientLN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientLN.FormattingEnabled = true;
            this.comboBoxClientLN.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxClientLN.Location = new System.Drawing.Point(538, 211);
            this.comboBoxClientLN.Name = "comboBoxClientLN";
            this.comboBoxClientLN.Size = new System.Drawing.Size(295, 24);
            this.comboBoxClientLN.TabIndex = 9;
            this.comboBoxClientLN.SelectedValueChanged += new System.EventHandler(this.comboBoxClientLN_SelectedValueChanged);
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxClientID.Location = new System.Drawing.Point(155, 280);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(295, 24);
            this.comboBoxClientID.TabIndex = 10;
            // 
            // comboBoxClientFN
            // 
            this.comboBoxClientFN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClientFN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientFN.FormattingEnabled = true;
            this.comboBoxClientFN.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxClientFN.Location = new System.Drawing.Point(153, 211);
            this.comboBoxClientFN.Name = "comboBoxClientFN";
            this.comboBoxClientFN.Size = new System.Drawing.Size(295, 24);
            this.comboBoxClientFN.TabIndex = 10;
            this.comboBoxClientFN.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientFN_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(535, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lastname";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(152, 249);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "Client ID";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(150, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 8;
            this.label18.Text = "Firstname";
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Location = new System.Drawing.Point(539, 133);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(295, 24);
            this.comboBoxRoomNo.TabIndex = 2;
            this.comboBoxRoomNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomNo_SelectedIndexChanged);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(154, 133);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(295, 24);
            this.comboBoxRoomType.TabIndex = 1;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(154, 321);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 36);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(535, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Room No.";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Reservation";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.BackColor = System.Drawing.Color.White;
            this.tabPageSearchReservation.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchReservation.Controls.Add(this.textBoxSearchRoomNo);
            this.tabPageSearchReservation.Controls.Add(this.label5);
            this.tabPageSearchReservation.Controls.Add(this.label4);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(1031, 386);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Search Reservation";
            this.tabPageSearchReservation.Enter += new System.EventHandler(this.tabPageSearchReservation_Enter);
            this.tabPageSearchReservation.Leave += new System.EventHandler(this.tabPageSearchReservation_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column11,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column12});
            this.dataGridViewReservation.Location = new System.Drawing.Point(26, 111);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.Size = new System.Drawing.Size(980, 246);
            this.dataGridViewReservation.TabIndex = 2;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Reservation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Reservation_Room_Type";
            this.Column2.HeaderText = "Room Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Reservation_Room_Number";
            this.Column3.HeaderText = "Room No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "Client_FirstName";
            this.Column11.HeaderText = "Firstname";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Client_LastName";
            this.Column4.HeaderText = "Lastname";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Reservation_In";
            this.Column5.HeaderText = "In";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Reservation_Out";
            this.Column6.HeaderText = "Out";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Reservation_Price";
            this.Column12.HeaderText = "Price";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // textBoxSearchRoomNo
            // 
            this.textBoxSearchRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchRoomNo.Location = new System.Drawing.Point(245, 62);
            this.textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            this.textBoxSearchRoomNo.Size = new System.Drawing.Size(296, 22);
            this.textBoxSearchRoomNo.TabIndex = 1;
            this.textBoxSearchRoomNo.TextChanged += new System.EventHandler(this.textBoxSearchClientID_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(242, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Room No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(6, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search Reservation";
            // 
            // tabPageUapdateAndCancelReservation
            // 
            this.tabPageUapdateAndCancelReservation.BackColor = System.Drawing.Color.White;
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.labelPrice1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label24);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label6);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label7);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.comboBoxClientID1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label20);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.comboBoxRoomNo1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.comboBoxClientLN1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.comboBoxClientFN1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.comboBoxRoomType1);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label3);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label17);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label13);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label14);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.buttonCancel);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.buttonUpdate);
            this.tabPageUapdateAndCancelReservation.Controls.Add(this.label8);
            this.tabPageUapdateAndCancelReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUapdateAndCancelReservation.Name = "tabPageUapdateAndCancelReservation";
            this.tabPageUapdateAndCancelReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUapdateAndCancelReservation.Size = new System.Drawing.Size(1031, 386);
            this.tabPageUapdateAndCancelReservation.TabIndex = 2;
            this.tabPageUapdateAndCancelReservation.Text = "Uapdate and Cancel Reservation";
            this.tabPageUapdateAndCancelReservation.Enter += new System.EventHandler(this.tabPageUapdateAndCancelReservation_Enter);
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice1.Location = new System.Drawing.Point(616, 290);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(19, 20);
            this.labelPrice1.TabIndex = 17;
            this.labelPrice1.Text = "?";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(558, 290);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 20);
            this.label24.TabIndex = 18;
            this.label24.Text = "Price";
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Location = new System.Drawing.Point(562, 73);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(295, 22);
            this.dateTimePickerOut1.TabIndex = 16;
            this.dateTimePickerOut1.ValueChanged += new System.EventHandler(this.dateTimePickerOut1_ValueChanged);
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Enabled = false;
            this.dateTimePickerIn1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerIn1.Location = new System.Drawing.Point(178, 73);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(295, 22);
            this.dateTimePickerIn1.TabIndex = 15;
            this.dateTimePickerIn1.ValueChanged += new System.EventHandler(this.dateTimePickerIn1_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(559, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Out";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(174, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "In";
            // 
            // comboBoxClientID1
            // 
            this.comboBoxClientID1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClientID1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientID1.FormattingEnabled = true;
            this.comboBoxClientID1.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxClientID1.Location = new System.Drawing.Point(176, 290);
            this.comboBoxClientID1.Name = "comboBoxClientID1";
            this.comboBoxClientID1.Size = new System.Drawing.Size(295, 24);
            this.comboBoxClientID1.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(173, 259);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "Client ID";
            // 
            // comboBoxRoomNo1
            // 
            this.comboBoxRoomNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNo1.FormattingEnabled = true;
            this.comboBoxRoomNo1.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxRoomNo1.Location = new System.Drawing.Point(562, 147);
            this.comboBoxRoomNo1.Name = "comboBoxRoomNo1";
            this.comboBoxRoomNo1.Size = new System.Drawing.Size(295, 24);
            this.comboBoxRoomNo1.TabIndex = 2;
            this.comboBoxRoomNo1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxRoomNo1_SelectedIndexChanged);
            // 
            // comboBoxClientLN1
            // 
            this.comboBoxClientLN1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClientLN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientLN1.FormattingEnabled = true;
            this.comboBoxClientLN1.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxClientLN1.Location = new System.Drawing.Point(561, 227);
            this.comboBoxClientLN1.Name = "comboBoxClientLN1";
            this.comboBoxClientLN1.Size = new System.Drawing.Size(295, 24);
            this.comboBoxClientLN1.TabIndex = 1;
            this.comboBoxClientLN1.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientLN1_SelectedIndexChanged);
            // 
            // comboBoxClientFN1
            // 
            this.comboBoxClientFN1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClientFN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientFN1.FormattingEnabled = true;
            this.comboBoxClientFN1.Items.AddRange(new object[] {
            "Please select..."});
            this.comboBoxClientFN1.Location = new System.Drawing.Point(176, 227);
            this.comboBoxClientFN1.Name = "comboBoxClientFN1";
            this.comboBoxClientFN1.Size = new System.Drawing.Size(295, 24);
            this.comboBoxClientFN1.TabIndex = 1;
            this.comboBoxClientFN1.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientFN1_SelectedIndexChanged);
            // 
            // comboBoxRoomType1
            // 
            this.comboBoxRoomType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType1.FormattingEnabled = true;
            this.comboBoxRoomType1.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxRoomType1.Location = new System.Drawing.Point(177, 147);
            this.comboBoxRoomType1.Name = "comboBoxRoomType1";
            this.comboBoxRoomType1.Size = new System.Drawing.Size(295, 24);
            this.comboBoxRoomType1.TabIndex = 1;
            this.comboBoxRoomType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(558, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room No.";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(558, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Lastname";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(173, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Firstname";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(173, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Room Type";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(360, 329);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 36);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(186, 329);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(122, 36);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Update and Cancel Reservation";
            // 
            // tabPageReservationHistory
            // 
            this.tabPageReservationHistory.Controls.Add(this.dataGridViewReservationHistory);
            this.tabPageReservationHistory.Controls.Add(this.textBoxRoomNo);
            this.tabPageReservationHistory.Controls.Add(this.label15);
            this.tabPageReservationHistory.Controls.Add(this.label16);
            this.tabPageReservationHistory.Location = new System.Drawing.Point(4, 4);
            this.tabPageReservationHistory.Name = "tabPageReservationHistory";
            this.tabPageReservationHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReservationHistory.Size = new System.Drawing.Size(1031, 386);
            this.tabPageReservationHistory.TabIndex = 3;
            this.tabPageReservationHistory.Text = "History Reservation";
            this.tabPageReservationHistory.UseVisualStyleBackColor = true;
            this.tabPageReservationHistory.Enter += new System.EventHandler(this.tabPageReservationHistory_Enter);
            // 
            // dataGridViewReservationHistory
            // 
            this.dataGridViewReservationHistory.AllowUserToAddRows = false;
            this.dataGridViewReservationHistory.AllowUserToDeleteRows = false;
            this.dataGridViewReservationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservationHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column13});
            this.dataGridViewReservationHistory.Location = new System.Drawing.Point(35, 116);
            this.dataGridViewReservationHistory.Name = "dataGridViewReservationHistory";
            this.dataGridViewReservationHistory.ReadOnly = true;
            this.dataGridViewReservationHistory.Size = new System.Drawing.Size(980, 246);
            this.dataGridViewReservationHistory.TabIndex = 6;
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRoomNo.Location = new System.Drawing.Point(254, 67);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(296, 22);
            this.textBoxRoomNo.TabIndex = 5;
            this.textBoxRoomNo.TextChanged += new System.EventHandler(this.textBoxRoomNo_TextChanged);
            this.textBoxRoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoomNo_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(251, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Room No.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.label16.Location = new System.Drawing.Point(15, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Search Reservation";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reservation_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Client_FirstName";
            this.Column7.HeaderText = "FirstName";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "Client_LastName";
            this.Column8.HeaderText = "LastName";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "Client_Phone";
            this.Column9.HeaderText = "Phone";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "Client_Address";
            this.Column10.HeaderText = "Address";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Reservation_Room_Type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Reservation_Room_Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room No.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Reservation_In";
            this.dataGridViewTextBoxColumn5.HeaderText = "In";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reservation_Out";
            this.dataGridViewTextBoxColumn6.HeaderText = "Out";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Reservation_Price";
            this.Column13.HeaderText = "Price";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlReservation);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageUapdateAndCancelReservation.ResumeLayout(false);
            this.tabPageUapdateAndCancelReservation.PerformLayout();
            this.tabPageReservationHistory.ResumeLayout(false);
            this.tabPageReservationHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservationHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox textBoxSearchRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUapdateAndCancelReservation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxRoomNo1;
        private System.Windows.Forms.ComboBox comboBoxRoomType1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxClientFN1;
        private System.Windows.Forms.TabPage tabPageReservationHistory;
        private System.Windows.Forms.DataGridView dataGridViewReservationHistory;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxClientLN1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxClientLN;
        private System.Windows.Forms.ComboBox comboBoxClientFN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxClientID1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}
