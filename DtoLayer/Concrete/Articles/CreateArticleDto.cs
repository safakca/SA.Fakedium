﻿namespace DtoLayer.Concrete.Articles;

public record CreateArticleDto
{
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
}
