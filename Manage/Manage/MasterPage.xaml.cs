using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Manage
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();
            //this.BackgroundColor = Color.LightGray;
            //Creating TapGestureRecognizers
            var tapImage = new TapGestureRecognizer();
            //Binding events
            tapImage.Tapped += tapImage_Tapped;
            //Associating tap events to the image buttons
            img.GestureRecognizers.Add(tapImage);

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "home.png",
                TargetType = typeof(HomePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Profile",
                IconSource = "profile.png",
                TargetType = typeof(ProfilePage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "My Flight",
                IconSource = "myflight.png",
                TargetType = typeof(MyFlightPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Recommend to a friend",
                IconSource = "bell.png",
                TargetType = typeof(RecommendFriendPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Notifications",
                IconSource = "star.png",
                TargetType = typeof(NotificationsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Setting",
                IconSource = "setting.png",
                TargetType = typeof(SettingPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Help",
                IconSource = "help.png",
                TargetType = typeof(HelpPage)
            });

            listView.ItemsSource = masterPageItems;
        }


             

    // Use like click button event
    void tapImage_Tapped(object sender, EventArgs e)
    {
        // handle the tap
        DisplayAlert("Alert", "This is an image button", "OK");
    }


    }
}
