
// //Exercise 5.3
// byte i = 255;
// i++;
// i++;

// Console.WriteLine(i);

// //Exercise 5.15: Average Age Topic
// //Consider the following program:
// int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
// int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
// int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
// int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
// int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
// int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
// float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
// float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
// float avg = (male_avg + female_avg) / 2;
// float diff = male_avg - female_avg;
// Console.Write("Average lifespan of a male computer scientist: ");
// Console.WriteLine(male_avg);
// Console.Write("Average lifespan of a female computer scientist: ");
// Console.WriteLine(female_avg);
// Console.Write("Average lifespan of a computer scientist: ");
// Console.WriteLine(avg);
// Console.Write("Males live this much longer than females: ");
// Console.WriteLine(diff);

// // Exercise 5.8: Areas of Circles Topic
// // Creativity feedback
// // Write a program that calculates and prints out the area (π · r2) of three circles with radiuses of
// // 1, 3 and 5.
// float[] circleRadiuses = {1f, 3f, 5f};
// float pi = 3.1416f;

// float CalcCircleArea(float radius)
// {
//     return pi * radius * 2;
// }

// foreach (int value in circleRadiuses)
// {
//     Console.WriteLine(CalcCircleArea(value));
// }

// // Exercise 5.10: Celcius to Fahrenheit Topic
// // Write a program in which:
// // 1. A Celcius temperature is assigned to a variable.
// // 2. This temperature is converted to degree Fahrenheit and stored in another variable.
// // • Formula: TF = 32 + 9 / 5 * C
// // 3. Print out the conversion in a reasonable way.

// float celsius = 20f;

// Console.WriteLine(32f + 9f / 5f * celsius);



// // Exercise 5.14: Daily Differences Topic
// // Creativity feedback
// // Write a program that has 7 hardcoded daily temperatures. It should calculate and print out
// // the temperature of all consecutive days (i.e., Tuesday-Monday, Wednesday-Tuesday …Sunday-
// // Saturday).
// // The daily temperatures could be:
// // • Monday: 21.5
// // • Tuesday: 23.7
// // • Wednesday: 19.6
// // • Thursday: 22.5
// // • Friday: 25.3
// // • Saturday: 21.7
// // • Sunday: 18.9
// // Then, the result would be:
// // 2.1999999999999993
// // -4.099999999999998
// // 2.8999999999999986
// // 2.8000000000000007
// // -3.6000000000000014
// // -2.8000000000000007
// // Why is the result wrong?
// float[] dailyTemps = {21.5f, 23.7f, 19.6f, 22.5f, 25.3f, 21.7f, 18.9f};

// float storedTemp = 0f;
// foreach(float temp in dailyTemps)
// {
//     if(storedTemp <= 0f)
//     {
//         Console.WriteLine(temp - dailyTemps[dailyTemps.Length - 1]);
//         storedTemp = temp;
//         continue;
//     }
//     Console.WriteLine(temp - storedTemp);
//     storedTemp = temp;
// }
// // Result is wrong, cause the floats have non perfect precision, and therefore are not the values are off a bit



// // Exercise 5.11: Epoch Topic
// // Write a program in which:
// // 1. Some number of seconds since a specific point in time (e.g., January 1st, 1970) is stored in
// // a variable. Given an agreement of this starting point (January 1st, 1970), such a number
// // can be used to represent a timestamp.
// // 2. Convert this number to an even number of years (lets assume that there are 365 days in
// // every year) and how many days the timestamp is into this year.
// // • This way, we can convert the timestamp into something that makes more sense for
// // humans: A combination of a year and a day. The day will then have a values between
// // 0 and 364 (both included).
// // • Ideally we would add months as well so that we have a year-month-day date. Months,
// // however, don’t have the same lenght, and we don’t want to include that complexity
// // in this exercise.
// // • Added together, the two numbers (year and day) should be within 24 hours of our
// // timestamp.
// // 3. Print out the resulting year and day.
// // Verify that the program works correctly.

