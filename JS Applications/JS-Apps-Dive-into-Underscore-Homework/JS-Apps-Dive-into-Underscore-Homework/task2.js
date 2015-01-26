(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../../scripts/underscore.js');
    }

    var Student = Object.create({
        init: function (fname, lname, age) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            return this;
        },
        toString: function () {
            return this.fname + ' ' + this.lname;
        }
    });




    var students = [
		Object.create(Student).init('Doncho', 'Minkov', 45),
		Object.create(Student).init('Nikolay', 'Kostov', 34),
		Object.create(Student).init('Aneliya', 'Kostov', 18),
        Object.create(Student).init('Aneliya', 'Stoyanova', 23),
		Object.create(Student).init('Ivaylo', 'Kenov', 22),
		Object.create(Student).init('Todor', 'Stoyanov', 56)
    ];

    console.log('---Task 2---');

    function filterSpecificAgeRange(students) {
        var filtered = _.chain(students)
                        .filter( function (student) {
                            return student.age >= 18 && student.age <= 24
                        })
                        .each(function (student) {
                            return student.fname + ' ' + student.lname;
                        }).value();

        return filtered;
    }

    console.log(filterSpecificAgeRange(students));
}());