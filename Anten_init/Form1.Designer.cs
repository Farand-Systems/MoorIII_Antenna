namespace Anten_init
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Createall_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Loadxlsxbtn = new System.Windows.Forms.Button();
            this.LoadtxtBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataAddressText = new System.Windows.Forms.TextBox();
            this.TextAddressText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Createall_btn
            // 
            this.Createall_btn.Location = new System.Drawing.Point(543, 3);
            this.Createall_btn.Name = "Createall_btn";
            this.Createall_btn.Size = new System.Drawing.Size(112, 53);
            this.Createall_btn.TabIndex = 8;
            this.Createall_btn.Text = "CreateAll";
            this.Createall_btn.UseVisualStyleBackColor = true;
            this.Createall_btn.Click += new System.EventHandler(this.Createall_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(420, 31);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(117, 25);
            this.create_btn.TabIndex = 7;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anten Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(720, 226);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 226);
            this.dataGridView1.TabIndex = 11;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackgroundImage = global::Anten_init.Properties.Resources.applyIcon2;
            this.ApplyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplyBtn.Location = new System.Drawing.Point(696, 51);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(32, 29);
            this.ApplyBtn.TabIndex = 10;
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(317, 5);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(97, 51);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Loadxlsxbtn
            // 
            this.Loadxlsxbtn.Location = new System.Drawing.Point(275, 7);
            this.Loadxlsxbtn.Name = "Loadxlsxbtn";
            this.Loadxlsxbtn.Size = new System.Drawing.Size(36, 23);
            this.Loadxlsxbtn.TabIndex = 1;
            this.Loadxlsxbtn.Text = "...";
            this.Loadxlsxbtn.UseVisualStyleBackColor = true;
            this.Loadxlsxbtn.Click += new System.EventHandler(this.Loadxlsxbtn_Click);
            // 
            // LoadtxtBtn
            // 
            this.LoadtxtBtn.Location = new System.Drawing.Point(275, 34);
            this.LoadtxtBtn.Name = "LoadtxtBtn";
            this.LoadtxtBtn.Size = new System.Drawing.Size(36, 23);
            this.LoadtxtBtn.TabIndex = 2;
            this.LoadtxtBtn.Text = "...";
            this.LoadtxtBtn.UseVisualStyleBackColor = true;
            this.LoadtxtBtn.Click += new System.EventHandler(this.LoadtxtBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data Path :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Text Path : ";
            // 
            // dataAddressText
            // 
            this.dataAddressText.Location = new System.Drawing.Point(73, 11);
            this.dataAddressText.Name = "dataAddressText";
            this.dataAddressText.Size = new System.Drawing.Size(196, 20);
            this.dataAddressText.TabIndex = 3;
            // 
            // TextAddressText
            // 
            this.TextAddressText.Location = new System.Drawing.Point(73, 37);
            this.TextAddressText.Name = "TextAddressText";
            this.TextAddressText.Size = new System.Drawing.Size(196, 20);
            this.TextAddressText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 547);
            this.Controls.Add(this.TextAddressText);
            this.Controls.Add(this.dataAddressText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoadtxtBtn);
            this.Controls.Add(this.Loadxlsxbtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.Createall_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Initioal Antens ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Createall_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button Loadxlsxbtn;
        private System.Windows.Forms.Button LoadtxtBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataAddressText;
        private System.Windows.Forms.TextBox TextAddressText;
    }
}

