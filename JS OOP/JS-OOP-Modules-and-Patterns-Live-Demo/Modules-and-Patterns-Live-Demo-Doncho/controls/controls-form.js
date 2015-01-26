var controls = controls || {};
(function (scope) {
    var Form = (function () {
        function Form(title) {
            this._title = title;
        }

        return Form;
    }());

    scope.getForm = function (title) {
        return new Form();
    };
}(controls));