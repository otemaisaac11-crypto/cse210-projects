public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string problems, string textbookSection) : base(studentName, topic)
    {
        _problems = problems;
        _textbookSection = textbookSection;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()} - Section {_textbookSection} {_problems}";
    }
}
