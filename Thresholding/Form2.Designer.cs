namespace Thresholding
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opentoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.savetoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.exittoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.morphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationtoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.erosiontoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openingtoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.closingtoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.gradienttoolStripMeniItem = new System.Windows.Forms.ToolStripTextBox();
            this.topHattoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.blackHattoolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.a = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationtoolStripMenuItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.erosiontoolStripMenuItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.morphologyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opentoolStripMenuItem,
            this.savetoolStripMenuItem,
            this.exittoolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // opentoolStripMenuItem
            // 
            this.opentoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.opentoolStripMenuItem.Name = "opentoolStripMenuItem";
            this.opentoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.opentoolStripMenuItem.Text = "Open";
            this.opentoolStripMenuItem.Click += new System.EventHandler(this.opentoolStripMenuItem_Click);
            // 
            // savetoolStripMenuItem
            // 
            this.savetoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savetoolStripMenuItem.Name = "savetoolStripMenuItem";
            this.savetoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.savetoolStripMenuItem.Text = "Save";
            this.savetoolStripMenuItem.Click += new System.EventHandler(this.savetoolStripMenuItem_Click);
            // 
            // exittoolStripMenuItem
            // 
            this.exittoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exittoolStripMenuItem.Name = "exittoolStripMenuItem";
            this.exittoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.exittoolStripMenuItem.Text = "Exit";
            this.exittoolStripMenuItem.Click += new System.EventHandler(this.exittoolStripMenuItem_Click);
            // 
            // morphologyToolStripMenuItem
            // 
            this.morphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationtoolStripMenuItem,
            this.erosiontoolStripMenuItem,
            this.toolStripSeparator1,
            this.openingtoolStripMenuItem,
            this.closingtoolStripMenuItem,
            this.gradienttoolStripMeniItem,
            this.topHattoolStripMenuItem,
            this.blackHattoolStripMenuItem,
            this.a});
            this.morphologyToolStripMenuItem.Name = "morphologyToolStripMenuItem";
            this.morphologyToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.morphologyToolStripMenuItem.Text = "Morphology";
            // 
            // dilationtoolStripMenuItem
            // 
            this.dilationtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dilationtoolStripMenuItem.Name = "dilationtoolStripMenuItem";
            this.dilationtoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.dilationtoolStripMenuItem.Text = "Dilation";
            this.dilationtoolStripMenuItem.Click += new System.EventHandler(this.dilationtoolStripMenuItem_Click);
            // 
            // erosiontoolStripMenuItem
            // 
            this.erosiontoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.erosiontoolStripMenuItem.Name = "erosiontoolStripMenuItem";
            this.erosiontoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.erosiontoolStripMenuItem.Text = "Erosion";
            this.erosiontoolStripMenuItem.Click += new System.EventHandler(this.erosiontoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // openingtoolStripMenuItem
            // 
            this.openingtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openingtoolStripMenuItem.Name = "openingtoolStripMenuItem";
            this.openingtoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.openingtoolStripMenuItem.Text = "Opening";
            this.openingtoolStripMenuItem.Click += new System.EventHandler(this.openingtoolStripMenuItem_Click);
            // 
            // closingtoolStripMenuItem
            // 
            this.closingtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closingtoolStripMenuItem.Name = "closingtoolStripMenuItem";
            this.closingtoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.closingtoolStripMenuItem.Text = "Closing";
            this.closingtoolStripMenuItem.Click += new System.EventHandler(this.closingtoolStripMenuItem_Click);
            // 
            // gradienttoolStripMeniItem
            // 
            this.gradienttoolStripMeniItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gradienttoolStripMeniItem.Name = "gradienttoolStripMeniItem";
            this.gradienttoolStripMeniItem.Size = new System.Drawing.Size(100, 27);
            this.gradienttoolStripMeniItem.Text = "Gradient";
            this.gradienttoolStripMeniItem.Click += new System.EventHandler(this.gradienttoolStripMeniItem_Click);
            // 
            // topHattoolStripMenuItem
            // 
            this.topHattoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.topHattoolStripMenuItem.Name = "topHattoolStripMenuItem";
            this.topHattoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.topHattoolStripMenuItem.Text = "Top Hat";
            this.topHattoolStripMenuItem.Click += new System.EventHandler(this.topHattoolStripMenuItem_Click);
            // 
            // blackHattoolStripMenuItem
            // 
            this.blackHattoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.blackHattoolStripMenuItem.Name = "blackHattoolStripMenuItem";
            this.blackHattoolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.blackHattoolStripMenuItem.Text = "Black Hat";
            this.blackHattoolStripMenuItem.Click += new System.EventHandler(this.blackHattoolStripMenuItem_Click);
            // 
            // a
            // 
            this.a.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationtoolStripMenuItem1,
            this.erosiontoolStripMenuItem1});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(224, 26);
            this.a.Text = "Morrphology";
            // 
            // dilationtoolStripMenuItem1
            // 
            this.dilationtoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dilationtoolStripMenuItem1.Name = "dilationtoolStripMenuItem1";
            this.dilationtoolStripMenuItem1.Size = new System.Drawing.Size(100, 27);
            this.dilationtoolStripMenuItem1.Text = "Dilation";
            this.dilationtoolStripMenuItem1.Click += new System.EventHandler(this.dilationtoolStripMenuItem1_Click);
            // 
            // erosiontoolStripMenuItem1
            // 
            this.erosiontoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.erosiontoolStripMenuItem1.Name = "erosiontoolStripMenuItem1";
            this.erosiontoolStripMenuItem1.Size = new System.Drawing.Size(100, 27);
            this.erosiontoolStripMenuItem1.Text = "Erosion";
            this.erosiontoolStripMenuItem1.Click += new System.EventHandler(this.erosiontoolStripMenuItem1_Click);
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 89);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(435, 419);
            this.pictureBoxInput.TabIndex = 1;
            this.pictureBoxInput.TabStop = false;
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.Location = new System.Drawing.Point(490, 89);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(435, 419);
            this.pictureBoxOutput.TabIndex = 2;
            this.pictureBoxOutput.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 682);
            this.Controls.Add(this.pictureBoxOutput);
            this.Controls.Add(this.pictureBoxInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox opentoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox savetoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox exittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morphologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox dilationtoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox erosiontoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox openingtoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox closingtoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox gradienttoolStripMeniItem;
        private System.Windows.Forms.ToolStripTextBox topHattoolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox blackHattoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem a;
        private System.Windows.Forms.ToolStripTextBox dilationtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox erosiontoolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxOutput;
    }
}