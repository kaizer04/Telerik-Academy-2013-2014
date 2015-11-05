/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (students) {
        //var _ = require('./underscore-min.js');

        var foundStudent = _.chain(students)
            .each(function (student, index, collection) {
                student.fullname = function () {
                    return this.firstName + ' ' + this.lastName;
                };

                student.averageGrade = function () {
                    var marksSum = _.reduce(this.marks, function (result, mark) {
                        return result + mark;
                    }, 0);
                    return marksSum / this.marks.length;
                };
            })
            .max(function (student, index, collection) {
                return student.averageGrade();
            })
            .value();

        console.log(foundStudent.fullname() + ' has an average score of ' + foundStudent.averageGrade());
    };
}

var students = [{
    firstName: 'NAME #3',
    lastName: 'NAME #2',
    age: 5,
    marks: [1, 2, 3]
}, {
    firstName: 'NAME #4',
    lastName: 'NAME #1',
    age: 18,
    marks: [1, 2, 3]
}, {
    firstName: 'NAME #5',
    lastName: 'NAME #7',
    age: 55,
    marks: [1, 2, 3, 6]
}, {
    firstName: 'NAME #8',
    lastName: 'NAME #9',
    age: 20,
    marks: [1, 2, 3]
}, {
    firstName: 'NAME #11',
    lastName: 'NAME #15',
    age: 55,
    marks: [1, 2, 3]
}];

var result = solve();
result(students);

module.exports = solve;