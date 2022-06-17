namespace LOGIC_DRILLS_Traffic_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static string UpdateLight(string current)
        {
            if (current.ToLower() == "green")
            {
                return "yellow";
            }
            else if (current.ToLower() == "yellow")
            {
                return "red";
            }    
            else
            {
                return "green";
            }
        }
    }
}