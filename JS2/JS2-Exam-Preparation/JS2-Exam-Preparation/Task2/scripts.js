//$.fn.tabs = function () {
//    var $this = this;
//    var $parentNode = $this;
//    $this.addClass('tabs-container');

//    //$this.find('.tab-item-content').css('display', 'none');
//    $this.find('.tab-item-content').hide();

//    //.tab-item-title
//    $this.find('.tab-item-title').on('click', function (ev) {
//        var $this = $(this);
//        $parentNode.find('.current').removeClass('current');
//        $this.parent().addClass('current');
//        $parentNode.find('.tab-item-content').hide();
//        $this.parent().find('.tab-item-content').show();
//        //.css('display', '');
//    });
//    //.first().click();
    
//    $this.find('.current .tab-item-title')
//		.click();
//};


//Ivaylo Kenov
$.fn.tabs = function () {
    var $tabControl = this;
    $tabControl.addClass('tabs-container');
    hideTabControlContents();

    $tabControl.on('click', '.tab-item-title', function () {
        var $clickedElement = $(this);
        hideTabControlContents();
        $tabControl.find('.tab-item').removeClass('current');
        $clickedElement.next().show();
        $clickedElement.parent().addClass('current');
    });

    function hideTabControlContents() {
        $tabControl.find('.tab-item-content').hide();
    };

    //$tabControl.find('.current .tab-item-title').click();
};
