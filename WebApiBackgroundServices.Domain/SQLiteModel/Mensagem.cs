using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiBackgroundServices.Domain.SQLiteModel
{
    public class Message: AuditableEntity
    {
        public byte IdMessage { get; set; }
        public string Content { get; set; }

    }
}
