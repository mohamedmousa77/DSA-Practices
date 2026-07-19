class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    
    public double ExpectedMinutesInOven() 
    {
        return 40; 
        // Minutes Duration in Oven
    }    
    // TODO: define the 'RemainingMinutesInOven()' method
    public double RemainingMinutesInOven(double actualMinutesInOven)
    {
        return ExpectedMinutesInOven() - actualMinutesInOven; 
        // Minutes the lasagna still has to remain in the oven
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public double PreparationTimeInMinutes(double layers)
    {
        return layers * 2;
        // Time Spent based on layer
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public double ElapsedTimeInMinutes(double layers, double minutesInOven)
    {
        double spent = ExpectedMinutesInOven() - RemainingMinutesInOven(minutesInOven);
        return PreparationTimeInMinutes(layers) + spent;
    }
}
