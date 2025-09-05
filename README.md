# item-hold-treeview-xamarin

This example illustrates the item hold event in Xamarin.Forms SfTreeView.

## Sample

### XAML
```xaml
<ContentPage.BindingContext>
    <local:FileManagerViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<ContentPage.Behaviors>
    <local:Behavior/>
</ContentPage.Behaviors>

<syncfusion:SfTreeView x:Name="treeView"
                       ChildPropertyName="SubFiles"
                       ItemTemplateContextType="Node"
                       ItemsSource="{Binding ImageNodeInfo}">
    <syncfusion:SfTreeView.ItemTemplate>
        <DataTemplate>
            <Grid x:Name="grid" RowSpacing="0" >
                <Grid.RowDefinitions>
                    <RowDefinition Height="*" />
                    <RowDefinition Height="1" />
                </Grid.RowDefinitions>
                <Grid RowSpacing="0" Grid.Row="0">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="40" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <Grid Padding="5,5,5,5">
                        <Image Source="{Binding Content.ImageIcon}"
                               VerticalOptions="Center"
                               HorizontalOptions="Center"
                               HeightRequest="35" 
                               WidthRequest="35"/>
                    </Grid>
                    <Grid Grid.Column="1"              
                          RowSpacing="1"
                          Padding="1,0,0,0"
                          VerticalOptions="Center">
                        <Label LineBreakMode="NoWrap"
                               Text="{Binding Content.ItemName}"
                               VerticalTextAlignment="Center">
                        </Label>
                    </Grid>
                </Grid>
            </Grid>
        </DataTemplate>
    </syncfusion:SfTreeView.ItemTemplate>
</syncfusion:SfTreeView>
```

### Behavior
```csharp
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
```

## Requirements to run the demo
Visual Studio 2017 or Visual Studio for Mac.
Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.

## Conclusion

I hope you enjoyed learning about how to the item hold works in Xamarin.Forms TreeView (SfTreeView).

You can refer to our Xamarin.Forms TreeViewfeature tour page to know about its other groundbreaking feature representations and documentation, and how to quickly get started for configuration specifications.

For current customers, you can check out our components from the License and Downloads page. If you are new to Syncfusion, you can try our 30-day free trial to check out our other controls.

If you have any queries or require clarifications, please let us know in the comments section below. You can also contact us through our support forums, Direct-Trac, or feedback portal. We are always happy to assist you!