//var type = [
//            'accessory',
//            'smart-phone',
//            'notebook',
//            'pc',
//            'tablet'
//];

function Item(type, name, price) {
    var type = [
            'accessory',
            'smart-phone',
            'notebook',
            'pc',
            'tablet'
    ];
    this._type = type;
    this.name = name;
    this.price = price;
    console.log(this._type);
}

//console.log(type);

Item('accessory');