namespace ToetsDB1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtIdGeslacht = new TextBox();
            txtWachtwoord = new TextBox();
            btnToonAlles = new Button();
            btnFilter = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 53);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "id geslacht";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 53);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "ww";
            // 
            // txtIdGeslacht
            // 
            txtIdGeslacht.Location = new Point(271, 50);
            txtIdGeslacht.Name = "txtIdGeslacht";
            txtIdGeslacht.Size = new Size(147, 23);
            txtIdGeslacht.TabIndex = 2;
            // 
            // txtWachtwoord
            // 
            txtWachtwoord.Location = new Point(584, 50);
            txtWachtwoord.Name = "txtWachtwoord";
            txtWachtwoord.Size = new Size(126, 23);
            txtWachtwoord.TabIndex = 3;
            // 
            // btnToonAlles
            // 
            btnToonAlles.Location = new Point(35, 85);
            btnToonAlles.Name = "btnToonAlles";
            btnToonAlles.Size = new Size(91, 23);
            btnToonAlles.TabIndex = 4;
            btnToonAlles.Text = "Toon alles";
            btnToonAlles.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(174, 85);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(244, 23);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 128);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(383, 289);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 444);
            Controls.Add(listBox1);
            Controls.Add(btnFilter);
            Controls.Add(btnToonAlles);
            Controls.Add(txtWachtwoord);
            Controls.Add(txtIdGeslacht);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Toets 1 programmeren met databanken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdGeslacht;
        private TextBox txtWachtwoord;
        private Button btnToonAlles;
        private Button btnFilter;
        private ListBox listBox1;
    }
}
