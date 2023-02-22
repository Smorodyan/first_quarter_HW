
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма.


void newText(string[] text)
{
    Console.Write("{ ");
    for(int i = 0; i < text.Length; i++)
    {
        string current = text[i];
        if(current.Length <= 3 )
            Console.Write(text[i] + "; ");
    }
    Console.Write("}");
}

string[] text = {"hello", "wod", "world", "2"};

for(int i = 0; i < text.Length; i++)
 Console.Write(text[i] + "; ");

Console.WriteLine();
newText(text);


