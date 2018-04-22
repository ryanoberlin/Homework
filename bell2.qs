namespace Quantum.Bell
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Set (desired: Result, q1: Qubit) : ()
    {
        body
        {
			let current = M(q1);
			if (desired != current)
			{
				X(q1);
			}
        }
    }
	operation BellTest (count: Int, intial: Result) : (Int,Int)
	{
		body
		{
				mutable numOnes = 0;
				using (qubits = Qubit[2])
				{
					for(test in 1..count)
					{
						Set (intial, qubits[0]);
						H(qubits[0]);
						let res = M (qubits[0]);
						// count # of "1"s seen
						if (res == One)
						{
							set numOnes = numOnes + 1;
						}
						if (res == One)
						{
							set agrees
						}
					}
					Set(Zero, qubits[0]);
				}
				// return |0> && |1>
				return(count-numOnes, numOnes);
		}
	}
}
