using System.Collections.Generic;

class QuestPriorityComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        return x.Priority - y.Priority;
    }
}
