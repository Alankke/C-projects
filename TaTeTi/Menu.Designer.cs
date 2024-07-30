namespace TaTeTi
{
    partial class MenuWindow
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
            player1Label = new Label();
            player2Label = new Label();
            player1TextBox = new RichTextBox();
            player2TextBox = new RichTextBox();
            jugarButton = new Button();
            SuspendLayout();
            // 
            // player1Label
            // 
            player1Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            player1Label.AutoSize = true;
            player1Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1Label.ForeColor = SystemColors.MenuText;
            player1Label.Location = new Point(116, 76);
            player1Label.Name = "player1Label";
            player1Label.Size = new Size(155, 38);
            player1Label.TabIndex = 0;
            player1Label.Text = "Jugador 1:";
            // 
            // player2Label
            // 
            player2Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            player2Label.AutoSize = true;
            player2Label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2Label.ForeColor = SystemColors.MenuText;
            player2Label.Location = new Point(116, 249);
            player2Label.Name = "player2Label";
            player2Label.Size = new Size(155, 38);
            player2Label.TabIndex = 1;
            player2Label.Text = "Jugador 2:";
            // 
            // player1TextBox
            // 
            player1TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            player1TextBox.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            player1TextBox.Location = new Point(62, 117);
            player1TextBox.Multiline = false;
            player1TextBox.Name = "player1TextBox";
            player1TextBox.ScrollBars = RichTextBoxScrollBars.None;
            player1TextBox.Size = new Size(261, 45);
            player1TextBox.TabIndex = 2;
            player1TextBox.Text = "";
            // 
            // player2TextBox
            // 
            player2TextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            player2TextBox.Font = new Font("Franklin Gothic Medium Cond", 18F);
            player2TextBox.Location = new Point(62, 290);
            player2TextBox.Multiline = false;
            player2TextBox.Name = "player2TextBox";
            player2TextBox.ScrollBars = RichTextBoxScrollBars.None;
            player2TextBox.Size = new Size(261, 45);
            player2TextBox.TabIndex = 5;
            player2TextBox.Text = "";
            // 
            // jugarButton
            // 
            jugarButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            jugarButton.BackColor = Color.Snow;
            jugarButton.FlatStyle = FlatStyle.Flat;
            jugarButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jugarButton.ForeColor = SystemColors.MenuText;
            jugarButton.Location = new Point(62, 405);
            jugarButton.Name = "jugarButton";
            jugarButton.Size = new Size(249, 47);
            jugarButton.TabIndex = 4;
            jugarButton.Text = "¡Jugar!";
            jugarButton.UseVisualStyleBackColor = false;
            jugarButton.Click += jugarButton_Click;
            // 
            // MenuWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(394, 504);
            Controls.Add(player2TextBox);
            Controls.Add(jugarButton);
            Controls.Add(player1TextBox);
            Controls.Add(player2Label);
            Controls.Add(player1Label);
            Name = "MenuWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label player1Label;
        private Label player2Label;
        private RichTextBox player1TextBox;
        private RichTextBox player2TextBox;
        private Button jugarButton;
        
    }
}