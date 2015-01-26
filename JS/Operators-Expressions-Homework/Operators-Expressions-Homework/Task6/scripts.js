// 06. Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

var coordinateX = 5;
var coordinateY = 0;
var inCircle = ((coordinateX * coordinateX) + (coordinateY * coordinateY)) <= 25;
console.log("The point is within a circle K(O, 5): " + inCircle);
