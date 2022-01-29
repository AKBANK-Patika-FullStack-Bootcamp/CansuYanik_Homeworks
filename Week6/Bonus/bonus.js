/*I assumed that, strings in the array have only English letters (not digits, spaces or punctiontions)*/

const lines = ["qwertyuıopğü", "asdfghjklşi", "zxcvbnmöç"];

/*function takes word and line, and it converts world to char array,
using reduce, every char is checked from the given line whetter current char exist or not*/
let hasOrNot  = (word, line) => {
    return word.split("").reduce((acc, character) => acc && line.includes(character), true);
};


/*function takes word, for each line, hasOrNot function is called to check all characters exist in that line,
if yes word is returned*/
checkLines = (word) => {
    if (lines.map(function(line) {return hasOrNot(word, line)}).includes(true)){
        return word;
    }
};

/*Arrow funstion takes array, for each word, checkLines function is called, then words are found*/
findWords = (array) => array.map(checkLines).filter(word => word !==undefined);

let array = ["asli", "menekşe", "çöz", "giresun"]; //example array

console.log(findWords(array));