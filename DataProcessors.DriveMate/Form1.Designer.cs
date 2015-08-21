namespace DataProcessors.DriveMate
{
    partial class frmMainForm
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
            this.lblOrigin = new System.Windows.Forms.Label();
            this.LblDestination = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblWayPoints = new System.Windows.Forms.Label();
            this.txtWaypoints = new System.Windows.Forms.TextBox();
            this.lblAlternatives = new System.Windows.Forms.Label();
            this.btnFindDirections = new System.Windows.Forms.Button();
            this.pnlAlternatives = new System.Windows.Forms.Panel();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlAlternatives.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(12, 34);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(69, 13);
            this.lblOrigin.TabIndex = 0;
            this.lblOrigin.Text = "Origin (From):";
            // 
            // LblDestination
            // 
            this.LblDestination.AutoSize = true;
            this.LblDestination.Location = new System.Drawing.Point(15, 78);
            this.LblDestination.Name = "LblDestination";
            this.LblDestination.Size = new System.Drawing.Size(85, 13);
            this.LblDestination.TabIndex = 1;
            this.LblDestination.Text = "Destination (To):";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(115, 31);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(197, 20);
            this.txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(115, 76);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(197, 20);
            this.txtTo.TabIndex = 3;
            // 
            // lblWayPoints
            // 
            this.lblWayPoints.AutoSize = true;
            this.lblWayPoints.Location = new System.Drawing.Point(15, 130);
            this.lblWayPoints.Name = "lblWayPoints";
            this.lblWayPoints.Size = new System.Drawing.Size(57, 13);
            this.lblWayPoints.TabIndex = 4;
            this.lblWayPoints.Text = "Waypoints";
            // 
            // txtWaypoints
            // 
            this.txtWaypoints.Location = new System.Drawing.Point(115, 130);
            this.txtWaypoints.Name = "txtWaypoints";
            this.txtWaypoints.Size = new System.Drawing.Size(197, 20);
            this.txtWaypoints.TabIndex = 5;
            // 
            // lblAlternatives
            // 
            this.lblAlternatives.AutoSize = true;
            this.lblAlternatives.Location = new System.Drawing.Point(15, 181);
            this.lblAlternatives.Name = "lblAlternatives";
            this.lblAlternatives.Size = new System.Drawing.Size(65, 13);
            this.lblAlternatives.TabIndex = 6;
            this.lblAlternatives.Text = "Alternatives:";
            // 
            // btnFindDirections
            // 
            this.btnFindDirections.Location = new System.Drawing.Point(164, 213);
            this.btnFindDirections.Name = "btnFindDirections";
            this.btnFindDirections.Size = new System.Drawing.Size(75, 45);
            this.btnFindDirections.TabIndex = 9;
            this.btnFindDirections.Text = "Find Directions";
            this.btnFindDirections.UseVisualStyleBackColor = true;
            this.btnFindDirections.Click += new System.EventHandler(this.btnFindDirections_Click);
            // 
            // pnlAlternatives
            // 
            this.pnlAlternatives.Controls.Add(this.radioNo);
            this.pnlAlternatives.Controls.Add(this.radioYes);
            this.pnlAlternatives.Location = new System.Drawing.Point(115, 171);
            this.pnlAlternatives.Name = "pnlAlternatives";
            this.pnlAlternatives.Size = new System.Drawing.Size(200, 30);
            this.pnlAlternatives.TabIndex = 11;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Checked = true;
            this.radioNo.Location = new System.Drawing.Point(83, 8);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 1;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(4, 6);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(43, 17);
            this.radioYes.TabIndex = 0;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(115, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 12;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 270);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlAlternatives);
            this.Controls.Add(this.btnFindDirections);
            this.Controls.Add(this.lblAlternatives);
            this.Controls.Add(this.txtWaypoints);
            this.Controls.Add(this.lblWayPoints);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.LblDestination);
            this.Controls.Add(this.lblOrigin);
            this.Name = "frmMainForm";
            this.Text = "DriveMate";
            this.pnlAlternatives.ResumeLayout(false);
            this.pnlAlternatives.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label LblDestination;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblWayPoints;
        private System.Windows.Forms.TextBox txtWaypoints;
        private System.Windows.Forms.Label lblAlternatives;
        private System.Windows.Forms.Button btnFindDirections;
        private System.Windows.Forms.Panel pnlAlternatives;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.Label lblStatus;
    }
}

