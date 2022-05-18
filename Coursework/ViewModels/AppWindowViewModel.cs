using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.Views.Pages;
using System.Windows.Controls;

namespace Coursework.ViewModels
{
    public sealed class AppWindowViewModel
    {
        public AppWindowViewModel()
        {
            ShowSettingsCommand = new(o =>
                CurrentPage = new SettingsPage());
        }

        public Command ShowSettingsCommand { get; }

        public Page? CurrentPage { get; set; }
    }
}