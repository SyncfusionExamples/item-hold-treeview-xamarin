using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class Behavior : Behavior<ContentPage>
    {
        SfTreeView treeView;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            treeView = bindable.FindByName<SfTreeView>("treeView");
            treeView.ItemHolding += TreeView_ItemHolding;
        }

        private void TreeView_ItemHolding(object sender, ItemHoldingEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Item Hold", "TreeView item is holding", "Close");
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            treeView.ItemHolding += TreeView_ItemHolding;
        }
    }
}
    


