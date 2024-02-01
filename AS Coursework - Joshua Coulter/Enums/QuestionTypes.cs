using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Enums;

//This enum is used to easily differentiate between question types
//It used alongside polymorphism in the base question class to be able to find question types with a base class reference
public enum QuestionTypes
{
    MultipleChoice,
    Text,
    AudioMultipleChoice,
    AudioText,
    PictureMultipleChoice,
    PictureText,
    Match
}
