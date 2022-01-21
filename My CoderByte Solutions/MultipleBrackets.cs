using System;
using System.Collections.Generic;

class MainClass {

  public static string MultipleBrackets(string str) {

    bool bra = false;
    int count = 0;

    Stack<char> stck = new Stack<char>();

    for(int i=0; i<str.Length; i++){
      if(str[i] == '(' || str[i] == '['){
        stck.Push(str[i]);
        bra = true;
      }
      else if(str[i] == ')' || str[i] == ']'){
        if((str[i] == ')' && stck.Peek() == '(') || (str[i] == ']' && stck.Peek() == '[')){
          stck.Pop();
          count++;
        }
        else{
          return "0";
        }
      }
    }

    if(bra == false){
      return "1";
    }

    if(stck.Count>0){
      return "0";
    }

    str = "1 " + count.ToString();
    return str;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(MultipleBrackets(Console.ReadLine()));
  } 

}