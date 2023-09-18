// hello = length 5, 01234 <-indeksid
// trim = eemaldab ebavajalikud tyhikud

string hello = "well hello, world! ";

int stringLength = hello.Length;

//string trimmedString = hello.Trim(); luukse vahemällu uus sõne

hello = hello.Trim(); // vana väärtus kustatakse vahemälust ja asendatakse

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('!', '?');

firstLetter = hello[0];
Console.WriteLine(firstLetter);

Console.WriteLine(hello);



////int wordCount = 0; // int wordCount = 1, siis ei ole vaja sw lisada +1

////for (int i = 0; i < hello.Length; i++)
////{
////    //if (hello[i] == ' ')
////    //{
////    //    wordCount++;
////    //}
////    ////Console.WriteLine($"{i} symbol in string: {hello[i]}"); näitab kõikide sümbolite asukohta
////    ///

////    if (char.IsWhiteSpace(hello[i]))
////    {
////        wordCount++;
////    }
////}

// Console.WriteLine(hello.Length);

//Console.WriteLine($"Word count in {hello}: {wordCount + 1} words.");

