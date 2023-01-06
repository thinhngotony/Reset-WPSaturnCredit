
namespace deleteAllFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotFound = new System.Windows.Forms.TextBox();
            this.ckbCancelMode = new System.Windows.Forms.CheckBox();
            this.ckbLastOutputId = new System.Windows.Forms.CheckBox();
            this.ckbLastSettlementBrandCode = new System.Windows.Forms.CheckBox();
            this.ckbLastSettlementSeqNo = new System.Windows.Forms.CheckBox();
            this.ckbLastTransactionInquiry = new System.Windows.Forms.CheckBox();
            this.ckbJournal = new System.Windows.Forms.CheckBox();
            this.ckbtoPos = new System.Windows.Forms.CheckBox();
            this.ckbLog = new System.Windows.Forms.CheckBox();
            this.ckbWPSaturnEMoney = new System.Windows.Forms.CheckBox();
            this.txtNotify = new System.Windows.Forms.TextBox();
            this.txtFromPos = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAutoEnter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbWPSaturnCredit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(517, 65);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Reset";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(12, 83);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(517, 26);
            this.txtPath.TabIndex = 1;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(12, 128);
            this.txtDelete.Multiline = true;
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDelete.Size = new System.Drawing.Size(273, 114);
            this.txtDelete.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deleted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NotFound";
            // 
            // txtNotFound
            // 
            this.txtNotFound.Location = new System.Drawing.Point(291, 128);
            this.txtNotFound.Multiline = true;
            this.txtNotFound.Name = "txtNotFound";
            this.txtNotFound.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotFound.Size = new System.Drawing.Size(238, 114);
            this.txtNotFound.TabIndex = 4;
            // 
            // ckbCancelMode
            // 
            this.ckbCancelMode.AutoSize = true;
            this.ckbCancelMode.Checked = true;
            this.ckbCancelMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCancelMode.Location = new System.Drawing.Point(546, 12);
            this.ckbCancelMode.Name = "ckbCancelMode";
            this.ckbCancelMode.Size = new System.Drawing.Size(86, 17);
            this.ckbCancelMode.TabIndex = 6;
            this.ckbCancelMode.Text = "CancelMode";
            this.ckbCancelMode.UseVisualStyleBackColor = true;
            // 
            // ckbLastOutputId
            // 
            this.ckbLastOutputId.AutoSize = true;
            this.ckbLastOutputId.Checked = true;
            this.ckbLastOutputId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLastOutputId.Location = new System.Drawing.Point(546, 37);
            this.ckbLastOutputId.Name = "ckbLastOutputId";
            this.ckbLastOutputId.Size = new System.Drawing.Size(87, 17);
            this.ckbLastOutputId.TabIndex = 7;
            this.ckbLastOutputId.Text = "LastOutputId";
            this.ckbLastOutputId.UseVisualStyleBackColor = true;
            // 
            // ckbLastSettlementBrandCode
            // 
            this.ckbLastSettlementBrandCode.AutoSize = true;
            this.ckbLastSettlementBrandCode.Checked = true;
            this.ckbLastSettlementBrandCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLastSettlementBrandCode.Location = new System.Drawing.Point(546, 62);
            this.ckbLastSettlementBrandCode.Name = "ckbLastSettlementBrandCode";
            this.ckbLastSettlementBrandCode.Size = new System.Drawing.Size(149, 17);
            this.ckbLastSettlementBrandCode.TabIndex = 8;
            this.ckbLastSettlementBrandCode.Text = "LastSettlementBrandCode";
            this.ckbLastSettlementBrandCode.UseVisualStyleBackColor = true;
            // 
            // ckbLastSettlementSeqNo
            // 
            this.ckbLastSettlementSeqNo.AutoSize = true;
            this.ckbLastSettlementSeqNo.Checked = true;
            this.ckbLastSettlementSeqNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLastSettlementSeqNo.Location = new System.Drawing.Point(546, 87);
            this.ckbLastSettlementSeqNo.Name = "ckbLastSettlementSeqNo";
            this.ckbLastSettlementSeqNo.Size = new System.Drawing.Size(129, 17);
            this.ckbLastSettlementSeqNo.TabIndex = 9;
            this.ckbLastSettlementSeqNo.Text = "LastSettlementSeqNo";
            this.ckbLastSettlementSeqNo.UseVisualStyleBackColor = true;
            // 
            // ckbLastTransactionInquiry
            // 
            this.ckbLastTransactionInquiry.AutoSize = true;
            this.ckbLastTransactionInquiry.Checked = true;
            this.ckbLastTransactionInquiry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbLastTransactionInquiry.Location = new System.Drawing.Point(546, 112);
            this.ckbLastTransactionInquiry.Name = "ckbLastTransactionInquiry";
            this.ckbLastTransactionInquiry.Size = new System.Drawing.Size(133, 17);
            this.ckbLastTransactionInquiry.TabIndex = 10;
            this.ckbLastTransactionInquiry.Text = "LastTransactionInquiry";
            this.ckbLastTransactionInquiry.UseVisualStyleBackColor = true;
            // 
            // ckbJournal
            // 
            this.ckbJournal.AutoSize = true;
            this.ckbJournal.Location = new System.Drawing.Point(546, 137);
            this.ckbJournal.Name = "ckbJournal";
            this.ckbJournal.Size = new System.Drawing.Size(60, 17);
            this.ckbJournal.TabIndex = 12;
            this.ckbJournal.Text = "Journal";
            this.ckbJournal.UseVisualStyleBackColor = true;
            // 
            // ckbtoPos
            // 
            this.ckbtoPos.AutoSize = true;
            this.ckbtoPos.Checked = true;
            this.ckbtoPos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbtoPos.Location = new System.Drawing.Point(546, 162);
            this.ckbtoPos.Name = "ckbtoPos";
            this.ckbtoPos.Size = new System.Drawing.Size(53, 17);
            this.ckbtoPos.TabIndex = 13;
            this.ckbtoPos.Text = "toPos";
            this.ckbtoPos.UseVisualStyleBackColor = true;
            // 
            // ckbLog
            // 
            this.ckbLog.AutoSize = true;
            this.ckbLog.Location = new System.Drawing.Point(546, 183);
            this.ckbLog.Name = "ckbLog";
            this.ckbLog.Size = new System.Drawing.Size(44, 17);
            this.ckbLog.TabIndex = 14;
            this.ckbLog.Text = "Log";
            this.ckbLog.UseVisualStyleBackColor = true;
            // 
            // ckbWPSaturnEMoney
            // 
            this.ckbWPSaturnEMoney.AutoSize = true;
            this.ckbWPSaturnEMoney.Checked = true;
            this.ckbWPSaturnEMoney.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbWPSaturnEMoney.Location = new System.Drawing.Point(546, 206);
            this.ckbWPSaturnEMoney.Name = "ckbWPSaturnEMoney";
            this.ckbWPSaturnEMoney.Size = new System.Drawing.Size(134, 17);
            this.ckbWPSaturnEMoney.TabIndex = 15;
            this.ckbWPSaturnEMoney.Text = "WPSaturnEMoney.exe";
            this.ckbWPSaturnEMoney.UseVisualStyleBackColor = true;
            // 
            // txtNotify
            // 
            this.txtNotify.Location = new System.Drawing.Point(15, 284);
            this.txtNotify.Multiline = true;
            this.txtNotify.Name = "txtNotify";
            this.txtNotify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotify.Size = new System.Drawing.Size(360, 114);
            this.txtNotify.TabIndex = 17;
            // 
            // txtFromPos
            // 
            this.txtFromPos.Location = new System.Drawing.Point(378, 284);
            this.txtFromPos.Multiline = true;
            this.txtFromPos.Name = "txtFromPos";
            this.txtFromPos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFromPos.Size = new System.Drawing.Size(317, 114);
            this.txtFromPos.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(88, 255);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(441, 26);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Search";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAutoEnter
            // 
            this.txtAutoEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoEnter.Location = new System.Drawing.Point(546, 255);
            this.txtAutoEnter.Name = "txtAutoEnter";
            this.txtAutoEnter.Size = new System.Drawing.Size(108, 26);
            this.txtAutoEnter.TabIndex = 21;
            this.txtAutoEnter.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "ms";
            // 
            // ckbWPSaturnCredit
            // 
            this.ckbWPSaturnCredit.AutoSize = true;
            this.ckbWPSaturnCredit.Checked = true;
            this.ckbWPSaturnCredit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbWPSaturnCredit.Location = new System.Drawing.Point(546, 229);
            this.ckbWPSaturnCredit.Name = "ckbWPSaturnCredit";
            this.ckbWPSaturnCredit.Size = new System.Drawing.Size(122, 17);
            this.ckbWPSaturnCredit.TabIndex = 23;
            this.ckbWPSaturnCredit.Text = "WPSaturnCredit.exe";
            this.ckbWPSaturnCredit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 401);
            this.Controls.Add(this.ckbWPSaturnCredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutoEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtFromPos);
            this.Controls.Add(this.txtNotify);
            this.Controls.Add(this.ckbWPSaturnEMoney);
            this.Controls.Add(this.ckbLog);
            this.Controls.Add(this.ckbtoPos);
            this.Controls.Add(this.ckbJournal);
            this.Controls.Add(this.ckbLastTransactionInquiry);
            this.Controls.Add(this.ckbLastSettlementSeqNo);
            this.Controls.Add(this.ckbLastSettlementBrandCode);
            this.Controls.Add(this.ckbLastOutputId);
            this.Controls.Add(this.ckbCancelMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reset all file in Emoney";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotFound;
        private System.Windows.Forms.CheckBox ckbCancelMode;
        private System.Windows.Forms.CheckBox ckbLastOutputId;
        private System.Windows.Forms.CheckBox ckbLastSettlementBrandCode;
        private System.Windows.Forms.CheckBox ckbLastSettlementSeqNo;
        private System.Windows.Forms.CheckBox ckbLastTransactionInquiry;
        private System.Windows.Forms.CheckBox ckbJournal;
        private System.Windows.Forms.CheckBox ckbtoPos;
        private System.Windows.Forms.CheckBox ckbLog;
        private System.Windows.Forms.CheckBox ckbWPSaturnEMoney;
        private System.Windows.Forms.TextBox txtNotify;
        private System.Windows.Forms.TextBox txtFromPos;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAutoEnter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbWPSaturnCredit;
    }
}

