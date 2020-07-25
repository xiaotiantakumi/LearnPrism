using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using LearnPrism.Conditions;
using Prism.Navigation;

namespace LearnPrism.ViewModels
{
    public class PrismContentPage1ViewModel : ViewModelBase
    {
        public PrismContentPage1ViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var param = parameters[nameof(PrismContentPageCondition)] as PrismContentPageCondition;
            if (param == null)
            {
                throw new ArgumentException(nameof(PrismContentPageCondition));
            }
            Title = param.Title;
        }
    }
}
