using System;


//child EventArgs
public class CustomEventArgs : EventArgs
{
	public int a { get; set; }
	public int b { get; set; }
}

//publisher
public class Publisher
{
	// step 1: create event 
	public event EventHandler<CustomEventArgs> myEvent;

	public void RiseEvent(object sender, int aa, int bb)
	{
		//step 2: raise event
		if(this.myEvent != null)
		{
			CustomEventArgs customEventArgs = new CustomEventArgs() {a = aa, b = bb};
			this.myEvent(sender, customEventArgs);
		}

	}
}