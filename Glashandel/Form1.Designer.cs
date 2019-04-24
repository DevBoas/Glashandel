namespace Glashandel
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
            this.RadioSoort1 = new System.Windows.Forms.RadioButton();
            this.RadioSoort2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxMaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RadioSoort1
            // 
            this.RadioSoort1.AutoSize = true;
            this.RadioSoort1.Checked = true;
            this.RadioSoort1.Location = new System.Drawing.Point(174, 78);
            this.RadioSoort1.Name = "RadioSoort1";
            this.RadioSoort1.Size = new System.Drawing.Size(64, 17);
            this.RadioSoort1.TabIndex = 0;
            this.RadioSoort1.TabStop = true;
            this.RadioSoort1.Text = "Normaal";
            this.RadioSoort1.UseVisualStyleBackColor = true;
            // 
            // RadioSoort2
            // 
            this.RadioSoort2.AutoSize = true;
            this.RadioSoort2.Location = new System.Drawing.Point(174, 101);
            this.RadioSoort2.Name = "RadioSoort2";
            this.RadioSoort2.Size = new System.Drawing.Size(66, 17);
            this.RadioSoort2.TabIndex = 1;
            this.RadioSoort2.Text = "Speciaal";
            this.RadioSoort2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soort glas";
            // 
            // TextBoxMaat
            // 
            this.TextBoxMaat.Location = new System.Drawing.Point(174, 52);
            this.TextBoxMaat.Name = "TextBoxMaat";
            this.TextBoxMaat.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMaat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maat glas";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(174, 124);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(75, 23);
            this.Bereken.TabIndex = 5;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(171, 159);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 23);
            this.Output.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxMaat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioSoort2);
            this.Controls.Add(this.RadioSoort1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioSoort1;
        private System.Windows.Forms.RadioButton RadioSoort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Output;
    }
}

