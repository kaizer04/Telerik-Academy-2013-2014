// 09. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var coordinateX = 1;
var coordinateY = 4;

var inRectangle = (((coordinateX <= 5) && (coordinateX >= -1)) && ((coordinateY <= 1) && (coordinateY >= -1)));
var inCircle = ((((coordinateX - 1) * (coordinateX - 1)) + ((coordinateY - 1) * (coordinateY - 1))) <= 9);

var outRectangle = !inRectangle;
var result = outRectangle && inCircle;

console.log(result ? "The point is within the circle K((1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2)" : "The point is not within a circle K((1,1), 3) or out of the rectangle R(top=1, left=-1, width=6, height=2)");