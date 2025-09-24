string fraseCorreta, fraseComDislalia;
Console.Write("Texto:");
fraseCorreta = Console.ReadLine();

fraseComDislalia = fraseCorreta.Replace("r", "l");

Console.WriteLine(fraseComDislalia);