using System;
using MvvmCross.ViewModels;
using Mapimax.Core.ViewModels;

namespace Mapimax.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}
