using System.ComponentModel.DataAnnotations;

namespace Discoteque.Data.Models;

public class BaseEntity<TId> 
where TId : struct
{
    [Key]
    public TId Id {get; set;}
}