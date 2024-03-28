public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
            Queue<int> studentsQ = new Queue<int>(students);

            foreach(int sandwich in sandwiches)
            {
                int size = studentsQ.Count;

                while(size>0)
                {
                    int student = studentsQ.Dequeue();

                    if(student == sandwich)
                        break;
                    
                    studentsQ.Enqueue(student);
                    
                    size--;
                }

                if (size == 0)
                    break;
            }
            
            return studentsQ.Count;
    }
}