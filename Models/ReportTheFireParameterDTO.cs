using System;

namespace NASATest2018.Models
{
    [Serializable]
    public class ReportTheFireParameterDTO: ParameterDTO
    {
        public string Image {get; set;}

        public string Video {get; set;}

        public string TextOfComment {get; set;}

        public decimal Longitude {get; set;}

        public decimal Latitude {get; set;}
        
    }
}