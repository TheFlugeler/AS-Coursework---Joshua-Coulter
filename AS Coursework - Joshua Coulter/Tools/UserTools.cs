using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class UserTools
{
    public static bool CheckProperties(string[] details)
    {
        bool passed = true;

        string username = details[0];
        for(int i = 0;i < details[0].Length;i++)
        {
            if (char.IsSymbol(username[i])) passed = false;
            if (username[i] == ' ') passed = false;
        }

        string password = details[1];
        if (string.IsNullOrEmpty(password)) passed = false;

        int highscore;
        if (!int.TryParse(details[2], out highscore)) passed = false;

        DateTime dob;
        if(!DateTime.TryParse(details[3],out dob)) passed = false;

        string gender = details[4];
        if (gender != "Male" && gender != "Female" && gender != "Other") passed = false;

        bool isadmin;
        if (!bool.TryParse(details[5],out isadmin)) passed = false;

        return passed;
    }
}
