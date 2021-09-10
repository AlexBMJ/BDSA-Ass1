using Xunit;
using Assignment1;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Theory]
        [InlineData(1, 2, 3, 4, 5)]
        public void Filter_Given_1through5_returns_2_4(params int[] numbers) 
        {
            Predicate<int> even = (int i) => i % 2 == 0;

            var test = Iterators.Filter<int>(numbers, even);
            Assert.Equal(new int[] {2, 4}, test);
        }

        [Fact]
        public void Flatten_Given_Nested_Array_1through6_returns_Single_Array_1through6()
        {
            var list = new List<List<int>>();

            for(int i = 0; i < 6; i+=2) {
                list.Add(new List<int>(){i, i+1});
            }
            
            var result = Iterators.Flatten<int>(list);

            Assert.Equal(new int[] {0, 1, 2, 3, 4, 5}, result);
        }
    }
}
