namespace TaTeTi
{
    partial class MainWindow
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
            Grid = new TableLayoutPanel();
            RightBottomButton = new Button();
            CenterBottomButton = new Button();
            LeftBottomButton = new Button();
            RightCenterButton = new Button();
            LeftCenterButton = new Button();
            CenterUpperButton = new Button();
            CenterCenterButton = new Button();
            LeftUpperButton = new Button();
            RightUpperButton = new Button();
            player1NameLabel = new Label();
            player2NameLabel = new Label();
            player2IconLabel = new Label();
            player1IconLabel = new Label();
            label1 = new Label();
            playerTurnLabel = new Label();
            Grid.SuspendLayout();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.ColumnCount = 3;
            Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            Grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            Grid.Controls.Add(RightBottomButton, 2, 2);
            Grid.Controls.Add(CenterBottomButton, 1, 2);
            Grid.Controls.Add(LeftBottomButton, 0, 2);
            Grid.Controls.Add(RightCenterButton, 2, 1);
            Grid.Controls.Add(LeftCenterButton, 0, 1);
            Grid.Controls.Add(CenterUpperButton, 1, 0);
            Grid.Controls.Add(CenterCenterButton, 1, 1);
            Grid.Controls.Add(LeftUpperButton, 0, 0);
            Grid.Controls.Add(RightUpperButton, 2, 0);
            Grid.Location = new Point(138, 97);
            Grid.Name = "Grid";
            Grid.RowCount = 3;
            Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Grid.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            Grid.Size = new Size(434, 341);
            Grid.TabIndex = 0;
            // 
            // RightBottomButton
            // 
            RightBottomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RightBottomButton.Location = new Point(291, 229);
            RightBottomButton.Name = "RightBottomButton";
            RightBottomButton.Size = new Size(140, 109);
            RightBottomButton.TabIndex = 8;
            RightBottomButton.UseVisualStyleBackColor = true;
            RightBottomButton.Click += Button_Click;
            // 
            // CenterBottomButton
            // 
            CenterBottomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterBottomButton.Location = new Point(147, 229);
            CenterBottomButton.Name = "CenterBottomButton";
            CenterBottomButton.Size = new Size(138, 109);
            CenterBottomButton.TabIndex = 7;
            CenterBottomButton.UseVisualStyleBackColor = true;
            CenterBottomButton.Click += Button_Click;
            // 
            // LeftBottomButton
            // 
            LeftBottomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LeftBottomButton.Location = new Point(3, 229);
            LeftBottomButton.Name = "LeftBottomButton";
            LeftBottomButton.Size = new Size(138, 109);
            LeftBottomButton.TabIndex = 6;
            LeftBottomButton.UseVisualStyleBackColor = true;
            LeftBottomButton.Click += Button_Click;
            // 
            // RightCenterButton
            // 
            RightCenterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RightCenterButton.Location = new Point(291, 116);
            RightCenterButton.Name = "RightCenterButton";
            RightCenterButton.Size = new Size(140, 107);
            RightCenterButton.TabIndex = 5;
            RightCenterButton.UseVisualStyleBackColor = true;
            RightCenterButton.Click += Button_Click;
            // 
            // LeftCenterButton
            // 
            LeftCenterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LeftCenterButton.Location = new Point(3, 116);
            LeftCenterButton.Name = "LeftCenterButton";
            LeftCenterButton.Size = new Size(138, 107);
            LeftCenterButton.TabIndex = 3;
            LeftCenterButton.UseVisualStyleBackColor = true;
            LeftCenterButton.Click += Button_Click;
            // 
            // CenterUpperButton
            // 
            CenterUpperButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterUpperButton.Location = new Point(147, 3);
            CenterUpperButton.Name = "CenterUpperButton";
            CenterUpperButton.Size = new Size(138, 107);
            CenterUpperButton.TabIndex = 1;
            CenterUpperButton.UseVisualStyleBackColor = true;
            CenterUpperButton.Click += Button_Click;
            // 
            // CenterCenterButton
            // 
            CenterCenterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CenterCenterButton.Location = new Point(147, 116);
            CenterCenterButton.Name = "CenterCenterButton";
            CenterCenterButton.Size = new Size(138, 107);
            CenterCenterButton.TabIndex = 4;
            CenterCenterButton.UseVisualStyleBackColor = true;
            CenterCenterButton.Click += Button_Click;
            // 
            // LeftUpperButton
            // 
            LeftUpperButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LeftUpperButton.Location = new Point(3, 3);
            LeftUpperButton.Name = "LeftUpperButton";
            LeftUpperButton.Size = new Size(138, 107);
            LeftUpperButton.TabIndex = 0;
            LeftUpperButton.UseVisualStyleBackColor = true;
            LeftUpperButton.Click += Button_Click;
            // 
            // RightUpperButton
            // 
            RightUpperButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RightUpperButton.Location = new Point(291, 3);
            RightUpperButton.Name = "RightUpperButton";
            RightUpperButton.Size = new Size(140, 107);
            RightUpperButton.TabIndex = 2;
            RightUpperButton.UseVisualStyleBackColor = true;
            RightUpperButton.Click += Button_Click;
            // 
            // player1NameLabel
            // 
            player1NameLabel.AutoSize = true;
            player1NameLabel.Font = new Font("Segoe UI", 12F);
            player1NameLabel.Location = new Point(21, 9);
            player1NameLabel.Name = "player1NameLabel";
            player1NameLabel.Size = new Size(0, 28);
            player1NameLabel.TabIndex = 1;
            // 
            // player2NameLabel
            // 
            player2NameLabel.AutoSize = true;
            player2NameLabel.Font = new Font("Segoe UI", 12F);
            player2NameLabel.Location = new Point(21, 47);
            player2NameLabel.Name = "player2NameLabel";
            player2NameLabel.Size = new Size(0, 28);
            player2NameLabel.TabIndex = 2;
            // 
            // player2IconLabel
            // 
            player2IconLabel.AutoSize = true;
            player2IconLabel.Font = new Font("Segoe UI", 12F);
            player2IconLabel.Location = new Point(138, 47);
            player2IconLabel.Name = "player2IconLabel";
            player2IconLabel.Size = new Size(0, 28);
            player2IconLabel.TabIndex = 4;
            // 
            // player1IconLabel
            // 
            player1IconLabel.AutoSize = true;
            player1IconLabel.Font = new Font("Segoe UI", 12F);
            player1IconLabel.Location = new Point(138, 9);
            player1IconLabel.Name = "player1IconLabel";
            player1IconLabel.Size = new Size(0, 28);
            player1IconLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 56);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 5;
            label1.Text = "Turno de";
            // 
            // playerTurnLabel
            // 
            playerTurnLabel.AutoSize = true;
            playerTurnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerTurnLabel.Location = new Point(369, 56);
            playerTurnLabel.Name = "playerTurnLabel";
            playerTurnLabel.Size = new Size(0, 28);
            playerTurnLabel.TabIndex = 6;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 450);
            Controls.Add(playerTurnLabel);
            Controls.Add(label1);
            Controls.Add(player2IconLabel);
            Controls.Add(player1IconLabel);
            Controls.Add(player2NameLabel);
            Controls.Add(player1NameLabel);
            Controls.Add(Grid);
            Name = "MainWindow";
            Text = "Ta Te Ti";
            Grid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel Grid;
        private Button LeftUpperButton;
        private Button CenterUpperButton;
        private Button RightUpperButton;
        private Button LeftCenterButton;
        private Button CenterCenterButton;
        private Button RightBottomButton;
        private Button CenterBottomButton;
        private Button LeftBottomButton;
        private Button RightCenterButton;
        private Label player1NameLabel;
        private Label player2NameLabel;
        private Label player2IconLabel;
        private Label player1IconLabel;
        private Label label1;
        private Label playerTurnLabel;
    }
}
