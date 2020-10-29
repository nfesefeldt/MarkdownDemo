using System;
using System.Collections.Generic;

namespace MarkdownDemo
{
    public static class Util
    {
       public static List<Tuple<string,string>> GetTestItems()
        {
            List<Tuple<string,string>> list = new List<Tuple<string,string>>();
            list.Add(new Tuple<string, string>("This is a block of text that **includes** the __features__ we are *likely* to _want_, and omits the ones we do not want.",
                "We could probably also see how the parsers handle multiple lines. This one ends with no space." +
                           "This one ends with one space. " +
                           "And this one ends with two spaces.  " +
                           "And this should be the end."));
            list.Add(new Tuple<string, string>("This is a string with some **bold stuff**", "Here is more __bold__ and _italics_"));
            list.Add(new Tuple<string, string>("*This is all italic*", "**This is all bold * *"));
            list.Add(new Tuple<string, string>("This is a block of text that **includes** the __features__ we are *likely* to _want_, and omits the ones we do not want.",
                "We could probably also see how the parsers handle multiple lines. This one ends with no space." +
                           "This one ends with one space. " +
                           "And this one ends with two spaces.  " +
                           "And this should be the end."));
            list.Add(new Tuple<string, string>("This is a string with some **bold stuff**", "Here is more __bold__ and _italics_"));


            return list;

        }
    }
}
