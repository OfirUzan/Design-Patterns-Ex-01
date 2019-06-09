using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AlbumFacade : IEnumerable
    {
        internal AlbumsManager AlbumsManager { get; set; }

        internal AlbumFacade()
        {
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string url in AlbumsManager)
            {
                yield return url;
            }
        }
    }
}
