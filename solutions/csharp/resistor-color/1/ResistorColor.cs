public static class ResistorColor
{
    static string [] colors = 
     {"black", "brown",
         "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    
    public static int ColorCode(string color)
    {
        return Array.IndexOf(colors, color);
        // for(int x = 0; x < colors.Length; x++)
        // {
        //     if(color == colors[x]){
        //         return x;
        //     }
        // }        
        // return -1;
    }

    public static string[] Colors()
    {
        return colors;
    }
}