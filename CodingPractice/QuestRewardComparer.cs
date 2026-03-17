using System.Collections.Generic;

class QuestRewardComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        return y.Reward - x.Reward;
    }
}
