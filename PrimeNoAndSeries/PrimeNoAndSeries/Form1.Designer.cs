namespace PrimeNoAndSeries
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
            this.label1 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txtseries2 = new System.Windows.Forms.TextBox();
            this.txtseries1 = new System.Windows.Forms.TextBox();
            this.btnSeries = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Number";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(543, 274);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "label3";
            this.lab1.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(190, 224);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Find";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(181, 155);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(100, 20);
            this.txt_add.TabIndex = 4;
            // 
            // txtseries2
            // 
            this.txtseries2.Location = new System.Drawing.Point(546, 184);
            this.txtseries2.Name = "txtseries2";
            this.txtseries2.Size = new System.Drawing.Size(100, 20);
            this.txtseries2.TabIndex = 5;
            // 
            // txtseries1
            // 
            this.txtseries1.Location = new System.Drawing.Point(546, 142);
            this.txtseries1.Name = "txtseries1";
            this.txtseries1.Size = new System.Drawing.Size(100, 20);
            this.txtseries1.TabIndex = 6;
            // 
            // btnSeries
            // 
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.Location = new System.Drawing.Point(557, 230);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(75, 23);
            this.btnSeries.TabIndex = 7;
            this.btnSeries.Text = "Find";
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Check if it is a prime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Display prime number series between them";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.txtseries1);
            this.Controls.Add(this.txtseries2);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prime number series between them";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txtseries2;
        private System.Windows.Forms.TextBox txtseries1;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

