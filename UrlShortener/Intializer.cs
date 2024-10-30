using DAL.Contracts;
using System.Runtime.CompilerServices;

namespace UrlShortener
{
    public static class Intializer
    {
        public static void Initialize(this WebApplication webApplication) //we need to review this and 
                                                                          //reviewing the IDbContextIntializer
        {
            using var scope= webApplication.Services.CreateScope();//using will dispose the scope
            var services = scope.ServiceProvider;
            var urlDbContextIntializer = services.GetRequiredService<IDbContextIntializer>();

            try
            {
                urlDbContextIntializer.Initilize();
              //  scope.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message); 
                
            }

        }
    }
}
