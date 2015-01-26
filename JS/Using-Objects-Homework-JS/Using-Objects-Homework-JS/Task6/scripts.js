/* 06. Write a function that groups an array of persons by age, first or last name. The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups
Use function overloading (i.e. just one function)*/

function group(arrayOfPersons, key) {
    var grouped = {};
    for (var prop in arrayOfPersons[0]) {
        if (prop === key) {
            for (var i = 0; i < arrayOfPersons.length; i++) {
                if (!grouped[arrayOfPersons[i][key]]) {
                    grouped[arrayOfPersons[i][key]] = [];
                }
                grouped[arrayOfPersons[i][key]].push(arrayOfPersons[i]);
            }
        }
    }

    return grouped;
}

var persons = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Pam', lastname: 'Anderson', age: 23 }
];


var groupedByFname = group(persons, 'firstname');
var groupedByAge = group(persons, 'age');

console.log(groupedByFname);
