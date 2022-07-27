void CountVowelsLetters(string text, char[] letters,int count = 0,int i = 0)
{
    int index = letters.Length - i;
    int textLength = text.Length;
    if (index == 0)
    {
        Console.WriteLine(count);
        return;
    }
    for(int j = 0; j < textLength; j++)
    {
        if(letters[i] == text[j]) count++;
    }
    i++;
    CountVowelsLetters(text, letters,count,i);
}
char[] Vowelsletters = new char[]{'а','е','ё','и','й','о','у','ы','э','ю','я','1'};
Console.WriteLine("Напишите поговорку");
string text = Console.ReadLine();
string textLower = text.ToLower();
int length = textLower.Length;
CountVowelsLetters(text, Vowelsletters, length);