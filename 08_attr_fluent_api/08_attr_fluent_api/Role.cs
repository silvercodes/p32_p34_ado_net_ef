

using System.ComponentModel.DataAnnotations.Schema;

namespace _08_attr_fluent_api;

[NotMapped]
internal class Role
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string? Description { get; set; }
}
