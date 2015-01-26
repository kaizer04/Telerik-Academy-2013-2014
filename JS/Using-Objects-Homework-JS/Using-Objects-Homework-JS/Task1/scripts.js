/* 01. Write functions for working with shapes in  standard Planar coordinate system
Points are represented by coordinates P(X, Y)
Lines are represented by two points, marking their beginning and ending
L(P1(X1,Y1), P2(X2,Y2))
Calculate the distance between two points
Check if three segment lines can form a triangle */

function calculateDistanceBetweenPoints(x1, y1, x2, y2) {
    var  distance = Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2));
    return distance;
}

function checkIsTriangle(x1, y1, x2, y2, x3, y3) {
    var sideA = calculateDistanceBetweenPoints(x1, y1, x2, y2);
    var sideB = calculateDistanceBetweenPoints(x2, y2, x3, y3);
    var sideC = calculateDistanceBetweenPoints(x3, y3, x1, y1);
    var result = "";
    if ((sideA + sideB > sideC) & (sideB + sideC > sideA) & (sideA + sideC > sideB)) {
        result = "Yes, it`s a triangle!";
    }
    else {
        result = "No, it`s NOT a triangle!";
    }
    return result;
}

var x1, x2, x3, y1, y2, y3;
x1 = 5;
y1 = 6;
x2 = -9;
y2 = 7;
x3 = 0;
y3 = 0;

var distance =  calculateDistanceBetweenPoints(x1, y1, x2, y2);
console.log(distance);
console.log(checkIsTriangle(x1, y1, x2, y2, x3, y3));