namespace ThreeLayerOfcMgtSystem3
{
    partial class Form2
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
            this.txtpid = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtexpiry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmft = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.record)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product_id";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(182, 81);
            this.txtpid.Name = "txtpid";
            this.txtpid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpid.Size = new System.Drawing.Size(85, 20);
            this.txtpid.TabIndex = 2;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(182, 107);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(128, 20);
            this.txttitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title";
            // 
            // txtprize
            // 
            this.txtprize.Location = new System.Drawing.Point(182, 136);
            this.txtprize.Name = "txtprize";
            this.txtprize.Size = new System.Drawing.Size(128, 20);
            this.txtprize.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prize";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(182, 162);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(128, 20);
            this.txtstock.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock";
            // 
            // txtexpiry
            // 
            this.txtexpiry.Location = new System.Drawing.Point(182, 190);
            this.txtexpiry.Name = "txtexpiry";
            this.txtexpiry.Size = new System.Drawing.Size(128, 20);
            this.txtexpiry.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Expiry";
            // 
            // txtmft
            // 
            this.txtmft.Location = new System.Drawing.Point(182, 218);
            this.txtmft.Name = "txtmft";
            this.txtmft.Size = new System.Drawing.Size(128, 20);
            this.txtmft.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Manufacturor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(273, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // record
            // 
            this.record.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.record.Location = new System.Drawing.Point(386, 51);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(571, 303);
            this.record.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(630, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 33);
            this.button5.TabIndex = 18;
            this.button5.Text = "Show Record";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 433);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.record);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtexpiry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtexpiry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView record;
        private System.Windows.Forms.Button button5;
    }
}