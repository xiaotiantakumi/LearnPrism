using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnPrism.Conditions;
using LearnPrism.Views;
using Prism.Services;

namespace LearnPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IPageDialogService _pageDialogService;

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService)
        {
            _pageDialogService = pageDialogService;
            Title = "Main Page";
            LabelC = "DDD";
            ButtonC = new DelegateCommand(SetText);
            NextCommand = new DelegateCommand(PagePrismContentPage1Show);
            MessageCommand = new DelegateCommand(MessageShow);
        }


        private string _labelC = string.Empty;
        public string LabelC
        {
            get { return _labelC; }
            set
            {
                SetProperty(ref _labelC, value);
            }
        }

        public DelegateCommand ButtonC { get; set; }
        public DelegateCommand NextCommand { get; set; }
        public DelegateCommand MessageCommand { get; set; }

        private void SetText()
        {
            LabelC = "EEE";
        }

        private void PagePrismContentPage1Show()
        {
            var param = new NavigationParameters
            {
                {nameof(PrismContentPageCondition),new PrismContentPageCondition("Test") }
            };
            NavigationService.NavigateAsync(nameof(PrismContentPage1), param);
        }

        private void MessageShow()
        {
            _pageDialogService.DisplayAlertAsync("たいとる", "めっせーじ", "OK");
        }
    }
}
