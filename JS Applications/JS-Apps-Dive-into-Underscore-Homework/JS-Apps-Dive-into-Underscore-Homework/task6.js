(function () {
    //check if running on Node.js
    if (typeof require !== 'undefined') {
        //load underscore if on Node.js
        _ = require('../../scripts/underscore.js');
    }

    var Book = Object.create({
        init: function (name, author) {
            this.name = name,
            this.author = author;
            return this;
        },
        toString: function () {
            return this.name + ' ' + this.author;
        }
    });

    var books = [
         Object.create(Book).init("Black House", "Steven King"),
         Object.create(Book).init("Cycle of the Werewolf", "Steven King"),
         Object.create(Book).init("And Then There Were None", "Agatha Christie"),
         Object.create(Book).init("The Body in the Library", "Agatha Christie"),
         Object.create(Book).init(" Crooked House ", "Agatha Christie")
    ];

    console.log('---Task 6---');

    //function findMostPopularAuthor(books) {
    //    var mostPopularAuthor = _.max(_.groupBy(books, 'author'), function (book) {
    //        return book.length;
    //    });
    //    return mostPopularAuthor;
    //}
    //var mostPopularAuthorBooks = findMostPopularAuthor(books);
    //var mostPopularAuthor = mostPopularAuthorBooks[0].author;
    //console.log(mostPopularAuthor);


    //var mostFamousBooks = _.groupBy(books, 'author');
    //console.log(_.keys(mostFamousBooks)[0]);
    //mostFamousBooks = _.sortBy(mostFamousBooks, );
    var mostFamousBooks = _.groupBy(books, 'author');
    mostFamousBooks = _.sortBy(mostFamousBooks, function (book) { return book.length });
    console.log('mostPopularAuthor: ' + _.last(mostFamousBooks)[0].author);
    
}());