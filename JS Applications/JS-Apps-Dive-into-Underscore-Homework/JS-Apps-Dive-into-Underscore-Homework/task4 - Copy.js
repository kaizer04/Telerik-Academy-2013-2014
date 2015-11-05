
/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
    *   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:
```
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    GROUP_1_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in group 1
    NAME has LEGS_COUNT legs //for the second animal in group 1
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    GROUP_2_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in the group 2
    NAME has LEGS_COUNT legs //for the second animal in the group 2
    NAME has LEGS_COUNT legs //for the third animal in the group 2
    NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (animals) {
        //var _ = require('./underscore-min.js');

        function animalSort(firstAnimal, secondAnimal) {
            if (firstAnimal.legsCount !== secondAnimal.legsCount) {
                if (firstAnimal.legsCount <= secondAnimal.legsCount) {
                    return -1;
                } else {
                    return 1;
                }
            } else {
                if (firstAnimal.name <= secondAnimal.name) {
                    return -1;
                } else {
                    return 1;
                }
            }
        }

        var groupedAnimals = _.chain(animals)
            .groupBy("species")
            .each(function (animalGroup) {
                _.chain(animalGroup).sort(animalSort);

            })
            .value();

        var sortedAnimalGroupNames = _.keys(groupedAnimals)
            .sort()
            .reverse();

        _.each(sortedAnimalGroupNames, function (groupName) {
            console.log(Array(groupName.length + 2).join('-'));
            console.log(groupName + ':');
            console.log(Array(groupName.length + 2).join('-'));

            _.chain(groupedAnimals[groupName])
                .each(function (animal, index, collection) {
                    console.log(animal.name + ' has ' + animal.legsCount + ' legs');
                })
        });
    };
}

// var animals = [];
// var species = ['insects', 'mammals', 'fish'];
// for (var i = 0; i < 6; i += 1) {
//     animals.push({
//         name: 'animal #' + (i + 1),
//         species: species[(Math.random() * species.length) | 0],
//         legsCount: (Math.random() * 4 + 1) | 0,
//     });
// }

// console.log(animals);
// console.log('');

// var result = solve();
// result(animals);

module.exports = solve;