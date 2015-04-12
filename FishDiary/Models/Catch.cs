using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishDiary.Models
{
    public class Catch
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int? CatchPictureID { get; set; }
        public DateTime TimeOfCatch { get; set; }
        public string Location { get; set; }
        public string LatCoordinates { get; set; }
        public string LonCoordinates { get; set; }
        public float Depth { get; set; }
        public string FishName { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public string Lure { get; set; }
        public string Bait { get; set; }
        public string Notes { get; set; }
        public bool Public { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual CatchPicture CatchPicture { get; set; }
    }
}