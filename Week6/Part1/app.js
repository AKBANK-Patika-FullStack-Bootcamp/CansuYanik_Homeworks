//import functions and variables from other files
const { Cookie } = require('./dog.js');
const {Cleaning, dogCareHour} = require('./dogCareUtility.js');

//take system date
var registrationTime = new Date().toTimeString().replace(/.*(\d{2}:\d{2}:\d{2}).*/, "$1");

//print operations
console.log(`Dog registration time: ${registrationTime}`);
console.log(`Dog Information:
\tDod name is ${Cookie.name}. ${Cookie.name} is a ${Cookie.breed} dog and ${Cookie.age} years old.
\t${Cookie.name} is ${Cookie.height} cm height and ${Cookie.weight} kg.
\t${Cookie.name} is ${Cookie.gender}.`);

console.log(Cleaning());
console.log(`Taking care of the dog took ${dogCareHour} hours.`);