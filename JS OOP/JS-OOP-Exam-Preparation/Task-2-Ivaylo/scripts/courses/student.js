define(function () { //namespace-modula
    var Student;
    //class-Student
    Student = (function () {
        //constructor
        function Student(information) {
            this.name = information.name;
            this.exam = information.exam;
            this.homework = information.homework;
            this.attendance = information.attendance;
            this.teamwork = information.teamwork;
            this.bonus = information.bonus;
        }

        //Student.prototype.setTotalResult = function (result) {

        //};

        return Student;
    }());

   


    return Student;
});