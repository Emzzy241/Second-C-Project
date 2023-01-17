// having written the Project File(the learn-method.csproj file)
// THis is our actual C# code and it ends in .cs 
// NOTE: Your Code file(which is this one) and your Project file(learn-method.csproj) MUST have the same name, the only 
// difference should be in their extension(i.e the type of file they are, one is a .csproj and the other is a .cs)
// Lets move on to writing the Code file itself


// Making use of using statements to ensure .... THe using statements serve as a directive, because C# is compiled, 
// We need to tell it what code it needs in order to function
// A cooking Analogy Explaining directves: When cooking, you don't just bring out all of the ingredients you have in your Kitchen,
// instead it wold be more effective if you only bring out therequired ingredients for whatever you are cooking.... 
// C# is concerned with speed , and Directives are like an ingredient list and allows us to retrieve and organize
// only the ingredients we need. It keeps our compiled compiled programs smaller and faster

using System;

class Program{
    static void Main(){
        // the code you want .NET to execute for yo goes in here 
        // 1. how to create variables In C#
        // C# is a completely different Language from JavaScript and you crerate Variables in C# by indicating the 
        // datatype of that specific variable, enough talking let's create A STRING VARIABLE
        
        // CREATING A VARIABLE STORING A STRING
        string greetingUser = "Hello World"; // voila!!! We have just created our string variable
        Console.WriteLine(greetingUser); // Outputing our string variable to the console

        // CREATING A VARIALE STORING AN INTEGER
        int myNumber = 55;
        Console.WriteLine(myNumber);    // Outputing our integer variable to the console

        // As you can see, we followed the previous convention for naming our variables in C# just like we did
        // In JavaScript it was Kamal casing for creating variables, and here in C# its kamal casing too... thisIsKamalCasing

        // ----- Practicing Methods in C# 

        // Let's practice some string Methods and then one integer Method too

        // PRACTICING STRING METHODS

        // 1. ToUpper() case and ToLower() case methods
        // this method basically turns all string characters to upper cases
        // ALWAYS ADD A SEMI COLON WHEN CREATING A C# VARIABLE, C# IS A STRONGLY TYPED LANGUAGE
        string myGreeting = "Hello My Dear Friend";
        myGreeting = myGreeting.ToUpper();
        Console.WriteLine(myGreeting);

        // for Lower casing now
        // this method basically turns all string characters to lower cases
        string yourGreeting = "Hello ONCE AGAIN MY NAME IS BEN and its nice to meet you";
        yourGreeting = yourGreeting.ToLower();
        Console.WriteLine(yourGreeting);

        // NOTE: THe casing we used for our methods in C# is different from the one we used for our methods in JavaScript
        // this type of casing is called Pascaal casing, and it can be denoted like this: ThisIsPascalCasing
        // WHAT THE DIFFERENCE IS: Kamal is like this thisIsKamalCasing and pascal casing is like this ThisIsPascalCasing


        // 2. The Contains() method
        // THis method just checks to see if a variable contains another variable
        // the method returns a boolean(true or false) 
        string varOne = "Hello Word, Its a beautiful day";
        string varTwo = "Hello Word";

        Console.WriteLine(varOne.Contains(varTwo));


        // The Replace() method
        // This method swaps a string in one variable for another string of our choice
        // ALSO the Replace() method takes in strings as an arguments
        string aboutToSwap = "Hello How do You do";
        string mySwapper = aboutToSwap.Replace("Hello", "Already Swapped");

        Console.WriteLine(mySwapper);

        // NOTE: The Replace() method is a method for strings only, this code below will not work
        // it will throw you a "cannot convert a datatype" error; In fact, whenever we see things like: Cannot convert (some datatype) to
        // (some other datatypes) it means we have provided incorrec datatype in our code, the 2nd datatype you see is what C# epected
        // and the 1st one is the incorrect datatype you supplied to C#
        // You can learn more on what arguments may be provided to a string method in the C# Documentation
        // string mySwapper = aboutToSwap.Replace("Hello", 1); 
        // "Hello" is a string and 1 is an integer, so you would get the "cannot convert a datatype" error

        // Finally Let's look at an INTEGER type Method
        // THe ToString() method
        // all this method does is it basically helps us convert an integer datatype into a string datatype[it changes integers to strings]
        // ANOTHER KEY THING TO NOTE: This method only works on integer, and it wouldn't work on strings
        // the same way string methods won't work on integers is the same way integer method won't work on strings

        int myNewNumber = 55;
        string myNewString = myNewNumber.ToString();

        Console.WriteLine(myNewString);

        // Also, we can turn our number into a string, we can use string methods on it
        // int numberToString = 55;
        // numberToString = numberToString.ToString();

        // string numberTurnsString = numberToString.ToUpper();

        // Console.WriteLine(numberTurnsString);



        // Since C# is so strongly typed, it needs semi colons when executing methods to really execute them

    }
}
