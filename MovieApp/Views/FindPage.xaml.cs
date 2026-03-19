using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Views;

public partial class FindPage : ContentPage
{
    public FindPage()
    {
        InitializeComponent();
        Title = "List Movies";
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        var moveTemplate = new DataTemplate(typeof(TextCell));
        moveTemplate.SetBinding(TextCell.TextProperty, "Title");
        moveTemplate.SetBinding(TextCell.DetailProperty, "Rating");

        lstMovies.ItemTemplate = moveTemplate;
        lstMovies.ItemsSource = App.MovieList.GetMovies();
    }
}