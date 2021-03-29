namespace stolichnaya.iOS.Views
{
    using Loymax.Core.iOS.Views;
    using Loymax.Core.ViewModels.Base;
    using MvvmCross.ViewModels;
    using stolichnaya.Core.ViewModels;

    [MvxViewFor(typeof(MenuViewModel))]
    public class MenuView : BaseMenuView<BaseMenuViewModel>
    {
    }
}