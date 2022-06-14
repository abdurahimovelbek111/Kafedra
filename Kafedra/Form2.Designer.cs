namespace Kafedra
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
            this.allTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTablesToolStripMenuItem,
            this.generalSearchToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutTheProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allTablesToolStripMenuItem
            // 
            this.allTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directionToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.chairToolStripMenuItem});
            this.allTablesToolStripMenuItem.Name = "allTablesToolStripMenuItem";
            this.allTablesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.allTablesToolStripMenuItem.Text = "All Tables";
            // 
            // directionToolStripMenuItem
            // 
            this.directionToolStripMenuItem.Name = "directionToolStripMenuItem";
            this.directionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directionToolStripMenuItem.Text = "Direction";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // chairToolStripMenuItem
            // 
            this.chairToolStripMenuItem.Name = "chairToolStripMenuItem";
            this.chairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chairToolStripMenuItem.Text = "Chair";
            // 
            // generalSearchToolStripMenuItem
            // 
            this.generalSearchToolStripMenuItem.Name = "generalSearchToolStripMenuItem";
            this.generalSearchToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.generalSearchToolStripMenuItem.Text = "General Search";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutTheProgramToolStripMenuItem
            // 
            this.aboutTheProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.aboutTheProgramToolStripMenuItem.Name = "aboutTheProgramToolStripMenuItem";
            this.aboutTheProgramToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.aboutTheProgramToolStripMenuItem.Text = "About the Program";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
    }
}