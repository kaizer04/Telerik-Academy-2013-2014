function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    
    var filterField = document.createElement('aside');
    var spanFilter = document.createElement('span');
    spanFilter.innerText = 'Filter';
    filterField.appendChild(spanFilter);
    var formFilter = document.createElement('form');
    var inputFilter = document.createElement('input');
    

    formFilter.appendChild(inputFilter);
    filterField.appendChild(formFilter);
    container.appendChild(filterField);

    var listItems = document.createElement('ul');
    for (var i = 0, len = items.length; i < len; i+=1) {
        var liItem = document.createElement('li');
        var titleImg = document.createElement('h4');
        titleImg.innerText = items[i].title;

        liItem.appendChild(titleImg);
        listItems.appendChild(liItem);

    }

    container.appendChild(listItems);

    //styes
    container.style.width = '1000px';
    listItems.style.float = 'right';
    listItems.style.width = '200px';
    listItems.style.marginTop = '5px';


    //filterField.style.float = 'right';
    filterField.style.width = '150px';
    formFilter = '150px';
    spanFilter.style.textAlign = 'center';
}