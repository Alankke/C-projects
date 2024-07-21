namespace generadorLoremIpsum
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantityRichTextBox.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Por favor, debe ingresar un número", "Dato Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (quantityRichTextBox.Text.Trim() == null || quantityRichTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor debe ingresar primero la cantidad deseada", "Dato Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Generator.GenerationMode mode = wordRadioButton.Checked ? Generator.GenerationMode.Words : Generator.GenerationMode.Paragraphs;
            

            try
            {
                string generatedText = Generator.GenerateLorem(quantity, mode, startWithCheckBox.Checked);
                generatedTextRichTextBox.Clear();
                generatedTextRichTextBox.Text = generatedText;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Un error ocurrió: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quantityRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (generatedTextRichTextBox.Text != null)
            {
                try
                {
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                    string fileName = "Lorem.txt";

                    string fullpath = Path.Combine(downloadsFolder, fileName);

                    File.WriteAllText(fullpath, generatedTextRichTextBox.Text);

                    MessageBox.Show("El archivo se guardo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Se produjo un error {exception.Message}", "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No puedes guardar el archivo sin generar el texto previamente", "Dato Faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
