using System;
using System.Collections.Generic;
public class SentenceGenerator {
    public static void Main(string[] args) {
        Random rgen=new Random();
        //sentence generator
        //lists
        List<string>articles = new List<string>{"a","an","the"};
        List<string>adjectives = new List<string>{"fat","big","small"};
        List<string>nouns = new List<string>{"cat","rat","house"};
        List<string>adverbs = new List<string>{"slowly","gently","quickly"};
        List<string>verbs = new List<string>{"ate","sat","pushed"};
        //words dictionary
        Dictionary<String,List<String>> words = new Dictionary<String,List<String>>{};
        words.Add( "articles",articles);
        words.Add( "adjectives",adjectives);
        words.Add( "nouns",nouns);
        words.Add( "adverbs",adverbs);
        words.Add( "verbs",verbs);
        List<string>keys = new List<string>{"articles", "adjectives", "nouns", "adverbs", "verbs", "articles","adjectives", "nouns"};
        String sentence = "";
        //create sentences
        foreach(string key in keys){
            int r = rgen.Next(words[key].Count);
            sentence += words[key][r] + " ";
        }
        Console.WriteLine(sentence);
    }
}