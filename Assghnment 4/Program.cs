using System.Diagnostics;
using System.Net.Sockets;
using System.Text;

namespace Assghnment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question 01
            //a : the code is inefficient because it create string object as many as the loop count and every loop
            // create a new string allocation in memory which will be a heavy pressure on GC
            // b & c :

            //var StrConStopWatch = Stopwatch.StartNew();
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            //StrConStopWatch.Stop();

            //var StrBulStopWatch = Stopwatch.StartNew();
            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append($"PROD-{i},");
            //}
            //StrBulStopWatch.Stop();

            //Console.WriteLine($"String Concat Time : {StrConStopWatch.ElapsedMilliseconds}ms");
            //Console.WriteLine($"String Builder Time : {StrBulStopWatch.ElapsedMilliseconds}ms");

            #endregion

            #region Question 02: Ticket Pricing System
            //Console.Write("Enter Your Age : ");
            ////int age = int.Parse(Console.ReadLine());
            //int validAge;
            //while (true)
            //{
            //    string age = Console.ReadLine();
            //    if (int.TryParse(age, out validAge))
            //    {
            //        break;
            //    }
            //    Console.Write("Please Re-Enter a Valid Age : ");
            //}

            //double price = 0;
            //var finalPriceBreakDown = new StringBuilder();

            //if (validAge < 5)
            //{
            //    price = 0;
            //    finalPriceBreakDown.Append("Ticket is Free");
            //}
            //else if (validAge >= 5 && validAge <= 12)
            //{
            //    price = 30;
            //    finalPriceBreakDown.Append($"Ticket Price is {price} LE");
            //}
            //else if (validAge >= 13 && validAge <= 59)
            //{
            //    price = 50;
            //    finalPriceBreakDown.Append($"Ticket Price is {price} LE");
            //}
            //else if (validAge >= 60)
            //{
            //    price = 25;
            //    finalPriceBreakDown.Append($"Ticket Price is {price} LE");
            //}

            //Console.Write("\nWhat Is The Day ?\n1-Satarday\n2-Sunday\n3-Monday\n4-Tuseday\n5-Wendsday\n6-ThursDay\n7-Friday\nEnter The Day Number : ");
            ////int validDay = int.Parse(Console.ReadLine());
            //int validDay;
            //while (true)
            //{
            //    string day = Console.ReadLine();
            //    if (int.TryParse(day, out validDay))
            //    {
            //        if (validDay >= 1 && validDay <= 7)
            //        {
            //            break;
            //        }
            //    }
            //    Console.Write("Please Re-Enter a Valid Chooice : ");

            //}


            //Console.Write("\nAre You Having StudentID ?\n1-Yes\n2-No\nEnter The Answer Number : ");
            ////int studentId = int.Parse(Console.ReadLine());
            //int validStudentId;
            //while (true)
            //{
            //    string studentId = Console.ReadLine();
            //    if (int.TryParse(studentId, out validStudentId))
            //    {
            //        if (validStudentId == 1 || validStudentId == 2)
            //        {
            //            break;
            //        }
            //    }
            //    Console.Write("Please Re-Enter a Valid Chooice : ");
            //}





            //if (validDay == 1 || validDay == 7)
            //{
            //    price += 10;
            //    finalPriceBreakDown.Append(" and +10 LE for Holidays");
            //}

            //if (validStudentId == 1)
            //{
            //    price = price * 0.8;
            //    finalPriceBreakDown.Append(" and 20% Student Discount");
            //}

            //finalPriceBreakDown.Append($", so Total Ticket Price is {price} LE");
            //Console.WriteLine(finalPriceBreakDown.ToString());

            #endregion

            #region Question 03

            //a :
            //string fileExtension = ".Pdf";
            //string fileType;

            //switch (fileExtension.ToLower())
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        Console.WriteLine(fileType);
            //    break;

            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        Console.WriteLine(fileType);
            //    break;

            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        Console.WriteLine(fileType);
            //    break;

            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        Console.WriteLine(fileType);
            //    break;

            //    default:
            //        fileType = "Unknown File Type";
            //    break;
            //}

            //b:
            //string fileExtension = ".pdf";
            //string fileType = fileExtension.ToLower() switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};
            //Console.WriteLine(fileType);

            #endregion

            #region Question 04

            //int temperature = 35;
            //string weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." : temperature < 15 ? "Cold. Wear a jacket." : temperature < 25 ? "Pleasant weather." : temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";
            //Console.WriteLine(weatherAdvice);
            // very hard to read in multibale conditions , we use ternary operator in case of one condition
            #endregion

            #region Question 05

            //int times = 0;
            //bool validPassword = false;
            //string password;
            //do
            //{
            //    Console.Write("Enter Password : ");
            //    password = Console.ReadLine();
            //    times++;
            //    bool isInt = false;
            //    bool isUpper = false;
            //    bool isSpace = false;

            //    foreach (char ch in password)
            //    {
            //        if (char.IsDigit(ch))
            //        {
            //            isInt = true;
            //        }
            //        if (char.IsUpper(ch))
            //        {
            //            isUpper = true;
            //        }
            //        if (char.IsWhiteSpace(ch))
            //        {
            //            isSpace = true;
            //        }
            //    }

            //    if(password.Length < 8)
            //    {
            //        Console.WriteLine("Must be at least 8 chars");
            //    }
            //    if(isInt == false)
            //    {
            //        Console.WriteLine("Must contain at least 1 digit");
            //    }
            //    if(isUpper == false)
            //    {
            //        Console.WriteLine("Must contain at least uppercase");
            //    }
            //    if(isSpace == true)
            //    {
            //        Console.WriteLine("Must not contain space");
            //    }

            //    else if(password.Length >= 8 && isInt == true && isUpper == true && isSpace == false)
            //    {
            //        validPassword = true;
            //        Console.WriteLine("Password accepted!");
            //    }


            //}
            //while (validPassword == false && times < 5);

            //if(validPassword == false)
            //{
            //    Console.WriteLine("\nAccount Locked");
            //}

            #endregion

            #region Question 06

            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            //a
            //foreach (int score in scores)
            //{
            //    if (score < 50)
            //    {
            //        Console.Write($"{score}  ");
            //    }
            //}

            //b
            //foreach (int score in scores)
            //{
            //    if (score > 90)
            //    {
            //        Console.Write($" First > 90 is {score}");
            //        break;
            //    }
            //}

            //c
            //int sum = 0;
            //int count = 0;
            //double avg;
            //foreach (int score in scores)
            //{
            //    if (score > 40)
            //    {
            //        sum += score;
            //        count++;
            //    }
            //}
            //avg = (double)sum / count;
            //Console.WriteLine($"Avg = {avg}");

            //d
            //int A = 0;
            //int B = 0;
            //int C = 0;
            //int D = 0;
            //int F = 0;

            //foreach (int score in scores)
            //{
            //    if (score >= 90 && score <= 100)
            //    {
            //        A++;
            //    }
            //    if (score >= 80 && score < 90)
            //    {
            //        B++;
            //    }
            //    if (score >= 70 && score < 80)
            //    {
            //        C++;
            //    }
            //    if (score >= 60 && score < 70)
            //    {
            //        D++;
            //    }
            //    if (score < 60)
            //    {
            //        F++;
            //    }
            //}

            //Console.WriteLine("Count For Each Grade :");
            //Console.WriteLine($"A : {A}\nB : {B}\nC : {C}\nD : {D}\nF : {F}");


            #endregion
        }
    }
}
