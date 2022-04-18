namespace K_Smart_IMS.Models
{
    //this view model standardizes the way we use routing in our shared layout.html page
    public static class Nav
    {
        public static string Active(string value, string current) => 
            (value == current) ? "active" : "";
        public static string Active(int value, int current) =>
            (value == current) ? "active" : "";
    }
}
