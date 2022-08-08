
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
            this.productLabel = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertToDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bottlesCbx = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.productSelectComBox = new System.Windows.Forms.ComboBox();
            this.startTxtBox = new System.Windows.Forms.TextBox();
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.endTxtBox = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.labelPrevRuns = new System.Windows.Forms.Label();
            this.labelDateSearch = new System.Windows.Forms.Label();
            this.dateSearchCB = new System.Windows.Forms.ComboBox();
            this.productSearchCB = new System.Windows.Forms.ComboBox();
            this.labelProductSearch = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productLabel.AutoSize = true;
            this.productLabel.BackColor = System.Drawing.Color.Black;
            this.productLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.ForeColor = System.Drawing.Color.White;
            this.productLabel.Location = new System.Drawing.Point(547, 9);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(113, 18);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Product Name";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Black;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(55, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(101, 18);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Today\'s Date";
            // 
            // labelStart
            // 
            this.labelStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Black;
            this.labelStart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.Color.White;
            this.labelStart.Location = new System.Drawing.Point(224, 9);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(77, 18);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "Start Time";
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.Black;
            this.labelEnd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.ForeColor = System.Drawing.Color.White;
            this.labelEnd.Location = new System.Drawing.Point(404, 9);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(73, 18);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "End Time";
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Black;
            this.labelAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(694, 9);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(141, 18);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount Produced";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnInsertToDB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bottlesCbx);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Controls.Add(this.labelEnd);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.productLabel);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.productSelectComBox);
            this.panel1.Controls.Add(this.startTxtBox);
            this.panel1.Controls.Add(this.amountTxtBox);
            this.panel1.Controls.Add(this.endTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 70);
            this.panel1.TabIndex = 5;
            // 
            // btnInsertToDB
            // 
            this.btnInsertToDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertToDB.BackColor = System.Drawing.Color.White;
            this.btnInsertToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToDB.Location = new System.Drawing.Point(1016, 28);
            this.btnInsertToDB.Name = "btnInsertToDB";
            this.btnInsertToDB.Size = new System.Drawing.Size(75, 23);
            this.btnInsertToDB.TabIndex = 18;
            this.btnInsertToDB.Text = "Insert";
            this.btnInsertToDB.UseVisualStyleBackColor = false;
            this.btnInsertToDB.Click += new System.EventHandler(this.btnInsertToDB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(886, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bottle Used";
            // 
            // bottlesCbx
            // 
            this.bottlesCbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bottlesCbx.FormattingEnabled = true;
            this.bottlesCbx.Location = new System.Drawing.Point(872, 40);
            this.bottlesCbx.Name = "bottlesCbx";
            this.bottlesCbx.Size = new System.Drawing.Size(121, 21);
            this.bottlesCbx.TabIndex = 16;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.CalendarForeColor = System.Drawing.Color.White;
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.Black;
            this.datePicker.Location = new System.Drawing.Point(20, 42);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(150, 20);
            this.datePicker.TabIndex = 14;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // productSelectComBox
            // 
            this.productSelectComBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productSelectComBox.BackColor = System.Drawing.Color.White;
            this.productSelectComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productSelectComBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSelectComBox.ForeColor = System.Drawing.Color.Black;
            this.productSelectComBox.FormattingEnabled = true;
            this.productSelectComBox.Location = new System.Drawing.Point(539, 40);
            this.productSelectComBox.Name = "productSelectComBox";
            this.productSelectComBox.Size = new System.Drawing.Size(121, 21);
            this.productSelectComBox.TabIndex = 15;
            // 
            // startTxtBox
            // 
            this.startTxtBox.AcceptsTab = true;
            this.startTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTxtBox.BackColor = System.Drawing.Color.White;
            this.startTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startTxtBox.ForeColor = System.Drawing.Color.Black;
            this.startTxtBox.Location = new System.Drawing.Point(192, 41);
            this.startTxtBox.Name = "startTxtBox";
            this.startTxtBox.Size = new System.Drawing.Size(150, 20);
            this.startTxtBox.TabIndex = 13;
            this.startTxtBox.TextChanged += new System.EventHandler(this.startTxtBox_TextChanged);
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.AcceptsTab = true;
            this.amountTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountTxtBox.BackColor = System.Drawing.Color.White;
            this.amountTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTxtBox.ForeColor = System.Drawing.Color.Black;
            this.amountTxtBox.Location = new System.Drawing.Point(685, 40);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(150, 20);
            this.amountTxtBox.TabIndex = 8;
            this.amountTxtBox.TextChanged += new System.EventHandler(this.amountTxtBox_TextChanged);
            // 
            // endTxtBox
            // 
            this.endTxtBox.AcceptsTab = true;
            this.endTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTxtBox.BackColor = System.Drawing.Color.White;
            this.endTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endTxtBox.ForeColor = System.Drawing.Color.Black;
            this.endTxtBox.Location = new System.Drawing.Point(363, 41);
            this.endTxtBox.Name = "endTxtBox";
            this.endTxtBox.Size = new System.Drawing.Size(150, 20);
            this.endTxtBox.TabIndex = 12;
            this.endTxtBox.TextChanged += new System.EventHandler(this.endTxtBox_TextChanged);
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(97, 119);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(935, 349);
            this.dgvData.TabIndex = 16;
            // 
            // labelPrevRuns
            // 
            this.labelPrevRuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPrevRuns.AutoSize = true;
            this.labelPrevRuns.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrevRuns.ForeColor = System.Drawing.Color.Black;
            this.labelPrevRuns.Location = new System.Drawing.Point(93, 97);
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
            this.labelDateSearch.Location = new System.Drawing.Point(422, 96);
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
            this.dateSearchCB.Location = new System.Drawing.Point(469, 94);
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
            this.productSearchCB.Location = new System.Drawing.Point(714, 94);
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
            this.labelProductSearch.Location = new System.Drawing.Point(650, 95);
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
            this.searchBtn.Location = new System.Drawing.Point(957, 92);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // FormBottles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 480);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.labelProductSearch);
            this.Controls.Add(this.productSearchCB);
            this.Controls.Add(this.dateSearchCB);
            this.Controls.Add(this.labelDateSearch);
            this.Controls.Add(this.labelPrevRuns);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormBottles";
            this.Text = "Bottling";
            this.Load += new System.EventHandler(this.FormBottles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox amountTxtBox;
        private System.Windows.Forms.TextBox endTxtBox;
        private System.Windows.Forms.TextBox startTxtBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox productSelectComBox;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label labelPrevRuns;
        private System.Windows.Forms.Label labelDateSearch;
        private System.Windows.Forms.ComboBox dateSearchCB;
        private System.Windows.Forms.ComboBox productSearchCB;
        private System.Windows.Forms.Label labelProductSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox bottlesCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertToDB;
    }
}