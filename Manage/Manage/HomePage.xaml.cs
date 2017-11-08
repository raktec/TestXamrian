using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Manage
{
    public partial class HomePage : ContentPage
    {
        private StackLayout _manage;
        private StackLayout _notice;
        private StackLayout _buy;
        private StackLayout _order;



        public HomePage()
        {
            InitializeComponent();
            _manage = manage;
            _notice = notice;
            _buy = buy;
            _order = order;
        }

        void changeColor(StackLayout obj, string id)
        {
            Label myLabel;
            myLabel = obj.FindByName<Label>("myLabel0");
            myLabel.TextColor = Color.Black;
            myLabel = obj.FindByName<Label>("myLabel1");
            myLabel.TextColor = Color.Black;

            myLabel = obj.FindByName<Label>("myLabel2");
            myLabel.TextColor = Color.Black;

            myLabel = obj.FindByName<Label>("myLabel3");
            myLabel.TextColor = Color.Black;


            myLabel = obj.FindByName<Label>(id);
            myLabel.TextColor = Color.Red;


        }

        void onTapCommand(object sender, EventArgs args)
        {

            StackLayout sl = (StackLayout)sender;

            if (sl.ClassId is string)
            {
                switch ((string)sl.ClassId)
                {
                    case "0":

                        this.changeColor(sl, "myLabel0");
                        this.Title = "Manage";
                        _manage.IsVisible = true;
                        _notice.IsVisible = false;
                        _buy.IsVisible = false;
                        _order.IsVisible = false;

                        break;
                    case "1":
                        this.Title = "Notice";
                        this.changeColor(sl, "myLabel1");
                        _manage.IsVisible = false;
                        _notice.IsVisible = true;
                        _buy.IsVisible = false; 
                        _order.IsVisible = false; 
                        break;
                    case "2":
                        this.Title = "Buy";

                        this.changeColor(sl, "myLabel2");
                        _manage.IsVisible = false;
                        _notice.IsVisible = false;
                        _buy.IsVisible = true; 
                        _order.IsVisible = false; 
                        break;
                    case "3":
                        this.Title = "Order";
                        _manage.IsVisible = false;
                        _notice.IsVisible = false;
                        _buy.IsVisible = false; 
                        _order.IsVisible = true; 
                        this.changeColor(sl, "myLabel3");
                        break;
                    default:
                        this.Title = "Manage";

                        this.changeColor(sl, "myLabel0");
                        break;
                }


                //}
            }

        }

    }
}
