(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../../scripts/underscore.js');
    }

    var Animal = Object.create({
        init: function (name, species, legs) {
            this.name = name;
            this.species = species;
            this.legs = legs;
            return this;
        },
        toString: function () {
            return this.name + ' ' + this.species + ' ' + this.legs;
        }
    });

    var animals = [
            Object.create(Animal).init("Peshu", "Mammals", 2),
            Object.create(Animal).init("Goshu", "Mammals", 4),
            Object.create(Animal).init("Pam", "Insects", 6),
            Object.create(Animal).init("Yanko", "Birds", 8),
            Object.create(Animal).init("Mimi", "Birds", 100),
            Object.create(Animal).init("Ivo", "Insects", 2),
            Object.create(Animal).init("Ivan", "Mammals", 4),
    ];

    console.log('---Task 5---');

    function totalLegsCount(animals) {
        var totalLegsCount = 0;
        for (var i = 0; i < animals.length; i++) {
            totalLegsCount += animals[i].legs;
        }
        return totalLegsCount;
    }

    console.log('totalLegsCount: ' + totalLegsCount(animals));
}());