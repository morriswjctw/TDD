using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TDDHomework1
{
    [TestClass]
    public class CalculateSum
    {
        [TestMethod]
        public void Sum3_CalculateCost每3個一組()
        {
            //arrange
            var target = new Sum();
            int SumSize = 3;
            string SumField = "Cost";
            var products = new List<Record>() {
                new Record() {Id=1, Cost=1, Revenue=11, SellPrice=21},
                new Record() {Id=2, Cost=2, Revenue=12, SellPrice=22},
                new Record() {Id=3, Cost=3, Revenue=13, SellPrice=23},
                new Record() {Id=4, Cost=4, Revenue=14, SellPrice=24},
                new Record() {Id=5, Cost=5, Revenue=15, SellPrice=25},
                new Record() {Id=6, Cost=6, Revenue=16, SellPrice=26},
                new Record() {Id=7, Cost=7, Revenue=17, SellPrice=27},
                new Record() {Id=8, Cost=8, Revenue=18, SellPrice=28},
                new Record() {Id=9, Cost=9, Revenue=19, SellPrice=29},
                new Record() {Id=10, Cost=10, Revenue=20, SellPrice=30},
                new Record() {Id=11, Cost=11, Revenue=21, SellPrice=31}
            };

            var expected = new List<int> { 6, 15, 24, 21 };
            //act
            var actual = target.CalCostSum(SumSize, SumField, products);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sum4_CalculateRevenue每4個一組()
        {
            //arrange
            var target = new Sum();
            int SumSize = 4;
            string SumField = "Revenue";
            var products = new List<Record>() {
                new Record() {Id=1, Cost=1, Revenue=11, SellPrice=21},
                new Record() {Id=2, Cost=2, Revenue=12, SellPrice=22},
                new Record() {Id=3, Cost=3, Revenue=13, SellPrice=23},
                new Record() {Id=4, Cost=4, Revenue=14, SellPrice=24},
                new Record() {Id=5, Cost=5, Revenue=15, SellPrice=25},
                new Record() {Id=6, Cost=6, Revenue=16, SellPrice=26},
                new Record() {Id=7, Cost=7, Revenue=17, SellPrice=27},
                new Record() {Id=8, Cost=8, Revenue=18, SellPrice=28},
                new Record() {Id=9, Cost=9, Revenue=19, SellPrice=29},
                new Record() {Id=10, Cost=10, Revenue=20, SellPrice=30},
                new Record() {Id=11, Cost=11, Revenue=21, SellPrice=31}
            };

            var expected = new List<int> { 50, 66, 60 };
            //act
            var actual = target.CalCostSum(SumSize, SumField, products);
            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
