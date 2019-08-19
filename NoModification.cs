using System.Linq;
using static Sequences.Helpers;

namespace Sequences
{
    [Run(5)]
    public class NoModification
    {
        public NoModification()
        {
            var list = StoryPoints.ToList();

//            foreach (var item in list)
//            {
//                if (item >= 13)
//                    list.Remove(item);
//            }

            list.RemoveAll(item => item >= 13);
        }
    }
}