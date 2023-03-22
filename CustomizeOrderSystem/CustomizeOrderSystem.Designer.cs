
namespace CustomizeOrderSystem
{
    partial class CustomizeOrderSystem
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
            this.txt_OrderNo = new System.Windows.Forms.TextBox();
            this.txt_OrderDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_INSERT = new System.Windows.Forms.Button();
            this.btn_SHOWDATA = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_OrderNo
            // 
            this.txt_OrderNo.Location = new System.Drawing.Point(111, 96);
            this.txt_OrderNo.Name = "txt_OrderNo";
            this.txt_OrderNo.Size = new System.Drawing.Size(151, 20);
            this.txt_OrderNo.TabIndex = 0;
            // 
            // txt_OrderDetail
            // 
            this.txt_OrderDetail.Location = new System.Drawing.Point(111, 138);
            this.txt_OrderDetail.Name = "txt_OrderDetail";
            this.txt_OrderDetail.Size = new System.Drawing.Size(151, 20);
            this.txt_OrderDetail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMIZE ORDER SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "OrderDetail : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "OrderNo :";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(38, 216);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(433, 170);
            this.dgv.TabIndex = 6;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btn_INSERT
            // 
            this.btn_INSERT.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_INSERT.Location = new System.Drawing.Point(525, 135);
            this.btn_INSERT.Name = "btn_INSERT";
            this.btn_INSERT.Size = new System.Drawing.Size(93, 23);
            this.btn_INSERT.TabIndex = 3;
            this.btn_INSERT.Text = "INSERT";
            this.btn_INSERT.UseVisualStyleBackColor = false;
            this.btn_INSERT.Click += new System.EventHandler(this.btn_INSERT_Click);
            // 
            // btn_SHOWDATA
            // 
            this.btn_SHOWDATA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_SHOWDATA.ForeColor = System.Drawing.Color.Black;
            this.btn_SHOWDATA.Location = new System.Drawing.Point(525, 97);
            this.btn_SHOWDATA.Name = "btn_SHOWDATA";
            this.btn_SHOWDATA.Size = new System.Drawing.Size(93, 23);
            this.btn_SHOWDATA.TabIndex = 2;
            this.btn_SHOWDATA.Text = "SHOW DATA";
            this.btn_SHOWDATA.UseVisualStyleBackColor = false;
            this.btn_SHOWDATA.Click += new System.EventHandler(this.btn_SHOWDATA_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.BackColor = System.Drawing.Color.Red;
            this.btn_DELETE.Location = new System.Drawing.Point(525, 173);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(93, 23);
            this.btn_DELETE.TabIndex = 4;
            this.btn_DELETE.Text = "DELETE";
            this.btn_DELETE.UseVisualStyleBackColor = false;
            this.btn_DELETE.Click += new System.EventHandler(this.btn_DELETE_Click);
            // 
            // CustomizeOrderSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_SHOWDATA);
            this.Controls.Add(this.btn_INSERT);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_OrderDetail);
            this.Controls.Add(this.txt_OrderNo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CustomizeOrderSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomizeOrderSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_OrderNo;
        private System.Windows.Forms.TextBox txt_OrderDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_INSERT;
        private System.Windows.Forms.Button btn_SHOWDATA;
        private System.Windows.Forms.Button btn_DELETE;
    }
}