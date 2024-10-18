namespace Store.PL.Helpers
{
    public class FilesSettings
    {
        public static string uploadFiles(IFormFile file , string folderName) 
        {
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", folderName);

            //to make sure the users dont upload the same file name 
            string FileName = $"{Guid.NewGuid()}{file.FileName}";

            string FilePath = Path.Combine(FolderPath, FileName);
            
            //to creat folders
            var fileStream = new FileStream(FilePath,FileMode.Create);
            
            file.CopyTo(fileStream);
           
            return FileName;
        }
         
        public static void DeleteFiles(string FileName , string FolderName) 
        {
            string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files",  FolderName , FileName);

            if (File.Exists(FilePath))
            { 
               File.Delete(FilePath);
            
            }


        }
    }
}
