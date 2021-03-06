﻿using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace View.AssistiveComponents
{
    public class AppComponentFactory
    {
        public static IAppComponent CreateAppComponent(Utils.eAppComponent i_Context, Control.ControlCollection i_Controls, User i_User)
        {
            IAppComponent appComponent = null;

            switch(i_Context)
            {
                case Utils.eAppComponent.UserAlbumPictures:
                    appComponent = new UserAlbumPicturesComponent();
                    break;

                case Utils.eAppComponent.UserEvents:
                    appComponent = new UserEventsComponent() { User = i_User };
                    break;

                case Utils.eAppComponent.UserProfile:
                    appComponent = new UserProfileComponent() { User = i_User };
                    break;
            }

            i_Controls.Add(appComponent as UserControl);
            return appComponent;
        }
    }
}
