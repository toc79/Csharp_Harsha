using System;

namespace ClassLibrary1
{
	//delegate type
	public delegate void MyDelegateType(int a, int b);

	//publiser
	public class Publiser 
    {
		//private delegate
		private MyDelegateType myDelegate;
		
		//step 1: create event
		public event MyDelegateType myEvent
		{
			add
			{
				myDelegate += value;
			}

			remove
			{
				myDelegate -= value;
			}
		}

		public void RaiseEvent(int a, int b)
		{
			//step 2: rise event
			if (myDelegate != null)
				myDelegate(a, b);
		}
    }
}
