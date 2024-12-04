namespace AdventOfCode2024
{
    public class Day2
    {
        public Day2()
        {
        }

        //Dec 2
        public int SaveSafeReports(int[,] reports)
        {
            int rows = reports.GetLength(0);
            int columns = reports.GetLength(1);
            int safeReports = 0;

            for (int i = 0; i < rows; i++)
            {
                bool rowNotSafe = false;
                bool isAscending = true;
                bool isDescending = true;

                for (int j = 0; j < columns; j++)
                {
                    if (j + 1 < columns)
                    {
                        int difference = Math.Abs(reports[i, j] - reports[i, j + 1]);

                        if (difference < 1 || difference > 3)
                        {
                            rowNotSafe = true;
                            break;
                        }

                        if (reports[i, j] > reports[i, j + 1])
                        {
                            isAscending = false;
                        }

                        if (reports[i, j] < reports[i, j + 1])
                        {
                            isDescending = false;
                        }
                    }
                }

                if (!rowNotSafe && (isAscending || isDescending))
                {
                    safeReports++;
                }
            }

            return safeReports;
        }
    }
}
