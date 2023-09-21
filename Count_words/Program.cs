// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome! I can help to know the frequency of words in your sentence");
Console.WriteLine("Enter your sentence: ");
string input = Console.ReadLine();

// Split the input string into words, ignoring punctuations
string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(word => new string(word.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower())
                        .ToArray();



Dictionary<string, int> count_word = new Dictionary<string, int>();

foreach (string word in words)
{
    if (count_word.ContainsKey(word))
    {
        count_word[word] += 1;
    }
    else
    {
        count_word[word] = 1;
    }
}

Console.WriteLine("Here is the frequency of each words in the sentence you entered...");
foreach( KeyValuePair<string, int> kvp in count_word )
        {
            Console.WriteLine($"- {kvp.Key}: {kvp.Value}");
        }