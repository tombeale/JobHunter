using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace JobHunter.Services
{
    public class BrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<bool> CenterElement()
        {
            return await _js.InvokeAsync<bool>("dialog.CenterElement", "note-editor");
        }

    }

    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
