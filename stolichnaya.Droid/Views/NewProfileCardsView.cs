
using Android.Runtime;
using Loymax.Module.Profile.ViewModels;
using Loymax.Module.Profile.Droid;
using Loymax.Module.Profile.Droid.Views;


namespace alfa.Droid.Views
{
    [Register(nameof(NewProfileCardsView))]
    public class NewProfileCardsView : ProfileCardFragment
    {
        protected override int FragmentId => stolichnaya.Droid.Resource.Layout.NewProfileCardsView;
    }
}