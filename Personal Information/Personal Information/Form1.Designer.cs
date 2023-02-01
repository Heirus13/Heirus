namespace Personal_Information
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnSinging = new System.Windows.Forms.CheckBox();
            this.btnDancing = new System.Windows.Forms.CheckBox();
            this.btnPlaying = new System.Windows.Forms.CheckBox();
            this.btnCooking = new System.Windows.Forms.CheckBox();
            this.btnCycling = new System.Windows.Forms.CheckBox();
            this.btnPainting = new System.Windows.Forms.CheckBox();
            this.btnFemale = new System.Windows.Forms.RadioButton();
            this.btnMale = new System.Windows.Forms.RadioButton();
            this.btnImage = new System.Windows.Forms.PictureBox();
            this.btnBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSinging
            // 
            this.btnSinging.AutoSize = true;
            this.btnSinging.Location = new System.Drawing.Point(106, 38);
            this.btnSinging.Name = "btnSinging";
            this.btnSinging.Size = new System.Drawing.Size(66, 19);
            this.btnSinging.TabIndex = 2;
            this.btnSinging.Text = "Singing";
            this.btnSinging.UseVisualStyleBackColor = true;
            this.btnSinging.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDancing
            // 
            this.btnDancing.AutoSize = true;
            this.btnDancing.Location = new System.Drawing.Point(17, 38);
            this.btnDancing.Name = "btnDancing";
            this.btnDancing.Size = new System.Drawing.Size(70, 19);
            this.btnDancing.TabIndex = 3;
            this.btnDancing.Text = "Dancing";
            this.btnDancing.UseVisualStyleBackColor = true;
            // 
            // btnPlaying
            // 
            this.btnPlaying.AutoSize = true;
            this.btnPlaying.Location = new System.Drawing.Point(106, 88);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.Size = new System.Drawing.Size(65, 19);
            this.btnPlaying.TabIndex = 4;
            this.btnPlaying.Text = "Playing";
            this.btnPlaying.UseVisualStyleBackColor = true;
            // 
            // btnCooking
            // 
            this.btnCooking.AutoSize = true;
            this.btnCooking.Location = new System.Drawing.Point(106, 63);
            this.btnCooking.Name = "btnCooking";
            this.btnCooking.Size = new System.Drawing.Size(71, 19);
            this.btnCooking.TabIndex = 5;
            this.btnCooking.Text = "Cooking";
            this.btnCooking.UseVisualStyleBackColor = true;
            // 
            // btnCycling
            // 
            this.btnCycling.AutoSize = true;
            this.btnCycling.Location = new System.Drawing.Point(17, 88);
            this.btnCycling.Name = "btnCycling";
            this.btnCycling.Size = new System.Drawing.Size(66, 19);
            this.btnCycling.TabIndex = 6;
            this.btnCycling.Text = "Cycling";
            this.btnCycling.UseVisualStyleBackColor = true;
            // 
            // btnPainting
            // 
            this.btnPainting.AutoSize = true;
            this.btnPainting.Location = new System.Drawing.Point(17, 63);
            this.btnPainting.Name = "btnPainting";
            this.btnPainting.Size = new System.Drawing.Size(70, 19);
            this.btnPainting.TabIndex = 7;
            this.btnPainting.Text = "Painting";
            this.btnPainting.UseVisualStyleBackColor = true;
            // 
            // btnFemale
            // 
            this.btnFemale.AutoSize = true;
            this.btnFemale.Location = new System.Drawing.Point(17, 50);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(63, 19);
            this.btnFemale.TabIndex = 8;
            this.btnFemale.TabStop = true;
            this.btnFemale.Text = "Female";
            this.btnFemale.UseVisualStyleBackColor = true;
            // 
            // btnMale
            // 
            this.btnMale.AutoSize = true;
            this.btnMale.Location = new System.Drawing.Point(17, 25);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(51, 19);
            this.btnMale.TabIndex = 9;
            this.btnMale.TabStop = true;
            this.btnMale.Text = "Male";
            this.btnMale.UseVisualStyleBackColor = true;
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(403, 30);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(369, 232);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnImage.TabIndex = 10;
            this.btnImage.TabStop = false;
            this.btnImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBirthday
            // 
            this.btnBirthday.Location = new System.Drawing.Point(87, 54);
            this.btnBirthday.Name = "btnBirthday";
            this.btnBirthday.Size = new System.Drawing.Size(200, 23);
            this.btnBirthday.TabIndex = 11;
            // 
            // btnDisplay
            // 
            this.btnDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDisplay.Location = new System.Drawing.Point(619, 268);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 12;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(481, 268);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFemale);
            this.groupBox1.Controls.Add(this.btnMale);
            this.groupBox1.Location = new System.Drawing.Point(87, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDancing);
            this.groupBox2.Controls.Add(this.btnSinging);
            this.groupBox2.Controls.Add(this.btnPlaying);
            this.groupBox2.Controls.Add(this.btnCooking);
            this.groupBox2.Controls.Add(this.btnCycling);
            this.groupBox2.Controls.Add(this.btnPainting);
            this.groupBox2.Location = new System.Drawing.Point(87, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 131);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobbies";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(87, 25);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(100, 23);
            this.btnName.TabIndex = 16;
            this.btnName.TextChanged += new System.EventHandler(this.btnName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnBirthday);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private ImageList imageList2;
        private CheckBox btnSinging;
        private CheckBox btnDancing;
        private CheckBox btnPlaying;
        private CheckBox btnCooking;
        private CheckBox btnCycling;
        private CheckBox btnPainting;
        private RadioButton btnFemale;
        private RadioButton btnMale;
        private PictureBox btnImage;
        private DateTimePicker btnBirthday;
        private Button btnDisplay;
        private Button btnBrowse;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox btnName;
    }
}