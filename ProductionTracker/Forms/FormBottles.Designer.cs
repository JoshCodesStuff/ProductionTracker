
namespace ProductionTracker.Forms
{
    partial class FormBottles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numLotCount = new System.Windows.Forms.NumericUpDown();
            this.btnInsertToDB = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.labelPrevRuns = new System.Windows.Forms.Label();
            this.labelDateSearch = new System.Windows.Forms.Label();
            this.dateSearchCB = new System.Windows.Forms.ComboBox();
            this.productSearchCB = new System.Windows.Forms.ComboBox();
            this.labelProductSearch = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelLotCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLotCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelLotCount);
            this.panel1.Controls.Add(this.labelEndTime);
            this.panel1.Controls.Add(this.labelStartTime);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.txtStart);
            this.panel1.Controls.Add(this.numLotCount);
            this.panel1.Controls.Add(this.btnInsertToDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 70);
            this.panel1.TabIndex = 5;
            // 
            // numLotCount
            // 
            this.numLotCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numLotCount.Location = new System.Drawing.Point(776, 29);
            this.numLotCount.Name = "numLotCount";
            this.numLotCount.Size = new System.Drawing.Size(120, 20);
            this.numLotCount.TabIndex = 22;
            // 
            // btnInsertToDB
            // 
            this.btnInsertToDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertToDB.BackColor = System.Drawing.Color.White;
            this.btnInsertToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToDB.Location = new System.Drawing.Point(957, 27);
            this.btnInsertToDB.Name = "btnInsertToDB";
            this.btnInsertToDB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertToDB.TabIndex = 18;
            this.btnInsertToDB.Text = "Insert";
            this.btnInsertToDB.UseVisualStyleBackColor = false;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(70, 40);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(935, 898);
            this.dgvData.TabIndex = 16;
            // 
            // labelPrevRuns
            // 
            this.labelPrevRuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPrevRuns.AutoSize = true;
            this.labelPrevRuns.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrevRuns.ForeColor = System.Drawing.Color.Black;
            this.labelPrevRuns.Location = new System.Drawing.Point(140, 8);
            this.labelPrevRuns.Name = "labelPrevRuns";
            this.labelPrevRuns.Size = new System.Drawing.Size(188, 20);
            this.labelPrevRuns.TabIndex = 17;
            this.labelPrevRuns.Text = "Search Previous Runs By:";
            // 
            // labelDateSearch
            // 
            this.labelDateSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDateSearch.AutoSize = true;
            this.labelDateSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateSearch.ForeColor = System.Drawing.Color.Black;
            this.labelDateSearch.Location = new System.Drawing.Point(366, 13);
            this.labelDateSearch.Name = "labelDateSearch";
            this.labelDateSearch.Size = new System.Drawing.Size(41, 17);
            this.labelDateSearch.TabIndex = 18;
            this.labelDateSearch.Text = "Date:";
            // 
            // dateSearchCB
            // 
            this.dateSearchCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateSearchCB.BackColor = System.Drawing.Color.White;
            this.dateSearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateSearchCB.ForeColor = System.Drawing.Color.Black;
            this.dateSearchCB.FormattingEnabled = true;
            this.dateSearchCB.Location = new System.Drawing.Point(413, 9);
            this.dateSearchCB.Name = "dateSearchCB";
            this.dateSearchCB.Size = new System.Drawing.Size(121, 21);
            this.dateSearchCB.TabIndex = 19;
            // 
            // productSearchCB
            // 
            this.productSearchCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.productSearchCB.BackColor = System.Drawing.Color.White;
            this.productSearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productSearchCB.ForeColor = System.Drawing.Color.Black;
            this.productSearchCB.FormattingEnabled = true;
            this.productSearchCB.Location = new System.Drawing.Point(658, 9);
            this.productSearchCB.Name = "productSearchCB";
            this.productSearchCB.Size = new System.Drawing.Size(121, 21);
            this.productSearchCB.TabIndex = 20;
            // 
            // labelProductSearch
            // 
            this.labelProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelProductSearch.AutoSize = true;
            this.labelProductSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductSearch.ForeColor = System.Drawing.Color.Black;
            this.labelProductSearch.Location = new System.Drawing.Point(594, 13);
            this.labelProductSearch.Name = "labelProductSearch";
            this.labelProductSearch.Size = new System.Drawing.Size(58, 17);
            this.labelProductSearch.TabIndex = 21;
            this.labelProductSearch.Text = "Product:";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.BackColor = System.Drawing.Color.Black;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(840, 7);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // txtStart
            // 
            this.txtStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStart.Location = new System.Drawing.Point(291, 30);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 20;
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnd.Location = new System.Drawing.Point(511, 29);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 21;
            // 
            // labelStartTime
            // 
            this.labelStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.White;
            this.labelStartTime.Location = new System.Drawing.Point(193, 32);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(76, 20);
            this.labelStartTime.TabIndex = 23;
            this.labelStartTime.Text = "Start Time";
            // 
            // labelEndTime
            // 
            this.labelEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.ForeColor = System.Drawing.Color.White;
            this.labelEndTime.Location = new System.Drawing.Point(424, 30);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(71, 20);
            this.labelEndTime.TabIndex = 24;
            this.labelEndTime.Text = "End Time";
            // 
            // labelLotCount
            // 
            this.labelLotCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLotCount.AutoSize = true;
            this.labelLotCount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLotCount.ForeColor = System.Drawing.Color.White;
            this.labelLotCount.Location = new System.Drawing.Point(665, 28);
            this.labelLotCount.Name = "labelLotCount";
            this.labelLotCount.Size = new System.Drawing.Size(80, 20);
            this.labelLotCount.TabIndex = 25;
            this.labelLotCount.Text = "Lot Count";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDateSearch);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Controls.Add(this.labelProductSearch);
            this.panel2.Controls.Add(this.labelPrevRuns);
            this.panel2.Controls.Add(this.productSearchCB);
            this.panel2.Controls.Add(this.dateSearchCB);
            this.panel2.Location = new System.Drawing.Point(45, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 552);
            this.panel2.TabIndex = 23;
            // 
            // FormBottles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormBottles";
            this.Text = "Bottling";
            this.Load += new System.EventHandler(this.FormBottles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLotCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label labelPrevRuns;
        private System.Windows.Forms.Label labelDateSearch;
        private System.Windows.Forms.ComboBox dateSearchCB;
        private System.Windows.Forms.ComboBox productSearchCB;
        private System.Windows.Forms.Label labelProductSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button btnInsertToDB;
        private System.Windows.Forms.NumericUpDown numLotCount;
        private System.Windows.Forms.Label labelLotCount;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Panel panel2;
    }
}