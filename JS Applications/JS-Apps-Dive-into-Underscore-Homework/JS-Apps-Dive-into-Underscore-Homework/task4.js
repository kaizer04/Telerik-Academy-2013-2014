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
            Object.create(Animal).init("Peshu", "Mammals", 1),
            Object.create(Animal).init("Goshu", "Mammals", 3),
            Object.create(Animal).init("Pam", "Insects", 4),
            Object.create(Animal).init("Yanko", "Birds", 5),
            Object.create(Animal).init("Mimi", "Birds", 2),
            Object.create(Animal).init("Ivo", "Insects", 6),
            Object.create(Animal).init("Ivan", "Mammals", 2),
    ];

    console.log('---Task 4---');

    //function groupBySpeciesAndSortByLegs(animals) {
    //    var sortedByLegs = _.sortBy(animals, 'legs');
    //    var grouped = _.groupBy(sortedByLegs, 'species');
        
    //    return grouped;
    //}

    function groupBySpeciesAndSortByLegs(animals) {
        var grouped = _.groupBy(_.sortBy(animals, 'legs'), 'species');
        return grouped;
    }

    console.log(groupBySpeciesAndSortByLegs(animals));
}());