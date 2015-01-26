// 04. Write a function to count the number of divs on the web page



function getDivsCount() {
    var count = document.getElementsByTagName('div').length;;
    console.log("The number of divs is " + count);
}

getDivsCount();



