namespace Abraks.Common.Constants
{
    public class StringConstants
    {
        public const string DefaultAdminPassword = "Secret_Pass12";
        public const string RoleAdmin = "Admin";
        public const string AdminUsername = "Abraks";
        public const string AdminEmail = "abraks@abv.bg";
        public const string RoleDancers = "Dancer";
        public const string ContextConnectionString = "AbraksContext";

        public const string ExceptionHandlerPath = "/Home/Error";

        public const string DefaultMapRouteName = "default";
        public const string DefaultMapRouteTemplate = "{controller=Home}/{action=Index}/{id?}";
        public const string AreaMapRouteName = "area";
        public const string AreaMapRouteTemplate = "{area:exists}/{controller=Home}/{action=Index}/{id?}";
        public const string SendGridEmailSettings = "EmailSettings";
        public const string SendGridDefaultEmail = "daniel_atila@abv.bg";
        public const string SendGridDefaultSender = "Abraks Administrator";

        public const string EventDetailsNotExist = "Book with id {0} does not exist.";
    }
}
