define(function () {
    'use strict';
    var Item;
    Item = (function () {
        function Item(content) {
            this._content = content;
        }

        Item.prototype.getData = function () {
            //return this.content;
            return {
                content: this._content
            };
        };

        return Item;
    })();

    return Item;
});