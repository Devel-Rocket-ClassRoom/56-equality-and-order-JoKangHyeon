class Quest
{
    public string Name { get; set; }
    public int Priority { get; set; }
    public int Reward { get; set; }

    public Quest(string name, int priority, int reward)
    {
        Name = name;
        Priority = priority;
        Reward = reward;
    }
    public override string ToString()
    {
        return $"  [우선순위{Priority}] {Name} (보상:{Reward}골드)";
    }
}
