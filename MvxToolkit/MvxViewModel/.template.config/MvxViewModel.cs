using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;

namespace $rootnamespace$
{
    public class $safeitemname$ : MvxViewModel
    {
        private IMvxNavigationService _navigationService;

        public $safeitemname$(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
