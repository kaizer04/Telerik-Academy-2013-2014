define(['jquery', 'rsvp'], function () {
    function getJSON(path) {
        var promise = new RSVP.Promise(function () {
            $.getJSON(path)
                .success(function (data) {
                    resolve(data);
                }).error(function (err) {
                    reject(err);
                });
        });

        return promise;
    }

    return {
        getJSON: getJSON
    };
})