define(['data', 'combobox'], function (courses, combobox) {
    var run = function () {
        var myCombobox = combobox.getComboBoxController(courses);
        myCombobox.renderTemplate('#combobox-template');
        myCombobox.createCombo('#combobox-root');
    }

    return {
        run: run
    }
})