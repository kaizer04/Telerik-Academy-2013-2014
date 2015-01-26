define(function () {
    'use strict';
    var Container;
    Container = (function () {
        function Container() {
            this._sections = [];
        }

        Container.prototype.add = function (section) {
            this._sections.push(section);
        };

        Container.prototype.getData = function () {
            var i, section, dataSections, len;

            dataSections = [];

            for (var i = 0, len = this._sections.length; i < len; i += 1) {
                section = this._sections[i];
                dataSections.push(section.getData());
            }

            return dataSections;
        };

        return Container;
    }());

    return Container;
});