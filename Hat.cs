
namespace Quest
{
    public class Hat
    {
        public int ShineinessLevel { get; set; }

        public string ShininessDescription
        {
            get
            {
                if (ShineinessLevel < 2)
                {
                    return "dull";
                }
                else if (ShineinessLevel >= 2 && ShineinessLevel <= 5)
                {
                    return "noticeable";
                }
                else if (ShineinessLevel >= 6 && ShineinessLevel <= 9)
                {
                    return "bright";
                }
                else
                {
                    return "blinding";
                }
            }
        }
    }
}