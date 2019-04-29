using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.DataStructures.CSharp
{
    public class LeftRotation
    {
        private int[] _inputArr;
        private int _numberOfRotation;

        public LeftRotation(int[] n, int d)
        {
            _inputArr = n;
            _numberOfRotation = d;
        }


        public int[] Rotate()
        {
            _numberOfRotation = _numberOfRotation % _inputArr.Length;
            int[] buffer = new int[_numberOfRotation];

            Array.Copy(_inputArr, buffer, _numberOfRotation);
            Array.Copy(_inputArr, _numberOfRotation, _inputArr, 0, _inputArr.Length - _numberOfRotation);
            Array.Copy(buffer, 0, _inputArr, _inputArr.Length - _numberOfRotation, _numberOfRotation);

            return _inputArr;
        }

    }
}
