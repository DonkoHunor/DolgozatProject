namespace DolgozatProject
{
	public class Dolgozat
	{
		private List<int> pontok;

		public Dolgozat() 
		{
			pontok = new List<int>();
		}

		public int Ossz { get { return pontok.Count; } }

		public void PontFelvesz(int x)
		{
			if( x < -1 || x > 100)
			{
				throw new ArgumentException();
			}
			pontok.Add(x);
		}

		public bool MindenkiMegirta()
		{
			if ( pontok.Count == 0 )
			{
				return false;
			}
			else if(pontok.Contains(-1))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public int Bukas
		{
			get
			{
				int db = 0;
				foreach (int pont in pontok)
				{
					if (pont != -1 && pont < 50)
					{
						db++;
					}
				}
				return db;
			}
		}

		public int Elegseges
		{
			get
			{
				int db = 0;
				foreach (int pont in pontok)
				{
					if (pont != -1 && pont >= 50 && pont <= 60)
					{
						db++;
					}
				}
				return db;
			}
		}

		public int Kozepes
		{
			get
			{
				int db = 0;
				foreach (int pont in pontok)
				{
					if (pont != -1 && pont > 60 && pont <= 70)
					{
						db++;
					}
				}
				return db;
			}
		}

		public int Jo
		{
			get
			{
				int db = 0;
				foreach (int pont in pontok)
				{
					if (pont != -1 && pont > 70 && pont <= 80)
					{
						db++;
					}
				}
				return db;
			}
		}

		public int Jeles
		{
			get
			{
				int db = 0;
				foreach (int pont in pontok)
				{
					if (pont != -1 && pont > 80)
					{
						db++;
					}
				}
				return db;
			}
		}

		public bool Gyanus(int kivalok)
		{
			if(kivalok < 0)
			{
				throw new ArgumentException();
			}
			if(kivalok >= this.Jeles)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool Ervenytelen
		{
			get
			{
				int db = 0;
				foreach (int pont in pontok)
				{
					if (pont == -1)
					{
						db++;
					}
				}

				if (db >= pontok.Count/2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}