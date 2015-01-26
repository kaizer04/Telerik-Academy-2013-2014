// 06. Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

//static void FillArray(int[] array)
//{
//        Console.WriteLine("FILL the array");
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write("array[{0}] = ", i);
//    array[i] = int.Parse(Console.ReadLine());
//}
//}

function checkPosition(position, length) {
    if (position <= 0 || position >= length) {
        console.log("Enter a correct position!");
        return false;
    }
    else {
        return true;
    }   
}

function checkBiggerNeighbors() {
    var elementPosition = 5;
    var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, -3];
    
    if (checkPosition(elementPosition, array.length)) {
        if (array[elementPosition] > array[elementPosition - 1] && array[elementPosition] > array[elementPosition + 1]) {
            console.log("The elementi IS BIGGER than its two neighbor!");
        }
        else {
            console.log("The elementi IS NOT BIGGER than its two neighbor!");
        }
    }
}
    
checkBiggerNeighbors();
