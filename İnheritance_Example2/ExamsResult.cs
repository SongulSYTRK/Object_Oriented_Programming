using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance_Example2
{
    public static class ExamsResult
    {
       
       public static double  result (int exam_1, int exam_2, int project ) =>exam_1 * 0.3 + exam_2 * 0.6 + project* 0.1;  // for student exams 

        public static double Accepted(int YDS, int Ales, int ScienceExam) => YDS * 0.6 + Ales * 0.2 + ScienceExam* 0.2;

    }
}
