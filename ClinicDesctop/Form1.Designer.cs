namespace ClinicDesctop
{
    partial class VeterinaryClinic
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
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            columnHeaderDoc = new ColumnHeader();
            columnHeaderBirthday = new ColumnHeader();
            btnGetAllClient = new Button();
            label1 = new Label();
            sNameTextBox = new RichTextBox();
            fNameTextBox = new RichTextBox();
            pNameTextBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCreate = new Button();
            label5 = new Label();
            docTextBox = new RichTextBox();
            label6 = new Label();
            BirthdayTextBox = new RichTextBox();
            btnUpdate = new Button();
            btnDell = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            listView1 = new ListView();
            columnHeaderIdPet = new ColumnHeader();
            columnHeaderIdClient = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderBirthdaiPet = new ColumnHeader();
            btnDellPet = new Button();
            clientIDTextBox = new RichTextBox();
            btnUpdatePet = new Button();
            btnCreatePet = new Button();
            label9 = new Label();
            GetAllPet = new Button();
            label10 = new Label();
            birthdayPetTextBox = new RichTextBox();
            nameTextBox = new RichTextBox();
            panel3 = new Panel();
            label15 = new Label();
            descBoxConsul = new RichTextBox();
            label11 = new Label();
            label12 = new Label();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeaderclID = new ColumnHeader();
            columnHeaderpID = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            columnHeaderDesc = new ColumnHeader();
            btnDellCons = new Button();
            clientIdBoxConsul = new RichTextBox();
            btnUpdateCons = new Button();
            btnCreateCons = new Button();
            label13 = new Label();
            button4 = new Button();
            label14 = new Label();
            dateBoxConsul = new RichTextBox();
            petIdBoxConsul = new RichTextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic, columnHeaderDoc, columnHeaderBirthday });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(13, 443);
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(421, 99);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            listViewClients.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            columnHeaderId.Width = 30;
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Surname";
            columnHeaderSurName.Width = 80;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Firstname";
            columnHeaderFirstName.Width = 80;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Patronymic";
            columnHeaderPatronymic.Width = 80;
            // 
            // columnHeaderDoc
            // 
            columnHeaderDoc.Text = "Document";
            columnHeaderDoc.Width = 80;
            // 
            // columnHeaderBirthday
            // 
            columnHeaderBirthday.Text = "Birthday";
            // 
            // btnGetAllClient
            // 
            btnGetAllClient.Location = new Point(94, 397);
            btnGetAllClient.Name = "btnGetAllClient";
            btnGetAllClient.Size = new Size(75, 23);
            btnGetAllClient.TabIndex = 2;
            btnGetAllClient.Text = "Get All Client";
            btnGetAllClient.UseVisualStyleBackColor = true;
            btnGetAllClient.Click += btnGetAllClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Clients";
            label1.Click += label1_Click;
            // 
            // sNameTextBox
            // 
            sNameTextBox.Location = new Point(13, 63);
            sNameTextBox.Name = "sNameTextBox";
            sNameTextBox.Size = new Size(156, 20);
            sNameTextBox.TabIndex = 4;
            sNameTextBox.Text = "";
            sNameTextBox.TextChanged += sNameTextBox_TextChanged;
            // 
            // fNameTextBox
            // 
            fNameTextBox.Location = new Point(13, 114);
            fNameTextBox.Name = "fNameTextBox";
            fNameTextBox.Size = new Size(156, 20);
            fNameTextBox.TabIndex = 5;
            fNameTextBox.Text = "";
            fNameTextBox.TextChanged += fNameTextBox_TextChanged;
            // 
            // pNameTextBox
            // 
            pNameTextBox.Location = new Point(13, 177);
            pNameTextBox.Name = "pNameTextBox";
            pNameTextBox.Size = new Size(156, 20);
            pNameTextBox.TabIndex = 6;
            pNameTextBox.Text = "";
            pNameTextBox.TextChanged += pNameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 45);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "SURNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 96);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "FIRSTNAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 159);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 9;
            label4.Text = "PATRONYMIC";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(13, 352);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 226);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "DOCUMENT";
            // 
            // docTextBox
            // 
            docTextBox.Location = new Point(13, 244);
            docTextBox.Name = "docTextBox";
            docTextBox.Size = new Size(156, 20);
            docTextBox.TabIndex = 11;
            docTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 294);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 14;
            label6.Text = "BIRTHDAY";
            // 
            // BirthdayTextBox
            // 
            BirthdayTextBox.Location = new Point(13, 312);
            BirthdayTextBox.Name = "BirthdayTextBox";
            BirthdayTextBox.Size = new Size(156, 20);
            BirthdayTextBox.TabIndex = 13;
            BirthdayTextBox.Text = "";
            BirthdayTextBox.TextChanged += BirthdayTextBox_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(94, 352);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDell
            // 
            btnDell.Location = new Point(13, 397);
            btnDell.Name = "btnDell";
            btnDell.Size = new Size(75, 23);
            btnDell.TabIndex = 16;
            btnDell.Text = "DELL";
            btnDell.UseVisualStyleBackColor = true;
            btnDell.Click += btnDell_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listViewClients);
            panel2.Controls.Add(btnDell);
            panel2.Controls.Add(sNameTextBox);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnCreate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnGetAllClient);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(BirthdayTextBox);
            panel2.Controls.Add(fNameTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(docTextBox);
            panel2.Controls.Add(pNameTextBox);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 562);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(btnDellPet);
            panel1.Controls.Add(clientIDTextBox);
            panel1.Controls.Add(btnUpdatePet);
            panel1.Controls.Add(btnCreatePet);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(GetAllPet);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(birthdayPetTextBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Location = new Point(473, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 562);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 3;
            label7.Text = "Pets";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 45);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "CLIENT ID";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderIdPet, columnHeaderIdClient, columnHeaderName, columnHeaderBirthdaiPet });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(13, 443);
            listView1.Name = "listView1";
            listView1.Size = new Size(226, 99);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // columnHeaderIdPet
            // 
            columnHeaderIdPet.Text = "#";
            columnHeaderIdPet.Width = 30;
            // 
            // columnHeaderIdClient
            // 
            columnHeaderIdClient.Text = "Client ID";
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            // 
            // columnHeaderBirthdaiPet
            // 
            columnHeaderBirthdaiPet.Text = "Birthday";
            // 
            // btnDellPet
            // 
            btnDellPet.Location = new Point(13, 397);
            btnDellPet.Name = "btnDellPet";
            btnDellPet.Size = new Size(75, 23);
            btnDellPet.TabIndex = 16;
            btnDellPet.Text = "DELL";
            btnDellPet.UseVisualStyleBackColor = true;
            btnDellPet.Click += btnDellPet_Click;
            // 
            // clientIDTextBox
            // 
            clientIDTextBox.Location = new Point(13, 63);
            clientIDTextBox.Name = "clientIDTextBox";
            clientIDTextBox.Size = new Size(156, 20);
            clientIDTextBox.TabIndex = 4;
            clientIDTextBox.Text = "";
            // 
            // btnUpdatePet
            // 
            btnUpdatePet.Location = new Point(94, 352);
            btnUpdatePet.Name = "btnUpdatePet";
            btnUpdatePet.Size = new Size(75, 23);
            btnUpdatePet.TabIndex = 15;
            btnUpdatePet.Text = "Update";
            btnUpdatePet.UseVisualStyleBackColor = true;
            btnUpdatePet.Click += btnUpdatePet_Click;
            // 
            // btnCreatePet
            // 
            btnCreatePet.Location = new Point(13, 352);
            btnCreatePet.Name = "btnCreatePet";
            btnCreatePet.Size = new Size(75, 23);
            btnCreatePet.TabIndex = 10;
            btnCreatePet.Text = "Create";
            btnCreatePet.UseVisualStyleBackColor = true;
            btnCreatePet.Click += btnCreatePet_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 96);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 8;
            label9.Text = "NAME";
            // 
            // GetAllPet
            // 
            GetAllPet.Location = new Point(94, 397);
            GetAllPet.Name = "GetAllPet";
            GetAllPet.Size = new Size(75, 23);
            GetAllPet.TabIndex = 2;
            GetAllPet.Text = "Get All Client";
            GetAllPet.UseVisualStyleBackColor = true;
            GetAllPet.Click += GetAllPet_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 150);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 14;
            label10.Text = "BIRTHDAY";
            // 
            // birthdayPetTextBox
            // 
            birthdayPetTextBox.Location = new Point(13, 168);
            birthdayPetTextBox.Name = "birthdayPetTextBox";
            birthdayPetTextBox.Size = new Size(156, 20);
            birthdayPetTextBox.TabIndex = 13;
            birthdayPetTextBox.Text = "";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(13, 114);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(156, 20);
            nameTextBox.TabIndex = 5;
            nameTextBox.Text = "";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label15);
            panel3.Controls.Add(descBoxConsul);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(listView2);
            panel3.Controls.Add(btnDellCons);
            panel3.Controls.Add(clientIdBoxConsul);
            panel3.Controls.Add(btnUpdateCons);
            panel3.Controls.Add(btnCreateCons);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(dateBoxConsul);
            panel3.Controls.Add(petIdBoxConsul);
            panel3.Location = new Point(777, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(330, 562);
            panel3.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 206);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 18;
            label15.Text = "DESCRIPTION";
            // 
            // descBoxConsul
            // 
            descBoxConsul.Location = new Point(13, 224);
            descBoxConsul.Name = "descBoxConsul";
            descBoxConsul.Size = new Size(156, 20);
            descBoxConsul.TabIndex = 17;
            descBoxConsul.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 11);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 3;
            label11.Text = "Consultations";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 45);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 7;
            label12.Text = "CLIENT ID";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeaderclID, columnHeaderpID, columnHeaderDate, columnHeaderDesc });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(13, 443);
            listView2.Name = "listView2";
            listView2.Size = new Size(310, 99);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            columnHeader1.Width = 30;
            // 
            // columnHeaderclID
            // 
            columnHeaderclID.Text = "Client ID";
            // 
            // columnHeaderpID
            // 
            columnHeaderpID.Text = "Pet ID";
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Consultation Date";
            // 
            // columnHeaderDesc
            // 
            columnHeaderDesc.Text = "Description";
            columnHeaderDesc.Width = 90;
            // 
            // btnDellCons
            // 
            btnDellCons.Location = new Point(13, 397);
            btnDellCons.Name = "btnDellCons";
            btnDellCons.Size = new Size(75, 23);
            btnDellCons.TabIndex = 16;
            btnDellCons.Text = "DELL";
            btnDellCons.UseVisualStyleBackColor = true;
            btnDellCons.Click += btnDellCons_Click;
            // 
            // clientIdBoxConsul
            // 
            clientIdBoxConsul.Location = new Point(13, 63);
            clientIdBoxConsul.Name = "clientIdBoxConsul";
            clientIdBoxConsul.Size = new Size(156, 20);
            clientIdBoxConsul.TabIndex = 4;
            clientIdBoxConsul.Text = "";
            // 
            // btnUpdateCons
            // 
            btnUpdateCons.Location = new Point(94, 352);
            btnUpdateCons.Name = "btnUpdateCons";
            btnUpdateCons.Size = new Size(75, 23);
            btnUpdateCons.TabIndex = 15;
            btnUpdateCons.Text = "Update";
            btnUpdateCons.UseVisualStyleBackColor = true;
            btnUpdateCons.Click += btnUpdateCons_Click;
            // 
            // btnCreateCons
            // 
            btnCreateCons.Location = new Point(13, 352);
            btnCreateCons.Name = "btnCreateCons";
            btnCreateCons.Size = new Size(75, 23);
            btnCreateCons.TabIndex = 10;
            btnCreateCons.Text = "Create";
            btnCreateCons.UseVisualStyleBackColor = true;
            btnCreateCons.Click += btnCreateCons_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 96);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 8;
            label13.Text = "PET ID";
            // 
            // button4
            // 
            button4.Location = new Point(94, 397);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 2;
            button4.Text = "Get All Client";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 150);
            label14.Name = "label14";
            label14.Size = new Size(121, 15);
            label14.TabIndex = 14;
            label14.Text = "CONSULTATION DATE";
            // 
            // dateBoxConsul
            // 
            dateBoxConsul.Location = new Point(13, 168);
            dateBoxConsul.Name = "dateBoxConsul";
            dateBoxConsul.Size = new Size(156, 20);
            dateBoxConsul.TabIndex = 13;
            dateBoxConsul.Text = "";
            // 
            // petIdBoxConsul
            // 
            petIdBoxConsul.Location = new Point(13, 114);
            petIdBoxConsul.Name = "petIdBoxConsul";
            petIdBoxConsul.Size = new Size(156, 20);
            petIdBoxConsul.TabIndex = 5;
            petIdBoxConsul.Text = "";
            // 
            // VeterinaryClinic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 586);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "VeterinaryClinic";
            Text = "Veterinary Clinic";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewClients;
        private Button btnGetAllClient;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private Label label1;
        private RichTextBox sNameTextBox;
        private RichTextBox fNameTextBox;
        private RichTextBox pNameTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCreate;
        private Label label5;
        private RichTextBox docTextBox;
        private Label label6;
        private RichTextBox BirthdayTextBox;
        private ColumnHeader columnHeaderDoc;
        private ColumnHeader columnHeaderBirthday;
        private Button btnUpdate;
        private Button btnDell;
        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Label label8;
        private ListView listView1;
        private ColumnHeader columnHeaderIdPet;
        private ColumnHeader columnHeaderBirthdaiPet;
        private Button btnDellPet;
        private RichTextBox clientIDTextBox;
        private Button btnUpdatePet;
        private Button btnCreatePet;
        private Label label9;
        private Button GetAllPet;
        private Label label10;
        private RichTextBox birthdayPetTextBox;
        private RichTextBox nameTextBox;
        private ColumnHeader columnHeaderIdClient;
        private ColumnHeader columnHeaderName;
        private Panel panel3;
        private Label label11;
        private Label label12;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeaderclID;
        private ColumnHeader columnHeaderpID;
        private ColumnHeader columnHeaderDate;
        private Button button1;
        private RichTextBox clientIdBoxConsul;
        private Button button2;
        private Button button3;
        private Label label13;
        private Button button4;
        private Label label14;
        private RichTextBox dateBoxConsul;
        private RichTextBox petIdBoxConsul;
        private Label label15;
        private RichTextBox descBoxConsul;
        private ColumnHeader columnHeaderDesc;
        private Button btnDellCons;
        private Button btnUpdateCons;
        private Button btnCreateCons;
    }
}