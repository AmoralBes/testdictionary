using System.IO;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
using Excel = Microsoft.Office.Interop;
using Aspose.Cells;
namespace Slovo
{
    


    class Program
    {

        static void Main(string[] args)
        {
            //string Stroka = "Borisenkov M. F., Popov S. V., Smirnov V. V., Gubin D. G., Petrov I. M., Vasilkova T. N., Solovieva S. V., Martinson E. A., Pechеrkina A. A., Dorogina O. I., Symaniuk E. E.";
            //Console.WriteLine(Trans.russian.Count);
            //for (int i = 0; i < Trans.russian.Count;i++) 
            //{
            //    int pos = Stroka.IndexOf(Trans.english[i]);
            //    Stroka = Stroka.Remove(pos, Trans.english[i].Length).Insert(pos, Trans.russian[i]); 
            //}

            //    Console.WriteLine(Stroka);
            //for (int i = 0; i < (Trans.russian.Count + Trans.english.Count) / 2; i++)
            //{
            //    int pos = Stroka.IndexOf(Trans.russian[i]);
            //    Stroka = Stroka.Remove(pos, Trans.russian[i].Length).Insert(pos, Trans.english[i]);
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine(Stroka);

            ////foreach (var person in people)
            ////{
            ////    Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            ////}
            //    foreach (var pers in Trans.english)       
            //    {
            //        Console.WriteLine($"key: {pers.Key} value : {pers.Value}");
            //    }

            Console.WriteLine("Выберите файл\n");
            string gate; gate = Console.ReadLine();
            Workbook wb = new Workbook(gate);
            Worksheet ws = wb.Worksheets[0];

            Console.WriteLine("Выберите колонну\n");                  
            int I = Convert.ToInt32(Console.ReadLine());
            I--;
            //string A = (string)ws.Cells[4, I].Value;
            //Console.WriteLine(A);
            Console.WriteLine("Сколько строк содержат заголовкии?\n");
            int Zagolovki = Convert.ToInt32(Console.ReadLine());

            int Counter_Rows_Sheet = wb.Worksheets[0].Cells.Rows.Count;
            for (int i = Zagolovki + 1; i < Counter_Rows_Sheet; i++) //Цикл колонн
            {
                string A = (string)ws.Cells[i, I].Value;
                foreach (var family in Trans.Urusification) //Цикл транслитерации (перевода) в колоннах
                {
                    int pos = A.IndexOf(Trans.Urusification[family.Key]);
                    A = A.Remove(pos, Trans.Urusification[family.Key].Length).Insert(pos, Trans.Urusification[family.Value]);
                }
                ws.Cells[i, I].Value = A;
                i++;
            }
            wb.Save(gate);
        }
    }
}
