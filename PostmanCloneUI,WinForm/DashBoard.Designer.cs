namespace PostmanCloneUI_WinForm
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            apiLabel = new Label();
            apiTextBox = new TextBox();
            callApi = new Button();
            resultsTextBox = new TextBox();
            resultsLable = new Label();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            clearApiText = new Button();
            mainPanel = new TableLayoutPanel();
            apiPanel = new TableLayoutPanel();
            apiTextPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            httpVerbSelection = new ComboBox();
            resultsPanel = new TableLayoutPanel();
            statusStrip.SuspendLayout();
            mainPanel.SuspendLayout();
            apiPanel.SuspendLayout();
            apiTextPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            resultsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Dock = DockStyle.Left;
            headerLabel.Location = new Point(8, 5);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(174, 32);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Postman Clone";
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Dock = DockStyle.Fill;
            apiLabel.Location = new Point(10, 3);
            apiLabel.Margin = new Padding(5);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(53, 50);
            apiLabel.TabIndex = 0;
            apiLabel.Text = "API:";
            apiLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apiTextBox
            // 
            apiTextBox.BorderStyle = BorderStyle.FixedSingle;
            apiTextBox.Dock = DockStyle.Fill;
            apiTextBox.Location = new Point(3, 7);
            apiTextBox.Name = "apiTextBox";
            apiTextBox.Size = new Size(438, 39);
            apiTextBox.TabIndex = 1;
            apiTextBox.TextChanged += apiTextBox_TextChanged;
            // 
            // callApi
            // 
            callApi.BackColor = Color.White;
            callApi.Dock = DockStyle.Fill;
            callApi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            callApi.Location = new Point(648, 3);
            callApi.Margin = new Padding(5);
            callApi.MinimumSize = new Size(50, 50);
            callApi.Name = "callApi";
            callApi.Size = new Size(50, 50);
            callApi.TabIndex = 2;
            callApi.Text = "GO";
            callApi.UseVisualStyleBackColor = false;
            callApi.Click += callApi_Click;
            // 
            // resultsTextBox
            // 
            resultsTextBox.BackColor = Color.White;
            resultsTextBox.Dock = DockStyle.Fill;
            resultsTextBox.Location = new Point(8, 40);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.ReadOnly = true;
            resultsTextBox.ScrollBars = ScrollBars.Both;
            resultsTextBox.Size = new Size(752, 375);
            resultsTextBox.TabIndex = 1;
            resultsTextBox.TabStop = false;
            // 
            // resultsLable
            // 
            resultsLable.AutoSize = true;
            resultsLable.Dock = DockStyle.Left;
            resultsLable.Location = new Point(8, 5);
            resultsLable.Name = "resultsLable";
            resultsLable.Size = new Size(93, 32);
            resultsLable.TabIndex = 0;
            resultsLable.Text = "Results:";
            resultsLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.White;
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 531);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(784, 30);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(62, 25);
            statusLabel.Text = "Ready";
            // 
            // clearApiText
            // 
            clearApiText.BackColor = Color.White;
            clearApiText.Dock = DockStyle.Fill;
            clearApiText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearApiText.ForeColor = Color.Red;
            clearApiText.Location = new Point(708, 3);
            clearApiText.Margin = new Padding(5);
            clearApiText.MinimumSize = new Size(50, 50);
            clearApiText.Name = "clearApiText";
            clearApiText.Size = new Size(50, 50);
            clearApiText.TabIndex = 3;
            clearApiText.Text = "X";
            clearApiText.UseVisualStyleBackColor = false;
            clearApiText.Click += clearApiText_Click;
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 1;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainPanel.Controls.Add(apiPanel, 0, 1);
            mainPanel.Controls.Add(resultsPanel, 0, 2);
            mainPanel.Controls.Add(headerLabel, 0, 0);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(5);
            mainPanel.RowCount = 3;
            mainPanel.RowStyles.Add(new RowStyle());
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainPanel.Size = new Size(784, 531);
            mainPanel.TabIndex = 4;
            // 
            // apiPanel
            // 
            apiPanel.ColumnCount = 5;
            apiPanel.ColumnStyles.Add(new ColumnStyle());
            apiPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            apiPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            apiPanel.ColumnStyles.Add(new ColumnStyle());
            apiPanel.ColumnStyles.Add(new ColumnStyle());
            apiPanel.Controls.Add(apiTextPanel, 2, 1);
            apiPanel.Controls.Add(apiLabel, 0, 1);
            apiPanel.Controls.Add(callApi, 3, 1);
            apiPanel.Controls.Add(tableLayoutPanel1, 1, 1);
            apiPanel.Controls.Add(clearApiText, 4, 1);
            apiPanel.Dock = DockStyle.Fill;
            apiPanel.Location = new Point(8, 40);
            apiPanel.Name = "apiPanel";
            apiPanel.Padding = new Padding(5);
            apiPanel.RowCount = 3;
            apiPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999962F));
            apiPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            apiPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            apiPanel.Size = new Size(768, 54);
            apiPanel.TabIndex = 6;
            // 
            // apiTextPanel
            // 
            apiTextPanel.ColumnCount = 1;
            apiTextPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            apiTextPanel.Controls.Add(apiTextBox, 0, 1);
            apiTextPanel.Dock = DockStyle.Fill;
            apiTextPanel.Location = new Point(196, 1);
            apiTextPanel.Name = "apiTextPanel";
            apiTextPanel.RowCount = 3;
            apiTextPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            apiTextPanel.RowStyles.Add(new RowStyle());
            apiTextPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            apiTextPanel.Size = new Size(444, 54);
            apiTextPanel.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(httpVerbSelection, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(71, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.848484F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.15151F));
            tableLayoutPanel1.Size = new Size(119, 54);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.BackColor = SystemColors.Window;
            httpVerbSelection.Dock = DockStyle.Fill;
            httpVerbSelection.DrawMode = DrawMode.OwnerDrawFixed;
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
            httpVerbSelection.Location = new Point(3, 11);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(113, 40);
            httpVerbSelection.TabIndex = 9;
            httpVerbSelection.DrawItem += httpVerbSelection_DrawItem;
            httpVerbSelection.SelectedIndexChanged += httpVerbSelection_SelectedIndexChanged;
            // 
            // resultsPanel
            // 
            resultsPanel.ColumnCount = 1;
            resultsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            resultsPanel.Controls.Add(resultsLable, 0, 0);
            resultsPanel.Controls.Add(resultsTextBox, 0, 1);
            resultsPanel.Dock = DockStyle.Fill;
            resultsPanel.Location = new Point(8, 100);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Padding = new Padding(5);
            resultsPanel.RowCount = 2;
            resultsPanel.RowStyles.Add(new RowStyle());
            resultsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            resultsPanel.Size = new Size(768, 423);
            resultsPanel.TabIndex = 5;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(mainPanel);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            MinimumSize = new Size(400, 400);
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postman Clone";
            Shown += DashBoard_Shown;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            apiPanel.ResumeLayout(false);
            apiPanel.PerformLayout();
            apiTextPanel.ResumeLayout(false);
            apiTextPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            resultsPanel.ResumeLayout(false);
            resultsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label apiLabel;
        private TextBox apiTextBox;
        private Button callApi;
        private TextBox resultsTextBox;
        private Label resultsLable;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private Button clearApiText;
        private TableLayoutPanel mainPanel;
        private TableLayoutPanel resultsPanel;
        private TableLayoutPanel apiPanel;
        private TableLayoutPanel apiTextPanel;
        private ComboBox httpVerbSelection;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
