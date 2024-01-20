class ConvertSecondsIntoMinutes
{
	static void Main()
	{
		int input = 288970;
		int secondsToMinuteFactor = 60;
		int minutesToHourFactor = 60;
		int hoursToDayFactor = 24;
		
		//calculating days
		int days = input / secondsToMinuteFactor / minutesToHourFactor / hoursToDayFactor;
		//calculating seconds for days
		int daysInSeconds = days * hoursToDayFactor * minutesToHourFactor * secondsToMinuteFactor;
		//calculating remaining seconds
		int remainingSeconds = input - daysInSeconds;
		
		//calculating hours from remaining/rest of the seconds
		int hours = remainingSeconds / secondsToMinuteFactor / minutesToHourFactor;

		//calculating remaining seconds 
		int hoursInSeconds = hours * minutesToHourFactor * secondsToMinuteFactor;
		remainingSeconds = remainingSeconds - hoursInSeconds;
		
		//calculating minutes from remaining seconds
		int minutes = remainingSeconds / secondsToMinuteFactor;

		//calculating remaining seconds
		int minutesInSeconds = minutes * secondsToMinuteFactor;
		remainingSeconds = remainingSeconds - minutesInSeconds;

		System.Console.WriteLine(days + " days, " + hours + " ho urs, " + minutes + " minutes, " + remainingSeconds + " seconds");
		System.Console.ReadKey();
	}
}