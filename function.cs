using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace batch_shield_deob
{
    public class functions
    {
        public static string Deobfuscate(string input)
        {
            string removedPercentages = Regex.Replace(input, @"%[a-zA-Z0-9]+%", "");
            string[] lines = removedPercentages.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Skip the ASCII art and "Obfuscated By Batchsield" line
            int startIndex = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Trim().StartsWith("::"))
                {
                    startIndex = i + 1;
                }
                else
                {
                    break;
                }
            }

            return string.Join(Environment.NewLine, lines.Skip(startIndex));
        }

        public static string ReadFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return null;
            }
        }

        public static void WriteFile(string filePath, string content)
        {
            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine($"Text successfully written to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
