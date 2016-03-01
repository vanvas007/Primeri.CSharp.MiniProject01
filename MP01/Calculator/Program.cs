using System;

namespace Calculator
{
	class MainClass
		{
		//Дефиниране на библиотека
		public UserInput.UInput  uImput = new UserInput.UInput ();
		public About.Me about = new About.Me ();


		public static void Main (string[] args)
		{
			MainClass _program = new MainClass ();

			//Форматиране на програмата
			Console.Title = _program.about.shortName + ", "  + _program.about.version;

			//стартиране на програмата
			_program.uImput.sayHello ();
			_program.uImput.getUserCommands ();
		}
	}
}
