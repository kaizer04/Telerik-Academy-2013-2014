/* 08. Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

function replacesTags(htmlDoc) {
    console.log('Entered HTML document: ');
    console.log(htmlDoc);
    htmlDoc = htmlDoc.replace(/<a href="/g, '[URL=');
    htmlDoc = htmlDoc.replace(/">/g, ']');
    htmlDoc = htmlDoc.replace(/<\/a>/g, '[/URL]');
   
    console.log(htmlDoc);
}

var text = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

replacesTags(text);

