
namespace Windows_Activator
{
    partial class Form_Activate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Activate));
            this.label_Windows = new System.Windows.Forms.Label();
            this.comboBox_Windows = new System.Windows.Forms.ComboBox();
            this.comboBox_Edition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Windows
            // 
            this.label_Windows.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.label_Windows, "label_Windows");
            this.label_Windows.Name = "label_Windows";
            // 
            // comboBox_Windows
            // 
            this.comboBox_Windows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Windows.Items.AddRange(new object[] {
            resources.GetString("comboBox_Windows.Items"),
            resources.GetString("comboBox_Windows.Items1"),
            resources.GetString("comboBox_Windows.Items2"),
            resources.GetString("comboBox_Windows.Items3")});
            resources.ApplyResources(this.comboBox_Windows, "comboBox_Windows");
            this.comboBox_Windows.Name = "comboBox_Windows";
            this.comboBox_Windows.SelectedIndexChanged += new System.EventHandler(this.comboBox_Windows_SelectedIndexChanged);
            // 
            // comboBox_Edition
            // 
            this.comboBox_Edition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_Edition, "comboBox_Edition");
            this.comboBox_Edition.FormattingEnabled = true;
            this.comboBox_Edition.Name = "comboBox_Edition";
            this.comboBox_Edition.SelectedIndexChanged += new System.EventHandler(this.comboBox_Edition_SelectedIndexChanged);
            // 
            // Form_Activate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.comboBox_Edition);
            this.Controls.Add(this.comboBox_Windows);
            this.Controls.Add(this.label_Windows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Activate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Windows;
        private System.Windows.Forms.ComboBox comboBox_Windows;
        private System.Windows.Forms.ComboBox comboBox_Edition;
    }
}

