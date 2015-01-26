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
        Object.create(Student).init('Aneliya', 'Stoyanova', 18),
		Object.create(Student).init('Ivaylo', 'Kenov', 87),
		Object.create(Student).init('Todor', 'Stoyanov', 56)
    ];

    console.log('---Task 1---');
   
    function filterAndSortFirstNameBeforeLastName(students) {
        var filtered = _.filter(students, function (student) {
            if (student.fname < student.lname) {
                return true;
            }
            else {
                return false;
            }
        });

        var sorted = _.chain(filtered)
                        .sortBy(function (student) {
                            return student.fname + ' ' + student.lname
                        })
                        .reverse().value();

        return sorted;
    }

    console.log(filterAndSortFirstNameBeforeLastName(students));
}());