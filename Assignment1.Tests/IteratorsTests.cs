using Xunit;
using Assignment1;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests {
    public class IteratorsTests {
        [Theory]
        [InlineData(1, 2, 3, 4, 5)]
        public void Filter_Given_1through5_returns_2_4(params int[] numbers) {
            bool Even(int i) => i % 2 == 0;
            var test = Iterators.Filter(numbers, Even);
            Assert.Equal(new [] {2, 4}, test);
        }

        [Fact]
        public void Flatten_Given_Nested_Array_1through6_returns_Single_Array_1through6() {
            List<List<int>> list = new ();
            for (var i = 0; i < 6; i += 2)
                list.Add(new List<int>() {i, i + 1});
            var result = Iterators.Flatten(list);
            Assert.Equal(new [] {0, 1, 2, 3, 4, 5}, result);
        }

        [Fact]
        public void Flatten_GivenNullList_SkipNullList() {
            List<List<int>> list = new();
            for (var i = 0; i < 6; i += 2) {
                list.Add(new List<int>() {i, i + 1});
                list.Add(null);
            }

            var result = Iterators.Flatten(list);
            Assert.Equal(new [] {0, 1, 2, 3, 4, 5}, result);
        }
    }
}