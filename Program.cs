// See https://aka.ms/new-console-template for more information

//---------Adding numbers with user input----------

// Console.WriteLine("Enter a number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter another number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num1 + num2);

//----------Building a mad lib game----------------

// string color, pluralNoun, celebrity;
// Console.Write("Enter a color: ");
// color = Console.ReadLine();
// Console.Write("Enter a plural noun: ");
// pluralNoun = Console.ReadLine();
// Console.Write("Enter a celebrity: ");
// celebrity = Console.ReadLine();

// Console.WriteLine("Roses are " + color);
// Console.WriteLine(pluralNoun + " are Blue");
// Console.WriteLine("I love " + celebrity);

//--------Dealing with Arrays----------------------
//type [] variableName = { __,__,__};

// int [] luckyNumbers = {13, 23, 43, 20, 69};
// luckyNumbers[2] = 42;
// string[] friends = new string[5];
// friends[0] = "Skyler";
// friends[1] = "Cody";
// friends[2] = "Chance";
// Console.WriteLine( luckyNumbers[0]);

//-----------Methods--------------------------------

// static void SayHi(string name, int age){
//     Console.WriteLine("Hello " + name + " you are " + age);
// }

// SayHi("Chase", 26);

//----------Return Methods--------------------------

// static int cube(int num){
//     int result = num * num * num;
//     return result;
// }
// int cubedNumber = cube(5);
// Console.WriteLine(cubedNumber);

//----------If statements---------------------------
// bool isMale = true;
// bool isTall = false;

// int[] primeNumbers = {1,2,3,5,7,11,13,17};

// if (isMale || isTall){
//     Console.WriteLine("You are a tall male or you are a tall female.");
// } else{
//     Console.WriteLine("You are either not a male or you are not tall.");
// }

// if (primeNumbers[7] == 17){
//     Console.WriteLine("That is correct.");
// }

//--------Comparisons--------------------------------
// static int GetMax(int num1, int num2){
//     int result;
//     if (num1 > num2){
//         result = num1;
//     } else{
//         result = num2;
//     }
//     return result;
// }
// Console.WriteLine(GetMax(48, 46));

//--------------Calculator---------------------------
// Console.Write("Enter a number: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter Operator: ");
// string op = Console.ReadLine();
// Console.Write("Enter a number: ");
// double num2 = Convert.ToDouble(Console.ReadLine());


// if (op == "+"){
//     Console.WriteLine(num1 + num2);
// } else if(op == "-"){
//     Console.WriteLine(num1 - num2);
// } else if(op == "/"){
//     Console.WriteLine(num1 / num2);
// } else if(op == "*"){
//     Console.WriteLine(num1 * num2);
// } else{
//     Console.WriteLine("Please enter a valid operator.");
// }

//----------Switch Cases------------------------------
// static string GetDay(int dayNum){
//     string dayName;

//     switch(dayNum){
//         case 0:
//             dayName = "Sunday";
//             break;
//         case 1:
//             dayName = "Monday";
//             break;
//         case 2:
//             dayName = "Tuesday";
//             break;
//         case 3:
//             dayName = "Wednesday";
//             break;
//         case 4:
//             dayName = "Thursday";
//             break;
//         case 5:
//             dayName = "Friday";
//             break;
//         case 6:
//             dayName = "Saturday";
//             break;
//         default:
//             dayName = "Invalid day number";
//             break;
//     }

//     return dayName;
// }

//------------While Loop----------------------
// int index = 1;

// while(index <= 5){
//     Console.WriteLine(index);
//     index++;
// }

//-----------Guessing game with 3 tries--------------------
// string secretWord = "giraffe";
// string guess = "";
// int guessNum = 0;
// int guessLimit = 3;
// bool outofGuesses = false;
// while(guess != secretWord && !outofGuesses){
//     if(guessNum < guessLimit){
//         Console.Write("Enter your guess: ");
//         guess = Console.ReadLine();
//         guessNum++;
//     }
//     else{
//         outofGuesses = true;
//     }
// }
// if(outofGuesses){
//     Console.Write("You Lose!");
// }
// else{
//     Console.Write("You win!");
// }

//--------------For Loops----------------------
// int i = 1;
// while(i <= 5){
//     Console.WriteLine(i);
//     i++;
// }

// for(int j = 1; j<=5; j++){
//     Console.WriteLine(j);
// }

//-------2 deminsional Arrays--------------------
// int[,] numberGrid = {
//     {1, 2},
//     {3, 4},
//     {5, 6}
// };

// Console.WriteLine(numberGrid[1,1]);

//---------Exception Handling --------------------
// try{
// Console.Write("Enter a number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num1 / num2);
// }
// catch(DivideByZeroException e){
//     Console.WriteLine(e.Message);
// }
// catch(FormatException e){
//     Console.WriteLine(e.Message);
// }

//--------Classes and Objects-------------

// Book book1 = new Book();
// book1.title = "The Lightning Thief";
// book1.author = "Rick Riordan";
// book1.pages = 345;
// Book book2 = new Book();
// book2.title = "Lor of the Rings";
// book2.author = "Tolkein";
// book2.pages = 705;

// Console.WriteLine(book1.title);
// Console.WriteLine(book2.author);

//--------Constructors-----------------------
// Book book1 = new Book("Lightning Thief", "Rick Riordan", 345);

// Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

// Console.WriteLine(book1.author);
// Console.WriteLine(book2.pages);

//--------Object Methods---------------------

// Student student1 = new Student("Jim", "Business", 2.8);
// Student student2 = new Student("Pam","Accounting", 3.6);

// Console.WriteLine(student1.Honors());
// Console.WriteLine(student2.Honors());

//---------Getters and Setters----------------

// Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
// Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

// Console.WriteLine(avengers.Rating);

//-----------Static Classes-------------------

// Song holiday = new Song("Holiday", "Green Day", 200);
// Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

// Console.WriteLine(Song.songCount);
// Console.WriteLine(kashmir.artist);

//-----------Static methods--------------------

Console.WriteLine(Math.Sqrt(144));
Console.ReadLine();
