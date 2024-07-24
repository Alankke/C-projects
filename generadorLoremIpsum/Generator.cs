using System;
using System.Linq;
using System.Text;

namespace generadorLoremIpsum
{
    internal class Generator
    {
        private const int MinimumQuantitySentence = 3;
        private const int MaximumQuantitySentence = 8;
        private const int MaximumQuantityParagraph = 4;
        private const int StartWithWordCount = 8;
        private static readonly string FilePath = Path.Combine(Application.StartupPath, "assets", "palabras lorem.txt");
        private static readonly string[] Words = File.ReadAllLines(FilePath);
        private static readonly string StartPhrase = string.Join(" ", Words.Take(StartWithWordCount));

        public enum GenerationMode
        {
            Words,
            Paragraphs
        }

        public static string GenerateLorem(int quantity, GenerationMode mode, bool startWith)
        {
            if (Words == null || Words.Length == 0)
            {
                throw new InvalidOperationException("Error en la lectura del archivo");
            }

            Random random = new();
            StringBuilder result = new();

            if (mode == GenerationMode.Words)
            {
                if (startWith)
                {
                    result.Append(StartPhrase).Append(' ');
                    quantity -= StartWithWordCount;
                }
                result.Append(GenerateWords(quantity, random));
            }
            else
            {
                for (int i = 0; i < quantity; i++)
                {
                    result.Append(GenerateParagraph(random, startWith && i == 0));
                    if (i < quantity - 1)
                    {
                        result.Append("\n\n");
                    }
                }
            }

            return result.ToString().TrimEnd();
        }

        private static string GenerateWords(int wordQuantity, Random random)
        {
            StringBuilder loremBuilder = new();

            for (int i = 0; i < wordQuantity; i++)
            {
                int index = random.Next(Words.Length);
                loremBuilder.Append(Words[index]);
                if (i < wordQuantity - 1)
                    loremBuilder.Append(' ');
            }
            return loremBuilder.ToString();
        }

        private static string GenerateParagraph(Random random, bool includeStartPhrase)
        {
            int sentenceQuantity = random.Next(1, MaximumQuantityParagraph + 1);
            StringBuilder paragraphBuilder = new();

            for (int i = 0; i < sentenceQuantity; i++)
            {
                if (i == 0 && includeStartPhrase)
                {
                    paragraphBuilder.Append(StartPhrase).Append(' ');
                    int remainingWords = random.Next(MinimumQuantitySentence, MaximumQuantitySentence + 1) - StartWithWordCount;
                    paragraphBuilder.Append(GenerateWords(remainingWords, random));
                }
                else
                {
                    int wordQuantity = random.Next(MinimumQuantitySentence, MaximumQuantitySentence + 1);
                    paragraphBuilder.Append(GenerateWords(wordQuantity, random));
                }
                paragraphBuilder.Append(". ");
            }

            return paragraphBuilder.ToString().TrimEnd();
        }

        public static int countCharacters(string generatedText)
        {
            return generatedText.Length;
        }

        public static int countWords(string generatedText)
        {
            string[] words = generatedText.Split(' ');
            return words.Length;

        }
    }
}