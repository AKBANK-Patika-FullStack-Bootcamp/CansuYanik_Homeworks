using System;

class MainClass {

  public static string CountingMinutes(string str) {

    int ans;
    string[] times = str.Split('-');

    int length1 = times[0].Length;
    int length2 = times[1].Length;

    //am, pm information
    char ap1 = times[0][length1-2];
    char ap2 = times[1][length2-2];
    
    //remove am/pm part from the time
    times[0] = times[0].Remove(length1-2, 2);
    times[1] = times[1].Remove(length2-2, 2);

    //split times into hour and minute
    string[] ntimes1 = times[0].Split(':');
    string[] ntimes2 = times[1].Split(':');

    //convert hour and minute strings to integers
    int h1 = Int16.Parse(ntimes1[0]);
    int m1 = Int16.Parse(ntimes1[1]);

    int h2 = Int16.Parse(ntimes2[0]);
    int m2 = Int16.Parse(ntimes2[1]);

    //If time is pm, add 12
    if(ap1 == 'p'){
      h1 += 12;
    }
    if(ap2 == 'p'){
      h2 += 12;
    }

    if(h1<=h2 && m1<=m2){
      ans = (h2-h1)*60-m1+m2;
    }
    else{
      ans = (24-h1+h2)*60-m1+m2;
    }

    str = ans.ToString();
    return str;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CountingMinutes(Console.ReadLine()));
  } 

}