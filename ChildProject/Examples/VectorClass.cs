using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject.Examples
{
	class VectorClass
	{
		private int[] _vector;

		//тут кстати важный момент работы с массивами и коллекциями в геттере обрати внимание
		public int[] Vector
		{
			get
			{
				if (_vector == null)
				{
					_vector = new int[] {};
				}
				return _vector;

				//а еще можно сразу ожной строкой тернарным оператором, привыкай
				//return _vector ?? (_vector = new int[] {});
			}
			set { _vector = value; }
		}

		public VectorClass(int[] vector)
		{
			_vector = vector;
		}

		public VectorClass()
		{
			_vector = new int[] {};
		}

		public void ConcatVector(int[] vector)
		{
			Vector = Vector.Concat(vector).ToArray();
		}

		public static void Test()
		{
			var vector1 = new VectorClass(new int[] {1, 2, 3, 4, 5});
			var vector2 = new VectorClass(new []{6, 7});

			vector1.ConcatVector(vector2.Vector);

			for (int i = 0; i < vector1.Vector.Length; i++)
			{
				Console.Write(vector1.Vector[i] + " ");
			}
		}
	}
}
