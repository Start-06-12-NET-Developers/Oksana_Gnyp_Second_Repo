namespace Lesson8
{
    public class Account
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            return (int)worker < hours;
        }
    }
}
