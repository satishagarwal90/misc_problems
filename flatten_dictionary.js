var result = {};
function flatten(obj,prefix){	
	for(var prop in obj){
		if(!obj.hasOwnProperty(prop)) return;
		if(typeof(obj[prop]) == "object"){
			var key = prefix == ""?prop:prefix+"."+prop;
			flatten(obj[prop],key);
		}			
		else{
			var key = prop;
			if(prefix != "") key = prefix+"."+key;
			result[key] = obj[prop];
		}
	}
}
var obj = {
            "Key1" : "1",
            "Key2" : {
                "a" : "2",
                "b" : "3",
                "c" : {
                    "d" : "3",
                    "e" : "1"
                }
            }
        };
		flatten(obj,"");
console.log(result);
