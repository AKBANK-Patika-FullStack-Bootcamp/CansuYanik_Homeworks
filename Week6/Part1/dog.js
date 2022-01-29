// dog object assignment
let dogObject = (name, height, weight, gender, age, breed) => {
return({ 
        name: name,
        height: height,
        weight: weight,
        gender: gender,
        age: age,
        breed: breed
    });
};

const Cookie = dogObject("Cookie",18.2,3.7,"female",1,"Maltipoo");

//dogObject function also can be used.
module.exports = {Cookie, dogObject};