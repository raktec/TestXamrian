using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Manage.Controls
{
    public partial class BottomBar : ContentView
    {
        

        public BottomBar()
        {
            InitializeComponent();


        }

       
        void changeColor(StackLayout obj, string id){
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

                        break;
                    case "1":

                        this.changeColor(sl, "myLabel1");

                        break;
                    case "2":

                        this.changeColor(sl, "myLabel2");
                        break;
                    case "3":

                        this.changeColor(sl, "myLabel3");
                        break;
                    default:

                        this.changeColor(sl, "myLabel0");
                        break;
                }


                //}
            }

        }
    }
}
