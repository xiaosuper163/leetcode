using System;
using System.Text.RegularExpressions;

public class Solution {
    public bool IsNumber(string s) {
        string pattern = @"(?<valid>^\s*[+-]?(?:(?:\d+(?:\.\d*)?)|(?:\d*(?:\.\d+)))(?:[Ee][+-]?\d+)?\s*)";
        Regex rx = new Regex(pattern);
        MatchCollection matches = rx.Matches(s);
        foreach (Match match in matches) {
            if (match.Groups["valid"].Value.Length == s.Length) return true;
        }
        return false;
    }
}