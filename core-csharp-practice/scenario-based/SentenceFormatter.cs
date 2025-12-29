using System;

class SetenceFormatter{
    static string FormatParagraph(string text){
        if (text == null || text.Length == 0)
            return "";

        char[] result = new char[text.Length * 2];
        int index = 0;

        bool capitalizeNext = true;
        bool spaceAllowed = false;

        for (int i = 0; i < text.Length; i++){
            char ch = text[i];

            // Skip leading spaces
            if (index == 0 && ch == ' ')
                continue;

            // Handle multiple spaces
            if (ch == ' '){
                if (spaceAllowed){
                    result[index++] = ' ';
                    spaceAllowed = false;
                }
                continue;
            }

            // Capitalize first letter of sentence
            if (capitalizeNext && ch >= 'a' && ch <= 'z'){
                ch = (char)(ch - 32);
                capitalizeNext = false;
            }

            result[index++] = ch;
            spaceAllowed = true;

            // Sentence ending punctuation
            if (ch == '.' || ch == '?' || ch == '!'){
                capitalizeNext = true;
                result[index++] = ' ';
                spaceAllowed = false;
            }
        }

        return new string(result, 0, index).Trim();
    }

    static void AnalyzeParagraph(string text, string oldWord, string newWord){
        if (text == null || text.Length == 0)
        {
            Console.WriteLine("Word Count: 0");
            Console.WriteLine("Longest Word: None");
            return;
        }

        int wordCount = 0;
        int maxLen = 0;
        string longestWord = "";

        char[] word = new char[text.Length];
        int wIndex = 0;

        char[] updated = new char[text.Length * 2];
        int uIndex = 0;

        for (int i = 0; i <= text.Length; i++){
            char ch = (i == text.Length) ? ' ' : text[i];

            if (ch != ' '){
                word[wIndex++] = ch;
            }
            else if (wIndex > 0){
                wordCount++;

                // Find longest word
                if (wIndex > maxLen){
                    maxLen = wIndex;
                    longestWord = new string(word, 0, wIndex);
                }

                // Replace word (case-insensitive)
                bool match = CompareIgnoreCase(word, wIndex, oldWord);

                if (match) {
                    for (int j = 0; j < newWord.Length; j++)
                        updated[uIndex++] = newWord[j];
                }
                else{
                    for (int j = 0; j < wIndex; j++)
                        updated[uIndex++] = word[j];
                }

                updated[uIndex++] = ' ';
                wIndex = 0;
            }
        }

        Console.WriteLine("Word Count: " + wordCount);
        Console.WriteLine("Longest Word: " + longestWord);
        Console.WriteLine("Updated Paragraph: " + new string(updated, 0, uIndex));
    }

    // Case-insensitive comparison 
    static bool CompareIgnoreCase(char[] word, int len, string target){
        if (len != target.Length)
            return false;

        for (int i = 0; i < len; i++){
            char c1 = word[i];
            char c2 = target[i];

            if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
            if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);

            if (c1 != c2)
                return false;
        }
        return true;
    }

    
    static void Main(string[] args){
        int choice;

        do{
            Console.WriteLine("\n===== TEXT UTILITY MENU =====");
            Console.WriteLine("1. Sentence Formatter");
            Console.WriteLine("2. Paragraph Analyzer");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    Console.WriteLine("\nEnter paragraph:");
                    string input = Console.ReadLine();

                    string formatted = FormatParagraph(input);
                    Console.WriteLine("\nFormatted Paragraph:");
                    Console.WriteLine(formatted);
                    break;

                case 2:
                    Console.WriteLine("\nEnter paragraph:");
                    string para = Console.ReadLine();

                    Console.WriteLine("Enter word to replace:");
                    string oldWord = Console.ReadLine();

                    Console.WriteLine("Enter replacement word:");
                    string newWord = Console.ReadLine();

                    AnalyzeParagraph(para, oldWord, newWord);
                    break;

                case 3:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

        } while (choice != 3);
    }
}
