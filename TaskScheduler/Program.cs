using System;
using System.Collections.Generic;

List<TodoTask> tasks = new List<TodoTask>
{
    new TodoTask(){Title = "보고서 작성", Priority = 3, DueDate = "2026-03-15" },
    new TodoTask(){Title = "이메일 확인", Priority = 1, DueDate = "2026-03-10" },
    new TodoTask(){Title = "버그 수정", Priority = 3, DueDate = "2026-03-10" },
    new TodoTask(){Title = "회의 준비", Priority = 2, DueDate = "2026-03-12" },
    new TodoTask(){Title = "코드 리뷰", Priority = 3, DueDate = "2026-03-10" },
};


Console.WriteLine("=== 정렬 전 ===");
foreach (var task in tasks)
{
    Console.WriteLine(task.ToString());
}


Console.WriteLine();
Console.WriteLine("=== 정렬 후 ===");
tasks.Sort();
foreach (var task in tasks)
{
    Console.WriteLine(task.ToString());
}
