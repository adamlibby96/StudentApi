namespace StudentApi.Models
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public override string ToString()
        {
            return ID + "," + Name + "," + GPA;
        }
    }
}
