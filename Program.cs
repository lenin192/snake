﻿using System;

namespace snake
{
	class MainClass
	{
		public static void Main(string[] args)
		{
		int x1 = 1;
		int y1 = 2;
		char sym1 = '*';
        Console.SetCursorPosition(x1, y1);
        Console.Write(sym1);

        int x2 = 3;
        int y2 = 4;
        char sym2 = '@';

        Console.SetCursorPosition(x2, y2);
        Console.Write(sym2);

        int x3 = 5;
        int y3 = 6;
        char sym3 = '#';

        Console.SetCursorPosition(x3, y3);
        Console.Write(sym3);

        Console.ReadLine();
		}
	}
}
