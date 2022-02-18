﻿using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace CrakingTheCodeInterview.Test.LeetCode
{
    public class Question48
    {
        [Theory]
        [MemberData(nameof(RoutateMatrixTests))]
        public void Solution1(RotateMatrixTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question48.Resolution.Solution1(test.Value);
            
            Assert.Equal(test.ExpecteResult, result);
        }
        [Theory]
        [MemberData(nameof(RoutateMatrixTests))]
        public void Solution2(RotateMatrixTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question48.Resolution.Solution2(test.Value);

            Assert.Equal(test.ExpecteResult, result);
        }
        [Theory]
        [MemberData(nameof(RoutateMatrixTests))]
        public void Solution3(RotateMatrixTestInput test)
        {
            var result = CrackingTheCodingInterview.LeetCode.Question48.Resolution.Solution3(test.Value);

            Assert.Equal(test.ExpecteResult, result);
        }


        public static TheoryData<RotateMatrixTestInput> RoutateMatrixTests = new TheoryData<RotateMatrixTestInput>
        {
            new RotateMatrixTestInput()
            {
                Name = "2 matrix",
                Value = new int[,] { { 1, 2 }, { 3, 4 } },
                ExpecteResult = new int[,] { { 3, 1 },{ 4, 2 } }
            },
            new RotateMatrixTestInput()
            {
                Name = "3 matrix",
                Value = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                ExpecteResult = new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }
            },
            new RotateMatrixTestInput()
            {
                Name = "4 matrix",
                Value = new int[,] { { 1, 2, 3, 4 }, { 5,6,7,8 }, { 9,10,11,12 }, { 13,14,15,16 } },
                ExpecteResult = new int[,] { { 13,9,5,1 }, { 14,10,6,2 }, { 15,11,7,3 }, { 16,12,8,4 } }
            },
            new RotateMatrixTestInput()
            {
                Name = "5 matrix",
                Value = new int[,] { { 1,2,3,4,5 }, { 6,7,8,9,10 }, { 11,12,13,14,15 }, { 16,17,18,19,20 }, { 21,22,23,24,25 } },
                ExpecteResult = new int[,] { { 21, 16, 11, 6, 1 }, { 22, 17, 12, 7, 2 }, { 23, 18, 13, 8, 3 }, { 24, 19, 14, 9, 4 }, { 25, 20, 15, 10, 5 } }
            }
        };

        [ExcludeFromCodeCoverage]
        public class RotateMatrixTestInput
        {
            public string Name { get; set; }
            public int[,] Value { get; set; }
            public int[,] ExpecteResult { get; set; }
        }

    }
}
