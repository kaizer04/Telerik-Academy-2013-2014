
function solve(params) {
    var s = params;
    //console.log(s);
    var allWheels = s;
    //console.log(s);
    var count = 0;
    
    var trucks = 0;
    var cars = 0;
    var trikes = 0;

    var carWheels = 4;
    var truckWheels = 10;
    var trikeWheels = 3;

    //if (s % truckWheels === 0) {
    //    count++;
    //}
    //else 
    if (s > 10) {
        for (var i = 0; i <= s; i = i + truckWheels) {
            trucks++;
            if ((s - trucks * truckWheels) % carWheels === 0) {
                count++;
            }
        }
        
        s = allWheels;
    }
    else if (s > 14) {
    }
    //else {
    //    for (var i = carWheels; i <= s; i = i + carWheels) {
    //        cars++;
    //    }
    //    s = s - cars;
    //    if (s % trikeWheels === 0) {
    //        trikes = s / trikeWheels;
    //    }
    //}
    //}
    //if (s % carWheels === 0) {
    //    count++;
    //}
    
    //if (s % trikeWheels === 0) {
    //    count++;
    //}
    
    console.log(count);
}



var input = 32;

solve(input);