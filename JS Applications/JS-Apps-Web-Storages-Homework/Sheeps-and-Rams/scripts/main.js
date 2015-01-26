(function () {
    require.config({
        paths: {
            'game' : 'game',
            'chance': 'libs/chance.min'
        }
    });

    require(['game'], function (Game) {
        var theGame = new Game();
        theGame.startGame();

        //In the console you can see the number
        console.log('-- Computer Number --');
        console.log(theGame.guessNumber);
    })
}());
