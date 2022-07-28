using System.Globalization;
using System.Text;

namespace CodeSamplesL5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CharSymbols
            //char symbol1 = 'A';
            //char symbol2 = '\u006A';
            //char symbol3 = '\x006A';
            //char symbol4 = (char)106;
            //Console.WriteLine(symbol1);
            //Console.WriteLine(symbol2);
            //Console.WriteLine(symbol3);
            //Console.WriteLine(symbol4);
            //int number = (int)symbol1;
            //Console.WriteLine(number);


            //Console.WriteLine(char.IsWhiteSpace(symbol1)); //proverka probelniy ili net danniy simvol
            //symbol1 = ' ';
            //Console.WriteLine(char.IsWhiteSpace(symbol1));

            //Console.WriteLine(char.IsLetter(symbol1)); // proberka bukva ili net FALSE
            //symbol1 = 'A';
            //Console.WriteLine(char.IsLetter(symbol1)); //TRUE

            //Console.WriteLine(char.IsDigit(symbol1)); //Proverka cifra ili net FALSE
            //symbol1 = '2';
            //Console.WriteLine(char.IsDigit(symbol1)); //TRUE

            //Console.WriteLine(char.IsLetterOrDigit(symbol1)); //BUKVA ILI CIFRA CHECK TRUE
            //symbol1 = ' ';
            //Console.WriteLine(char.IsLetterOrDigit(symbol1)); //FALSE

            //Console.WriteLine(char.IsPunctuation(symbol1)); //FALSE (PROVERKA NA ZNAK PUNCTUACII)
            //symbol1 = ',';
            //Console.WriteLine(char.IsPunctuation(symbol1)); //TRUE

            //Console.WriteLine(char.IsLower(symbol1)); //FALSE (ZAGLAVNAYA ILI NIZHNIY REGISTR)
            //symbol1 = 'a';
            //Console.WriteLine(char.IsLower(symbol1)); //TRUE
            //Console.WriteLine(char.IsUpper(symbol1)); //FALSE
            #endregion


            #region Strings
            //string stringFromLiteral = "Hello world";
            //string stringFromArray = new string(new char[] { 'H', 'e', 'l', 'l', '0' });
            //string symbols = new string('A', 10); //POVTORIT 10 RAZ A
            //Console.WriteLine(stringFromLiteral);
            //Console.WriteLine(stringFromArray);
            //Console.WriteLine(symbols);

            //foreach (char symbol in stringFromLiteral)
            //{
            //    //symbol = 'A';
            //    Console.WriteLine(symbol);
            //}

            //for (int i = 0; i < stringFromLiteral.Length; i++)
            //{
            //    //stringFromLiteral[i] = 'A';
            //    Console.WriteLine(stringFromLiteral[i]); //STROKA NEIZMENIMA!!!!
            //}

            //string upperString = stringFromLiteral.ToUpper(); //VSE BYKVU V STROKE V UP REGISTR (SOZD 2 SSILKY, NA KOTORYY SSILAETSA, 1ST ISHODNAYA
            //Console.WriteLine(upperString);
            //string lowerString = stringFromLiteral.ToLower();
            //Console.WriteLine(lowerString);
            //Console.WriteLine(stringFromLiteral);

            ////string s = "iii";
            ////string invariant = s.ToUpperInvariant();//III (KULTURE NE ISPOLZ)
            ////var culture = new CultureInfo("tr-TR");
            ////string cultured = s.ToUpper(culture);//İİİ (TURKISH LANGUAGE )


            //Console.WriteLine(string.Empty == "");


            //int indexOfW = stringFromLiteral.IndexOf('W');
            //int indexOfSubstring = stringFromLiteral.IndexOf("orl");
            //string newString = stringFromLiteral.Replace('l', 'A'); //ZAMENA vseh l na A ili stroka na stroku
            //Console.WriteLine(stringFromLiteral);
            //Console.WriteLine(newString);
            //Console.WriteLine(stringFromLiteral.Substring(4, 5)); //vivod s 4 elementa 5 simvolov (pri N+ OVERSTACKFLOW)
            ////Console.WriteLine(stringFromLiteral.Substring(4, 5));

            //newString = stringFromLiteral.Replace("Hello", "Bye");
            //Console.WriteLine(stringFromLiteral);
            //Console.WriteLine(newString);

            //newString = stringFromLiteral.Insert(4, " my "); //S 4 SIMVOLA VSTAVILI STROKY
            //Console.WriteLine(stringFromLiteral);
            //Console.WriteLine(newString);

            //newString = stringFromLiteral.Remove(4, 4); //S 4 SIMVOLA UDALIT 4 SIMVOLA
            //Console.WriteLine(stringFromLiteral);
            //Console.WriteLine(newString);



            //string stringWithWhiteSpaces = "Ivan Nikita Alena Mila Sergey Nastya";
            //string[] arrayOfStrings = stringWithWhiteSpaces.Split(' ');//RAZDELENIE STROKI S POM ZADANNOGO RAZDELITELYA
            //foreach (string item in arrayOfStrings)
            //{
            //    Console.WriteLine(item);
            //}


            //string enteredString = Console.ReadLine();
            //Console.WriteLine(enteredString);
            //Console.WriteLine(enteredString.Length);

            //string trimmedString = enteredString.Trim(); //DELETE PROBELI V STROKE
            //Console.WriteLine(trimmedString.Length);
            //Console.WriteLine(trimmedString);
            //trimmedString = enteredString.TrimStart(); //DELETE PROBELI V NACHALE
            //Console.WriteLine(trimmedString.Length);
            //trimmedString = enteredString.TrimEnd(); // DELETE PROBELI V KONCE      
            //Console.WriteLine(trimmedString.Length);


            //enteredString = Console.ReadLine();
            //Console.WriteLine(enteredString);
            //Console.WriteLine(enteredString.Length); //CHASTO USABILITY
            //trimmedString = enteredString.Trim('_');
            //Console.WriteLine(trimmedString.Length);
            //Console.WriteLine(trimmedString);


            //string concattedString = string.Concat("He", "llo ", "Wor", "ld");// CONCAT soed stroki voedino
            //Console.WriteLine(concattedString);
            //////concattedString = "He" + "llo " + "Wor" + "ld";
            //////string str1 = "He";
            //////string str2 = "llo ";
            //////string str3 = "Wor";
            //////string str4 = "ld";
            //////concattedString = str1 + str2 + str3 + str4; /analog string.Concat(str1,str2,......)
            ////Console.WriteLine(concattedString);
            //string[] items = new string[] { "String1", "String2", "String3" };
            //concattedString = string.Join("|separator|", items); //na meste separatora vstavl probel ili , ili tp
            //Console.WriteLine(concattedString);
            //concattedString = string.Join(' ', items);
            //Console.WriteLine(concattedString); 

            //Console.WriteLine(string.IsNullOrEmpty(null)); // peredali null TRUE - (null)-pustaya ssilka ("" empty) 
            //Console.WriteLine(string.IsNullOrEmpty(string.Empty));
            //Console.WriteLine(string.IsNullOrWhiteSpace("      ")); //proverka na null ili probelniy simvol i vivodit true

            //string enteredString = Console.ReadLine();
            //if (!string.IsNullOrEmpty(enteredString))
            //{
            //    Console.WriteLine("Is not null or empty");
            //}

            //if (enteredString != null && enteredString != string.Empty)
            //{
            //    Console.WriteLine("Is not null or empty");
            //}
            ////sravnenie strok nizhe
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //Console.WriteLine(str1 == str2); //opredelit ravni stroki ili net TRUE esli ravni
            //Console.WriteLine(string.Compare(str1, str2)); //esli ne ravni to vernet "1" , esli ravni "0"
            //Console.WriteLine(string.Compare(str1, str2, true)); //true v kocne pozvolyaet ignorit' registr

            //var s1 = "HelloWorld";
            //var s2 = "HelloWorld";
            //var s3 = "Hello" + "World";

            //Console.WriteLine(ReferenceEquals(s1, s2));
            //Console.WriteLine(ReferenceEquals(s1, s3));


            //decimal price = 17.36m;
            //string s = string.Format("The current price is {0:C2}", price);
            //Console.WriteLine(s);
            //decimal temp1 = 36.93434m, temp2 = 39.5234234m;
            //s = string.Format("The temperature is between {0:N0} degrees - {1:N0} degrees", temp1, temp2);
            //Console.WriteLine(s);

            //s = $"price:{price}, temp1:{temp1}, temp2:{temp2}";
            //Console.WriteLine(s);
            #endregion


            #region StringBuilder
            //StringBuilder stringBuilder = new StringBuilder("str", 300);
            //for (int i = 1; i < 10; i++)
            //{
            //    stringBuilder.AppendLine("123");
            //}

            //string s = stringBuilder.ToString();





            //int sLen = 30, Loops = 5000;
            //string sSource = new string('X', sLen);
            //string sDest = "";

            //// Time string concatenation.
            //var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < Loops; i++)
            //{
            //    sDest += sSource;
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Concatenation took {stopwatch.ElapsedMilliseconds} ms.");

            //// Time StringBuilder.
            //stopwatch.Restart();
            //StringBuilder sb = new StringBuilder((int)(sLen * Loops * 1.1));
            //for (int i = 0; i < Loops; i++)
            //{
            //    sb.Append(sSource);
            //}
            //sDest = sb.ToString();
            //stopwatch.Stop();
            //Console.WriteLine($"String Builder took {stopwatch.ElapsedMilliseconds} ms.");
            #endregion
        }
    }
}