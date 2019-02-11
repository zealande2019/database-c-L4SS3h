namespace ConsoleAppDatabase
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string ExamNavn { get; set; }
        public int Karakter { get; set; }
        public int StudentId { get; set; }

        public Exam()
        {

        }

        public override string ToString()
        {
            return $"ExamId: {ExamId}\t ExamNavn: {ExamNavn}\t StudentId: {StudentId}\t Kararkter: {Karakter}\t";
        }
    }
}