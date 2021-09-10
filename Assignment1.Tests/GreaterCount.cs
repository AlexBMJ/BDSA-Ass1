using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests {
    public class GreaterCount {
        [Fact]
        public void GreaterCountTypeConstraint_GivenPlatypusList_5_2_AndPlatypus_4_Return_1() {
            var gc = new GreaterCountTypeConstraint();
            var platypus = new Platypus(4);
            var platypus_list = new List<Platypus>() {new Platypus(5), new Platypus(2)};
            var greater_than_count = gc.GreaterCount<Platypus, Animal>(platypus_list, platypus);
            Assert.Equal(1, greater_than_count);
        }
    }
}