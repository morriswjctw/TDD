using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDHomework1
{
    public class Sum
    {
        public List<int> CalCostSum(int size, string field, List<Record> record)
        {
            int num = 0;
            int SumCount = 0;
            var result = new List<int>();
            int PropertyValue = 0;
            foreach (var item in record)
            {
                //var RecProperty = item.GetType();
                PropertyValue = int.Parse(item.GetType().GetProperty(field).GetValue(item).ToString());
                SumCount += PropertyValue;
                num++;
                if (num % size == 0)
                {
                    result.Add(SumCount);
                    SumCount = 0;
                }
            }
            result.Add(SumCount);
            return result;
        }
    }
}
