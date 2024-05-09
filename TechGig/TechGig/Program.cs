using System;

class CandidateCode {
    static void Main(String[] args) {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++) {
            string[] paulInput = Console.ReadLine().Split(' ');
            int P = int.Parse(paulInput[0]);
            int X = int.Parse(paulInput[1]);
            int R1 = int.Parse(paulInput[2]);

            string[] ninaInput = Console.ReadLine().Split(' ');
            int N = int.Parse(ninaInput[0]);
            int Y = int.Parse(ninaInput[1]);
            int R2 = int.Parse(ninaInput[2]);

            int paulTime = CalculateTime(P, X, R1);
            int ninaTime = CalculateTime(N, Y, R2);

            if (paulTime < ninaTime) {
                Console.WriteLine("PAUL");
                Console.WriteLine(paulTime);
            } else if (paulTime > ninaTime) {
                Console.WriteLine("NINA");
                Console.WriteLine(ninaTime);
            } else {
                Console.WriteLine("BOTH");
                Console.WriteLine(paulTime);
            }
        }
    }

    static int CalculateTime(int distance, int speed, int repairs) {
        int time = distance / speed;
        return time + repairs;
    }
}
