using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentApp.Business.Models;

namespace StudentApp.Business.ViewModels
{
    public partial class AddNewStudentPageViewModel :ObservableObject
    {
        public AddNewStudentPageViewModel()
        {
            StudentDetails = new Student();
        }


        [ObservableProperty]
        private bool isRunning;


        public Student? StudentDetails { get; set; } 



        [RelayCommand]
        public async void AddStudent()
        {
            IsRunning =true;  
            
            var data = this.StudentDetails;

            if (data == null)
            {

            }

            IsRunning = false;
        }

    }
}
