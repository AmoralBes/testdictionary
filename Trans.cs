using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using Excel = Microsoft.Office.Interop;
using Aspose.Cells;
namespace Slovo
{

    public static class Trans
    {

        //public static string Translate(int line)
        //{
        //    return russian[line];
        //}
        //public static Dictionary<int, string> Dict = new Dictionary<int, string>
        //{
        //    [2] = "Строка 2",
        //    [3] = "Строка 3",
        //    [5] = "Строка 5",

        //};
        //public static Dictionary<int, string> russian = new Dictionary<int, string>
        //{   //То что встретит//то что выдаст
        //    [0] = "Борисенков",
        //    [1] = "Попов",
        //    [2] = "Смирнов",
        //    [3] = "Губин",
        //    [4] = "Петров",
        //    [5] = "Василькова",
        //    [6] = "Соловьёва",
        //    [7] = "Мартинсон",
        //    [8] = "Печёркина",
        //    [9] = "Дорогина",
        //    [10] = "Симанюк"
        //};
        //public static Dictionary<int, string> english = new Dictionary<int, string>
        //{   //То что встретит//то что выдаст
        //    [0] = "Borisenkov",
        //    [1] = "Popov",
        //    [2] = "Smirnov",
        //    [3] = "Gubin",
        //    [4] = "Petrov",
        //    [5] = "Vasilkova",
        //    [6] = "Solovieva",
        //    [7] = "Martinson",
        //    [8] = "Pechеrkina",
        //    [9] = "Dorogina",
        //    [10] = "Symaniuk"
        //};
        public static Dictionary<string, string> Urusification = new Dictionary<string, string>
        {
            {"Ya","Я"},{"ya","я"},{"Ia","Иа"},{"ia","иа"},
            {"Oo","Оо"},{"oo","оо"},{"Ee","Ее"},{"ee","ее"},
            {"Iy","Ий"},{"iy","ий"},{"Yi","йи"},{"yi","йи"},
            {"Yey","Ей"},{"yey","ей"},{"Ey","Ей"},{"ey","ей"},
            {"Uy","Уй"},{"uy","уй"},{"Oy","ой"},{"oy","ой"},
            {"Zh","Ж"},{"zh","ж"},{"Ts","Ц"},{"ts","ц"},
            {"Sh","Ш"},{"sh","ш"},{"Shch","Щ"},{"shch","щ"},
            {"Ch","Ч"},{"ch","ч"},
            {"Ce","Се"},{"ce","се"},{"Cy","Си"},{"cy","си"},{"Ci","Си"},{"ci","си"},
            {"Kh","Х"},{"kh","х"},
            {"Yu","Ю"},{"yu","ю"},{"Iu","Ю"},{"iu","ю"},
            {"Yo","Йо"},{"yo","йо"},
          // лат /рус|лат / рус
            {"A","А"},{"a","а"},//
            {"B","Б"},{"b","б"},//
            {"C","К"},{"c","к"},//
            {"D","Д"},{"d","д"},//
            {"E","Е"},{"e","е"},//
            {"F","Ф"},{"f","ф"},//
            {"G","Г"},{"g","г"},//
            {"H","Х"},{"h","х"},//
            {"I","И"},{"i","и"},//
            {"J","Ж"},{"j","ж"},// 
            {"K","К"},{"k","к"},//
            {"L","л"},{"l","л"},//
            {"M","М"},{"m","м"},//
            {"N","Н"},{"n","н"},//
            {"O","О"},{"o","о"},//
            {"P","П"},{"p","п"},//
            {"Q","К"},{"q","к"},//
            {"R","р"},{"r","р"},//
            {"S","С"},{"s","с"},//
            {"T","Т"},{"t","т"},//
            {"U","У"},{"u","у"},//
            {"V","В"},{"v","в"},//
            {"W","В"},{"w","в"},//
            {"X","Кс"},{"x","кс"},//
            {"Y","И"},{"y","и"},//
            {"Z","з"},{"z","з"},//
        };

    }
}
