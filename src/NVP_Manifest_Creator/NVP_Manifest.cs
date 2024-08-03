namespace NVP_Manifest_Creator
{
    public class NVP_Manifest : Attribute
    {
        public string Id { get; set; }
        public string PathAssembly { get; set; }
        public string PathExecuteClass { get; set; }
        public string CoderName { get; set; }
        public string Folder { get; set; }
        public string NodeName { get; set; }
        public string NodeType { get; set; }
        public string CADType { get; set; }
        public string ViewType { get; set; }
        public string Text { get; set; }
    }
}
