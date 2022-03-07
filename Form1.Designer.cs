
namespace Assignment6._2
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
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.grpbxCarInfo = new System.Windows.Forms.GroupBox();
            this.lblCarVIN = new System.Windows.Forms.Label();
            this.txbxCarVIN = new System.Windows.Forms.TextBox();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.txbxCarMake = new System.Windows.Forms.TextBox();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.txbxCarModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxCarYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxCarPrice = new System.Windows.Forms.TextBox();
            this.btnCarAddRecord = new System.Windows.Forms.Button();
            this.btnCarSubmitRecord = new System.Windows.Forms.Button();
            this.btnCarSelectToUpdate = new System.Windows.Forms.Button();
            this.btnCarUpdateRecord = new System.Windows.Forms.Button();
            this.btnCarDeleteRecord = new System.Windows.Forms.Button();
            this.btnCarRefreshRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.grpbxCarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCars
            // 
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(39, 21);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.Size = new System.Drawing.Size(592, 163);
            this.dataGridCars.TabIndex = 12;
            // 
            // grpbxCarInfo
            // 
            this.grpbxCarInfo.Controls.Add(this.txbxCarPrice);
            this.grpbxCarInfo.Controls.Add(this.label4);
            this.grpbxCarInfo.Controls.Add(this.txbxCarYear);
            this.grpbxCarInfo.Controls.Add(this.label3);
            this.grpbxCarInfo.Controls.Add(this.txbxCarModel);
            this.grpbxCarInfo.Controls.Add(this.lblCarModel);
            this.grpbxCarInfo.Controls.Add(this.txbxCarMake);
            this.grpbxCarInfo.Controls.Add(this.lblCarMake);
            this.grpbxCarInfo.Controls.Add(this.txbxCarVIN);
            this.grpbxCarInfo.Controls.Add(this.lblCarVIN);
            this.grpbxCarInfo.Location = new System.Drawing.Point(39, 207);
            this.grpbxCarInfo.Name = "grpbxCarInfo";
            this.grpbxCarInfo.Size = new System.Drawing.Size(592, 89);
            this.grpbxCarInfo.TabIndex = 1;
            this.grpbxCarInfo.TabStop = false;
            this.grpbxCarInfo.Text = "Car Information";
            // 
            // lblCarVIN
            // 
            this.lblCarVIN.AutoSize = true;
            this.lblCarVIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCarVIN.Location = new System.Drawing.Point(36, 27);
            this.lblCarVIN.Name = "lblCarVIN";
            this.lblCarVIN.Size = new System.Drawing.Size(40, 13);
            this.lblCarVIN.TabIndex = 0;
            this.lblCarVIN.Text = "VIN #";
            // 
            // txbxCarVIN
            // 
            this.txbxCarVIN.Location = new System.Drawing.Point(6, 43);
            this.txbxCarVIN.Name = "txbxCarVIN";
            this.txbxCarVIN.Size = new System.Drawing.Size(100, 20);
            this.txbxCarVIN.TabIndex = 1;
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCarMake.Location = new System.Drawing.Point(152, 27);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(38, 13);
            this.lblCarMake.TabIndex = 0;
            this.lblCarMake.Text = "Make";
            // 
            // txbxCarMake
            // 
            this.txbxCarMake.Location = new System.Drawing.Point(123, 43);
            this.txbxCarMake.Name = "txbxCarMake";
            this.txbxCarMake.Size = new System.Drawing.Size(100, 20);
            this.txbxCarMake.TabIndex = 2;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCarModel.Location = new System.Drawing.Point(273, 27);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(41, 13);
            this.lblCarModel.TabIndex = 0;
            this.lblCarModel.Text = "Model";
            // 
            // txbxCarModel
            // 
            this.txbxCarModel.Location = new System.Drawing.Point(242, 43);
            this.txbxCarModel.Name = "txbxCarModel";
            this.txbxCarModel.Size = new System.Drawing.Size(100, 20);
            this.txbxCarModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(395, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year";
            // 
            // txbxCarYear
            // 
            this.txbxCarYear.Location = new System.Drawing.Point(362, 43);
            this.txbxCarYear.Name = "txbxCarYear";
            this.txbxCarYear.Size = new System.Drawing.Size(100, 20);
            this.txbxCarYear.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(519, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // txbxCarPrice
            // 
            this.txbxCarPrice.Location = new System.Drawing.Point(484, 43);
            this.txbxCarPrice.Name = "txbxCarPrice";
            this.txbxCarPrice.Size = new System.Drawing.Size(100, 20);
            this.txbxCarPrice.TabIndex = 5;
            // 
            // btnCarAddRecord
            // 
            this.btnCarAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarAddRecord.Location = new System.Drawing.Point(123, 320);
            this.btnCarAddRecord.Name = "btnCarAddRecord";
            this.btnCarAddRecord.Size = new System.Drawing.Size(111, 23);
            this.btnCarAddRecord.TabIndex = 6;
            this.btnCarAddRecord.Text = "Add Record";
            this.btnCarAddRecord.UseVisualStyleBackColor = true;
            this.btnCarAddRecord.Click += new System.EventHandler(this.btnCarAddRecord_Click);
            // 
            // btnCarSubmitRecord
            // 
            this.btnCarSubmitRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarSubmitRecord.Location = new System.Drawing.Point(123, 360);
            this.btnCarSubmitRecord.Name = "btnCarSubmitRecord";
            this.btnCarSubmitRecord.Size = new System.Drawing.Size(111, 23);
            this.btnCarSubmitRecord.TabIndex = 7;
            this.btnCarSubmitRecord.Text = "Submit Record";
            this.btnCarSubmitRecord.UseVisualStyleBackColor = true;
            this.btnCarSubmitRecord.Click += new System.EventHandler(this.btnCarSubmitRecord_Click);
            // 
            // btnCarSelectToUpdate
            // 
            this.btnCarSelectToUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarSelectToUpdate.Location = new System.Drawing.Point(281, 320);
            this.btnCarSelectToUpdate.Name = "btnCarSelectToUpdate";
            this.btnCarSelectToUpdate.Size = new System.Drawing.Size(111, 23);
            this.btnCarSelectToUpdate.TabIndex = 8;
            this.btnCarSelectToUpdate.Text = "Select to Update";
            this.btnCarSelectToUpdate.UseVisualStyleBackColor = true;
            this.btnCarSelectToUpdate.Click += new System.EventHandler(this.btnCarSelectToUpdate_Click);
            // 
            // btnCarUpdateRecord
            // 
            this.btnCarUpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarUpdateRecord.Location = new System.Drawing.Point(281, 360);
            this.btnCarUpdateRecord.Name = "btnCarUpdateRecord";
            this.btnCarUpdateRecord.Size = new System.Drawing.Size(111, 23);
            this.btnCarUpdateRecord.TabIndex = 9;
            this.btnCarUpdateRecord.Text = "Update Record";
            this.btnCarUpdateRecord.UseVisualStyleBackColor = true;
            this.btnCarUpdateRecord.Click += new System.EventHandler(this.btnCarUpdateRecord_Click);
            // 
            // btnCarDeleteRecord
            // 
            this.btnCarDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarDeleteRecord.Location = new System.Drawing.Point(442, 319);
            this.btnCarDeleteRecord.Name = "btnCarDeleteRecord";
            this.btnCarDeleteRecord.Size = new System.Drawing.Size(111, 23);
            this.btnCarDeleteRecord.TabIndex = 10;
            this.btnCarDeleteRecord.Text = "Delete Record";
            this.btnCarDeleteRecord.UseVisualStyleBackColor = true;
            this.btnCarDeleteRecord.Click += new System.EventHandler(this.btnCarDeleteRecord_Click);
            // 
            // btnCarRefreshRecord
            // 
            this.btnCarRefreshRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarRefreshRecord.Location = new System.Drawing.Point(442, 360);
            this.btnCarRefreshRecord.Name = "btnCarRefreshRecord";
            this.btnCarRefreshRecord.Size = new System.Drawing.Size(111, 23);
            this.btnCarRefreshRecord.TabIndex = 11;
            this.btnCarRefreshRecord.Text = "Refresh Record";
            this.btnCarRefreshRecord.UseVisualStyleBackColor = true;
            this.btnCarRefreshRecord.Click += new System.EventHandler(this.btnCarRefreshRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 430);
            this.Controls.Add(this.btnCarRefreshRecord);
            this.Controls.Add(this.grpbxCarInfo);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.btnCarDeleteRecord);
            this.Controls.Add(this.btnCarSelectToUpdate);
            this.Controls.Add(this.btnCarAddRecord);
            this.Controls.Add(this.btnCarUpdateRecord);
            this.Controls.Add(this.btnCarSubmitRecord);
            this.Name = "Form1";
            this.Text = "Car Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.grpbxCarInfo.ResumeLayout(false);
            this.grpbxCarInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.GroupBox grpbxCarInfo;
        private System.Windows.Forms.TextBox txbxCarPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxCarYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxCarModel;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txbxCarMake;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.TextBox txbxCarVIN;
        private System.Windows.Forms.Label lblCarVIN;
        private System.Windows.Forms.Button btnCarAddRecord;
        private System.Windows.Forms.Button btnCarSubmitRecord;
        private System.Windows.Forms.Button btnCarSelectToUpdate;
        private System.Windows.Forms.Button btnCarUpdateRecord;
        private System.Windows.Forms.Button btnCarDeleteRecord;
        private System.Windows.Forms.Button btnCarRefreshRecord;
    }
}

