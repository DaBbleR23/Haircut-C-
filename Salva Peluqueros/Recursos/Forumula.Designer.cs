namespace Salva_Peluqueros
{
    partial class Forumula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forumula));
            this.richTextBox_formula = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_formula
            // 
            this.richTextBox_formula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_formula.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_formula.Name = "richTextBox_formula";
            this.richTextBox_formula.Size = new System.Drawing.Size(543, 123);
            this.richTextBox_formula.TabIndex = 0;
            this.richTextBox_formula.Text = "";
            // 
            // Forumula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 123);
            this.Controls.Add(this.richTextBox_formula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forumula";
            this.Text = "Forumula";
            this.Load += new System.EventHandler(this.Forumula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_formula;
    }
}