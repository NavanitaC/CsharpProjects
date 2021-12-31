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
       
            PhotoAlbum a1 = new PhotoAlbum();
            Console.WriteLine(a1.GetNumberOfPages());

            PhotoAlbum a2 = new PhotoAlbum(24);
            Console.WriteLine(a2.GetNumberOfPages());

            BigPhotoAlbum b = new BigPhotoAlbum();
            Console.WriteLine(b.GetNumberOfPages());

           
        }
    }
}
