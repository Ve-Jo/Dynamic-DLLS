namespace ClassLibrary4
{
    public class FileSystem
    {
        public static void CopyFile(string sourcePath, string destinationPath)
        {
            if (File.Exists(destinationPath) && Directory.Exists(destinationPath))
            {
                destinationPath = Path.Combine(destinationPath, Path.GetFileName(sourcePath));
            }

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
        }

        public static void CopyDirectory(string sourcePath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            foreach (string fileOrDirectory in Directory.EnumerateDirectories(sourcePath))
            {
                if (Directory.Exists(fileOrDirectory))
                {
                    CopyDirectory(fileOrDirectory, Path.Combine(destinationPath, Path.GetFileName(fileOrDirectory)));
                }
                else
                {
                    CopyFile(fileOrDirectory, Path.Combine(destinationPath, Path.GetFileName(fileOrDirectory)));
                }
            }
        }

        public static void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        public static void DeleteFiles(IEnumerable<string> fileNames)
        {
            foreach (string fileName in fileNames)
            {
                DeleteFile(fileName);
            }
        }

        public static void DeleteFilesByMask(string mask)
        {
            foreach (string fileName in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), mask))
            {
                DeleteFile(fileName);
            }
        }

        public static void MoveFile(string sourcePath, string destinationPath)
        {
            CopyFile(sourcePath, destinationPath);
            DeleteFile(sourcePath);
        }

        public static void FindWordInFile(string fileName, string word, string reportFileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("Файла нет.");
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                using (StreamWriter writer = new StreamWriter(reportFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int index = line.IndexOf(word);

                        if (index != -1)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }

        public static void FindWordInDirectory(string directoryPath, string word, string reportFileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException("Папки нет.");
            }

            using (StreamWriter writer = new StreamWriter(reportFileName))
            {
                foreach (string fileOrDirectory in Directory.EnumerateDirectories(directoryPath))
                {
                    if (File.Exists(fileOrDirectory))
                    {
                        FindWordInFile(fileOrDirectory, word, reportFileName);
                    }
                }
            }
        }
    }
}