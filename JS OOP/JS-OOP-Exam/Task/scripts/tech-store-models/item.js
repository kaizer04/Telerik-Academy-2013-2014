//Items represent the items in stock in a Store. Every item has type, name and price:
//•	Type is a regular string that can have any of the following values: 'accessory', 'smart-phone', 'notebook', 'pc' or 'tablet'. These are the only possible values. Any other value is invalid
//•	Name is a regular string between 6 and 40-characters-long
//•	Price is a decimal floating-point number

define(function () {
    'use strict';
    var Item;
    Item = (function () {
        
        function Item(type, name, price) {
            var typeValues, i, lenTypeValues;

            typeValues = [
            'accessory',
            'smart-phone',
            'notebook',
            'pc',
            'tablet'
            ];

            for (i = 0, lenTypeValues = typeValues.length; i < lenTypeValues; i += 1) {
                if (type === typeValues[i]) {
                    this._type = type;
                    break;
                }
                //else {
                //    throw {
                //        message: 'Type is NOT with right value!'
                //    };
                //}
            }
            
            if (name.length < 6 || name.length > 40) {
                throw {
                    message: 'The name must be with length between 6 and 30 characters!'
                };
            }
            this._name = name;

            this._price = price;
        }

        return Item;
    })();

    return Item;
});