// void EpochConverter(int timeStamp)
// {
//     int year = timeStamp / 60 / 60 / 24 / 365;
//     int removeLeap = (year + 1) / 4;
//     int remainingTime = timeStamp - year * 60 * 60 * 24 * 365;
//     int day = remainingTime / 60 / 60 / 24;

//     Console.WriteLine("Year {0} : Day {1}", year + 1970, day + 1 - removeLeap);
// }

// EpochConverter(1788964584);


// // Exercise 5.16: Printf Topic
// // Figure out experimentally how the following code works. Do so by trying out different variations
// // of the string in the last line:
// int i = 42;
// long l = 56;
// float f = 3.14159F;
// double d = 3.14159 * 10;
// Console.WriteLine("i = {0} \nl = {1,4} \nf = {2} \nd = {3,6:0.00}", i, l, f, d);
// // In most programming languages, this function would have been called printf. But Microsoft
// // have for some reason decided to make C# stand out in this regard.
// // 
// // It works by inserting the values at the spots with the brackets in the spots of each variable as seperated by comma.
// // Additionally next to the numbered set a comma like 1,4 is set at that adds 4 spaces in before the variable, and lastly
// // 0.00 is formatting the output to only show 2 decimal points.



// Exercise 5.2: Month Topic
// Which types are suitable for representing a month?
// Numerically? a byte, by name? A string.


// // Write a program in which:
// // 1. When executed, the program should write out a table of matching Celcius and Fahrenheit
// // values.
// // • Formula: TF = 32 + 9
// // 5 TC
// // 2. There should be one matching pair per line.
// // 3. The list should start at -5◦C and end at 40◦C.
// // 4. The list should have one line for ach 0.5◦C.
// float celsius = -5f;

// while (celsius <= 40f)
// {
//     Console.WriteLine("Celsius: " + celsius + " | Fahrenheit: " + (32f + 9f / 5f * celsius));
//     celsius += 0.5f;
// }

// // Exercise 5.20: Dice Topic
// // Write a program in which:
// // 1. the result of a roll of a dice is stored in a variable named dice.
// // • Which type should the variable be declared as?
// // • Chose a value and initialize the variable to it.
// // 2. Declare a boolean variable and assign it a value that represent whether the value in dice
// // is even and greater than 3.
// // 3. Print out the value of this boolean variable.

// int dice = 4;
// bool evenAndGreaterThanFour = dice > 3 && dice % 2 == 0;
// Console.WriteLine(evenAndGreaterThanFour);

// // Exercise 6.3: Christmas Sale Topic
// // Write a program in which:
// // 1. A variable is declared and initialized to the value 21816000. This value represents a number
// // of seconds since newyear (assuming that all months are 30 days long).
// // 2. Some other variable represents a price and has a value of 599.95.
// // 3. If it is Christmas, there is a 30% rebate. Find a reasonable way of determining when it is
// // Christmas.
// // 4. Calculate the current price (including any rebate) and store this in a third variable.
// // 5. Print out the value of this variable.
// // Be sure to test the logic you have written be assigning the first variable different values. Which
// // values would be relevant to test? Chrismas and not christmas values: 

// int secSinceNewYear = 31816000;
// //Christmas Value: 21816000;
// float price = 599.95f;
// int currentMonth = secSinceNewYear / 60 / 60 / 24 / 30;

// if(currentMonth >= 12)
// {
//     Console.WriteLine("Rebate Price: " + ((1 - 0.3) * price).ToString("0.00") + " | Current Month: " + currentMonth);
// }
// else
// {
//     Console.WriteLine("Regular Price: " + price.ToString("0.00") + " | Current Month: " + currentMonth);
// }

