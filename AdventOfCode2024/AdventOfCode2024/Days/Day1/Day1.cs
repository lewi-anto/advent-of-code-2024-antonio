namespace AdventOfCode2024
{
    public class Day1
    {
        public Day1()
        {
        }

        //Dec 1
        public int CalculateTotalDistance(List<int> leftList, List<int> rightList)
        {
            var distance = 0;

            if (leftList == null || rightList == null)
                throw new ArgumentNullException("Lists cannot be null.");

            if (leftList.Count != rightList.Count)
                throw new ArgumentException("Lists must have the same length.");

            leftList.Sort();
            rightList.Sort();

            for (int i = 0; i < leftList.Count; i++)
            {
                distance += Math.Abs(leftList[i] - rightList[i]);
            }

            return distance;
        }
    }
}
