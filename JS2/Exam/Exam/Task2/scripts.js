$.fn.gallery = function (col) {
    var $galleryControl = this;

    var col = col | 0;

    if (col) {
        var galleryWidth = col * 260;
    }
    else {
        galleryWidth = 1040;
    }
    //console.log(galleryWidth);
    $galleryControl.addClass('gallery').css('width', galleryWidth.toString() + 'px');
    
    hideSelectedImg();

    $galleryControl.on('click', '.image-container', function () {
        var $clickedImg = $(this);
        
        showZoomImg($clickedImg);
        //$galleryControl.find('.blurred').show();
        //$clickedImg.next().show();
        //$clickedImg.addClass('.current-image');
        //hideSelectedImg();
        
    });

    $galleryControl.on('click', '.selected .current-image', function () {
        hideSelectedImg();
    });

    $galleryControl.on('click', '.selected .next-image', function () {
        var $clickedImg = $(this);
        showZoomImg($clickedImg);
    });

    $galleryControl.on('click', '.selected .previous-image', function () {
        var $clickedImg = $(this);
        showZoomImg($clickedImg);
    });

    function hideSelectedImg() {
        $galleryControl.find('.selected').hide();
    }

    function showZoomImg($clickedImg) {
        //TO DO
        $galleryControl.find('.selected').show();

    }

    

    function generateSliderControl(holder) {
        var allSlidesJSONArray = getAllSlides();

        // in case a normal DOM element is givven
        var $holder = $(holder);

        var $sliderContent = $('<div />')
                                .attr('id', 'sliderContent')
                                .css('position', 'relative')
                                .appendTo($holder);

        for (var i = 0; i < allSlidesJSONArray.length; i++) {
            var $currElement = $('<div />')
                                .html(allSlidesJSONArray[i])
                                .hide()
                                .css('position', 'absolute');

            $sliderContent.append($currElement);
        }

        $sliderContent.children().first().show();

        var $prevButton = $('<button />')
                            .on('click', function () {
                                showSlide(true);
                            })
                            .html('Previous Slide')
                            .appendTo($holder);

        var $nextButton = $('<button />')
                            .on('click', function () {
                                showSlide(false);
                            })
                            .html('Next Slide')
                            .appendTo($holder);

        var refresher = setInterval(showSlide, 5000);

        function showSlide(previous) {
            clearInterval(refresher);
            refresher = setInterval(showSlide, 5000);

            var $currentVisible = $sliderContent.children(':visible');
            var $nextToShow = $currentVisible.first().next();

            if (previous) {
                $nextToShow = $currentVisible.first().prev();
            }

            if ($nextToShow.length == 0) {
                $nextToShow = $sliderContent.children().first();
                if (previous) {
                    $nextToShow = $sliderContent.children().last();
                }
            }

            $currentVisible.fadeOut(750);
            $nextToShow.fadeIn(750);
        }
    }
};