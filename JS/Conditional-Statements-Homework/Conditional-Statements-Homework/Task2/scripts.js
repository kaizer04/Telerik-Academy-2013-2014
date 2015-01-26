// 02. Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

var firstNumber = -9;
var secondNumber = 9;
var thirdNumber = 8;

if (firstNumber >= 0 && secondNumber >= 0 && thirdNumber >= 0)
{
    console.log("The sign of the product of three numbers is (+)");
}
else if (firstNumber >= 0 && secondNumber >= 0 && thirdNumber< 0)
{
    console.log("The sign of the product of three numbers is (-)");
}
else if (firstNumber >= 0 && secondNumber < 0 && thirdNumber>= 0)
{
    console.log("The sign of the product of three numbers is (-)");
}
else if (firstNumber >= 0 && secondNumber < 0 && thirdNumber< 0)
{
    console.log("The sign of the product of three numbers is (+)");
}
else if (firstNumber < 0 && secondNumber >= 0 && thirdNumber>= 0)
{
    console.log("The sign of the product of three numbers is (-)");
}
else if (firstNumber < 0 && secondNumber >= 0 && thirdNumber< 0)
{
    console.log("The sign of the product of three numbers is (+)");
}
else if (firstNumber < 0 && secondNumber < 0 && thirdNumber>= 0)
{
    console.log("The sign of the product of three numbers is (+)");
}
else if (firstNumber < 0 && secondNumber < 0 && thirdNumber< 0)
{
    console.log("The sign of the product of three numbers is (-)");
}