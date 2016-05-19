using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // so whoever is raising this event passes themselves
    // a reference to themselves in as this first parameter and then
    // NameChangedEvent Args are the actual event arguments that will be delivered
    // to whoever is subscribing to this event
    public delegate void NamedChangedDelegate(
        object sender, NameChangedEventArgs args);
}
