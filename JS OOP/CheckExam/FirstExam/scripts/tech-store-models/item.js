define(['tech-store-models/item'], function(){
	'use strict';
	var Item;
	Item=function() {
		function validateType(){
			if (this._type==='accessory'||this._type==='smart-phone'||this._type==='tablet'||this._type==='pc'||this._type==='notebook'){
				return true
			}
			return false
		}
		function validateName(){
			if (this._name.length>40||this._name.length<6){
				return false
			}
			return true
		}

		function validatePrice (){
			if (typeof(this._price)!=="number"){
				return false
			}
			return true
		}
		function Item(type, name, price){

			this._name=name;
			if (!validateName.call(this)){
				throw new Error('invalid name')
			}
			this._type=type;
			if (!validateType.call(this)){
				throw new Error('invalid type')
			}
			this._price=price;
			if (!validatePrice.call(this)){
				throw new Error('invalid price')
			}
		}
		return Item;
	}();
	return Item;
});
