using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterDayProgram.App
{
    public static class ComponentExtensions
    {
        public static IEnumerable<Component> GetAllComponents(this Component component)
        {
            IEnumerable<Component> components;
            if (component is ToolStrip) components = ((ToolStrip)component).Items.Cast<Component>();
            else if (component is Control) components = ((Control)component).Controls.Cast<Component>();
            else components = Enumerable.Empty<Component>();    //  figure out what you want to do here
            return components.Concat(components.SelectMany(x => GetAllComponents(x)));
        }
    }
}
