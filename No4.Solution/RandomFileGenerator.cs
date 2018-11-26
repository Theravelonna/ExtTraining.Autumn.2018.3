
namespace No4.Solution
{
    public abstract class RandomFileGenerator
    {
        public string WorkingDirectory { get; private set; }

        public string FileExtension { get; private set; }

        public RandomFileGenerator(string workingDirectory, string fileExtension)
        {
            WorkingDirectory = workingDirectory;
            FileExtension = fileExtension;
        }

        public abstract void GenerateFiles(int filesCount, int contentLength);

        protected abstract byte[] GenerateFileContent(int contentLength);

        protected abstract void WriteBytesToFile(string fileName, byte[] content);
    }
}
