using System;

namespace NorthwindApp.Entities
{
    public class BaseOBJ
         : IDisposable
    {
        public object ViewBag1 { get; set; }
        public object ViewBag2 { get; set; }
        public object ViewBag3 { get; set; }
        public object ViewBag4 { get; set; }
        public object ViewBag5 { get; set; }
        public object ViewBag6 { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
