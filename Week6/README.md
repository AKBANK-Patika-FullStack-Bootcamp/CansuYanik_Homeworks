## Week 6

In this week, three task and a bonus task were given. For each task, learning and using basic/general Javascript methods, learning important Javascript features, inbuilt methods are aimed.

### What has been done:
- Inbuilt string operations
- Javascript object assignment
- import/export objects and functions
- Arrow and general function usage
- Higher order functions
- Multiline strings
- Arrays, strings, variables etc.


<h3>Part 1</h3>

Define a dog object, create a "cleaning dog method", define a dog care time, import & export methods and variables, print dog and cleaning information<br><br>
<img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week6/Screenshots/part1.PNG" />

<h3>Part 2</h3>

Define a custom summation operation, name this process as "girlsPowerSum". 
"girlsPower" is a special high order function and it applys this operation to all the elements of the array given to it and return new array.<br><br>
<img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week6/Screenshots/part2.PNG" />


<h3>Part 3</h3>

For this part, I wrote 7 different methods<br><br>

<h5>Method 1: using inbuilt string methods</h5>

```javascript
function method1(s) {
    return s.split('').reverse().join('');
}
```

Convert string to array, reverse array then join array items.
Reverse() method needs to traverse array once, lets say its complexity is n (length of the string). When we add complexities of the other methods (split and join methods also takes n), it will take probably O(3n) time.
Time complexity = O(3n), remove the constants so we can say O(n). 

<h5>Method 2: using split, while (with 2 indexes) and join (optimed version of method1)</h5>

```javascript
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
```

In this method, I used split and join to be able to use array properties. In this method, I used 2 indexes. One starts from beginning, other starts from the end then swap them.
Split and join take n times and since we only traverse array until the middle index, time complexity will be O(n/2) for while loop.
In total time complexity will be 0(2n+n/2), remove the constants so we can say O(n). 

<h5>Method 3: using for loop</h5>

```
function method3(s) {
    let reversed = "";

    for(let character of s){
        reversed = character + reversed;
    }
    return reversed;
}
```

Start from the beginning, in each iteration, concatenate chars like -> char + reversed (or start from the end, in each iteration, concatenate chars like -> reversed + char)
Since we need the traverse string once, it takes O(n) time.

<h5>Method 4: using for while loop (optimized version of method3)</h5>

```
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
```

Find the middle char of the string, Use 2 indexes, one index starts from mid-1 to the beginning of the string, other starts from mid+1 to the end. In each iteration concatenate them. 
Since we start from the middle of the array, time complexity will be O(n/2), remove the constants so we can say O(n). 

<h5>Method 5: using recursive call</h5>

```javascript
function method5(s) {
    if (s.length < 2)
      return s;
    let mid = s.length / 2;
    return method5(s.substr(mid)) + method5(s.substr(0, mid));
}
```

In each call, middle of array is found, then subarrays are called and concatenated.
Time complexity O(logn).

<h5>Method 6: using foreach</h5>

```
function method6(s) {

    let reversed = "";  
    s.split("").forEach(function(char){
        reversed = char + reversed;
    });
    return reversed;
}
```

String is splitted in O(n) time and each item concanated. Total time complexity: O(2n), remove the constants so we can say O(n).

<h5>Method 7: using reduce</h5>

```javascript
function method7(s){

    return s.split("").reduce(function(reversed, char){
        return char + reversed;
    }, "");
} 
```

String is splitted in O(n) time and each item concanated by using reduce method. Total time complexity: O(2n), remove the constants so we can say O(n).

<h5>Conclusion</h5>
Generally, each methods have O(n) time. (n: length of the string). If we consider the constants, some methods have lower times, but they looks complex not simple. 
For example method4 has lower time than method3 or method1, but it looks more complex because it has more lines than other methods.
The best time complexity (O(logn)) belongs to method5. But method5 calls itself by recursively, each call is saved in a stack so we need extra stack space for it.
Thats why simple methods like method 1, 3 and 6 will be fine. 

<h3>Bonus</h3>

Task is to find the words that can be written by using the letters which are located in only one line.<br><br>
<img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week6/Screenshots/bonus.PNG" />

