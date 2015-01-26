var Person = (function () {
    function Person(name, age) {
        this._name = name;
        this._age = age;
    }

    Person.prototype.birthday = function () {
        this._age += 1;
    };

    //tova e ekvivalentno s dolnoto. Na Doncho mu haresva dolnto, zashtoto ima get i set
    //Person.prototype.age = function (newAge) {
    //    if (newAge) {
    //        //defensive programming validations
    //       this._age = newAge;
    //        return this;
    //    }
    //    else {
    //        return this._age;
    //    }
    //}


    Person.prototype.getAge = function () {
        return this._age;
    };

    Person.prototype.setAge = function (newAge) {
        //defensive programming validations
        this._age = newAge;
    };
    
    Person.prototype.toString = function () {
        return 'P Name: ' + this._name + ', Age: ' + this._age;
    }

    return Person;
}());

var Student = (function () {
    function Student(name, age, grade) {
        Person.call(this, name, age);
        //this._name = name;
        //this._age = age;
        this._grade = grade;
    };

    Student.prototype = new Person();
    Student.prototype.constructor = Student; //tozi red e savecheck.ne e zadyljitelen

    Student.prototype.toString = function () {
        return Person.prototype.toString.call(this) + ', Grade: ' + this._grade;
    };

    return Student;
}());


//var st = new Student('Pesho', 17, 10);

//console.log(st.getAge());
//console.log(st instanceof Student);
//console.log(st instanceof Person);

//console.log(st.toString());

var st = new Student();

for (var prop in st) {
    //if (Student.prototype.hasOwnProperty(prop)) {
    //    console.log(prop);
    //}
    if (st.hasOwnProperty(prop)) {
        console.log(prop);
    }
    //console.log(prop);
}