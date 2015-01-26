define(['tech-store-models/store'], function(){
	'use strict';
	var Store;
	Store=function() {
		function Store(name){
			this._name=name
			this.items=[];
		}

		Store.prototype={
			addItem: function(item){
				this.items.push(item);
				return this;
			},
			
			getAll: function(){
				var propArr=[];
				var sortedItems=[];
				var len=this.items.length;
				for (var i=0; i<len; i++){
					propArr.push(this.items[i]._name);
				}
				propArr.sort();
				for (var k=0; k<len; k++){
					for (var t=0; t<len; t++){
						if (this.items[t]._name==propArr[k]){
							sortedItems.push(this.items[t])
						}
					}
				}
				return sortedItems;
			},
			getSmartPhones: function(){
				var propArr=[];
				var sortedItems=[];
				var len=this.items.length;
				for (var i=0; i<len; i++){
					if (this.items[i]._type==='smart-phone')
					propArr.push(this.items[i]._name);
				}
				propArr.sort();
				for (var k=0; k<propArr.length; k++){
					for (var t=0; t<len; t++){
						if (this.items[t]._name==propArr[k]){
							sortedItems.push(this.items[t])
						}
					}
				}
				return sortedItems;
			},
			getMobiles: function(){
				var propArr=[];
				var sortedItems=[];
				var len=this.items.length;
				for (var i=0; i<len; i++){
					if (this.items[i]._type==='smart-phone'||this.items[i]._type==='tablet')
					propArr.push(this.items[i]._name);
				}
				propArr.sort();
				for (var k=0; k<propArr.length; k++){
					for (var t=0; t<len; t++){
						if (this.items[t]._name==propArr[k]){
							sortedItems.push(this.items[t])
						}
					}
				}
				return sortedItems;
			},
			getComputers: function(){
				var propArr=[];
				var sortedItems=[];
				var len=this.items.length;
				for (var i=0; i<len; i++){
					if (this.items[i]._type==='pc'||this.items[i]._type==='notebook')
					propArr.push(this.items[i]._name);
				}
				propArr.sort();
				for (var k=0; k<propArr.length; k++){
					for (var t=0; t<len; t++){
						if (this.items[t]._name==propArr[k]){
							sortedItems.push(this.items[t])
						}
					}
				}
				return sortedItems;
			},
			filterItemsByType: function(itemType){
				var propArr=[];
				var sortedItems=[];
				var len=this.items.length;
				for (var i=0; i<len; i++){
					if (this.items[i]._type===itemType)
					propArr.push(this.items[i]._name);
				}
				propArr.sort();
				for (var k=0; k<propArr.length; k++){
					for (var t=0; t<len; t++){
						if (this.items[t]._name==propArr[k]){
							sortedItems.push(this.items[t])
						}
					}
				}
				return sortedItems;
			},
			filterItemsByPrice: function(params){
				var min, max;
				if (typeof(params)==='undefined'){
					min=0, max=1/0
				}
				else{
					min=params.min;
					if (typeof(min)==='undefined'){
						min=0;
					}
					max=params.max;
					if (typeof(max)==='undefined'){
						max=1/0;
					}
				}
				var len=this.items.length;
				var itemsToSort=[];
				for (var i=0; i<len; i++){
					if (this.items[i]._price<=max&&this.items[i]._price>=min){
						itemsToSort.push(this.items[i]);
					}
				}
				len=itemsToSort.length;
				var tempMin;
				
				for (var i=0; i<len; i++){
					tempMin=itemsToSort[i];
					for (var t=i; t<len; t++){
						if (tempMin._price>=itemsToSort[t]._price){
							tempMin=itemsToSort[t];
							itemsToSort[t]=itemsToSort[i];
							itemsToSort[i]=tempMin;
						}
					}

				}
				return itemsToSort;

			},
			countItemsByType: function(){
				var typeCountArr=new Array();
				typeCountArr['accessory']=0;
				typeCountArr['smart-phone']=0;
				typeCountArr['notebook']=0;
				typeCountArr['pc']=0;
				typeCountArr['tablet']=0;
				var len=this.items.length;
				for (var i=0; i<len; i++){
					switch (this.items[i]._type){
						case 'accessory':
							typeCountArr['accessory']++;
						break;
						case 'smart-phone':
							typeCountArr['smart-phone']++;
						break;
						case 'notebook':
							typeCountArr['notebook']++;
						break;
						case 'pc':
							typeCountArr['pc']++;
						break;
						case 'tablet':
							typeCountArr['tablet']++;
						break;
					}
				}
				return typeCountArr;
			},
			filterItemsByName: function(partOfName){
				var propArr=[];
				var sortedItems=[];
				var len=this.items.length;
				for (var i=0; i<len; i++){
					if (this.items[i]._name.toLowerCase().indexOf(partOfName.toLowerCase())>=0)
					propArr.push(this.items[i]._name);
				}
				propArr.sort();
				for (var k=0; k<propArr.length; k++){
					for (var t=0; t<len; t++){
						if (this.items[t]._name==propArr[k]){
							sortedItems.push(this.items[t])
						}
					}
				}
				return sortedItems;
			}
		}
		return Store;
	}();
	return Store;
});