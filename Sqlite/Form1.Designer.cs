namespace Sqlite
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.querytxt = new System.Windows.Forms.TextBox();
            this.cmdExecuteQuery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(93, 161);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.Size = new System.Drawing.Size(429, 203);
            this.grid1.TabIndex = 0;
            // 
            // querytxt
            // 
            this.querytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querytxt.Location = new System.Drawing.Point(93, 88);
            this.querytxt.Name = "querytxt";
            this.querytxt.Size = new System.Drawing.Size(429, 26);
            this.querytxt.TabIndex = 1;
            // 
            // cmdExecuteQuery
            // 
            this.cmdExecuteQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExecuteQuery.Location = new System.Drawing.Point(361, 120);
            this.cmdExecuteQuery.Name = "cmdExecuteQuery";
            this.cmdExecuteQuery.Size = new System.Drawing.Size(161, 35);
            this.cmdExecuteQuery.TabIndex = 2;
            this.cmdExecuteQuery.Text = "Ejecutar Query";
            this.cmdExecuteQuery.UseVisualStyleBackColor = true;
            this.cmdExecuteQuery.Click += new System.EventHandler(this.cmdExecuteQuery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el Query que desea ejecutar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdExecuteQuery);
            this.Controls.Add(this.querytxt);
            this.Controls.Add(this.grid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.TextBox querytxt;
        private System.Windows.Forms.Button cmdExecuteQuery;
        private System.Windows.Forms.Label label1;
    }
}

