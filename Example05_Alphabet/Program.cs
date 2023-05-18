﻿// В машинном алфавите 4е буквы "a" "i" "c" "b", необходимо показать 
// все слова состоящие из Т комбинаций букв этого алфавита.
// Т - количество букв в слове.

// char[] s = {'a', 'i', 'c', 'b'}; // итеративный
// int count = s.Length;
// int n = 1;
// for (int i = 0, i < count; i++)
// {
//     Console.WriteLine($"{n++, -5} {s[i]}");
// }

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("aisb", new char[5]);