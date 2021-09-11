using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1 {
    public static class RegExpr {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines) {
            var wordRegex = new Regex(@"\w+");
            foreach (var line in lines) {
                foreach (Match word in wordRegex.Matches(line)) {
                    yield return word.Value;
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions) {
            var wordRegex = new Regex(@"(?<width>\d+)x(?<height>\d+)");
            foreach (Match resolution in wordRegex.Matches(resolutions)) {
                var width = Convert.ToInt32(resolution.Groups["width"].Value);
                var height = Convert.ToInt32(resolution.Groups["height"].Value);
                yield return (width, height);
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag) {
            throw new NotImplementedException();
        }
    }
}