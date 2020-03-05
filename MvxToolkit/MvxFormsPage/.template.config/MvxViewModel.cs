using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Arianna.Mobile.Core.ViewModels
{
    public class $viewmodelname$ : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public $viewmodelname$(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
