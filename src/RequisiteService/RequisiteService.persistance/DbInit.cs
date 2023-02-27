using RequisiteService.Application.Interface;

namespace RequisiteService.persistance
{
    public class DbInit
    {
        public static void init(RequisiteContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
