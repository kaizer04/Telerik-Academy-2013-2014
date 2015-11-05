
/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **finds** and **prints** the total number of legs to the console in the format:
    *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (animals) {
        //var _ = require('./underscore-min.js');

        var totalLegs = _.reduce(animals, function (result, animal) {
                return result + animal.legsCount;
            }, 0);

        console.log('Total number of legs: ' + totalLegs);
    };
}

var animals = [];
var species = ['insects', 'mammals', 'fish'];
for (var i = 0; i < 6; i += 1) {
    animals.push({
        name: 'animal #' + (i + 1),
        species: species[(Math.random() * species.length) | 0],
        legsCount: (Math.random() * 4 + 1) | 0,
    });
}

// console.log(animals);
// console.log('');

var result = solve();
result(animals);

module.exports = solve;