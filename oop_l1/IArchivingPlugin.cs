using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab45
{
    public interface IArchivingPlugin
    {
        void Save(IForm _view);
        void Load(IForm _view);
    }
}
