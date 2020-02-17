using System.Collections.Generic;

namespace DemoLibrary
{
    public class MyJsonType
    {
        public string MyStringProperty { get; set; }

        public int MyIntegerProperty { get; set; }

        public MyJsonSubDocumentType MySubDocument { get; set; }

        public List<string> InterfaceNames { get; set; }
        public List<string> ClassNames { get; set; }
    }

    public class MyJsonSubDocumentType
    {
        public string SubDocumentProperty { get; set; }
    }
}