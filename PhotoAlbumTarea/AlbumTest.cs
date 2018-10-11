using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            
            PhotoAlbum p1 = new PhotoAlbum();
            Console.WriteLine(p1.GetNumberOfPages());

            PhotoAlbum p2 = new PhotoAlbum(24);
            Console.WriteLine(p2.GetNumberOfPages());

            BigPhotoAlbum bp3 = new BigPhotoAlbum();
            Console.WriteLine(bp3.GetNumberOfPages());  

            Console.WriteLine();
            Console.Read();
        }
    }
}
