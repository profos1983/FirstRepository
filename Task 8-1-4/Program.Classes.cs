partial class Program
{
    Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
    public void CreateFolder(string name)
    {
        Folders.Add(name, new Folder());
    }
    public class DiskInfo
    {
        protected string diskName;
        public string DiskName
        {
            get
            {
                return diskName;
            }
        }

        protected long diskSize;
        public long DiskSize
        {
            get
            {
                return diskSize;
            }
        }

        protected long freeSize;
        public long FreeSize
        {
            get
            {
                return freeSize;
            }
        }

        public DiskInfo(string diskName, long diskSize, long freeSize)
        {
            this.diskName = diskName;
            this.diskSize = diskSize;
            this.freeSize = freeSize;
        }
    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
    }
}