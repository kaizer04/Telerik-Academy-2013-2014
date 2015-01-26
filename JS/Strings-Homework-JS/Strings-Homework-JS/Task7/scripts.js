/* 07. Write a script that parses an URL address given in the format:
[protocol]://[server]/[resource]
		and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.*/

function extractsURLAdress(urlAdress) {
    console.log("Entered URL adress: ");
    console.log(urlAdress);
    var protocolIndex = urlAdress.indexOf(':'); //=4
    var protocol = urlAdress.substring(0, protocolIndex); 
    console.log('{protocol: \'' + protocol + '\','); 
    var serverIndex = urlAdress.indexOf('/', protocolIndex + 3); //=20
    var server = urlAdress.substring((protocolIndex + 3), (serverIndex));
    console.log('server: \'' + server + '\',');
    var resource = urlAdress.substring(serverIndex, urlAdress.length);
    console.log('resource = \'' + resource + '\'}');
}

var urlAdress = 'http://www.devbg.org/forum/index.php';

extractsURLAdress(urlAdress);
