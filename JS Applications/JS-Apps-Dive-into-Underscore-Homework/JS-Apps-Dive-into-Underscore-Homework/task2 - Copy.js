function solve() {
    return function (students) {
        //var _ = require('./lib/underscore-min.js');

        function getFullname(student) {
            return student.firstName + ' ' + student.lastName;
        }

        _.chain(students)
            .filter(function (student, index, collection) {
                return 18 <= student.age && student.age <= 24;
            })
            .sortBy(function (student, index, collection) {
                return getFullname(student).toLowerCase();
            })
            .each(function (student, index, collection) {
                console.log(getFullname(student));
            });
    };
}