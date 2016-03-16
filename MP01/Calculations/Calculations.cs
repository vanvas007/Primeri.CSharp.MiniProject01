﻿using System;

namespace Calculations
{
	public class MainLibrary
	{
		//Дефиниции
		public Formula01 F01 = new Formula01 ();
		public Formula02 F02 = new Formula02 ();
		public Formula03 F03 = new Formula03 ();

		//Библиотеки
		private Colors.ForCLI _cl = new Colors.ForCLI ();
		public MainLibrary ()
		{
		}

		public void comands ()
		{
			_cl.Default (); Console.WriteLine ("Налични команди\n");

			_cl.Comand (); Console.Write ( "[яма]" );
			_cl.Default (); Console.WriteLine (" - пресмятане на строителна яма");

			_cl.Comand (); Console.Write ( "[въгъл]" );
			_cl.Default (); Console.WriteLine (" - пресмятане на вдлъбнат ъгъл");

			_cl.Comand (); Console.Write ( "[иъгъл]" );
			_cl.Default (); Console.WriteLine (" - пресмятане на изпъкнал ъгъл");
		}
	}
}

