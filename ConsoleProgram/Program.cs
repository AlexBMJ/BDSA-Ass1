using System;
using System.Collections.Generic;
using Assignment1;
namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args) {
            var html = @"<div>
    <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p>
                </div>";
            var tag = "a";
            foreach (var result in RegExpr.InnerText(html, "a")) {
                Console.WriteLine(result);
            }
            foreach (var result in RegExpr.Resolution("1920x1080\n1024x768, 800x600, 640x480\n320x200, 320x240, 800x600\n1280x960")) {
                Console.WriteLine($"({result.width.ToString()}, {result.height.ToString()})");
            }
        }
    }
}
