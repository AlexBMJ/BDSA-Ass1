using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests {
    public class RegExprTests {
        [Theory]
        [InlineData("Happy Go Lucky", "lower case test", "lower and UPPER", "1,2,3", "mixed 2>1=true")]
        public void SplitLine_GivenListOfSentences_ReturnListOfWords(params string[] sentences) {
            var result = RegExpr.SplitLine(sentences);
            var expected = new string[] {
                "Happy", "Go", "Lucky", "lower", "case", "test", "lower", "and", "UPPER", "1", "2", "3", "mixed", "2",
                "1", "true"
            };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1920x1080\n1024x768, 800x600, 640x480\n320x200, 320x240, 800x600\n1280x960")]
        public void Resolution_GivenString1920x1080_ReturnListOfTuple_1920_1080(string resolutionStringList) {
            var result = RegExpr.Resolution(resolutionStringList);
            var expected = new List<(int, int)> {
                (1920, 1080),
                (1024, 768),
                (800, 600),
                (640, 480),
                (320, 200),
                (320, 240),
                (800, 600),
                (1280, 960)
            };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1920x1080x957")]
        public void Resolution_GivenString1920x1080x957_ReturnListOfTuple_1920_1080(string resolutionStringList) {
            var result = RegExpr.Resolution(resolutionStringList);
            var expected = new List<(int, int)> {
                (1920, 1080)
            };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(@"<div>
                        <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formal_language"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character_(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searching_algorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String_(computer_science)"" title=""String (computer science)"">strings</a>.</p>
                    </div>", "a")]
        public void InnerText_GivenArbitraryHTMLAndTag_ReturnInnerText(string html, string tag) {
            var result = RegExpr.InnerText(html, tag);
            var expected = new List<string> {
                "theoretical computer science",
                "formal language",
                "characters",
                "pattern",
                "string searching algorithms",
                "strings"
            };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(@"<div>
                        <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>
                    </div>", "p")]
        public void InnerText_GivenNestedHTMLAndTag_ReturnInnerText(string html, string tag) {
            var result = RegExpr.InnerText(html, tag);
            var expected = new List<string> {
                "The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."
            };
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(@"<div>
                         <p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>
                    </div>", "a")]
        public void InnerText_GivenTagThatDoesNotExistInGivenHTML_ReturnEmptyList(string html, string tag) {
            var result = RegExpr.InnerText(html, tag);
            var expected = new List<string> {};
            Assert.Equal(expected, result);
        }
    }
}