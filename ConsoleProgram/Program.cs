using System;
using Assignment1;
namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args) {
            /* var nested_html = @"<div>
                <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>
                </div>";
            var html = @"<div>
    <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p>
                </div>";
            var tag = "a";
            foreach (var result in RegExpr.InnerText(nested_html, "p")) {
                Console.WriteLine(result);
            } */
            foreach (var result in RegExpr.Resolution("1920x1080x957")) {
                Console.WriteLine($"({result.width.ToString()}, {result.height.ToString()})");
            }
        }
    }
}
