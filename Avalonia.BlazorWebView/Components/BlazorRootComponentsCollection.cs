using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AvaloniaBlazorWebView.Components
{
    public class BlazorRootComponentsCollection : ObservableCollection<BlazorRootComponent>
    {
        public BlazorRootComponentsCollection()
        {

        }

        public void Add<TComponent>(string selector) where TComponent : Microsoft.AspNetCore.Components.IComponent
        {
            BlazorRootComponent component = new()
            {
                ComponentType = typeof(TComponent),
                Selector = selector
            };

            Add(component);
        }

    }
}
