﻿namespace BuyMe.Domain.DTO
{
    public class CreateFilmDto
    {
        public byte[] Image { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Duration { get; set; }
        public DateOnly Releasedate { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int FilmCategoryId { get; set; }
    }
}
