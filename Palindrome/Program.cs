// See https://aka.ms/new-console-template for more information
using System;
using System.Text.RegularExpressions;

Console.WriteLine("Enter a string:");
string input = Console.ReadLine();
// Remove spaces, punctuation, and convert to lowercase
string processedInput = Regex.Replace(input, @"\s+|[^a-zA-Z0-9]+", "").ToLower();

int ind = 0;
bool c = true;



int l = processedInput.Length;
while (ind < l)
{
    if (processedInput[ind] != processedInput[l - ind - 1])
    {
        c = false;
    }
    ind++;
}

if (c){
    Console.WriteLine("The input is palindrome");
}
else{
    Console.WriteLine("The input is not palindrome");
}




