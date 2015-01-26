

function solve(params) {
    var answer = 1;
    params = params.map(Number);

    for (var i = 2; i < params.length; i++) {
        if (params[i - 1] > params[i]) {
            answer++;
        }
    }
    
    return answer;
}


console.log(solve(['7', '1', '2', '-3', '4', '4', '0', '1']));