using StudentApp.Business.ViewModels;

namespace StudentsApp.Pages;

public partial class AddNewStudentPage : ContentPage
{

    public AddNewStudentPageViewModel vm;
    public AddNewStudentPage()
	{
		InitializeComponent();
		this.BindingContext  = vm = new AddNewStudentPageViewModel();	
	}
}