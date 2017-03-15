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

		//public void Test()
		//{
		//	//var vector1 = new VectorClass(new Exam[] {Vector[0]});
		//	//var vector2 = new VectorClass(new []{});

		//	//vector1.ConcatVector(vector2.Vector);

		//	for (int i = 0; i <Vector.Length; i++)
		//	{
		//		Console.Write(Vector[i] + " ");
		//	}
		//}
	}
}
