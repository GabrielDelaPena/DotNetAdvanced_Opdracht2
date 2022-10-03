using Oefening1;

Koe koe = new Koe(50, "boe", "Downloads\\cow-moo2.wav");
Console.WriteLine(koe.Zegt());
Console.WriteLine(koe.Gewicht);
Console.WriteLine(koe.Geluid);

Slang slang = new Slang(10, "ssj", "Downloads\\hiss.mp3");
Console.WriteLine(slang.Zegt());
Console.WriteLine(slang.Gewicht);
Console.WriteLine(slang.Geluid);

Varken varken = new Varken(80, "groink", "Downloads\\PIG.wav");
Console.WriteLine(varken.Zegt());
Console.WriteLine(varken.Gewicht);
Console.WriteLine(varken.Geluid);