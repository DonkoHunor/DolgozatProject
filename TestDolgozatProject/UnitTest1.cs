namespace TestDolgozatProject
{
	public class DolgozatTest
	{
		Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void PontFelvesz_X()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(-4),"Hibás felvételi érték");
		}

		[Test]
		public void PontFelvesz_Hozzaad()
		{
			dolgozat.PontFelvesz(4);
			Assert.That(dolgozat.Ossz.Equals(1));
		}

		[Test]
		public void MindenkiMegirta_Hamis()
		{
			dolgozat.PontFelvesz(53);
			dolgozat.PontFelvesz(29);
			dolgozat.PontFelvesz(86);
			dolgozat.PontFelvesz(-1);
			Assert.That(!dolgozat.MindenkiMegirta());
		}

		[Test]
		public void MindenkiMegirta_Igaz()
		{
			dolgozat.PontFelvesz(53);
			dolgozat.PontFelvesz(29);
			dolgozat.PontFelvesz(86);
			Assert.That(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void Bukas()
		{
			dolgozat.PontFelvesz(5);
			dolgozat.PontFelvesz(2);
			dolgozat.PontFelvesz(82);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Bukas.Equals(2));
		}

		[Test]
		public void Elegseges()
		{
			dolgozat.PontFelvesz(51);
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(49);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Elegseges.Equals(2));
		}

		[Test]
		public void Kozepes()
		{
			dolgozat.PontFelvesz(61);
			dolgozat.PontFelvesz(60);
			dolgozat.PontFelvesz(59);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Kozepes.Equals(1));
		}

		[Test]
		public void Jo()
		{
			dolgozat.PontFelvesz(71);
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(69);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Jo.Equals(1));
		}

		[Test]
		public void Jeles()
		{
			dolgozat.PontFelvesz(81);
			dolgozat.PontFelvesz(80);
			dolgozat.PontFelvesz(79);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Jeles.Equals(1));
		}

		[Test]
		public void Gyanus_Ertek()
		{
			dolgozat.PontFelvesz(81);
			dolgozat.PontFelvesz(89);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(-12));
		}

		[Test]
		public void Gyanus_Igaz()
		{
			dolgozat.PontFelvesz(82);
			dolgozat.PontFelvesz(89);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Gyanus(2));
		}

		[Test]
		public void Gyanus_Hamis()
		{
			dolgozat.PontFelvesz(81);
			dolgozat.PontFelvesz(89);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			Assert.That(!dolgozat.Gyanus(3));
		}

		[Test]
		public void Ervenytelen_Igaz()
		{
			dolgozat.PontFelvesz(45);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			Assert.That(dolgozat.Ervenytelen);
		}

		[Test]
		public void Ervenytelen_Hamis()
		{
			dolgozat.PontFelvesz(45);
			dolgozat.PontFelvesz(20);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			Assert.That(!dolgozat.Ervenytelen);
		}
	}
}