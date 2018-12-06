namespace JoinsInLinq
{
    internal class joinedLists
    {
        public int rollNo { get; internal set; }
        public string Name { get; internal set; }
        public string DeptName { get; internal set; }
        public int DeptId { get; internal set; }

        public override string ToString()
        {
            return "roll no " + rollNo + " Name:  " + Name + " Dept name: " + DeptName + " Dept Id: " + DeptId;
        }
    }
}