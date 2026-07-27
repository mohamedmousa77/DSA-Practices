public class HighScores
{
    private List<int> _scores;
    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores() => _scores;

    public int Latest() => Scores().Last();
    

    // public int PersonalBest() => Scores().Max();

    // public List<int> PersonalTopThree()
    // {
    //    return _scores
    //         .OrderByDescending(s => s)
    //         .Take(3)
    //         .ToList();
    // }

     public int PersonalBest()
     {
         int highest = _scores[0]; //  int.MinValue;
         for (int i = 0; i < Scores().Count; i++)
         {
             if (Scores()[i] > highest)
             {
                 highest = Scores()[i];
             }
         }
         return highest;
     }

     public List<int> PersonalTopThree()
     {
         List<int> top = new List<int>();
    
         List<int> sortedList = GetSortedScoresDescending();
    
         int itemsToTake = Math.Min(3, sortedList.Count);
    
         for (int i = 0; i < itemsToTake; i++)
         {
             top.Add(sortedList[i]);
         }
         return top;
     }
    
     public List<int> GetSortedScoresDescending()
     {
         List<int> sortedList = new List<int>(_scores);
    
         for(int i = 0;i < sortedList.Count; i++)
         {
             for (int j = 0; j <sortedList.Count -1 -i;  j++)
             {
                 if (sortedList[j] < sortedList[j + 1])
                 {
                     int temp = sortedList[j];
                     sortedList[j] = sortedList[j + 1];
                     sortedList[j + 1] = temp;
                 }
             }
         }
         return sortedList;
     }
}