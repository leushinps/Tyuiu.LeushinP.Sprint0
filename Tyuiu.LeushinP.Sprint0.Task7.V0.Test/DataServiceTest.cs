using Tyuiu.LeushinP.Sprint0.Task7.V0.Lib;

using System;

namespace Tyuiu.LeushinP.Sprint0.Task7.V0.Test
{
    public class DataServiceTest
    {


        [Test]
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums2 = new int[] { 1, 1, 1, 1, 1 };
            int[] nums3 = new int[] { 1, 1, 1, 1, 1 };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}