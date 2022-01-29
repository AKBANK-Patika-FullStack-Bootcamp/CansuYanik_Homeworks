/*Method 1: using inbuild string methods:
convert it to array, reverse array then join array items
reverse() method needs to traverse array once, lets say its complexity is n (length of the string)
when we added other methods complexity(split and join also n), it will take probably O(3n) time.
Time complexity = O(3n) (or we can say O(n))*/
function method1(s) {
    return s.split('').reverse().join('');
}

/*Method2: using split, while (2 indexes) and join (optimed version of method1)
In this method, I used split and join to be able to use array properties.
In this method, I used 2 indexes. One starts from beginning, other starts from the end, swap them
split and join take n times and since we only traverse array until the middle, time complexity will be O(n/2)
In total time complexity will be 0(2n+n/2) (or we can say O(n))*/
function method2(s) {

    let sArray = s.split('');

    let start = 0;
    let end = sArray.length-1;
    let temp;
        
    while(start<end){
        temp = sArray[start];
        sArray[start] = sArray[end];
        sArray[end] = temp;
        start++;
        end--;
    }
    return sArray.join('');
}

/*Method3: using for loop
Start from the beginning, in each iteration, concat chars like -> char + reversed
(or start from the end, in each iteration, concat chars like -> reversed + char)
Since we need the traverse string once, it takes O(n) time.*/
function method3(s) {
    let reversed = "";

    for(let character of s){
        reversed = character + reversed;
    }
    return reversed;
}

/*Method4: using for while loop (optimized version of method3)
Find the middle char of string, One index starts from mid-1 to the beginning of the string, 
other starts from mid+1 to the end. In each iteration concat them
Since we start from the middle of the array, time complexity will be O(n/2) (we can say O(n))*/
function method4(s) {

    let reversed = "";
    let mid = s.length/2;
    let start = mid-1;
    let end = mid;

    //If string length is odd, we can take middle char directly
    if(s.length%2==1){
        end = mid+1;
        reversed = s.charAt(mid);
    }
        
    while(start>=0){
        reversed = s.charAt(end) + reversed + s.charAt(start);
        start--;
        end++;
    }
    return reversed;
}

/*Method5: using recursive call
In each call, middle of array is found, then subarrays are called and concatenated.
Time complexity O(logn)*/
function method5(s) {
    if (s.length < 2)
      return s;
    let mid = s.length / 2;
    return method5(s.substr(mid)) + method5(s.substr(0, mid));
}

/*Method6: using foreach
string is splitted O(n) and each item concanated.
Total time complexity: O(2n) (or we can say O(n))*/
function method6(s) {

    let reversed = "";  
    s.split("").forEach(function(char){
        reversed = char + reversed;
    });
    return reversed;
}

/*Method7: using reduce
string is splitted O(n) and each item concanated.
Total time complexity: O(2n) (or we can say O(n))*/
function method7(s){

    return s.split("").reduce(function(reversed, char){
        return char + reversed;
    }, "");
   
}
  
let str1 = "cansu";
let str2 = "tree";

console.log("******Method1******");
console.log(method1(str1));
console.log(method1(str2));

console.log("******Method2******");
console.log(method2(str1));
console.log(method2(str2));

console.log("******Method3******");
console.log(method3(str1));
console.log(method3(str2));

console.log("******Method4******");
console.log(method4(str1));
console.log(method4(str2));

console.log("******Method5******");
console.log(method5(str1));
console.log(method5(str2));

console.log("******Method6******");
console.log(method6(str1));
console.log(method6(str2));

console.log("******Method7******");
console.log(method7(str1));
console.log(method7(str2));