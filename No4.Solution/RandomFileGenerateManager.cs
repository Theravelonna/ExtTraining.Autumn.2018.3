using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomFileGenerateManager
    {
        private RandomFileGenerator fileGenerator;

        public RandomFileGenerateManager(RandomFileGenerator fileGenerator)
        {
            this.fileGenerator = fileGenerator;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            fileGenerator.GenerateFiles(filesCount, contentLength);
        }
    }
}
