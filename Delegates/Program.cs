using System;

namespace Delegates
{
    class Program
    {
        //Delegate in an object that know how to call a method or multiple method
        //a pointer to a function - that provies flexibility and Extensability
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filter = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            processor.Process("photo.jpg", filterHandler);

            //Buildin delegates:
            //System.Action // for a method that not returns a value;
            //System.Func // for a method that returns value
            
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove Eye filter");
        }

        public class Photo
        {
            public static Photo Load(string path)
            {

                return new Photo();
            }

            public void Save()
            {

            }

        }

        public class PhotoFilters
        { 
            public void ApplyBrightness(Photo photo)
            {
                Console.WriteLine("Apply Brightness");
            }

            public void ApplyContrast(Photo photo)
            {
                Console.WriteLine("Apply Contrast");
            }
            public void Resize(Photo photo)
            {
                Console.WriteLine("Photo Resize");
            }
        }


        public class PhotoProcessor
        {
            public delegate void PhotoFilterHandler(Photo photo);
            public void Process(string path,PhotoFilterHandler filterHandler)
            {
                var photo = Photo.Load(path);
                filterHandler(photo);
                //var filters = new PhotoFilters();
                //filters.ApplyBrightness(photo);
                //filters.ApplyContrast(photo);
                //filters.Resize(photo);

                photo.Save();
            }
        }
    }
}
