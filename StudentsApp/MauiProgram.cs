using Microsoft.Extensions.Logging;
using StudentApp.Business.ViewModels;
using StudentsApp.Pages;
namespace StudentsApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Pages
            builder.Services.AddTransient<StudentsListPage>();
            builder.Services.AddTransient<AddNewStudentPage>();

            

            //View Model 
            builder.Services.AddTransient<StudentsListPageViewModel>();
            builder.Services.AddTransient<AddNewStudentPageViewModel>();
            
            return builder.Build();
        }
    }
}
