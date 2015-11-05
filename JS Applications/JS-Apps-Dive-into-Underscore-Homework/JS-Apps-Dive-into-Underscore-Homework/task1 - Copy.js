var Student = Object.create({
    init: function (firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.fullname = function () {
            return this.firstName + ' ' + this.lastName;
        };
        return this;
    }
});




var students = [
    Object.create(Student).init('Doncho', 'Minkov'),
    Object.create(Student).init('Nikolay', 'Kostov'),
    Object.create(Student).init('Aneliya', 'Kostov'),
    Object.create(Student).init('Aneliya', 'Stoyanova'),
    Object.create(Student).init('Ivaylo', 'Kenov'),
    Object.create(Student).init('Todor', 'Stoyanov')
];

var students = [{
    firstName: 'Doncho',
    lastName: 'Minkov'
}, {
    firstName: 'Nikolay',
    lastName: 'Kostov'
}, {
    firstName: 'Ivaylo',
    lastName: 'Kenov'
}];

function solve() {
    return function (students) {
        //var _ = require('./lib/underscore-min.js');
        _.chain(students)
            .each(function (student, index, collection) {
                student.fullname = function () {
                    return this.firstName + ' ' + this.lastName;
                }
            })
            .filter(function (student) {
                return student.firstName.toLowerCase() < student.lastName.toLowerCase();
            })
            .sortBy(function (student, index, collection) {
                return student.fullname().toLowerCase();
            })
            .reverse()
            .each(function (student, index, collection) {
                console.log(student.fullname());
            });
    };
}

module.exports = solve;