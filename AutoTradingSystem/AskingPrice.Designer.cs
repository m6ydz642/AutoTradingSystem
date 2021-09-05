
namespace AutoTradingSystem
{
    partial class AskingPrice
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
            this.volumeListBox = new System.Windows.Forms.ListBox();
            this.stockSearchButton = new System.Windows.Forms.Button();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.upDownRateLabel = new System.Windows.Forms.Label();
            this.volumeListLabel = new System.Windows.Forms.Label();
            this.priceListLabel = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.volumeListBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockSearchButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.priceListBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.priceLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.upDownRateLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.86274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.13726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 415);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // volumeListBox
            // 
            this.volumeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeListBox.FormattingEnabled = true;
            this.volumeListBox.ItemHeight = 12;
            this.volumeListBox.Location = new System.Drawing.Point(161, 52);
            this.volumeListBox.Margin = new System.Windows.Forms.Padding(0);
            this.volumeListBox.Name = "volumeListBox";
            this.volumeListBox.Size = new System.Drawing.Size(154, 352);
            this.volumeListBox.TabIndex = 6;
            // 
            // stockSearchButton
            // 
            this.stockSearchButton.Location = new System.Drawing.Point(164, 4);
            this.stockSearchButton.Name = "stockSearchButton";
            this.stockSearchButton.Size = new System.Drawing.Size(148, 22);
            this.stockSearchButton.TabIndex = 5;
            this.stockSearchButton.Text = "종목검색";
            this.stockSearchButton.UseVisualStyleBackColor = true;
            this.stockSearchButton.Click += new System.EventHandler(this.stockSearchButton_Click);
            // 
            // priceListBox
            // 
            this.priceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 12;
            this.priceListBox.Location = new System.Drawing.Point(1, 52);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(0);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(159, 352);
            this.priceListBox.TabIndex = 4;
            // 
            // stockTextBox
            // 
            this.stockTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.stockTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.stockTextBox.Location = new System.Drawing.Point(4, 4);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(153, 21);
            this.stockTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.SeaShell;
            this.priceLabel.Location = new System.Drawing.Point(4, 30);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(153, 21);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "0";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upDownRateLabel
            // 
            this.upDownRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownRateLabel.AutoSize = true;
            this.upDownRateLabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.upDownRateLabel.Location = new System.Drawing.Point(164, 30);
            this.upDownRateLabel.Name = "upDownRateLabel";
            this.upDownRateLabel.Size = new System.Drawing.Size(148, 21);
            this.upDownRateLabel.TabIndex = 2;
            this.upDownRateLabel.Text = "0";
            this.upDownRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeListLabel
            // 
            this.volumeListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeListLabel.AutoSize = true;
            this.volumeListLabel.Location = new System.Drawing.Point(463, 52);
            this.volumeListLabel.Name = "volumeListLabel";
            this.volumeListLabel.Size = new System.Drawing.Size(0, 12);
            this.volumeListLabel.TabIndex = 6;
            this.volumeListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceListLabel
            // 
            this.priceListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceListLabel.AutoSize = true;
            this.priceListLabel.Location = new System.Drawing.Point(404, 72);
            this.priceListLabel.Name = "priceListLabel";
            this.priceListLabel.Size = new System.Drawing.Size(0, 12);
            this.priceListLabel.TabIndex = 5;
            this.priceListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AskingPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.volumeListLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.priceListLabel);
            this.Name = "AskingPrice";
            this.Size = new System.Drawing.Size(780, 452);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label volumeListLabel;
        private System.Windows.Forms.Button stockSearchButton;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label priceListLabel;
        private System.Windows.Forms.Label upDownRateLabel;
        private System.Windows.Forms.ListBox volumeListBox;
        private System.Windows.Forms.ListBox priceListBox;
    }
}
