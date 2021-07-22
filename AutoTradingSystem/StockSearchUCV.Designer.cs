
namespace AutoTradingSystem
{
    partial class StockSearchUCV
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stockVolumeLabel = new System.Windows.Forms.Label();
            this.stockUpDownLabel = new System.Windows.Forms.Label();
            this.stockPriceLabel = new System.Windows.Forms.Label();
            this.stockPrice = new System.Windows.Forms.Label();
            this.stockVolume = new System.Windows.Forms.Label();
            this.stockUpDownRate = new System.Windows.Forms.Label();
            this.stockName = new System.Windows.Forms.Label();
            this.stockUpDown = new System.Windows.Forms.Label();
            this.stockUpDownRateLabel = new System.Windows.Forms.Label();
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stockSearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.96154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.03846F));
            this.tableLayoutPanel1.Controls.Add(this.stockUpDownRateLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.stockNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stockUpDown, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockUpDownRate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.stockVolume, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.stockVolumeLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.stockUpDownLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockPriceLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(113, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 113);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // stockVolumeLabel
            // 
            this.stockVolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockVolumeLabel.AutoSize = true;
            this.stockVolumeLabel.Location = new System.Drawing.Point(109, 65);
            this.stockVolumeLabel.Name = "stockVolumeLabel";
            this.stockVolumeLabel.Size = new System.Drawing.Size(96, 26);
            this.stockVolumeLabel.TabIndex = 0;
            this.stockVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockUpDownLabel
            // 
            this.stockUpDownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockUpDownLabel.AutoSize = true;
            this.stockUpDownLabel.Location = new System.Drawing.Point(109, 39);
            this.stockUpDownLabel.Name = "stockUpDownLabel";
            this.stockUpDownLabel.Size = new System.Drawing.Size(96, 25);
            this.stockUpDownLabel.TabIndex = 2;
            this.stockUpDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockPriceLabel
            // 
            this.stockPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockPriceLabel.AutoSize = true;
            this.stockPriceLabel.Location = new System.Drawing.Point(109, 20);
            this.stockPriceLabel.Name = "stockPriceLabel";
            this.stockPriceLabel.Size = new System.Drawing.Size(96, 18);
            this.stockPriceLabel.TabIndex = 2;
            this.stockPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockPrice
            // 
            this.stockPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockPrice.AutoSize = true;
            this.stockPrice.Location = new System.Drawing.Point(4, 20);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(98, 18);
            this.stockPrice.TabIndex = 3;
            this.stockPrice.Text = "현재가";
            this.stockPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockVolume
            // 
            this.stockVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockVolume.AutoSize = true;
            this.stockVolume.Location = new System.Drawing.Point(4, 65);
            this.stockVolume.Name = "stockVolume";
            this.stockVolume.Size = new System.Drawing.Size(98, 26);
            this.stockVolume.TabIndex = 4;
            this.stockVolume.Text = "거래량";
            this.stockVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockUpDownRate
            // 
            this.stockUpDownRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockUpDownRate.AutoSize = true;
            this.stockUpDownRate.Location = new System.Drawing.Point(4, 92);
            this.stockUpDownRate.Name = "stockUpDownRate";
            this.stockUpDownRate.Size = new System.Drawing.Size(98, 20);
            this.stockUpDownRate.TabIndex = 5;
            this.stockUpDownRate.Text = "등락률";
            this.stockUpDownRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockName
            // 
            this.stockName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockName.AutoSize = true;
            this.stockName.Location = new System.Drawing.Point(4, 1);
            this.stockName.Name = "stockName";
            this.stockName.Size = new System.Drawing.Size(98, 18);
            this.stockName.TabIndex = 4;
            this.stockName.Text = "종목명";
            this.stockName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockUpDown
            // 
            this.stockUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockUpDown.AutoSize = true;
            this.stockUpDown.Location = new System.Drawing.Point(4, 39);
            this.stockUpDown.Name = "stockUpDown";
            this.stockUpDown.Size = new System.Drawing.Size(98, 25);
            this.stockUpDown.TabIndex = 5;
            this.stockUpDown.Text = "전일대비";
            this.stockUpDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockUpDownRateLabel
            // 
            this.stockUpDownRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockUpDownRateLabel.AutoSize = true;
            this.stockUpDownRateLabel.Location = new System.Drawing.Point(109, 92);
            this.stockUpDownRateLabel.Name = "stockUpDownRateLabel";
            this.stockUpDownRateLabel.Size = new System.Drawing.Size(96, 20);
            this.stockUpDownRateLabel.TabIndex = 4;
            this.stockUpDownRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockNameLabel.AutoSize = true;
            this.stockNameLabel.Location = new System.Drawing.Point(109, 1);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(96, 18);
            this.stockNameLabel.TabIndex = 5;
            this.stockNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(113, 40);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 21);
            this.stockTextBox.TabIndex = 3;
            // 
            // stockSearchButton
            // 
            this.stockSearchButton.Location = new System.Drawing.Point(236, 40);
            this.stockSearchButton.Name = "stockSearchButton";
            this.stockSearchButton.Size = new System.Drawing.Size(86, 23);
            this.stockSearchButton.TabIndex = 4;
            this.stockSearchButton.Text = "종목검색";
            this.stockSearchButton.UseVisualStyleBackColor = true;
            this.stockSearchButton.Click += new System.EventHandler(this.stockSearchButton_Click);
            // 
            // StockSearchUCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stockSearchButton);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockSearchUCV";
            this.Size = new System.Drawing.Size(857, 289);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label stockUpDownRateLabel;
        private System.Windows.Forms.Label stockNameLabel;
        private System.Windows.Forms.Label stockName;
        private System.Windows.Forms.Label stockPrice;
        private System.Windows.Forms.Label stockUpDown;
        private System.Windows.Forms.Label stockUpDownRate;
        private System.Windows.Forms.Label stockVolume;
        private System.Windows.Forms.Label stockVolumeLabel;
        private System.Windows.Forms.Label stockUpDownLabel;
        private System.Windows.Forms.Label stockPriceLabel;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Button stockSearchButton;
    }
}
