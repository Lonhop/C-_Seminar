int ran = new System.Random().Next(100, 1000);
    System.Console.WriteLine(ran);
    char[] digitChar = ran.ToString().ToCharArray();
    System.Console.Write(digitChar[0]);
    System.Console.Write(digitChar[2]);