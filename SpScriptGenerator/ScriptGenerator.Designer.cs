
namespace SpScriptGenerator
{
    partial class ScriptGenerator
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
            this.sps = new System.Windows.Forms.RichTextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.qtype = new System.Windows.Forms.ComboBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sps
            // 
            this.sps.Location = new System.Drawing.Point(42, 114);
            this.sps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sps.Name = "sps";
            this.sps.Size = new System.Drawing.Size(756, 399);
            this.sps.TabIndex = 1;
            this.sps.Text = "";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(644, 540);
            this.generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(154, 47);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter SP\'s name with scema.";            
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(42, 521);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 20);
            this.errorMessage.TabIndex = 4;
            // 
            // qtype
            // 
            this.qtype.FormattingEnabled = true;
            this.qtype.Items.AddRange(new object[] {
            "Store Procedure",
            "Views"});
            this.qtype.Location = new System.Drawing.Point(446, 30);
            this.qtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qtype.Name = "qtype";
            this.qtype.Size = new System.Drawing.Size(190, 28);
            this.qtype.TabIndex = 5;
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "CREATE",
            "ALTER"});
            this.cbtype.Location = new System.Drawing.Point(660, 30);
            this.cbtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(138, 28);
            this.cbtype.TabIndex = 6;            
            // 
            // ScriptGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 600);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.qtype);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.sps);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScriptGenerator";
            this.Text = "Script Generator";
            this.Load += new System.EventHandler(this.ScriptGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox sps;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.ComboBox qtype;
        private System.Windows.Forms.ComboBox cbtype;
    }
}

