using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDBEditor.Tools.Abstract.General
{
    public interface IToolRepository<TObject> where TObject : class, ITool
    {
        public void Handle();
    }
}
