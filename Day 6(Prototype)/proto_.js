
function Animal(owner){
    this.owner = owner
    

}
function Dog(name, color){
    this.name = name,
    this.color = color
}

let a = new Animal("John");
let b = new Dog("Huskey", "White");

b.__proto__.owner=a.owner;
console.log(b.owner)
