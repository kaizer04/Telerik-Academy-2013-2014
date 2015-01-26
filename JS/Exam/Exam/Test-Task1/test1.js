
function solve(params) {
    var s = params;
    //console.log(s);
    
    var count = 0;

    var trucks = 0;
    var cars = 0;
    var trikes = 0;

    var carWheels = 4;
    var truckWheels = 10;
    var trikeWheels = 3;

  
    
    for (var i = 0; i <= s; i = i + truckWheels, trucks++) {
            
        if ((s - trucks * truckWheels) % carWheels === 0) {
            count++;
        }
        for (var j = 0; j < s - i; j = j + carWheels, cars++) {
                
            if ((s - trucks * truckWheels - cars * carWheels) % trikeWheels === 0) {
                count++;
            }
            
            for (var k = 0; k < s - i - j; k = k + trikes, trikes++) {

                if (s === trucks * truckWheels + cars * carWheels + trikeWheels * trikes) {
                    count++;
                }
            }
            //console.log(count);
        }
    }

    
    return count;
}



var input = 40;

console.log(solve(input));