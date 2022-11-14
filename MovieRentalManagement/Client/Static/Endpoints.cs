namespace MovieRentalManagement.Client.Static
{
    public class EndPoints
    {
        private static string Prefix = "api/";

        public static string MoviesEndpoint = $"{Prefix}movies/";

        public static string GenresEndpoint = $"{Prefix}genre/";
        public static string IndustryEndpoint = $"{Prefix}industry/";
        public static string BookingEndpoint = $"{Prefix}booking/";
        public static string CustomerEndpoint = $"{Prefix}customer/";
    }
}
