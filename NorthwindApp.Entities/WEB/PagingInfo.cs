﻿namespace NorthwindApp.Entities.WEB
{
    public class PagingInfo
    {
        public int CurrentPage { get; set; }
        public int TotalPageCount { get; set; }
        public string BaseUrl { get; set; }
    }
}