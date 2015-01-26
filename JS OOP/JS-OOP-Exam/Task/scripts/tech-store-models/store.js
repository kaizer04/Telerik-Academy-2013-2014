define(function () {
    'use strict';
    var Store;
    Store = (function () {

        function Store(name) {
            if (name.length < 6 || name.length > 30) {
                throw {
                    message: 'The name must be with length between 6 and 30 characters!'
                };
            }
            this._name = name;;
            this._items = [];
        }

        Store.prototype.addItem = function (item) {
            this._items.push(item);
            return this;
        };

        Store.prototype.getAll = function () {
            var dataItems;

            var dataItems = this._items;
            sortItemsByName(dataItems);
            return dataItems;
            
        };

        Store.prototype.getSmartPhones = function () {
            var dataItems, i, len;
            var self = this;
            dataItems = [];
            for (var i = 0, len = self._items.length; i < len; i += 1) {
                if (this._items[i]._type === 'smart-phone') {
                    dataItems.push(this._items[i]);
                }
            };

            return dataItems;
        };

        Store.prototype.getMobiles = function () {
            var dataItems, i, len;
            var self = this;
            dataItems = [];
            for (var i = 0, len = self._items.length; i < len; i += 1) {
                if (this._items[i]._type === 'smart-phone' || this._items[i]._type === 'tablet') {
                    dataItems.push(this._items[i]);
                }
            };

            return dataItems;
        };

        Store.prototype.getComputers = function () {
            var dataItems, i, len;
            var self = this;
            dataItems = [];
            for (var i = 0, len = self._items.length; i < len; i += 1) {
                if (this._items[i]._type === 'pc' || this._items[i]._type === 'notebook') {
                    dataItems.push(this._items[i]);
                }
            };

            return dataItems;
        };

        function sortItemsByName(items) {
            items.sort(function (first, second) {
                return second._name - first._name;
            });

            return items;
        };



        return Store;
    })();

    return Store;
});