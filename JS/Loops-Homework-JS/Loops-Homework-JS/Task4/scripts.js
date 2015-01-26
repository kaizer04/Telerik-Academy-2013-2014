// 04. Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects

function findSmallest(object) {
    var smallest = false;
    for (var property in object) {
        if (!smallest) {
            smallest = property;
        }
        if (property < smallest) {
            smallest = property;
        }
    }

    console.log("The smallest lexicographically property in " + object + " is " + smallest);
}

function findLargest(object) {
    var largest = false;
    for (var property in object) {
        if (!largest) {
            largest = property;
        }
        if (property > largest) {
            largest = property;
        }
    }

    console.log("The biggest lexicographically property in " + object + " is " + largest);
}

findSmallest(document);
findLargest(document);
findSmallest(window);
findLargest(window);
findSmallest(navigator);
findLargest(navigator);
