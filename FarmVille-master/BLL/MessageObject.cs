using System;

namespace BLL
{
    [Serializable]
    public class MessageObject
    {
        private byte[] data;
        private int objectReference = 0;
        private int operationReference = 0;

        public byte[] Data { get => data; set => data = value; }
        public int ObjectReference { get => objectReference; set => objectReference = value; }
        public int OperationReference { get => operationReference; set => operationReference = value; }

    }
}
