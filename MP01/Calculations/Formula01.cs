using System;

namespace Calculations
/// <summary>
/// Клас за формула за обикновена строителна яма. (Формула 1)/// </summary>
{
	public class Formula01
	{
		//Библиотеки
		private Colors.ForCLI _c=new Colors.ForCLI ();
		/// <summary>
		/// Конструктор на формула 01/// </summary>
		public Formula01 () //Формула за обикновена строителна яма
		{
		}

		/// <summary>
		/// Метод за пресмятане на формула 01
		/// </summary>
		/// <param name="_userInput">User input.</param>
		public void calc (string _userInput)
		{
			try {
				string[] param = _userInput.Split (' ');

				if ( param.Length > 1  && _userInput.Contains ("-п"))
					{
						//Помощ за командата

					help ();

					}

				if ( param.Length > 1  && !_userInput.Contains ("-п"))
						{
							//Изчисления 
					double _result = 0;

					if ( runCalculations ( param, out _result ))
					{
						_c.Default (); Console.Write ("Обема на строителната яма е:  ");
						_c.Result (); Console.Write (_result.ToString("N2"));
						_c.Default (); Console.WriteLine (" м3");
						} else {
						_c.Default (); Console.WriteLine ("Има грешно въведени параметри, Може да проверите синтаксиса с параметър '-п'\n");
					}

						}


				} catch {
			}
		}
		

		/// <summary>
		/// Вътрешен метод за парсване на командата от потребителя/// </summary>
		/// <returns><c>true</c>, if calculations was run, <c>false</c> otherwise.</returns>
		/// <param name="_param">Parameter.</param>
		/// <param name="_result">Result.</param>
		private bool runCalculations (string[] _param, out double _result)
					{
						try	{
							double _a1 = 0, _b1 = 0, _a2 = 0, _b2 = 0, _h = 0;

							//_param[0]==<име на команда>
							Double.TryParse (_param[1], out _a1);
							Double.TryParse (_param[2], out _b1);
							Double.TryParse (_param[3], out _a2);
							Double.TryParse (_param[4], out _b2);
							Double.TryParse (_param[5], out _h);

							double F1 = _a1 * _b1, F2 = _a2 * _b2;
							_result = _h * (F1 + F2) / 2;
							
				return true;
						}catch {
						}

			_result = 0;		 
			return false;
					}	

		/// <summary>
		/// Вътрешен метод показващ синтаксиса на командата в командния ред/// </summary>
		private void help ()
		{
			_c.Result (); Console.Write ("[яма]");
			_c.Default (); Console.WriteLine (" - команда за пресмятане на строителна яма");

			_c.Comand (); Console.Write ("параметри: ");
			_c.Default (); Console.WriteLine (" a1 b1 a2 b2 h\n");

			_c.Comand (); Console.Write ("а1 и b1 ");
			_c.Default (); Console.WriteLine (" - ширина и дължина на горната страна на изкопа");

			_c.Comand (); Console.Write ("а2 и b2 ");
			_c.Default (); Console.WriteLine (" - ширина и дължина на долната страна на изкопа");

			_c.Comand (); Console.Write ("h ");
			_c.Default (); Console.WriteLine ("- височина на изкопа\n");

		}
	}
}

