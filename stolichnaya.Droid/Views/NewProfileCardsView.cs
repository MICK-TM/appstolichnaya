
using Android.Runtime;
using Loymax.Module.Profile.Droid.Views;


namespace alfa.Droid.Views
{
    [Register(nameof(NewProfileCardsView))]
    public class NewProfileCardsView : ProfileCardFragmentOld
    {
        protected override int FragmentId => stolichnaya.Droid.Resource.Layout.NewProfileCardsView;
    }
}