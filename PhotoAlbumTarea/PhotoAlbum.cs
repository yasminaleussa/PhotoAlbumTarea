using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
        

        protected int _numberOfPages;

        public int GetNumberOfPages()
        {
            return _numberOfPages ;
           
        }

       

        public  PhotoAlbum()
        {
            _numberOfPages = 16;
        }
        public PhotoAlbum(int pages )
        {
            _numberOfPages = pages;
        }
    }
}
