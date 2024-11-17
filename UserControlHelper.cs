using STI_Join.MenuOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STI_Join
{
    public static class UserControlHelper
    {
        public static void HandleButtonClick(Button clickedButton, Button activeButton, Action<Button> setActiveButton, Action<Button> setInactiveButton, Action<UserControl> loadUserControl, string ButtonIdentifier)
        {
            if (activeButton != null && activeButton != clickedButton)
            {
                setInactiveButton(activeButton);
            }

            setActiveButton(clickedButton);
            loadUserControl(GetUserControlForButton(clickedButton, ButtonIdentifier));
        }

        public static UserControl GetUserControlForButton(Button button, string ButtonIdentifier)
        {
            switch (ButtonIdentifier)
            {
                case var _ when button.Name == "btnHome":
                    return new Home();
                case var _ when button.Name == "btnAddStudent":
                    return new AddStudent();
                case var _ when button.Name == "btnStudentList":
                    return new StudentList();
                case var _ when button.Name == "btnAbout":
                    return new About();
                default:
                    return null;
            }
        }
    }
}
