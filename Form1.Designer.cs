namespace RunBar_skeleton
{
    partial class runbar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(runbar));
            this.cmd = new System.Windows.Forms.Button();
            this.taskmgr = new System.Windows.Forms.Button();
            this.diskpart = new System.Windows.Forms.Button();
            this.notepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd
            // 
            this.cmd.Location = new System.Drawing.Point(12, 12);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(75, 23);
            this.cmd.TabIndex = 0;
            this.cmd.Text = "CMD";
            this.cmd.UseVisualStyleBackColor = true;
            this.cmd.Click += new System.EventHandler(this.cmd_Click);
            // 
            // taskmgr
            // 
            this.taskmgr.Location = new System.Drawing.Point(12, 41);
            this.taskmgr.Name = "taskmgr";
            this.taskmgr.Size = new System.Drawing.Size(75, 23);
            this.taskmgr.TabIndex = 1;
            this.taskmgr.Text = "TASKMGR";
            this.taskmgr.UseVisualStyleBackColor = true;
            this.taskmgr.Click += new System.EventHandler(this.taskmgr_Click);
            // 
            // diskpart
            // 
            this.diskpart.Location = new System.Drawing.Point(12, 70);
            this.diskpart.Name = "diskpart";
            this.diskpart.Size = new System.Drawing.Size(75, 23);
            this.diskpart.TabIndex = 2;
            this.diskpart.Text = "DISKPART";
            this.diskpart.UseVisualStyleBackColor = true;
            this.diskpart.Click += new System.EventHandler(this.diskpart_Click);
            // 
            // notepad
            // 
            this.notepad.Location = new System.Drawing.Point(12, 99);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(75, 23);
            this.notepad.TabIndex = 3;
            this.notepad.Text = "NOTEPAD";
            this.notepad.UseVisualStyleBackColor = true;
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            // 
            // runbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(99, 134);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.diskpart);
            this.Controls.Add(this.taskmgr);
            this.Controls.Add(this.cmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "runbar";
            this.Text = "RunBar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd;
        private System.Windows.Forms.Button taskmgr;
        private System.Windows.Forms.Button diskpart;
        private System.Windows.Forms.Button notepad;
    }
}

