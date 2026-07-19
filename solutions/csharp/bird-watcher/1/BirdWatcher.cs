class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] vists = new int[] {0, 2, 5, 3, 7, 8, 4};
        // for(int x =0; x <7; x++){
        //     System.Console.Write(birdsPerDay[x]);
        // }
        // birdsPerDay = vists;
        return vists;
    }

    public int Today()
    {
        int todayVisits = birdsPerDay[birdsPerDay.Length - 1];
         System.Console.Write(todayVisits);
        return todayVisits;
    }

    public void IncrementTodaysCount()
    {
        int todayVisits = birdsPerDay[birdsPerDay.Length - 1];
         birdsPerDay[birdsPerDay.Length - 1] = todayVisits + 1;
         // (birdsPerDay[birdsPerDay.Length - 1]) + 1 ;
        // System.Console.Write(todayVisits);
    }

    public bool HasDayWithoutBirds()
    {
        bool noVisit = false;
        for(int x = 0; x < 7; x++){
            if(birdsPerDay[x] == 0){
                noVisit = true;
                break;
            }
        }
        return noVisit;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int x = 0; x < numberOfDays; x++){
            count += birdsPerDay[x];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        for(int x = 0; x < birdsPerDay.Length-1; x++){
            if(birdsPerDay[x] >= 5){
                count ++;
            }            
        }
        return count;
    }
}
