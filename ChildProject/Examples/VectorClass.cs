using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject.Examples
{
	class VectorClass
	{
		public Exam[] Vector { get; set; }
        public Exam Exam { get; set; }

	    public VectorClass(Exam[] vector)
		{
			Vector = vector;
		}

		public VectorClass()
		{
			Vector = new Exam[] {};
		}

		public void ConcatVector(Exam[] vector)
		{
			Vector = Vector.Concat(vector).ToArray();
		}

		public void Test(Exam exam)
		{
			var vector1 = new VectorClass(new Exam[] {exam});
			var vector2 = new VectorClass(new []{exam});

			vector1.ConcatVector(vector2.Vector);

			for (int i = 0; i < vector1.Vector.Length; i++)
			{
				Console.Write(vector1.Vector[i] + " ");
			}
		}
	}
}
