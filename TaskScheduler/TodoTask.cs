using System;

class TodoTask : IComparable<TodoTask>
{
    public string Title { get; set; }
    public int Priority { get; set; }
    public string DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public int CompareTo(TodoTask other)
    {
        if(this.Priority == other.Priority)
        {
            if(DueDate == other.DueDate)
            {
                return Title.CompareTo(other.Title);
            }
            else
            {
                DateTime thisTime = DateTime.Parse(DueDate);
                DateTime otherTime = DateTime.Parse(other.DueDate);

                if (thisTime < otherTime)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
        else
        {
            return other.Priority - Priority;
        }
    }

    public override string ToString()
    {
        return $"  [우선순위 {Priority}] {Title} (마감: {DueDate})";
    }
}