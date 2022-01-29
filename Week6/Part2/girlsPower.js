
//higher order function
const girlsPowerSum = item => (item/2.0) + 3;

const girlsPower = (arr) => {
    //call higher order function
    return arr.map(girlsPowerSum);
};

let array = [2,3,4]; //example array
console.log(`[${array}] ==> [${girlsPower(array)}]`);

let array2 = [10,11,12]; //example array
console.log(`[${array2}] ==> [${girlsPower(array2)}]`);