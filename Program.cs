
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