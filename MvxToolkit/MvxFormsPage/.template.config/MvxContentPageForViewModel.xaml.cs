﻿using Arianna.Web.Mobile.MvvmCross;
using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms.Xaml;

namespace $rootnamespace$
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    $viewattribute$
    public partial class $viewname$ : $mvxpagetype$<$viewmodelname$>
    {
        public $viewname$()
        {
            InitializeComponent();
        }
    }
}