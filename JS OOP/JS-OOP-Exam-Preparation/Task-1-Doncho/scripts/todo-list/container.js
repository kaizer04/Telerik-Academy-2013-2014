define(['todo-list/section'],function () {
    'use strict';
    var Container;
    Container = (function () {
        //hidden data only accessible for Container instances
        //function privateMethod() {
        //    this.privateStuff = value;
        //}
        var lastContainerId = 0;
        function Container() {
            this._id = ++lastContainerId;
            this._sections = [];
        }

        //function Container() {
        //    this._sections = [];
        //    //privateMethod.call(this);
        //}

        Container.prototype = {
            add: function (section) {
                if (!(section instanceof Section)) {
                    throw {
                        message: 'Not a section in container'
                    };
                }
                this._sections.push(section);
                return this;
            },
            getData: function () {
                var i, section, dataSections, len;

                dataSections = [];

                for (var i = 0, len = this._sections.length; i < len; i +=1) {
                    section = this._sections[i];
                    dataSections.push(section.getData());
                }

                return dataSections;

                //return this;
            }
        };

        return Container;
    }());
    return Container;
});