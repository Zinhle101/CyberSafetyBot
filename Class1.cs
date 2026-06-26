using System;

public class CyberSafetyBot
{
	public CyberSafetyBot()
	{

        public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? ReminderDate { get; set; }
    public bool IsCompleted { get; set; }

    public CyberTask(string title, string description, DateTime? reminderDate = null)
    {
        Title = title;
        Description = description;
        ReminderDate = reminderDate;
        IsCompleted = false;
    }

    public override string ToString()
    {
        string status = IsCompleted ? "Completed" : "Pending";
        string reminder = ReminderDate.HasValue
            ? $" | Reminder: {ReminderDate.Value.ToShortDateString()}"
            : "";

        return $"{Title} - {status}{reminder}";
    }
}
