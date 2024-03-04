using System;

class Generics{
    public  T Display<T>(T value){
        Console.WriteLine($"value {value}" );;
        return value;
    }
}