/*testcase*/
function add(num1, num2, ...ep){
    if(arguments.length < 2){
        return 0;
    }
    else if(arguments.length == 2){
        
        let res = num1 + num2;
        if(isNaN(res)){
            console.log("Invalid inputs");
            return;
        }
        else{
            return res;
        }
    }
    else{
         
        let res1 = num1 + num2;
        let res2 = 0;
        for(var i = 2; i < arguments.length; i++){
            res2 += arguments[i];
        }
        if(isNaN(res1) || isNaN(res2)){
            console.log("Invalid input");
            return;
        }
        else{
            let result = res1 > res2 ? (res1 - res2) : (res2 - res1);
            return result;
        }
    }
}
let a = add(5,2,3,8,1);
console.log(a);