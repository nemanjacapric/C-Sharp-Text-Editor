namespace Nemanja_Capric_C_Sharp_Projekat
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
            this.components = new System.ComponentModel.Container();
            this.text_area = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontBoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontItalicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvori_fajl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_box1 = new System.Windows.Forms.TextBox();
            this.text_box2 = new System.Windows.Forms.TextBox();
            this.pronadji_zameni = new System.Windows.Forms.Button();
            this.snimi_fajl = new System.Windows.Forms.Button();
            this.zavrsi_program = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_area
            // 
            this.text_area.ContextMenuStrip = this.contextMenuStrip1;
            this.text_area.Location = new System.Drawing.Point(12, 65);
            this.text_area.Name = "text_area";
            this.text_area.Size = new System.Drawing.Size(719, 366);
            this.text_area.TabIndex = 0;
            this.text_area.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontBoldToolStripMenuItem,
            this.fontItalicToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 98);
            // 
            // fontBoldToolStripMenuItem
            // 
            this.fontBoldToolStripMenuItem.Name = "fontBoldToolStripMenuItem";
            this.fontBoldToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontBoldToolStripMenuItem.Text = "Font Bold";
            this.fontBoldToolStripMenuItem.Click += new System.EventHandler(this.fontBoldToolStripMenuItem_Click);
            // 
            // fontItalicToolStripMenuItem
            // 
            this.fontItalicToolStripMenuItem.Name = "fontItalicToolStripMenuItem";
            this.fontItalicToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontItalicToolStripMenuItem.Text = "Font Italic";
            this.fontItalicToolStripMenuItem.Click += new System.EventHandler(this.fontItalicToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fontColorToolStripMenuItem.Text = "Font Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // otvori_fajl
            // 
            this.otvori_fajl.Location = new System.Drawing.Point(13, 13);
            this.otvori_fajl.Name = "otvori_fajl";
            this.otvori_fajl.Size = new System.Drawing.Size(101, 48);
            this.otvori_fajl.TabIndex = 1;
            this.otvori_fajl.Text = "Otvori fajl";
            this.otvori_fajl.UseVisualStyleBackColor = true;
            this.otvori_fajl.Click += new System.EventHandler(this.otvori_fajl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pronadji:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zameni se:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_box1
            // 
            this.text_box1.Location = new System.Drawing.Point(187, 10);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(100, 20);
            this.text_box1.TabIndex = 4;
            // 
            // text_box2
            // 
            this.text_box2.Location = new System.Drawing.Point(187, 37);
            this.text_box2.Name = "text_box2";
            this.text_box2.Size = new System.Drawing.Size(100, 20);
            this.text_box2.TabIndex = 5;
            // 
            // pronadji_zameni
            // 
            this.pronadji_zameni.Location = new System.Drawing.Point(303, 10);
            this.pronadji_zameni.Name = "pronadji_zameni";
            this.pronadji_zameni.Size = new System.Drawing.Size(80, 50);
            this.pronadji_zameni.TabIndex = 6;
            this.pronadji_zameni.Text = "Pronadji i Zameni";
            this.pronadji_zameni.UseVisualStyleBackColor = true;
            this.pronadji_zameni.Click += new System.EventHandler(this.pronadji_zameni_Click);
            // 
            // snimi_fajl
            // 
            this.snimi_fajl.Location = new System.Drawing.Point(389, 11);
            this.snimi_fajl.Name = "snimi_fajl";
            this.snimi_fajl.Size = new System.Drawing.Size(76, 49);
            this.snimi_fajl.TabIndex = 7;
            this.snimi_fajl.Text = "Snimi fajl (Save as)";
            this.snimi_fajl.UseVisualStyleBackColor = true;
            this.snimi_fajl.Click += new System.EventHandler(this.snimi_fajl_Click);
            // 
            // zavrsi_program
            // 
            this.zavrsi_program.Location = new System.Drawing.Point(653, 15);
            this.zavrsi_program.Name = "zavrsi_program";
            this.zavrsi_program.Size = new System.Drawing.Size(78, 46);
            this.zavrsi_program.TabIndex = 8;
            this.zavrsi_program.Text = "Završi program";
            this.zavrsi_program.UseVisualStyleBackColor = true;
            this.zavrsi_program.Click += new System.EventHandler(this.zavrsi_program_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.zavrsi_program;
            this.ClientSize = new System.Drawing.Size(743, 443);
            this.Controls.Add(this.zavrsi_program);
            this.Controls.Add(this.snimi_fajl);
            this.Controls.Add(this.pronadji_zameni);
            this.Controls.Add(this.text_box2);
            this.Controls.Add(this.text_box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otvori_fajl);
            this.Controls.Add(this.text_area);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nemanja_Capric_S17/19";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_area;
        private System.Windows.Forms.Button otvori_fajl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_box1;
        private System.Windows.Forms.TextBox text_box2;
        private System.Windows.Forms.Button pronadji_zameni;
        private System.Windows.Forms.Button snimi_fajl;
        private System.Windows.Forms.Button zavrsi_program;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontBoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontItalicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

