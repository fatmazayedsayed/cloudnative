using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Data_Structure_Decode
{
	public class array_operations_implementation
	{
		public void Resize<T>(ref T[] arrSource, int newSize)
		{
			//ref to send the address
			if (newSize <= 0) return;
			if (arrSource == null) return;
			if (arrSource.Length == newSize) return;
			T[] newArr = new T[newSize];
			//copy block of bytes into new size
			Buffer.BlockCopy(arrSource, 0, newArr, 0, Buffer.ByteLength(arrSource));
			arrSource = newArr;

		}
	
	public T GetAt<T>(T[]arrSource, int index, int SizeOf)
		{
			if (index < 0) return default(T);
			ref byte zeroAddress=ref MemoryMarshal.GetArrayDataReference((Array)arrSource);

			ref byte indexref= ref Unsafe.Add(ref zeroAddress, index * SizeOf);
			ref T result = ref Unsafe.As<byte, T>(ref indexref);
			return result;
		}
	}
}
