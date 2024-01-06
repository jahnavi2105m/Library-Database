namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDisplayAdmin = new System.Windows.Forms.TextBox();
            this.textBoxDisplayUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDisplayUsers = new System.Windows.Forms.Button();
            this.buttonDisplayMostRead = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPasswordSU = new System.Windows.Forms.TextBox();
            this.textBoxUsernameSU = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonSubmitRating = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell Gothic Std Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ONLINE LIBRARY ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "BOOKS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(197, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(359, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(505, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Author:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxAuthor.Location = new System.Drawing.Point(547, 64);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuthor.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxTitle.Location = new System.Drawing.Point(389, 64);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxISBN.Location = new System.Drawing.Point(232, 64);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.textBoxISBN.TabIndex = 8;
            // 
            // textBoxID
            // 
            this.textBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxID.Location = new System.Drawing.Point(74, 64);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonAdd.Location = new System.Drawing.Point(683, 62);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "ADD BOOK";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonDisplay.Location = new System.Drawing.Point(764, 62);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(100, 23);
            this.buttonDisplay.TabIndex = 11;
            this.buttonDisplay.Text = "DISPLAY BOOKS";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonEdit.Location = new System.Drawing.Point(33, 120);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(84, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "EDIT BOOK";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonDelete.Location = new System.Drawing.Point(136, 120);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "DELETE BOOK";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(610, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Display Books/Users/Statistics:";
            // 
            // textBoxDisplayAdmin
            // 
            this.textBoxDisplayAdmin.BackColor = System.Drawing.Color.White;
            this.textBoxDisplayAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDisplayAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplayAdmin.ForeColor = System.Drawing.Color.Black;
            this.textBoxDisplayAdmin.Location = new System.Drawing.Point(538, 133);
            this.textBoxDisplayAdmin.Multiline = true;
            this.textBoxDisplayAdmin.Name = "textBoxDisplayAdmin";
            this.textBoxDisplayAdmin.ReadOnly = true;
            this.textBoxDisplayAdmin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDisplayAdmin.Size = new System.Drawing.Size(334, 134);
            this.textBoxDisplayAdmin.TabIndex = 16;
            // 
            // textBoxDisplayUser
            // 
            this.textBoxDisplayUser.BackColor = System.Drawing.Color.White;
            this.textBoxDisplayUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDisplayUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplayUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxDisplayUser.Location = new System.Drawing.Point(538, 280);
            this.textBoxDisplayUser.Multiline = true;
            this.textBoxDisplayUser.Name = "textBoxDisplayUser";
            this.textBoxDisplayUser.ReadOnly = true;
            this.textBoxDisplayUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDisplayUser.Size = new System.Drawing.Size(334, 188);
            this.textBoxDisplayUser.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label8.Location = new System.Drawing.Point(25, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Statistics:";
            // 
            // buttonDisplayUsers
            // 
            this.buttonDisplayUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonDisplayUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonDisplayUsers.Location = new System.Drawing.Point(136, 216);
            this.buttonDisplayUsers.Name = "buttonDisplayUsers";
            this.buttonDisplayUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplayUsers.TabIndex = 19;
            this.buttonDisplayUsers.Text = "DISPLAY USERS";
            this.buttonDisplayUsers.UseVisualStyleBackColor = false;
            this.buttonDisplayUsers.Click += new System.EventHandler(this.buttonDisplayUsers_Click);
            // 
            // buttonDisplayMostRead
            // 
            this.buttonDisplayMostRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonDisplayMostRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonDisplayMostRead.Location = new System.Drawing.Point(28, 178);
            this.buttonDisplayMostRead.Name = "buttonDisplayMostRead";
            this.buttonDisplayMostRead.Size = new System.Drawing.Size(205, 23);
            this.buttonDisplayMostRead.TabIndex = 20;
            this.buttonDisplayMostRead.Text = "DISPLAY THE MOST READ BOOK";
            this.buttonDisplayMostRead.UseVisualStyleBackColor = false;
            this.buttonDisplayMostRead.Click += new System.EventHandler(this.buttonDisplayMostRead_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label9.Location = new System.Drawing.Point(25, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Show all users:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label10.Location = new System.Drawing.Point(31, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 14);
            this.label10.TabIndex = 22;
            this.label10.Text = "USERS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bell Gothic Std Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label11.Location = new System.Drawing.Point(237, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "READ BOOKS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label12.Location = new System.Drawing.Point(31, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Search a book by Title or Author:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label13.Location = new System.Drawing.Point(31, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(413, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Sign in to open books. If you do not already have an account, you can sign up for" +
                " one";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxSearch.Location = new System.Drawing.Point(200, 305);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(202, 20);
            this.textBoxSearch.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonSearch.Enabled = false;
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonSearch.Location = new System.Drawing.Point(418, 305);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(97, 23);
            this.buttonSearch.TabIndex = 27;
            this.buttonSearch.Text = "SEARCH BOOK";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label14.Location = new System.Drawing.Point(295, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label15.Location = new System.Drawing.Point(31, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Username (email address):";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonSignIn.Location = new System.Drawing.Point(457, 372);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 30;
            this.buttonSignIn.Text = "SIGN IN";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxUsername.Location = new System.Drawing.Point(163, 375);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(122, 20);
            this.textBoxUsername.TabIndex = 31;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxPassword.Location = new System.Drawing.Point(352, 375);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(94, 20);
            this.textBoxPassword.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label16.Location = new System.Drawing.Point(295, 478);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(204, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "You can Sign in after creating an account";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label17.Location = new System.Drawing.Point(31, 484);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Re-enter Password:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label18.Location = new System.Drawing.Point(31, 432);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Username (email address):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label19.Location = new System.Drawing.Point(31, 408);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "SIGN UP";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label20.Location = new System.Drawing.Point(31, 458);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Password:";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(171, 484);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordConfirm.TabIndex = 38;
            // 
            // textBoxPasswordSU
            // 
            this.textBoxPasswordSU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxPasswordSU.Location = new System.Drawing.Point(171, 458);
            this.textBoxPasswordSU.Name = "textBoxPasswordSU";
            this.textBoxPasswordSU.PasswordChar = '*';
            this.textBoxPasswordSU.Size = new System.Drawing.Size(100, 20);
            this.textBoxPasswordSU.TabIndex = 39;
            // 
            // textBoxUsernameSU
            // 
            this.textBoxUsernameSU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.textBoxUsernameSU.Location = new System.Drawing.Point(171, 429);
            this.textBoxUsernameSU.Name = "textBoxUsernameSU";
            this.textBoxUsernameSU.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsernameSU.TabIndex = 40;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonCreateAccount.Location = new System.Drawing.Point(340, 448);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(117, 23);
            this.buttonCreateAccount.TabIndex = 41;
            this.buttonCreateAccount.Text = "CREATE ACCOUNT";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label21.Location = new System.Drawing.Point(535, 478);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(338, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Rate the book after reading on  scale 1-10! (1- not the best, 10- great!)";
            // 
            // buttonRating
            // 
            this.buttonRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonRating.Location = new System.Drawing.Point(239, 178);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(202, 23);
            this.buttonRating.TabIndex = 46;
            this.buttonRating.Text = "DISPLAY HIGHEST RATED BOOK";
            this.buttonRating.UseVisualStyleBackColor = false;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // buttonSubmitRating
            // 
            this.buttonSubmitRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.buttonSubmitRating.Enabled = false;
            this.buttonSubmitRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.buttonSubmitRating.Location = new System.Drawing.Point(664, 494);
            this.buttonSubmitRating.Name = "buttonSubmitRating";
            this.buttonSubmitRating.Size = new System.Drawing.Size(114, 23);
            this.buttonSubmitRating.TabIndex = 49;
            this.buttonSubmitRating.Text = "SUBMIT RATING";
            this.buttonSubmitRating.UseVisualStyleBackColor = false;
            this.buttonSubmitRating.Click += new System.EventHandler(this.buttonSubmitRating_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.numericUpDown1.Location = new System.Drawing.Point(538, 494);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 50;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("ESRI Enviro Hazard Sites", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label22.Location = new System.Drawing.Point(554, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 17);
            this.label22.TabIndex = 51;
            this.label22.Text = "RS";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("ESRI Enviro Hazard Sites", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.label23.Location = new System.Drawing.Point(306, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 17);
            this.label23.TabIndex = 52;
            this.label23.Text = "SR";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label24.Location = new System.Drawing.Point(30, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(203, 13);
            this.label24.TabIndex = 53;
            this.label24.Text = "Enter the book ID to edit or delete a book";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(891, 520);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonSubmitRating);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.textBoxUsernameSU);
            this.Controls.Add(this.textBoxPasswordSU);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDisplayMostRead);
            this.Controls.Add(this.buttonDisplayUsers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDisplayUser);
            this.Controls.Add(this.textBoxDisplayAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Online Library";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDisplayAdmin;
        private System.Windows.Forms.TextBox textBoxDisplayUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDisplayUsers;
        private System.Windows.Forms.Button buttonDisplayMostRead;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxPasswordSU;
        private System.Windows.Forms.TextBox textBoxUsernameSU;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.Button buttonSubmitRating;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

