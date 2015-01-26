function solve(args) {
    var size = args[0].split(' ');
    var rows = parseInt(size[0]);
    var cols = parseInt(size[1]);
    //var startPosition = 
    var row = 0;
    var col = 0;
    var lab = args.slice(1);
    //console.log(paths);
    var visited = {};
    
   
    var directions = {
        dl: {
            row: 1,
            col: -1
        },
        dr: {
            row: 1,
            col: 1
        },
        ur: {
            row: -1,
            col: 1
        },
        ul: {
            row: -1,
            col: -1
        }
    };

    function getValueAt(row, col, cols) {
        return Math.pow(2, row) + col;
    }

    function inRange(value, border) {
        return 0 <= value && value < border;
    }
    var sum = 0;
    var count = 0;

    while (true) {
        //chck if outside
        if (!inRange(row, rows) || !inRange(col, cols)) {
            return 'successed with ' + sum;
        }
        var cellValue = getValueAt(row, col, cols);
        //check if on visited
        //if (visited[cellValue]) {
        //    return 'failed at (' + row + ', ' + col + ')';
        //}

        sum += getValueAt(row, col, cols);
        count++;
        visited[cellValue] = true;

        var dir = lab[row][col];
        row += directions[dir].row;
        col += directions[dir].col;

        
    }

}

args = [
  '3 5',
  'dr dl dr ur ul',
  'dr dr ul ur ur',
  'dl dr ur dl ur'
];

solve(args);