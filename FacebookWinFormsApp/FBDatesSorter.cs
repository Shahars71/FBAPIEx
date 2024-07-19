using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FBDatesSorter
    {
        public Func<DateTime?, DateTime?, bool> DateComparingMethod { get; set; }
        public FBDatesSorter(Func<DateTime?, DateTime?, bool> dateComparingMethod) => DateComparingMethod = dateComparingMethod;

        public void SortDate(DataUnit[] i_Dates)
        {
            for (int g = i_Dates.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Dates.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (DateComparingMethod.Invoke(i_Dates[j].CreatedTime, i_Dates[j + g].CreatedTime))
                        {
                            FBLogic.SwapDataUnits(ref i_Dates[j], ref i_Dates[j + g]);
                        }
                    }
                }
            }
        }

    }
}
