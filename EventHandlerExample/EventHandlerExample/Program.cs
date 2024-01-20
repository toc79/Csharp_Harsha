using System;

namespace EventHandlerExample
{
	class Program
	{
		static void Main()
		{
			Program p = new Program();
			p.DoWork();

			Console.ReadKey();
		}

		public void DoWork()
		{
			//crate object of Publisher class
			Publisher publisher = new Publisher();

			//handle the event (or) suscrobe to event 
			publisher.myEvent += (sender, e) =>
			{
				int c = e.a + e.b;
				Console.WriteLine(c);
			};

			//invoke the event
			publisher.RiseEvent(this, 10, 50);
			publisher.RiseEvent(this, -5, 30);
			publisher.RiseEvent(this, 14, 10);
		}
	}
}
