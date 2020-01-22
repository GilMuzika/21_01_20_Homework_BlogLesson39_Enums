namespace _21_01_20_Homework_BlogLesson39_Enums
{
    partial class MainForm
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
            this.pnlElevatorPanel = new System.Windows.Forms.Panel();
            this.btnGoToFloor = new System.Windows.Forms.Button();
            this.cmbSelectFloor = new System.Windows.Forms.ComboBox();
            this.lblEnumResult = new System.Windows.Forms.Label();
            this.btnPrintAllNotIncluded = new System.Windows.Forms.Button();
            this.cmbDaysEnum = new System.Windows.Forms.ComboBox();
            this.btnCreateEnumeration = new System.Windows.Forms.Button();
            this.btnAddvalueToEnum = new System.Windows.Forms.Button();
            this.btnRemoveValueFromEnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlElevatorPanel
            // 
            this.pnlElevatorPanel.Location = new System.Drawing.Point(583, 70);
            this.pnlElevatorPanel.Name = "pnlElevatorPanel";
            this.pnlElevatorPanel.Size = new System.Drawing.Size(45, 57);
            this.pnlElevatorPanel.TabIndex = 0;
            // 
            // btnGoToFloor
            // 
            this.btnGoToFloor.Location = new System.Drawing.Point(484, 31);
            this.btnGoToFloor.Name = "btnGoToFloor";
            this.btnGoToFloor.Size = new System.Drawing.Size(75, 23);
            this.btnGoToFloor.TabIndex = 1;
            this.btnGoToFloor.Text = "Go to floor";
            this.btnGoToFloor.UseVisualStyleBackColor = true;
            this.btnGoToFloor.Click += new System.EventHandler(this.btnTest_Click_1);
            // 
            // cmbSelectFloor
            // 
            this.cmbSelectFloor.FormattingEnabled = true;
            this.cmbSelectFloor.Location = new System.Drawing.Point(565, 31);
            this.cmbSelectFloor.Name = "cmbSelectFloor";
            this.cmbSelectFloor.Size = new System.Drawing.Size(63, 21);
            this.cmbSelectFloor.TabIndex = 3;
            // 
            // lblEnumResult
            // 
            this.lblEnumResult.AutoSize = true;
            this.lblEnumResult.Location = new System.Drawing.Point(157, 16);
            this.lblEnumResult.Name = "lblEnumResult";
            this.lblEnumResult.Size = new System.Drawing.Size(74, 13);
            this.lblEnumResult.TabIndex = 4;
            this.lblEnumResult.Text = "lblEnumResult";
            // 
            // btnPrintAllNotIncluded
            // 
            this.btnPrintAllNotIncluded.Location = new System.Drawing.Point(15, 140);
            this.btnPrintAllNotIncluded.Name = "btnPrintAllNotIncluded";
            this.btnPrintAllNotIncluded.Size = new System.Drawing.Size(129, 23);
            this.btnPrintAllNotIncluded.TabIndex = 5;
            this.btnPrintAllNotIncluded.Text = "Print all not included";
            this.btnPrintAllNotIncluded.UseVisualStyleBackColor = true;
            this.btnPrintAllNotIncluded.Click += new System.EventHandler(this.btnPrintAllNotIncluded_Click);
            // 
            // cmbDaysEnum
            // 
            this.cmbDaysEnum.FormattingEnabled = true;
            this.cmbDaysEnum.Location = new System.Drawing.Point(12, 13);
            this.cmbDaysEnum.Name = "cmbDaysEnum";
            this.cmbDaysEnum.Size = new System.Drawing.Size(121, 21);
            this.cmbDaysEnum.TabIndex = 6;
            // 
            // btnCreateEnumeration
            // 
            this.btnCreateEnumeration.Location = new System.Drawing.Point(15, 53);
            this.btnCreateEnumeration.Name = "btnCreateEnumeration";
            this.btnCreateEnumeration.Size = new System.Drawing.Size(129, 23);
            this.btnCreateEnumeration.TabIndex = 7;
            this.btnCreateEnumeration.Text = "Create enumeration";
            this.btnCreateEnumeration.UseVisualStyleBackColor = true;
            this.btnCreateEnumeration.Click += new System.EventHandler(this.btnCreateEnumeration_Click);
            // 
            // btnAddvalueToEnum
            // 
            this.btnAddvalueToEnum.Location = new System.Drawing.Point(15, 82);
            this.btnAddvalueToEnum.Name = "btnAddvalueToEnum";
            this.btnAddvalueToEnum.Size = new System.Drawing.Size(129, 23);
            this.btnAddvalueToEnum.TabIndex = 8;
            this.btnAddvalueToEnum.Text = "Add value to the Enum";
            this.btnAddvalueToEnum.UseVisualStyleBackColor = true;
            this.btnAddvalueToEnum.Click += new System.EventHandler(this.cmbAddvalueToEnum_Click);
            // 
            // btnRemoveValueFromEnum
            // 
            this.btnRemoveValueFromEnum.Location = new System.Drawing.Point(15, 111);
            this.btnRemoveValueFromEnum.Name = "btnRemoveValueFromEnum";
            this.btnRemoveValueFromEnum.Size = new System.Drawing.Size(129, 23);
            this.btnRemoveValueFromEnum.TabIndex = 9;
            this.btnRemoveValueFromEnum.Text = "Remove from Enum";
            this.btnRemoveValueFromEnum.UseVisualStyleBackColor = true;
            this.btnRemoveValueFromEnum.Click += new System.EventHandler(this.btnRemoveValueFromEnum_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveValueFromEnum);
            this.Controls.Add(this.btnAddvalueToEnum);
            this.Controls.Add(this.btnCreateEnumeration);
            this.Controls.Add(this.cmbDaysEnum);
            this.Controls.Add(this.btnPrintAllNotIncluded);
            this.Controls.Add(this.lblEnumResult);
            this.Controls.Add(this.cmbSelectFloor);
            this.Controls.Add(this.btnGoToFloor);
            this.Controls.Add(this.pnlElevatorPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlElevatorPanel;
        private System.Windows.Forms.Button btnGoToFloor;
        private System.Windows.Forms.ComboBox cmbSelectFloor;
        private System.Windows.Forms.Label lblEnumResult;
        private System.Windows.Forms.Button btnPrintAllNotIncluded;
        private System.Windows.Forms.ComboBox cmbDaysEnum;
        private System.Windows.Forms.Button btnCreateEnumeration;
        private System.Windows.Forms.Button btnAddvalueToEnum;
        private System.Windows.Forms.Button btnRemoveValueFromEnum;
    }
}

