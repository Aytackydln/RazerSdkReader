using System.Reactive.Disposables;
using Avalonia.Media;
using RazerSdkReader.Structures;
using ReactiveUI;

namespace RazerSdkReader.Avalonia.ViewModels;

public class MousepadGridWindowViewModel : GridViewerWindowViewModel<CChromaMousepad>
{
    public MousepadGridWindowViewModel() : base(15, 1, "Mousepad")
    {
        this.WhenActivated(d =>
        {
            App.Reader.MousepadUpdated += ReaderOnMousepadUpdated;
            Disposable.Create(() => App.Reader.MousepadUpdated -= ReaderOnMousepadUpdated).DisposeWith(d);
        });
    }

    private void ReaderOnMousepadUpdated(object? sender, CChromaMousepad e)
    {
        Update(e);
    }

    protected override Color GetColor(in CChromaMousepad data, int index)
    {
        var clr =  data.GetColor(index);
        return Color.FromRgb(clr.R, clr.G, clr.B);
    }
}