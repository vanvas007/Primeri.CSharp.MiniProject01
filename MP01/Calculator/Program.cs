﻿using System;

namespace Calculator
{
	class MainClass
		{
		//Дефиниране на библиотека
		public UserInput.UInput  uImput = new UserInput.UInput ();
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			MainClass _program = new MainClass ();
			_program.uImput.justTesting ();
		}
	}
}
