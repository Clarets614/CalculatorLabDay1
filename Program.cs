
using System;

Console.WriteLine("Hello, let's calculate the size of your classroom.");

//the following commands will ask the user for specific input
//the user will be able to input decimal numbers and the input will be declared as a float/decimal number
//Then 2 more variables will be declared for the area and the perimeter of the room, which will use the users inputs to calculate the correct number


Console.WriteLine("First, please input the Length of the room.");

float userLength = float.Parse(Console.ReadLine());

Console.WriteLine("Second, please input the Width of the room.");

float userWidth = float.Parse(Console.ReadLine());

//float roomArea = userLength * userWidth; removed this line to use the following methods instead
//float roomPerimeter = 2 * (userLength + userWidth);removed this line to use the following methods instead

float roomArea = CalculateArea(userLength, userWidth);
float roomPerimeter = CalculatePerimeter(userLength, userWidth);



Console.WriteLine($"Thank you!");
Console.WriteLine($"Area:{roomArea}\nPerimeter:{roomPerimeter}");

if ((roomArea > 0) && (roomArea <= 250)){

    Console.WriteLine("You have a Small room to study in.");
}
if ((roomArea > 250) && (roomArea < 650))
{

    Console.WriteLine("You have a Medium room to study in.");
}

if (roomArea >= 650)
{

    Console.WriteLine("You have a Large room to study in.");
}

//methods

static float CalculatePerimeter(float length, float width)
{
    return 2 * (length + width);
}

static float CalculateArea(float length, float width)
{
    return length * width;
}