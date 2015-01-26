(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../../scripts/underscore.js');
    }

    var Student = Object.create({
        init: function (fname, lname, age, mark) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.mark = mark;
            return this;
        },
        toString: function () {
            return this.fname + ' ' + this.lname;
        }
    });




    var students = [
		Object.create(Student).init('Doncho', 'Minkov', 45, 5),
		Object.create(Student).init('Nikolay', 'Kostov', 34, 6),
		Object.create(Student).init('Aneliya', 'Kostov', 18, 2),
        Object.create(Student).init('Aneliya', 'Stoyanova', 23, 3),
		Object.create(Student).init('Ivaylo', 'Kenov', 22, 3),
		Object.create(Student).init('Todor', 'Stoyanov', 56, 4)
    ];

    console.log('---Task 3---');

    function findStudentWithHighestMarks(students) {
        var bestStudent = _.max(students, function (student) { return student.mark; });
        return bestStudent;
    }

    console.log(findStudentWithHighestMarks(students));
}());