/*counter*/
function count(){
    let result = 0;
    function countIntern(){
        result++;
        return result;
        
    }
    return countIntern;
}
let a = count();
console.log(a());
console.log(a());
console.log(a());
console.log(a());
console.log(a());