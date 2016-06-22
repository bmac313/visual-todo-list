namespace ToDoListCS
{
    partial class frmMainForm
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
            this.lstList = new System.Windows.Forms.ListBox();
            this.txtTextInput = new System.Windows.Forms.TextBox();
            this.lblTextInput = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstTaskNumbers = new System.Windows.Forms.ListBox();
            this.lblTaskNumber = new System.Windows.Forms.Label();
            this.lblTaskList = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 20;
            this.lstList.Location = new System.Drawing.Point(348, 78);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(489, 464);
            this.lstList.TabIndex = 0;
            // 
            // txtTextInput
            // 
            this.txtTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTextInput.Location = new System.Drawing.Point(47, 68);
            this.txtTextInput.Name = "txtTextInput";
            this.txtTextInput.Size = new System.Drawing.Size(216, 26);
            this.txtTextInput.TabIndex = 1;
            // 
            // lblTextInput
            // 
            this.lblTextInput.AutoSize = true;
            this.lblTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTextInput.Location = new System.Drawing.Point(43, 38);
            this.lblTextInput.Name = "lblTextInput";
            this.lblTextInput.Size = new System.Drawing.Size(145, 20);
            this.lblTextInput.TabIndex = 2;
            this.lblTextInput.Text = "Type a task here...";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(849, 28);
            this.mnuMainMenu.TabIndex = 3;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(129, 26);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(129, 26);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(129, 26);
            this.mnuSave.Text = "Save...";
            this.mnuSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(129, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(216, 93);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add task to list ->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(47, 241);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(216, 93);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<- Remove selected task";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(216, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update selected task...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstTaskNumbers
            // 
            this.lstTaskNumbers.Enabled = false;
            this.lstTaskNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstTaskNumbers.FormattingEnabled = true;
            this.lstTaskNumbers.ItemHeight = 20;
            this.lstTaskNumbers.Location = new System.Drawing.Point(295, 78);
            this.lstTaskNumbers.Name = "lstTaskNumbers";
            this.lstTaskNumbers.Size = new System.Drawing.Size(44, 464);
            this.lstTaskNumbers.TabIndex = 8;
            // 
            // lblTaskNumber
            // 
            this.lblTaskNumber.AutoSize = true;
            this.lblTaskNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTaskNumber.Location = new System.Drawing.Point(308, 38);
            this.lblTaskNumber.Name = "lblTaskNumber";
            this.lblTaskNumber.Size = new System.Drawing.Size(18, 20);
            this.lblTaskNumber.TabIndex = 10;
            this.lblTaskNumber.Text = "#";
            // 
            // lblTaskList
            // 
            this.lblTaskList.AutoSize = true;
            this.lblTaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTaskList.Location = new System.Drawing.Point(510, 38);
            this.lblTaskList.Name = "lblTaskList";
            this.lblTaskList.Size = new System.Drawing.Size(45, 20);
            this.lblTaskList.TabIndex = 11;
            this.lblTaskList.Text = "Task";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 562);
            this.Controls.Add(this.lblTaskList);
            this.Controls.Add(this.lblTaskNumber);
            this.Controls.Add(this.lstTaskNumbers);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTextInput);
            this.Controls.Add(this.txtTextInput);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainForm";
            this.Text = "Visual To-Do List";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.TextBox txtTextInput;
        private System.Windows.Forms.Label lblTextInput;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ListBox lstTaskNumbers;
        private System.Windows.Forms.Label lblTaskNumber;
        private System.Windows.Forms.Label lblTaskList;
    }
}

