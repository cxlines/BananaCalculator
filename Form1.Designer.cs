namespace bananacalculator
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
            this.closebtn = new System.Windows.Forms.Button();
            this.tag = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mm = new System.Windows.Forms.CheckBox();
            this.cm = new System.Windows.Forms.CheckBox();
            this.km = new System.Windows.Forms.CheckBox();
            this.ft = new System.Windows.Forms.CheckBox();
            this.inch = new System.Windows.Forms.CheckBox();
            this.miles = new System.Windows.Forms.CheckBox();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.resultlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closebtn.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.closebtn.Location = new System.Drawing.Point(521, 264);
            this.closebtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(121, 35);
            this.closebtn.TabIndex = 0;
            this.closebtn.Text = "bezárás";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // tag
            // 
            this.tag.AutoSize = true;
            this.tag.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tag.Location = new System.Drawing.Point(-1, -1);
            this.tag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(97, 22);
            this.tag.TabIndex = 1;
            this.tag.Text = "@codeatn8";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.miles);
            this.groupBox1.Controls.Add(this.inch);
            this.groupBox1.Controls.Add(this.ft);
            this.groupBox1.Controls.Add(this.km);
            this.groupBox1.Controls.Add(this.cm);
            this.groupBox1.Controls.Add(this.mm);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Location = new System.Drawing.Point(15, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(305, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "mértékegységek";
            // 
            // mm
            // 
            this.mm.AutoSize = true;
            this.mm.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mm.Location = new System.Drawing.Point(5, 28);
            this.mm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(101, 26);
            this.mm.TabIndex = 0;
            this.mm.Text = "miliméter";
            this.mm.UseVisualStyleBackColor = true;
            this.mm.CheckedChanged += new System.EventHandler(this.mm_CheckedChanged);
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cm.Location = new System.Drawing.Point(5, 61);
            this.cm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(110, 26);
            this.cm.TabIndex = 1;
            this.cm.Text = "centiméter";
            this.cm.UseVisualStyleBackColor = true;
            this.cm.CheckedChanged += new System.EventHandler(this.cm_CheckedChanged);
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.km.Location = new System.Drawing.Point(5, 95);
            this.km.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(100, 26);
            this.km.TabIndex = 2;
            this.km.Text = "kilóméter";
            this.km.UseVisualStyleBackColor = true;
            this.km.CheckedChanged += new System.EventHandler(this.km_CheckedChanged);
            // 
            // ft
            // 
            this.ft.AutoSize = true;
            this.ft.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ft.Location = new System.Drawing.Point(181, 28);
            this.ft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(54, 26);
            this.ft.TabIndex = 3;
            this.ft.Text = "láb";
            this.ft.UseVisualStyleBackColor = true;
            this.ft.CheckedChanged += new System.EventHandler(this.ft_CheckedChanged);
            // 
            // inch
            // 
            this.inch.AutoSize = true;
            this.inch.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inch.Location = new System.Drawing.Point(181, 61);
            this.inch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inch.Name = "inch";
            this.inch.Size = new System.Drawing.Size(85, 26);
            this.inch.TabIndex = 4;
            this.inch.Text = "hüvelyk";
            this.inch.UseVisualStyleBackColor = true;
            this.inch.CheckedChanged += new System.EventHandler(this.inch_CheckedChanged);
            // 
            // miles
            // 
            this.miles.AutoSize = true;
            this.miles.Font = new System.Drawing.Font("Yu Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miles.Location = new System.Drawing.Point(181, 95);
            this.miles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(88, 26);
            this.miles.TabIndex = 5;
            this.miles.Text = "mérföld";
            this.miles.UseVisualStyleBackColor = true;
            this.miles.CheckedChanged += new System.EventHandler(this.miles_CheckedChanged);
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.inputbox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.inputbox.Location = new System.Drawing.Point(15, 61);
            this.inputbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(304, 35);
            this.inputbox.TabIndex = 3;
            this.inputbox.Text = "Banánok száma...";
            this.inputbox.Click += new System.EventHandler(this.inputbox_Click);
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultlabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.resultlabel.Location = new System.Drawing.Point(327, 61);
            this.resultlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(98, 23);
            this.resultlabel.TabIndex = 5;
            this.resultlabel.Text = "Eredmény:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 313);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.closebtn);
            this.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balculator - The Banana Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label tag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox miles;
        private System.Windows.Forms.CheckBox inch;
        private System.Windows.Forms.CheckBox ft;
        private System.Windows.Forms.CheckBox km;
        private System.Windows.Forms.CheckBox cm;
        private System.Windows.Forms.CheckBox mm;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Label resultlabel;
    }
}

