using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    [Serializable]
    public class Class1Copy
    {
        public int NMember { set; get; }
        public String SMember { set; get; }
        public ClassMember CMember { get; set; }

        public  Class1Copy Clone()
        {
            return this.MemberwiseClone() as Class1Copy;
        }

        public Class1Copy Copy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as Class1Copy;
        }

        public override string ToString()
        {
            return NMember + "," + SMember + "," + CMember.NClassMember;
        }
    }

    [Serializable]
    public class ClassMember
    {
        public int NClassMember { set; get; }
    }
}