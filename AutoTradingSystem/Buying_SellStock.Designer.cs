
namespace AutoTradingSystem
{
    partial class Buying_SellStock
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.numberNumericLabel = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.priceNumbericLabel = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stockSearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.totalPurchaseLabel = new System.Windows.Forms.Label();
            this.clearLimitButton = new System.Windows.Forms.Button();
            this.setLimitButton = new System.Windows.Forms.Button();
            this.totalBalnce = new System.Windows.Forms.Label();
            this.limitNumericUpDownLabel = new System.Windows.Forms.Label();
            this.totalPurchase = new System.Windows.Forms.Label();
            this.limitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalBalnceLabel = new System.Windows.Forms.Label();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.balanceCheckButton = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.96154F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.03846F));
            tableLayoutPanel1.Controls.Add(this.buyButton, 0, 0);
            tableLayoutPanel1.Controls.Add(this.sellButton, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(446, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(216, 93);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(4, 4);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(102, 39);
            this.buyButton.TabIndex = 8;
            this.buyButton.Text = "신규매수";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(113, 4);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(99, 39);
            this.sellButton.TabIndex = 9;
            this.sellButton.Text = "신규매도";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.3913F));
            this.tableLayoutPanel3.Controls.Add(this.priceNumericUpDown, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.orderLabel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.numberNumericLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.stockTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.priceNumbericLabel, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.accountComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.accountLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.orderComboBox, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.numberNumericUpDown, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(63, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.82022F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.17978F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(277, 160);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(94, 95);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(179, 21);
            this.priceNumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "종목이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderLabel
            // 
            this.orderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(4, 126);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(83, 33);
            this.orderLabel.TabIndex = 8;
            this.orderLabel.Text = "거래구분";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberNumericLabel
            // 
            this.numberNumericLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberNumericLabel.AutoSize = true;
            this.numberNumericLabel.Location = new System.Drawing.Point(4, 66);
            this.numberNumericLabel.Name = "numberNumericLabel";
            this.numberNumericLabel.Size = new System.Drawing.Size(83, 25);
            this.numberNumericLabel.TabIndex = 5;
            this.numberNumericLabel.Text = "수량";
            this.numberNumericLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stockTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stockTextBox.Location = new System.Drawing.Point(94, 33);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(179, 21);
            this.stockTextBox.TabIndex = 10;
            // 
            // priceNumbericLabel
            // 
            this.priceNumbericLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceNumbericLabel.AutoSize = true;
            this.priceNumbericLabel.Location = new System.Drawing.Point(4, 92);
            this.priceNumbericLabel.Name = "priceNumbericLabel";
            this.priceNumbericLabel.Size = new System.Drawing.Size(83, 33);
            this.priceNumbericLabel.TabIndex = 3;
            this.priceNumbericLabel.Text = "가격";
            this.priceNumbericLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(94, 4);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(179, 20);
            this.accountComboBox.TabIndex = 6;
            // 
            // accountLabel
            // 
            this.accountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(4, 1);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(83, 28);
            this.accountLabel.TabIndex = 5;
            this.accountLabel.Text = "계좌번호";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(94, 129);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(179, 20);
            this.orderComboBox.TabIndex = 9;
            // 
            // numberNumericUpDown
            // 
            this.numberNumericUpDown.Location = new System.Drawing.Point(94, 69);
            this.numberNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numberNumericUpDown.Name = "numberNumericUpDown";
            this.numberNumericUpDown.Size = new System.Drawing.Size(179, 21);
            this.numberNumericUpDown.TabIndex = 11;
            // 
            // stockSearchButton
            // 
            this.stockSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockSearchButton.Location = new System.Drawing.Point(345, 78);
            this.stockSearchButton.Name = "stockSearchButton";
            this.stockSearchButton.Size = new System.Drawing.Size(74, 19);
            this.stockSearchButton.TabIndex = 7;
            this.stockSearchButton.Text = "종목검색";
            this.stockSearchButton.UseVisualStyleBackColor = true;
            this.stockSearchButton.Click += new System.EventHandler(this.stockSearchButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.3913F));
            this.tableLayoutPanel2.Controls.Add(this.totalPurchaseLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clearLimitButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.setLimitButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.totalBalnce, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.limitNumericUpDownLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.totalPurchase, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.limitNumericUpDown, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.totalBalnceLabel, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(678, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.32203F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.67797F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 121);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // totalPurchaseLabel
            // 
            this.totalPurchaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPurchaseLabel.AutoSize = true;
            this.totalPurchaseLabel.Location = new System.Drawing.Point(117, 1);
            this.totalPurchaseLabel.Name = "totalPurchaseLabel";
            this.totalPurchaseLabel.Size = new System.Drawing.Size(227, 34);
            this.totalPurchaseLabel.TabIndex = 15;
            this.totalPurchaseLabel.Text = "0";
            this.totalPurchaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearLimitButton
            // 
            this.clearLimitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLimitButton.Location = new System.Drawing.Point(117, 89);
            this.clearLimitButton.Name = "clearLimitButton";
            this.clearLimitButton.Size = new System.Drawing.Size(227, 28);
            this.clearLimitButton.TabIndex = 13;
            this.clearLimitButton.Text = "매수제한해제";
            this.clearLimitButton.UseVisualStyleBackColor = true;
            this.clearLimitButton.Click += new System.EventHandler(this.clearLimitButton_Click);
            // 
            // setLimitButton
            // 
            this.setLimitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setLimitButton.Location = new System.Drawing.Point(4, 89);
            this.setLimitButton.Name = "setLimitButton";
            this.setLimitButton.Size = new System.Drawing.Size(106, 28);
            this.setLimitButton.TabIndex = 12;
            this.setLimitButton.Text = "매수제한설정";
            this.setLimitButton.UseVisualStyleBackColor = true;
            this.setLimitButton.Click += new System.EventHandler(this.setLimitButton_Click);
            // 
            // totalBalnce
            // 
            this.totalBalnce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalBalnce.AutoSize = true;
            this.totalBalnce.Location = new System.Drawing.Point(4, 36);
            this.totalBalnce.Name = "totalBalnce";
            this.totalBalnce.Size = new System.Drawing.Size(106, 23);
            this.totalBalnce.TabIndex = 7;
            this.totalBalnce.Text = "종목이름";
            this.totalBalnce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limitNumericUpDownLabel
            // 
            this.limitNumericUpDownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limitNumericUpDownLabel.AutoSize = true;
            this.limitNumericUpDownLabel.Location = new System.Drawing.Point(4, 60);
            this.limitNumericUpDownLabel.Name = "limitNumericUpDownLabel";
            this.limitNumericUpDownLabel.Size = new System.Drawing.Size(106, 25);
            this.limitNumericUpDownLabel.TabIndex = 5;
            this.limitNumericUpDownLabel.Text = "매수제한금액";
            this.limitNumericUpDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPurchase
            // 
            this.totalPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPurchase.AutoSize = true;
            this.totalPurchase.Location = new System.Drawing.Point(4, 1);
            this.totalPurchase.Name = "totalPurchase";
            this.totalPurchase.Size = new System.Drawing.Size(106, 34);
            this.totalPurchase.TabIndex = 5;
            this.totalPurchase.Text = "계좌번호";
            this.totalPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limitNumericUpDown
            // 
            this.limitNumericUpDown.Location = new System.Drawing.Point(117, 63);
            this.limitNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.limitNumericUpDown.Name = "limitNumericUpDown";
            this.limitNumericUpDown.Size = new System.Drawing.Size(227, 21);
            this.limitNumericUpDown.TabIndex = 11;
            // 
            // totalBalnceLabel
            // 
            this.totalBalnceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalBalnceLabel.AutoSize = true;
            this.totalBalnceLabel.Location = new System.Drawing.Point(117, 36);
            this.totalBalnceLabel.Name = "totalBalnceLabel";
            this.totalBalnceLabel.Size = new System.Drawing.Size(227, 23);
            this.totalBalnceLabel.TabIndex = 14;
            this.totalBalnceLabel.Text = "0";
            this.totalBalnceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Location = new System.Drawing.Point(69, 230);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.RowTemplate.Height = 23;
            this.balanceDataGridView.Size = new System.Drawing.Size(953, 173);
            this.balanceDataGridView.TabIndex = 9;
            // 
            // balanceCheckButton
            // 
            this.balanceCheckButton.Location = new System.Drawing.Point(948, 200);
            this.balanceCheckButton.Name = "balanceCheckButton";
            this.balanceCheckButton.Size = new System.Drawing.Size(74, 24);
            this.balanceCheckButton.TabIndex = 10;
            this.balanceCheckButton.Text = "잔고확인";
            this.balanceCheckButton.UseVisualStyleBackColor = true;
            this.balanceCheckButton.Click += new System.EventHandler(this.balanceCheckButton_Click);
            // 
            // Buying_SellStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.balanceCheckButton);
            this.Controls.Add(this.balanceDataGridView);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.stockSearchButton);
            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Buying_SellStock";
            this.Size = new System.Drawing.Size(1159, 498);
            tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label numberNumericLabel;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label priceNumbericLabel;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.NumericUpDown numberNumericUpDown;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button stockSearchButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalPurchaseLabel;
        private System.Windows.Forms.Button clearLimitButton;
        private System.Windows.Forms.Button setLimitButton;
        private System.Windows.Forms.Label totalBalnce;
        private System.Windows.Forms.Label limitNumericUpDownLabel;
        private System.Windows.Forms.Label totalPurchase;
        private System.Windows.Forms.NumericUpDown limitNumericUpDown;
        private System.Windows.Forms.Label totalBalnceLabel;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.Button balanceCheckButton;
    }
}
