// 06. Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags

function extractsTextFromHTML(htmlPage) {
    var text = '';
    for (var i = 0; i < htmlPage.length; i++) {
        if (htmlPage[i] === '<') {
            while (htmlPage[i] != '>') {
                i++;
            }
            continue;
        }
        text += htmlPage[i];
    }

    return text;
}

var source = '<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>';

console.log(extractsTextFromHTML(source));