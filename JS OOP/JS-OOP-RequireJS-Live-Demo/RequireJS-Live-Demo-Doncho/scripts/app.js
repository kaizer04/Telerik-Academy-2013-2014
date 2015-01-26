(function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery-2.0.3',
            'mustache': 'libs/mustache',
            'rsvp': 'libs/rsvp'
        }
    });
    //require(['jquery'], function () {
    //    $(document.body).append('<h1>Loaded</h1>');
    //});
    require(['data/http-requester'], function (http) {
          
    });
}());