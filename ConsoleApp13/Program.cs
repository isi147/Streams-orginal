//File - static bir class
//FileInfo class
//Directory static class
//DirectoryINfo class

//FileMode 
//Open,OpenOrCreate,Append,Create,CreateNew,Truncate

//FileAccess
//write  read  readwrite


using ConsoleApp13;
using System.Text;
using System.Xml;

//using FileStream fs = new("teze.txt", FileMode.CreateNew);
//string str = "Hello Nazim";
//byte[] buffer = Encoding.Default.GetBytes(str);
//fs.Write(buffer, 0, buffer.Length);
//fs.Read(buffer, 0, buffer.Length);


//using FileStream fs = new("nazim.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

//using FileStream fs = new("teze.txt", FileMode.Truncate, FileAccess.ReadWrite);



//using FileStream fs = new(@"C:\Users\Seyidmammadli_i\Desktop\fikret.txt", FileMode.Create, FileAccess.ReadWrite);



//using FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate);
//using StreamWriter sw = new StreamWriter(fs);
//using StreamReader sr = new StreamReader(fs);
//Console.WriteLine(sr.ReadToEnd());


////sw.WriteLine("Hello World");
//Console.WriteLine(sw);



//using FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate);
//using StreamWriter sw = new StreamWriter(fs);

//List<Books> books = new List<Books>()
//{
//    new Books("Lord Of Rings 1",700,"J.R.R.Tolkien"),
//    new Books("Lord Of Rings 2",500,"J.R.R.Tolkien"),
//    new Books("Lord Of Rings 3",300,"J.R.R.Tolkien"),
//    new Books("Lord Of Rings 4",200,"J.R.R.Tolkien")
//};


//books.ForEach(book =>sw.WriteLine(book));

//same
//foreach (Books book in books)
//{
//    sw.WriteLine(book);
//}



//using StreamReader sr = new StreamReader("books.txt");
//Console.WriteLine(sr.ReadToEnd());




//File.WriteAllText("yeni.txt", "Hello World");


//var str = File.ReadAllText("yeni.txt");

//Console.WriteLine(str);


//Directory



//Console.WriteLine(Directory.GetCurrentDirectory());

//Directory.CreateDirectory("C:\\Users\\Seyidmammadli_i\\Desktop\\Folder5");
//Directory.Delete("C:\\Users\\Seyidmammadli_i\\Desktop\\Folder5");

//Console.WriteLine(Directory.Exists("));

//DirectoryInfo directoryInfo = new($"C:\\Users\\Seyidmammadli_i\\Desktop");

//foreach (FileInfo file in directoryInfo.GetFiles())
//    Console.WriteLine(file.Name);

//foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
//{
//    Console.WriteLine("Klasör: " + dir.Name);
//}



