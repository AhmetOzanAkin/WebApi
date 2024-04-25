using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class BaseEntity<TId>
{
    public TId Id { get; set; } // Generic yapı, id'yi her zaman int veya long yerine istediğimiz türde kullanmamıza yarar
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdateDate { get; set; } // ? = updateDate eklemek zorunda değilsin. nonnuble demek.
    public DateTime? DeletedDate { get; set; }
}
