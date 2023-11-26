using StudentApp.Business.ViewModels;

namespace StudentsApp.Pages;

public partial class StudentsListPage : ContentPage
{
    public StudentsListPage(StudentsListPageViewModel model)
	{
		InitializeComponent();
		this.BindingContext  = model;	
	}
}