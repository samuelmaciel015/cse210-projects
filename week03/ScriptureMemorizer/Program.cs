using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        //Reference reference = new Reference("Moroni", 10, 4, 5);
        //Reference reference1 = new Reference("Alma", 7, 14);
        //Scripture scripture = new Scripture(reference, "Behold my Spirit is upon you, wherefore all thy words will I justify; and the mountains shall flee before you, and the rivers shall turn from their course; and thou shalt abide in me, and I in you; therefore walk with me.");



        Word again = new Word("errado");

        again.GetDisplayText();
    }
}