using System;
using MvvmCross.ViewModels;

namespace Mapimax.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private double _beerInLitres;
        public double BeerInLitres
        {
            get => _beerInLitres;
            set => SetProperty(ref _beerInLitres, value);
        }
    }
}
