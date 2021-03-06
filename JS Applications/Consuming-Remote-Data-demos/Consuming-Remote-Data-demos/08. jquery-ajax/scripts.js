// Generated by CoffeeScript 1.7.1
(function () {
    var $errorMessage, $successMessage, addStudent, reloadStudents, resourceUrl;

    resourceUrl = 'http://localhost:3000/students';

    $successMessage = $('.messages .success');

    $errorMessage = $('.messages .error');

    addStudent = function (data) {
        return $.ajax({
            url: resourceUrl,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: 'application/json',
            success: function (data) {
                $successMessage
                  .html('' + data.name + ' successfully added')
                  .show()
                  .fadeOut(2000);
                reloadStudents();
            },
            error: function (err) {
                $errorMessage
                  .html('Error happened: ' + err)
                  .show()
                  .fadeOut(2000);
            }
        });
    };

    reloadStudents = function () {
        $.ajax({
            url: resourceUrl,
            type: 'GET',
            contentType: 'application/json',
            success: function (data) {
                var student, $studentsList, i, len;
                $studentsList = $('<ul/>').addClass('students-list');
                for (i = 0, len = data.students.length; i < len; i++) {
                    student = data.students[i];
                    $('<li />')
                      .addClass('student-item')
                      .append($('<strong /> ')
                        .html(student.name))
                      .append($('<span />')
                        .html(student.grade))
                      .appendTo($studentsList);
                }
                $('#students-container').html($studentsList);
            },
            error: function () {
                $errorMessage
                  .html("Error happened: " + err)
                  .show()
                  .fadeOut(2000);
            }
        });
    };

    $(function () {
        reloadStudents();
        $('#btn-add-student').on('click', function () {
            var student;
            student = {
                name: $('#tb-name').val(),
                grade: $('#tb-grade').val()
            };
            addStudent(student);
        });

        //GET zayavka
        //$.ajax({
        //    url: 'http://localhost:3000/students',
        //    type: 'GET',
        //    success: function (data) {
        //        console.log(data);
        //    }
        //});

        //POST zayavka
        //$.ajax({
        //    url: 'http://localhost:3000/students',
        //    type: 'POST',
        //    data: {
        //        name: 'Pesho',
        //        grade: 12
        //    },
        //    success: function (data) {
        //        if (data) {
        //            console.log(data);
        //        }
        //    },
        //    error: function (error) {
        //        console.log(error);
        //    }
        //});

        //$.get('http://localhost:3000/students')
        //    .then(function (data) {
        //        console.log(data);
        //    });

        var studentToSned = {
            name: 'easy method',
            grade: 100
        };

        $.post('http://localhost:3000/students', studentToSned)
            .then(function (data) {
                console.log(data);
            }, function (err) {
                console.log(err);
            });
    });
    
}).call(this);

//# sourceMappingURL=scripts.map