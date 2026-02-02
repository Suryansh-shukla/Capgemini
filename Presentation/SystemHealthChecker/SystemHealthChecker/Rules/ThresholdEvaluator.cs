using System.Drawing;

namespace SystemHealthChecker.Rules
{
    public class ThresholdEvaluator
    {
        public (string, Color) Evaluate(float value)
        {
            if (value < 70)
                return ("Normal", Color.Green);

            if (value < 85)
                return ("Warning", Color.Orange);

            return ("Critical", Color.Red);
        }
    }
}
