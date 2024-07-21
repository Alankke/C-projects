
namespace generadorLoremIpsum
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
            wordRadioButton = new RadioButton();
            paragraphRadioButton = new RadioButton();
            startWithCheckBox = new CheckBox();
            parametersGroupBox = new GroupBox();
            quantityRichTextBox = new RichTextBox();
            quantityLabel = new Label();
            generatedTextRichTextBox = new RichTextBox();
            saveFileButton = new Button();
            generateButton = new Button();
            parametersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // wordRadioButton
            // 
            wordRadioButton.AutoSize = true;
            wordRadioButton.Location = new Point(6, 26);
            wordRadioButton.Name = "wordRadioButton";
            wordRadioButton.Size = new Size(85, 24);
            wordRadioButton.TabIndex = 0;
            wordRadioButton.TabStop = true;
            wordRadioButton.Text = "Palabras";
            wordRadioButton.UseVisualStyleBackColor = true;
            // 
            // paragraphRadioButton
            // 
            paragraphRadioButton.AutoSize = true;
            paragraphRadioButton.Location = new Point(6, 56);
            paragraphRadioButton.Name = "paragraphRadioButton";
            paragraphRadioButton.Size = new Size(83, 24);
            paragraphRadioButton.TabIndex = 1;
            paragraphRadioButton.TabStop = true;
            paragraphRadioButton.Text = "Parrafos";
            paragraphRadioButton.UseVisualStyleBackColor = true;
            // 
            // startWithCheckBox
            // 
            startWithCheckBox.AutoSize = true;
            startWithCheckBox.Location = new Point(6, 86);
            startWithCheckBox.Name = "startWithCheckBox";
            startWithCheckBox.Size = new Size(233, 24);
            startWithCheckBox.TabIndex = 2;
            startWithCheckBox.Text = "¿Empezar con \"Lorem ipsum\"?";
            startWithCheckBox.UseVisualStyleBackColor = true;
            // 
            // parametersGroupBox
            // 
            parametersGroupBox.Controls.Add(wordRadioButton);
            parametersGroupBox.Controls.Add(startWithCheckBox);
            parametersGroupBox.Controls.Add(paragraphRadioButton);
            parametersGroupBox.Location = new Point(12, 12);
            parametersGroupBox.Name = "parametersGroupBox";
            parametersGroupBox.Size = new Size(250, 125);
            parametersGroupBox.TabIndex = 3;
            parametersGroupBox.TabStop = false;
            parametersGroupBox.Text = "Parametros";
            // 
            // quantityRichTextBox
            // 
            quantityRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quantityRichTextBox.Location = new Point(280, 47);
            quantityRichTextBox.Multiline = false;
            quantityRichTextBox.Name = "quantityRichTextBox";
            quantityRichTextBox.ScrollBars = RichTextBoxScrollBars.None;
            quantityRichTextBox.Size = new Size(212, 27);
            quantityRichTextBox.TabIndex = 4;
            quantityRichTextBox.Text = "";
            quantityRichTextBox.KeyPress += quantityRichTextBox_KeyPress;
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(280, 22);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(212, 20);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Ingrese cantidad en numeros";
            // 
            // generatedTextRichTextBox
            // 
            generatedTextRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            generatedTextRichTextBox.Location = new Point(18, 155);
            generatedTextRichTextBox.Name = "generatedTextRichTextBox";
            generatedTextRichTextBox.ReadOnly = true;
            generatedTextRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            generatedTextRichTextBox.Size = new Size(770, 150);
            generatedTextRichTextBox.TabIndex = 6;
            generatedTextRichTextBox.Text = "";
            // 
            // saveFileButton
            // 
            saveFileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveFileButton.Location = new Point(647, 409);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(132, 29);
            saveFileButton.TabIndex = 7;
            saveFileButton.Text = "Guardar archivo";
            saveFileButton.UseVisualStyleBackColor = true;
            saveFileButton.Click += saveFileButton_Click;
            // 
            // generateButton
            // 
            generateButton.Anchor = AnchorStyles.Bottom;
            generateButton.BackColor = Color.DeepSkyBlue;
            generateButton.FlatStyle = FlatStyle.Popup;
            generateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateButton.Location = new Point(356, 311);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(101, 29);
            generateButton.TabIndex = 8;
            generateButton.Text = "¡Generar!";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.UseWaitCursor = true;
            generateButton.Click += generateButton_Click;
            // 
            // MainWindow
            // 
            AcceptButton = generateButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(generateButton);
            Controls.Add(saveFileButton);
            Controls.Add(generatedTextRichTextBox);
            Controls.Add(quantityLabel);
            Controls.Add(quantityRichTextBox);
            Controls.Add(parametersGroupBox);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador Latín";
            parametersGroupBox.ResumeLayout(false);
            parametersGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton wordRadioButton;
        private RadioButton paragraphRadioButton;
        private CheckBox startWithCheckBox;
        private GroupBox parametersGroupBox;
        private RichTextBox quantityRichTextBox;
        private Label quantityLabel;
        private RichTextBox generatedTextRichTextBox;
        private Button saveFileButton;
        private Button generateButton;
    }
}
