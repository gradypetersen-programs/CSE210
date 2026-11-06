public class RandomPrompt
{
    List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today ?",
        "What was the best part of my day ?",
        "How did I see the hand of the Lord in my life today ?",
        "What was the strongest emotion I felt today ?",
        "If I had one thing I could do over today, what would it be ?",
        "What was the most interesting thing I noticed today?",
        "What conversation today stuck with me?",
        "What was one thing I didn't expect to happen today?",
        "What was something small that improved my mood today?",
        "What's the most random thought I had today?",
        "What would I tell someone about my day if I only had 30 Seconds? (Feel free to write for longer than 30 seconds)",
        "What is one memory from today that I want to remember in a week?",
        "What is one thing I found my self wondering about today?",
        "What is something that I wish lasted a little longer today?",
        "If I were stuck in one moment of today for the rest of the week, which moment would I enjoy the most?",
    };

    public string SelectRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}