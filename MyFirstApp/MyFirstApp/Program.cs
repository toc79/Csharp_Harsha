class FeetToCentimeters
{
    static void Main()
    {
        int feet = 5;
        int intches = 7;

        double oneInchToCm = 2.54;
        double oneFeetToInches = 12;

        double output = (feet * oneFeetToInches + intches) * oneInchToCm;
        System.Console.WriteLine(output);
        System.Console.ReadKey();
    }
}