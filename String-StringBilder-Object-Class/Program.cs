using String_StringBilder_Object_Class.Models;
using System.Text;
#region task-1
string sentence = "Salam necesen";
Console.WriteLine(ReversedString(sentence));
string ReversedString(string sentence)
{
    StringBuilder changeDirection = new StringBuilder();
    for (int i = sentence.Length - 1; i >= 0; i--)
    {
        changeDirection.Append(sentence[i]);
    }
    string[] reversedForIndex = changeDirection.ToString().Split(' ');
    string result = string.Empty;
    for (int i = reversedForIndex.Length - 1; i >= 0; i--)
    {
        result += reversedForIndex[i]+" "; 
    }
    return result;
}
#endregion
#region task-2
// Account adinda class yaradib, onun icinde Login methodu yazin.
// Hemin login methoduna username ve password gelecek. Username lorem123 ve
// password 123456* -a beraberdirse ekrana giriw ugurludur yazilsin, eks halda email ve ya password sehvdir cixsin.
//====>solution 1<==== 
/*Account username1 = new();
username1.Login("lorem123", "123456*");*/

//====>solution 2<==== 
/*Account username1 = new();
username1.Username = "lorem123";
username1.Password = "123456*";
username1.Login(username1.Username, username1.Password);*/
#endregion
#region task-3
//Factorial adinda class yaradin , hemin clasin icinde reqem qebul edib hemin reqemin
//factorialini hesablayan method yazin.

/*Factorial calculateNum1 = new();
Console.WriteLine(calculateNum1.FactorialNum(5));*/
#endregion
#region task-4
//Calculator adinda class yaradirsiz, hemin classin icinde Calculation metodunuz olur. Method 2 parametr qebul edir.
//4 emeliyyati (+,-,*,/)hesablayan calculator olacaq. Reqemler ve operatorlar console(readline)-dan daxil edilmelidir.

/*Calculator calculateNum1 = new Calculator();
calculateNum1.Calculation(calculateNum1.FirstNum, calculateNum1.SecondNum);*/
#endregion