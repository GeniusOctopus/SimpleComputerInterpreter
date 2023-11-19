namespace SimpleComputerInterpreter
{
    public class Interpreter
    {
        private int _pc;
        private int _ac;
        private int _instruction;
        private int _instructionType;
        private int _dataLocation;
        private int _data;
        private bool _halt = false;
        
        
        public void Interpret(int[] memory, int startingAddress)
        {
            _pc = startingAddress;
            while (!_halt)
            {
                _instruction = memory[_pc];
                _pc++;
                _instructionType = GetInstructionType(_instruction);
                _dataLocation = FindData(_instruction, _instructionType);
                if (_dataLocation >= 0)
                {
                    _data = memory[_dataLocation];
                }
                Execute(_instruction, _data);
            }
        }

        private int GetInstructionType(int address)
        {
            return 0;
        }

        private int FindData(int instruction, int type)
        {
            return 0;
        }

        private void Execute(int type, int data)
        {

        }
    }
}
