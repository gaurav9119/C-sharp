namespace SumAndProduct
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
            this.lab_sum = new System.Windows.Forms.Label();
            this.Btn_accept = new System.Windows.Forms.Button();
            this.Btn_sum = new System.Windows.Forms.Button();
            this.Btn_prod = new System.Windows.Forms.Button();
            this.lblarray = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_prod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_sum
            // 
            this.lab_sum.AutoSize = true;
            this.lab_sum.Location = new System.Drawing.Point(615, 302);
            this.lab_sum.Name = "lab_sum";
            this.lab_sum.Size = new System.Drawing.Size(35, 13);
            this.lab_sum.TabIndex = 0;
            this.lab_sum.Text = "label1";
            this.lab_sum.Visible = false;
            // 
            // Btn_accept
            // 
            this.Btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_accept.Location = new System.Drawing.Point(148, 187);
            this.Btn_accept.Name = "Btn_accept";
            this.Btn_accept.Size = new System.Drawing.Size(113, 23);
            this.Btn_accept.TabIndex = 2;
            this.Btn_accept.Text = "Enter Array";
            this.Btn_accept.UseVisualStyleBackColor = true;
            this.Btn_accept.Click += new System.EventHandler(this.Btn_accept_Click);
            // 
            // Btn_sum
            // 
            this.Btn_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sum.Location = new System.Drawing.Point(600, 154);
            this.Btn_sum.Name = "Btn_sum";
            this.Btn_sum.Size = new System.Drawing.Size(75, 23);
            this.Btn_sum.TabIndex = 3;
            this.Btn_sum.Text = "Sum";
            this.Btn_sum.UseVisualStyleBackColor = true;
            this.Btn_sum.Click += new System.EventHandler(this.Btn_sum_Click);
            // 
            // Btn_prod
            // 
            this.Btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_prod.Location = new System.Drawing.Point(600, 239);
            this.Btn_prod.Name = "Btn_prod";
            this.Btn_prod.Size = new System.Drawing.Size(75, 23);
            this.Btn_prod.TabIndex = 4;
            this.Btn_prod.Text = "Product";
            this.Btn_prod.UseVisualStyleBackColor = true;
            this.Btn_prod.Click += new System.EventHandler(this.Btn_prod_Click);
            // 
            // lblarray
            // 
            this.lblarray.AutoSize = true;
            this.lblarray.Location = new System.Drawing.Point(190, 265);
            this.lblarray.Name = "lblarray";
            this.lblarray.Size = new System.Drawing.Size(35, 13);
            this.lblarray.TabIndex = 5;
            this.lblarray.Text = "label1";
            this.lblarray.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ccalculate sum and product of Array";
            // 
            // lab_prod
            // 
            this.lab_prod.AutoSize = true;
            this.lab_prod.Location = new System.Drawing.Point(615, 366);
            this.lab_prod.Name = "lab_prod";
            this.lab_prod.Size = new System.Drawing.Size(35, 13);
            this.lab_prod.TabIndex = 6;
            this.lab_prod.Text = "label2";
            this.lab_prod.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_prod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblarray);
            this.Controls.Add(this.Btn_prod);
            this.Controls.Add(this.Btn_sum);
            this.Controls.Add(this.Btn_accept);
            this.Controls.Add(this.lab_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_sum;
        private System.Windows.Forms.Button Btn_accept;
        private System.Windows.Forms.Button Btn_sum;
        private System.Windows.Forms.Button Btn_prod;
        private System.Windows.Forms.Label lblarray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_prod;
    }
}

