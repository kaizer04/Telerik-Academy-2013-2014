/* 05. Write a function that finds the youngest person in a given array of persons and prints his/hers full name
Each person have properties firstname, lastname and age*/

function findYoungest(arrayOfPersons) {
    var youngest = arrayOfPersons[0];
    for (var i = 1; i < arrayOfPersons.length; i++) {
        if (arrayOfPersons[i].age < youngest.age) {
            youngest = arrayOfPersons[i];
        }
    }

    console.log("The youngest is " + youngest.firstname + " " + youngest.lastname);
};

var persons = [
    { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname : 'Pam', lastname: 'Anderson', age: 23}   
];

findYoungest(persons);


