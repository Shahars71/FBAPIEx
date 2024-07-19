using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FBLikesSorter
    {
        public Func<int, int, bool> LikesComparingMethod { get; set; }
        public FBLikesSorter(Func<int, int, bool> likesComparingMethod) => LikesComparingMethod = likesComparingMethod;

        public void sortLikes(DataUnit[] i_Likes)
        {
            for (int g = i_Likes.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Likes.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (LikesComparingMethod.Invoke(i_Likes[j].LikesCount, i_Likes[j + g].LikesCount))
                        {
                            FBLogic.SwapDataUnits(ref i_Likes[j], ref i_Likes[j + g]);
                        }
                    }
                }
            }
        }
    }
}