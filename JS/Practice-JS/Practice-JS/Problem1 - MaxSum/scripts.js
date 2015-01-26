

function solve(params) {

    var n = parseInt(params[0]);
    
    var sum = parseInt(params[1]);
    var maxSum = parseInt(params[1]);
    var begin = 1;
    var finalBegin = 1;
    var end = 1;
    
    for (var i = 2; i <= n; i++) {
        sum = sum + parseInt(params[i]);
        //console.log(sum);
        if (params[i] > sum) {
            sum = parseInt(params[i]);
            begin = i;
        }

        if (sum > maxSum) {
            maxSum = sum;
            finalBegin = begin;
            end = i;
        }
    }

    return maxSum;
}


console.log(solve(['6', '1', '3', '-5', '8', '7', '-6']));