// // A common educational calendar will have the following holidays:
// // • Autumn Holiday October
// // • Christmas Holiday December
// // • Spring Holiday April
// // • Summer Holiday July + August
// // Write a program in which:
// // 1. A month is given in the form of an integer via a variable.
// // 2. Depending on the value of this variable, either print out the name of the holiday (if there
// // is a holiday in the month), or simply “Hard work” (if there isn’t).

// int month = 11;
// switch(month) 
// {
//     case 4:
//         Console.WriteLine("Spring Holiday");
//         break;
//     case 7: case 8:
//         Console.WriteLine("Summer Holiday");
//         break;
//     case 10:
//         Console.WriteLine("Autumn Holiday");
//         break;
//     case 12:
//         Console.WriteLine("Christmas Holiday");
//         break;
//     default:
//         Console.WriteLine("Hard work");
//         break;
// }

// // Exercise 6.9: Areas of Circles Topic
// // Write a program that calculates and prints out the area (π · r2) of three circles that have the
// // radiuses 1, 3 and 5.
// // Notice: This is a repetition of exercise 5.8, but this time you have a larger toolbox at your
// // disposal.

// float[] circleRadiuses = {1f, 3f, 5f};
// float pi = 3.1416f;

// float CalcCircleArea(float radius)
// {
//     return pi * radius * 2;
// }

// foreach (int value in circleRadiuses)
// {
//     Console.WriteLine(CalcCircleArea(value));
// }

// // Exercise 7.10: Length of Month Topic
// // Write a program, that given a month number in a variable prints out the number of days in this
// // month. Do not consider leap years.
// // Note: This is a repetition of exercise 6.4, but this time you have a larger toolbox at your
// // disposal.
// string month = "February";
// switch(month) 
// {
//     case "January": case "Marts": case "May": case "July": case "August": case "October": case "December":
//         Console.WriteLine(31);
//         break;
//     case "April": case "June": case "September": case "November":
//         Console.WriteLine(30);
//         break;
//     case "February":
//         Console.WriteLine(29);
//         break;
//     default:
//         Console.WriteLine("Invalid Input");
//         break;
// }

// Exercise 6.10: Primes Topic
// Write a program that calculates all prime numbers below 1,000,000 and prints out the largest.
// Hints (unless you want more of a challenge):
// • A positive integer is a prime number if, and only if it is not divisible by integers other than
// 1.
// • Use a divide-and-conquer strategy1 whereby you subdivide the task into these subtasks:
// – Iterate through all positive integers below 1.000.000. Don’t we have a construct that
// can do this?
// – Determine whether a given positive number is a prime.
// – Print out an integer number (if it is prime).
// In order to determine whether a given positive integer is prime, you can, once again, divide
// an conquer:
// 1. Declare a boolean variable named is_prime and initialize it to True.
// 2. Iterate through all integers from (and including) 2 until (but not including) 1,000,000.
// 3. Check whether the prime candidate is divisible by each of these numbers. If that is
// the case, you should assign the False value to is_prime. But how do you determine
// one number is divisible by another?
// – You try it, of course!
// – If a number is divisible by another, then there won’t be a remainder if you do an
// integer division and the modulo operation (via the % operator) will evaluate to
// zero.
// – As an alternative, one could exploit that the integer division will result in a
// rounding error so that (a/b) · b 6 = a.
// 4. At this point, is_prime represent the truth value of whether the prime candidate is
// an actual prime.

int max = -1;
for(int i = 0; i < 100; i++)
{    
    // Numbers less than or equal to 1 are not prime
    if (i <= 1)
    {
        continue; 
    }
    
    // 2 is the only even prime number
    if (i == 2)
    {
        max = i;
    }
     
    // Exclude all other even numbers
    if (i % 2 == 0)
    {
        continue; 
    } 

    // Check odd factors up to the square root of n
    for (int j = 3; j * j <= i; j += 2)
    {
        if (i % j == 0)
        {
            continue;
        } // Found a factor, so not prime
    }

    if (i > max)
    {
        max = i;
    }
    // No factors found, it's prime     
}
 Console.WriteLine(max);