
namespace IBproject
{
    partial class createNewWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.DomainUpDown();
            this.label_H = new System.Windows.Forms.DomainUpDown();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label_S
            // 
            this.label_S.Location = new System.Drawing.Point(17, 37);
            this.label_S.Name = "label_S";
            this.label_S.Size = new System.Drawing.Size(123, 31);
            this.label_S.TabIndex = 2;
            // 
            // label_H
            // 
            this.label_H.Location = new System.Drawing.Point(152, 37);
            this.label_H.Name = "label_H";
            this.label_H.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_H.Size = new System.Drawing.Size(123, 31);
            this.label_H.TabIndex = 3;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(17, 74);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(123, 34);
            this.bt_ok.TabIndex = 4;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_No
            // 
            this.bt_No.Location = new System.Drawing.Point(152, 74);
            this.bt_No.Name = "bt_No";
            this.bt_No.Size = new System.Drawing.Size(123, 34);
            this.bt_No.TabIndex = 5;
            this.bt_No.Text = "cancel";
            this.bt_No.UseVisualStyleBackColor = true;
            this.bt_No.Click += new System.EventHandler(this.bt_No_Click);
            // 
            // createNewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 122);
            this.Controls.Add(this.bt_No);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label_H);
            this.Controls.Add(this.label_S);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "createNewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "createNewWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown label_S;
        private System.Windows.Forms.DomainUpDown label_H;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_No;
    }
}